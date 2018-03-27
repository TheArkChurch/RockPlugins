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
#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.secc.Purchasing.DataLayer.Accounting
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShelbyDBRepl")]
	public partial class ShelbyContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGLCompanyData(GLCompanyData instance);
    partial void UpdateGLCompanyData(GLCompanyData instance);
    partial void DeleteGLCompanyData(GLCompanyData instance);
    partial void InsertGLYearData(GLYearData instance);
    partial void UpdateGLYearData(GLYearData instance);
    partial void DeleteGLYearData(GLYearData instance);
    partial void InsertGLFundData(GLFundData instance);
    partial void UpdateGLFundData(GLFundData instance);
    partial void DeleteGLFundData(GLFundData instance);
    partial void InsertGLDepartmentData(GLDepartmentData instance);
    partial void UpdateGLDepartmentData(GLDepartmentData instance);
    partial void DeleteGLDepartmentData(GLDepartmentData instance);
    partial void InsertGLAccountData(GLAccountData instance);
    partial void UpdateGLAccountData(GLAccountData instance);
    partial void DeleteGLAccountData(GLAccountData instance);
    #endregion
		
		public ShelbyContext() : 
				base(global::org.secc.Purchasing.Properties.Settings.Default.ShelbyDBReplConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ShelbyContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShelbyContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShelbyContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShelbyContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GLCompanyData> GLCompanyDatas
		{
			get
			{
				return this.GetTable<GLCompanyData>();
			}
		}
		
		public System.Data.Linq.Table<GLYearData> GLYearDatas
		{
			get
			{
				return this.GetTable<GLYearData>();
			}
		}
		
		public System.Data.Linq.Table<GLFundData> GLFundDatas
		{
			get
			{
				return this.GetTable<GLFundData>();
			}
		}
		
		public System.Data.Linq.Table<GLDepartmentData> GLDepartmentDatas
		{
			get
			{
				return this.GetTable<GLDepartmentData>();
			}
		}
		
		public System.Data.Linq.Table<GLAccountData> GLAccountDatas
		{
			get
			{
				return this.GetTable<GLAccountData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Shelby.SSCo")]
	public partial class GLCompanyData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _CompanyNumber;
		
		private string _Name;
		
		private EntitySet<GLYearData> _GLYearDatas;
		
		private EntitySet<GLFundData> _GLFundDatas;
		
		private EntitySet<GLDepartmentData> _GLDepartmentDatas;
		
		private EntitySet<GLAccountData> _GLAccountDatas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCompanyNumberChanging(short value);
    partial void OnCompanyNumberChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public GLCompanyData()
		{
			this._GLYearDatas = new EntitySet<GLYearData>(new Action<GLYearData>(this.attach_GLYearDatas), new Action<GLYearData>(this.detach_GLYearDatas));
			this._GLFundDatas = new EntitySet<GLFundData>(new Action<GLFundData>(this.attach_GLFundDatas), new Action<GLFundData>(this.detach_GLFundDatas));
			this._GLDepartmentDatas = new EntitySet<GLDepartmentData>(new Action<GLDepartmentData>(this.attach_GLDepartmentDatas), new Action<GLDepartmentData>(this.detach_GLDepartmentDatas));
			this._GLAccountDatas = new EntitySet<GLAccountData>(new Action<GLAccountData>(this.attach_GLAccountDatas), new Action<GLAccountData>(this.detach_GLAccountDatas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CoNu", Storage="_CompanyNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short CompanyNumber
		{
			get
			{
				return this._CompanyNumber;
			}
			set
			{
				if ((this._CompanyNumber != value))
				{
					this.OnCompanyNumberChanging(value);
					this.SendPropertyChanging();
					this._CompanyNumber = value;
					this.SendPropertyChanged("CompanyNumber");
					this.OnCompanyNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLYearData", Storage="_GLYearDatas", ThisKey="CompanyNumber", OtherKey="CompanyNumber")]
		public EntitySet<GLYearData> GLYearDatas
		{
			get
			{
				return this._GLYearDatas;
			}
			set
			{
				this._GLYearDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLFundData", Storage="_GLFundDatas", ThisKey="CompanyNumber", OtherKey="CompanyNumber")]
		public EntitySet<GLFundData> GLFundDatas
		{
			get
			{
				return this._GLFundDatas;
			}
			set
			{
				this._GLFundDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLDepartmentData", Storage="_GLDepartmentDatas", ThisKey="CompanyNumber", OtherKey="CompanyNumber")]
		public EntitySet<GLDepartmentData> GLDepartmentDatas
		{
			get
			{
				return this._GLDepartmentDatas;
			}
			set
			{
				this._GLDepartmentDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLAccountData", Storage="_GLAccountDatas", ThisKey="CompanyNumber", OtherKey="CompanyNumber")]
		public EntitySet<GLAccountData> GLAccountDatas
		{
			get
			{
				return this._GLAccountDatas;
			}
			set
			{
				this._GLAccountDatas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_GLYearDatas(GLYearData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = this;
		}
		
		private void detach_GLYearDatas(GLYearData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = null;
		}
		
		private void attach_GLFundDatas(GLFundData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = this;
		}
		
		private void detach_GLFundDatas(GLFundData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = null;
		}
		
		private void attach_GLDepartmentDatas(GLDepartmentData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = this;
		}
		
		private void detach_GLDepartmentDatas(GLDepartmentData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = null;
		}
		
		private void attach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = this;
		}
		
		private void detach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLCompanyData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Shelby.GLYear")]
	public partial class GLYearData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _BeginDate;
		
		private short _CompanyNumber;
		
		private System.Nullable<System.DateTime> _EndDate;
		
		private EntitySet<GLAccountData> _GLAccountDatas;
		
		private EntityRef<GLCompanyData> _GLCompanyData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBeginDateChanging(System.DateTime value);
    partial void OnBeginDateChanged();
    partial void OnCompanyNumberChanging(short value);
    partial void OnCompanyNumberChanged();
    partial void OnEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEndDateChanged();
    #endregion
		
		public GLYearData()
		{
			this._GLAccountDatas = new EntitySet<GLAccountData>(new Action<GLAccountData>(this.attach_GLAccountDatas), new Action<GLAccountData>(this.detach_GLAccountDatas));
			this._GLCompanyData = default(EntityRef<GLCompanyData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BeginDate", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime BeginDate
		{
			get
			{
				return this._BeginDate;
			}
			set
			{
				if ((this._BeginDate != value))
				{
					this.OnBeginDateChanging(value);
					this.SendPropertyChanging();
					this._BeginDate = value;
					this.SendPropertyChanged("BeginDate");
					this.OnBeginDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CoNu", Storage="_CompanyNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short CompanyNumber
		{
			get
			{
				return this._CompanyNumber;
			}
			set
			{
				if ((this._CompanyNumber != value))
				{
					this.OnCompanyNumberChanging(value);
					this.SendPropertyChanging();
					this._CompanyNumber = value;
					this.SendPropertyChanged("CompanyNumber");
					this.OnCompanyNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLYearData_GLAccountData", Storage="_GLAccountDatas", ThisKey="CompanyNumber,BeginDate", OtherKey="CompanyNumber,BeginDate")]
		public EntitySet<GLAccountData> GLAccountDatas
		{
			get
			{
				return this._GLAccountDatas;
			}
			set
			{
				this._GLAccountDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLYearData", Storage="_GLCompanyData", ThisKey="CompanyNumber", OtherKey="CompanyNumber", IsForeignKey=true)]
		public GLCompanyData GLCompanyData
		{
			get
			{
				return this._GLCompanyData.Entity;
			}
			set
			{
				GLCompanyData previousValue = this._GLCompanyData.Entity;
				if (((previousValue != value) 
							|| (this._GLCompanyData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLCompanyData.Entity = null;
						previousValue.GLYearDatas.Remove(this);
					}
					this._GLCompanyData.Entity = value;
					if ((value != null))
					{
						value.GLYearDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
					}
					else
					{
						this._CompanyNumber = default(short);
					}
					this.SendPropertyChanged("GLCompanyData");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLYearData = this;
		}
		
		private void detach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLYearData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Shelby.GLFund")]
	public partial class GLFundData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _CompanyNumber;
		
		private short _FundNumber;
		
		private string _Name;
		
		private EntitySet<GLDepartmentData> _GLDepartmentDatas;
		
		private EntitySet<GLAccountData> _GLAccountDatas;
		
		private EntityRef<GLCompanyData> _GLCompanyData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCompanyNumberChanging(short value);
    partial void OnCompanyNumberChanged();
    partial void OnFundNumberChanging(short value);
    partial void OnFundNumberChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public GLFundData()
		{
			this._GLDepartmentDatas = new EntitySet<GLDepartmentData>(new Action<GLDepartmentData>(this.attach_GLDepartmentDatas), new Action<GLDepartmentData>(this.detach_GLDepartmentDatas));
			this._GLAccountDatas = new EntitySet<GLAccountData>(new Action<GLAccountData>(this.attach_GLAccountDatas), new Action<GLAccountData>(this.detach_GLAccountDatas));
			this._GLCompanyData = default(EntityRef<GLCompanyData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CoNu", Storage="_CompanyNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short CompanyNumber
		{
			get
			{
				return this._CompanyNumber;
			}
			set
			{
				if ((this._CompanyNumber != value))
				{
					this.OnCompanyNumberChanging(value);
					this.SendPropertyChanging();
					this._CompanyNumber = value;
					this.SendPropertyChanged("CompanyNumber");
					this.OnCompanyNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="FundNu", Storage="_FundNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short FundNumber
		{
			get
			{
				return this._FundNumber;
			}
			set
			{
				if ((this._FundNumber != value))
				{
					this.OnFundNumberChanging(value);
					this.SendPropertyChanging();
					this._FundNumber = value;
					this.SendPropertyChanged("FundNumber");
					this.OnFundNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLFundData_GLDepartmentData", Storage="_GLDepartmentDatas", ThisKey="CompanyNumber,FundNumber", OtherKey="CompanyNumber,FundNumber")]
		public EntitySet<GLDepartmentData> GLDepartmentDatas
		{
			get
			{
				return this._GLDepartmentDatas;
			}
			set
			{
				this._GLDepartmentDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLFundData_GLAccountData", Storage="_GLAccountDatas", ThisKey="CompanyNumber,FundNumber", OtherKey="CompanyNumber,FundNumber")]
		public EntitySet<GLAccountData> GLAccountDatas
		{
			get
			{
				return this._GLAccountDatas;
			}
			set
			{
				this._GLAccountDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLFundData", Storage="_GLCompanyData", ThisKey="CompanyNumber", OtherKey="CompanyNumber", IsForeignKey=true)]
		public GLCompanyData GLCompanyData
		{
			get
			{
				return this._GLCompanyData.Entity;
			}
			set
			{
				GLCompanyData previousValue = this._GLCompanyData.Entity;
				if (((previousValue != value) 
							|| (this._GLCompanyData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLCompanyData.Entity = null;
						previousValue.GLFundDatas.Remove(this);
					}
					this._GLCompanyData.Entity = value;
					if ((value != null))
					{
						value.GLFundDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
					}
					else
					{
						this._CompanyNumber = default(short);
					}
					this.SendPropertyChanged("GLCompanyData");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_GLDepartmentDatas(GLDepartmentData entity)
		{
			this.SendPropertyChanging();
			entity.GLFundData = this;
		}
		
		private void detach_GLDepartmentDatas(GLDepartmentData entity)
		{
			this.SendPropertyChanging();
			entity.GLFundData = null;
		}
		
		private void attach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLFundData = this;
		}
		
		private void detach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLFundData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Shelby.GLDept")]
	public partial class GLDepartmentData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _CompanyNumber;
		
		private short _DepartmentNumber;
		
		private short _FundNumber;
		
		private string _Name;
		
		private EntitySet<GLAccountData> _GLAccountDatas;
		
		private EntityRef<GLFundData> _GLFundData;
		
		private EntityRef<GLCompanyData> _GLCompanyData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCompanyNumberChanging(short value);
    partial void OnCompanyNumberChanged();
    partial void OnDepartmentNumberChanging(short value);
    partial void OnDepartmentNumberChanged();
    partial void OnFundNumberChanging(short value);
    partial void OnFundNumberChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public GLDepartmentData()
		{
			this._GLAccountDatas = new EntitySet<GLAccountData>(new Action<GLAccountData>(this.attach_GLAccountDatas), new Action<GLAccountData>(this.detach_GLAccountDatas));
			this._GLFundData = default(EntityRef<GLFundData>);
			this._GLCompanyData = default(EntityRef<GLCompanyData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CoNu", Storage="_CompanyNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short CompanyNumber
		{
			get
			{
				return this._CompanyNumber;
			}
			set
			{
				if ((this._CompanyNumber != value))
				{
					this.OnCompanyNumberChanging(value);
					this.SendPropertyChanging();
					this._CompanyNumber = value;
					this.SendPropertyChanged("CompanyNumber");
					this.OnCompanyNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DeptNu", Storage="_DepartmentNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short DepartmentNumber
		{
			get
			{
				return this._DepartmentNumber;
			}
			set
			{
				if ((this._DepartmentNumber != value))
				{
					this.OnDepartmentNumberChanging(value);
					this.SendPropertyChanging();
					this._DepartmentNumber = value;
					this.SendPropertyChanged("DepartmentNumber");
					this.OnDepartmentNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="FundNu", Storage="_FundNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short FundNumber
		{
			get
			{
				return this._FundNumber;
			}
			set
			{
				if ((this._FundNumber != value))
				{
					this.OnFundNumberChanging(value);
					this.SendPropertyChanging();
					this._FundNumber = value;
					this.SendPropertyChanged("FundNumber");
					this.OnFundNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLDepartmentData_GLAccountData", Storage="_GLAccountDatas", ThisKey="CompanyNumber,FundNumber,DepartmentNumber", OtherKey="CompanyNumber,FundNumber,DepartmentNumber")]
		public EntitySet<GLAccountData> GLAccountDatas
		{
			get
			{
				return this._GLAccountDatas;
			}
			set
			{
				this._GLAccountDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLFundData_GLDepartmentData", Storage="_GLFundData", ThisKey="CompanyNumber,FundNumber", OtherKey="CompanyNumber,FundNumber", IsForeignKey=true)]
		public GLFundData GLFundData
		{
			get
			{
				return this._GLFundData.Entity;
			}
			set
			{
				GLFundData previousValue = this._GLFundData.Entity;
				if (((previousValue != value) 
							|| (this._GLFundData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLFundData.Entity = null;
						previousValue.GLDepartmentDatas.Remove(this);
					}
					this._GLFundData.Entity = value;
					if ((value != null))
					{
						value.GLDepartmentDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
						this._FundNumber = value.FundNumber;
					}
					else
					{
						this._CompanyNumber = default(short);
						this._FundNumber = default(short);
					}
					this.SendPropertyChanged("GLFundData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLDepartmentData", Storage="_GLCompanyData", ThisKey="CompanyNumber", OtherKey="CompanyNumber", IsForeignKey=true)]
		public GLCompanyData GLCompanyData
		{
			get
			{
				return this._GLCompanyData.Entity;
			}
			set
			{
				GLCompanyData previousValue = this._GLCompanyData.Entity;
				if (((previousValue != value) 
							|| (this._GLCompanyData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLCompanyData.Entity = null;
						previousValue.GLDepartmentDatas.Remove(this);
					}
					this._GLCompanyData.Entity = value;
					if ((value != null))
					{
						value.GLDepartmentDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
					}
					else
					{
						this._CompanyNumber = default(short);
					}
					this.SendPropertyChanged("GLCompanyData");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLDepartmentData = this;
		}
		
		private void detach_GLAccountDatas(GLAccountData entity)
		{
			this.SendPropertyChanging();
			entity.GLDepartmentData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Shelby.GLAcct")]
	public partial class GLAccountData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AccountNumber;
		
		private System.DateTime _BeginDate;
		
		private short _CompanyNumber;
		
		private short _DepartmentNumber;
		
		private string _Description;
		
		private short _FundNumber;
		
		private EntityRef<GLCompanyData> _GLCompanyData;
		
		private EntityRef<GLYearData> _GLYearData;
		
		private EntityRef<GLFundData> _GLFundData;
		
		private EntityRef<GLDepartmentData> _GLDepartmentData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccountNumberChanging(int value);
    partial void OnAccountNumberChanged();
    partial void OnBeginDateChanging(System.DateTime value);
    partial void OnBeginDateChanged();
    partial void OnCompanyNumberChanging(short value);
    partial void OnCompanyNumberChanged();
    partial void OnDepartmentNumberChanging(short value);
    partial void OnDepartmentNumberChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnFundNumberChanging(short value);
    partial void OnFundNumberChanged();
    #endregion
		
		public GLAccountData()
		{
			this._GLCompanyData = default(EntityRef<GLCompanyData>);
			this._GLYearData = default(EntityRef<GLYearData>);
			this._GLFundData = default(EntityRef<GLFundData>);
			this._GLDepartmentData = default(EntityRef<GLDepartmentData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="AcctNu", Storage="_AccountNumber", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AccountNumber
		{
			get
			{
				return this._AccountNumber;
			}
			set
			{
				if ((this._AccountNumber != value))
				{
					this.OnAccountNumberChanging(value);
					this.SendPropertyChanging();
					this._AccountNumber = value;
					this.SendPropertyChanged("AccountNumber");
					this.OnAccountNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BeginDate", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime BeginDate
		{
			get
			{
				return this._BeginDate;
			}
			set
			{
				if ((this._BeginDate != value))
				{
					if (this._GLYearData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBeginDateChanging(value);
					this.SendPropertyChanging();
					this._BeginDate = value;
					this.SendPropertyChanged("BeginDate");
					this.OnBeginDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CoNu", Storage="_CompanyNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short CompanyNumber
		{
			get
			{
				return this._CompanyNumber;
			}
			set
			{
				if ((this._CompanyNumber != value))
				{
					this.OnCompanyNumberChanging(value);
					this.SendPropertyChanging();
					this._CompanyNumber = value;
					this.SendPropertyChanged("CompanyNumber");
					this.OnCompanyNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DeptNu", Storage="_DepartmentNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short DepartmentNumber
		{
			get
			{
				return this._DepartmentNumber;
			}
			set
			{
				if ((this._DepartmentNumber != value))
				{
					this.OnDepartmentNumberChanging(value);
					this.SendPropertyChanging();
					this._DepartmentNumber = value;
					this.SendPropertyChanged("DepartmentNumber");
					this.OnDepartmentNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Descr", Storage="_Description", DbType="VarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="FundNu", Storage="_FundNumber", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short FundNumber
		{
			get
			{
				return this._FundNumber;
			}
			set
			{
				if ((this._FundNumber != value))
				{
					this.OnFundNumberChanging(value);
					this.SendPropertyChanging();
					this._FundNumber = value;
					this.SendPropertyChanged("FundNumber");
					this.OnFundNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLCompanyData_GLAccountData", Storage="_GLCompanyData", ThisKey="CompanyNumber", OtherKey="CompanyNumber", IsForeignKey=true)]
		public GLCompanyData GLCompanyData
		{
			get
			{
				return this._GLCompanyData.Entity;
			}
			set
			{
				GLCompanyData previousValue = this._GLCompanyData.Entity;
				if (((previousValue != value) 
							|| (this._GLCompanyData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLCompanyData.Entity = null;
						previousValue.GLAccountDatas.Remove(this);
					}
					this._GLCompanyData.Entity = value;
					if ((value != null))
					{
						value.GLAccountDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
					}
					else
					{
						this._CompanyNumber = default(short);
					}
					this.SendPropertyChanged("GLCompanyData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLYearData_GLAccountData", Storage="_GLYearData", ThisKey="CompanyNumber,BeginDate", OtherKey="CompanyNumber,BeginDate", IsForeignKey=true)]
		public GLYearData GLYearData
		{
			get
			{
				return this._GLYearData.Entity;
			}
			set
			{
				GLYearData previousValue = this._GLYearData.Entity;
				if (((previousValue != value) 
							|| (this._GLYearData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLYearData.Entity = null;
						previousValue.GLAccountDatas.Remove(this);
					}
					this._GLYearData.Entity = value;
					if ((value != null))
					{
						value.GLAccountDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
						this._BeginDate = value.BeginDate;
					}
					else
					{
						this._CompanyNumber = default(short);
						this._BeginDate = default(System.DateTime);
					}
					this.SendPropertyChanged("GLYearData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLFundData_GLAccountData", Storage="_GLFundData", ThisKey="CompanyNumber,FundNumber", OtherKey="CompanyNumber,FundNumber", IsForeignKey=true)]
		public GLFundData GLFundData
		{
			get
			{
				return this._GLFundData.Entity;
			}
			set
			{
				GLFundData previousValue = this._GLFundData.Entity;
				if (((previousValue != value) 
							|| (this._GLFundData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLFundData.Entity = null;
						previousValue.GLAccountDatas.Remove(this);
					}
					this._GLFundData.Entity = value;
					if ((value != null))
					{
						value.GLAccountDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
						this._FundNumber = value.FundNumber;
					}
					else
					{
						this._CompanyNumber = default(short);
						this._FundNumber = default(short);
					}
					this.SendPropertyChanged("GLFundData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GLDepartmentData_GLAccountData", Storage="_GLDepartmentData", ThisKey="CompanyNumber,FundNumber,DepartmentNumber", OtherKey="CompanyNumber,FundNumber,DepartmentNumber", IsForeignKey=true)]
		public GLDepartmentData GLDepartmentData
		{
			get
			{
				return this._GLDepartmentData.Entity;
			}
			set
			{
				GLDepartmentData previousValue = this._GLDepartmentData.Entity;
				if (((previousValue != value) 
							|| (this._GLDepartmentData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GLDepartmentData.Entity = null;
						previousValue.GLAccountDatas.Remove(this);
					}
					this._GLDepartmentData.Entity = value;
					if ((value != null))
					{
						value.GLAccountDatas.Add(this);
						this._CompanyNumber = value.CompanyNumber;
						this._FundNumber = value.FundNumber;
						this._DepartmentNumber = value.DepartmentNumber;
					}
					else
					{
						this._CompanyNumber = default(short);
						this._FundNumber = default(short);
						this._DepartmentNumber = default(short);
					}
					this.SendPropertyChanged("GLDepartmentData");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
