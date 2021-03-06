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
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using Rock;
using Rock.CheckIn;
using Rock.Data;
using Rock.Workflow;
using Rock.Workflow.Action.CheckIn;

namespace org.secc.FamilyCheckin
{
    /// <summary>
    /// Loads the group types allowed for each person in a family
    /// </summary>
    [ActionCategory( "SECC > Check-In" )]
    [Description( "Loads the group types allowed for each person in a family. This is identical to the load group type in core except it doesn't filter by count." )]
    [Export( typeof( ActionComponent ) )]
    [ExportMetadata( "ComponentName", "Load All Group Types" )]
    public class LoadAllGroupTypes : CheckInActionComponent
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
        public override bool Execute( RockContext rockContext, Rock.Model.WorkflowAction action, Object entity, out List<string> errorMessages )
        {
            var checkInState = GetCheckInState( entity, out errorMessages );
            if ( checkInState != null )
            {

                //This is an optimization over standard Rock
                //Core Rock has this inside the loop. Reading all the iCals is slow.
                var activeKioskGroupTypes = new List<KioskGroupType>();

                foreach ( var kioskGroupType in checkInState.Kiosk.ActiveGroupTypes( checkInState.ConfiguredGroupTypes ) )
                {
                    if ( kioskGroupType.KioskGroups.SelectMany( g => g.KioskLocations ).Any( l => l.IsCheckInActive && l.Location.IsActive ) )
                    {
                        activeKioskGroupTypes.Add( kioskGroupType );
                    }
                }

                foreach ( var family in checkInState.CheckIn.GetFamilies( true ) )
                {
                    foreach ( var person in family.People )
                    {
                        foreach ( var kioskGroupType in activeKioskGroupTypes )
                        {
                            if ( !person.GroupTypes.Any( g => g.GroupType.Id == kioskGroupType.GroupType.Id ) )
                            {
                                var checkinGroupType = new CheckInGroupType();
                                checkinGroupType.GroupType = kioskGroupType.GroupType;
                                person.GroupTypes.Add( checkinGroupType );
                            }
                        }
                    }
                }
                return true;
            }
            errorMessages.Add( $"Attempted to run {this.GetType().GetFriendlyTypeName()} in check-in, but the check-in state was null." );
            return false;
        }
    }
}