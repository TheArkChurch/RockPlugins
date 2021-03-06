// <copyright>
// Copyright Southeast Christian Church
//
// Licensed under the  Southeast Christian Church License (the "License");
// you may not use this file except in compliance with the License.
// A copy of the License shoud be included with this file.
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
// <copyright>
// Copyright 2013 by the Spark Development Network
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;

using Rock.Attribute;
using Rock.CheckIn;
using Rock.Data;
using Rock.Model;

namespace Rock.Workflow.Action.CheckIn
{
    /// <summary>
    /// Saves the selected check-in data as attendance
    /// </summary>
    [ActionCategory( "SECC > Check-In" )]
    [Description( "Acts like Save Attendance except is doesn't set attendance date or did attend to true" )]
    [Export( typeof( ActionComponent ) )]
    [ExportMetadata( "ComponentName", "Reserve Attendance" )]
    [IntegerField( "Security Code Length", "The number of characters to use for the security code.", true, 3 )]
    [BooleanField( "Reuse Code For Family", "By default a unique security code is created for each person.  Select this option to use one security code per family.", false )]
    public class ReserveAttendance : CheckInActionComponent
    {
        /// <summary>
        /// Executes the specified workflow.
        /// </summary>
        /// <param name="rockContext">The rock context.</param>
        /// <param name="action">The workflow action.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override bool Execute( RockContext rockContext, Model.WorkflowAction action, Object entity, out List<string> errorMessages )
        {
            var checkInState = GetCheckInState( entity, out errorMessages );
            if ( checkInState != null )
            {
                AttendanceCode attendanceCode = null;
                DateTime startDateTime = RockDateTime.Now;

                bool reuseCodeForFamily = GetAttributeValue( action, "ReuseCodeForFamily" ).AsBoolean();

                int securityCodeLength = 3;
                if ( !int.TryParse( GetAttributeValue( action, "SecurityCodeLength" ), out securityCodeLength ) )
                {
                    securityCodeLength = 3;
                }

                var attendanceCodeService = new AttendanceCodeService( rockContext );
                var attendanceService = new AttendanceService( rockContext );
                var groupMemberService = new GroupMemberService( rockContext );
                var personAliasService = new PersonAliasService( rockContext );

                foreach ( var family in checkInState.CheckIn.Families.Where( f => f.Selected ) )
                {
                    foreach ( var person in family.People.Where( p => p.Selected ) )
                    {
                        if ( reuseCodeForFamily && attendanceCode != null )
                        {
                            person.SecurityCode = attendanceCode.Code;
                        }
                        else
                        {
                            attendanceCode = AttendanceCodeService.GetNew( securityCodeLength );
                            person.SecurityCode = attendanceCode.Code;
                        }

                        foreach ( var groupType in person.GroupTypes.Where( g => g.Selected ) )
                        {
                            foreach ( var group in groupType.Groups.Where( g => g.Selected ) )
                            {
                                foreach ( var location in group.Locations.Where( l => l.Selected ) )
                                {
                                    if ( groupType.GroupType.AttendanceRule == AttendanceRule.AddOnCheckIn &&
                                        groupType.GroupType.DefaultGroupRoleId.HasValue &&
                                        !groupMemberService.GetByGroupIdAndPersonId( group.Group.Id, person.Person.Id, true ).Any() )
                                    {
                                        var groupMember = new GroupMember();
                                        groupMember.GroupId = group.Group.Id;
                                        groupMember.PersonId = person.Person.Id;
                                        groupMember.GroupRoleId = groupType.GroupType.DefaultGroupRoleId.Value;
                                        groupMemberService.Add( groupMember );
                                    }

                                    foreach ( var schedule in location.Schedules.Where( s => s.Selected ) )
                                    {
                                        // Only create one attendance record per day for each person/schedule/group/location
                                        var attendance = attendanceService.Get( startDateTime, location.Location.Id, schedule.Schedule.Id, group.Group.Id, person.Person.Id );
                                        if ( attendance == null )
                                        {
                                            var primaryAlias = personAliasService.GetPrimaryAlias( person.Person.Id );
                                            if ( primaryAlias != null )
                                            {
                                                attendance = rockContext.Attendances.Create();
                                                attendance.Occurrence.LocationId = location.Location.Id;
                                                attendance.CampusId = location.CampusId;
                                                attendance.Occurrence.ScheduleId = schedule.Schedule.Id;
                                                attendance.Occurrence.GroupId = group.Group.Id;
                                                attendance.PersonAlias = primaryAlias;
                                                attendance.PersonAliasId = primaryAlias.Id;
                                                attendance.DeviceId = checkInState.Kiosk.Device.Id;
                                                attendance.SearchTypeValueId = checkInState.CheckIn.SearchType.Id;
                                                attendanceService.Add( attendance );
                                            }
                                        }

                                        attendance.AttendanceCodeId = attendanceCode.Id;
                                        attendance.StartDateTime = startDateTime;
                                        attendance.EndDateTime = null;
                                        attendance.DidAttend = false;

                                        KioskLocationAttendance.AddAttendance( attendance );
                                    }
                                }
                            }
                        }
                    }
                }

                rockContext.SaveChanges();
                return true;
            }
            errorMessages.Add( $"Attempted to run {this.GetType().GetFriendlyTypeName()} in check-in, but the check-in state was null." );
            return false;
        }
    }
}