﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDataBaseFirst
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataBase")]
	public partial class LentelesKonvertavimaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTestInformation(TestInformation instance);
    partial void UpdateTestInformation(TestInformation instance);
    partial void DeleteTestInformation(TestInformation instance);
    partial void InsertTestSetup(TestSetup instance);
    partial void UpdateTestSetup(TestSetup instance);
    partial void DeleteTestSetup(TestSetup instance);
    #endregion
		
		public LentelesKonvertavimaDataContext() : 
				base(global::EntityDataBaseFirst.Properties.Settings.Default.DataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LentelesKonvertavimaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LentelesKonvertavimaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LentelesKonvertavimaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LentelesKonvertavimaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TestInformation> TestInformations
		{
			get
			{
				return this.GetTable<TestInformation>();
			}
		}
		
		public System.Data.Linq.Table<TestSetup> TestSetups
		{
			get
			{
				return this.GetTable<TestSetup>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TestInformation")]
	public partial class TestInformation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _RunSeq;
		
		private string _SensNo;
		
		private System.Nullable<int> _TestTemp;
		
		private System.Nullable<int> _Supply;
		
		private string _Exposure;
		
		private System.Nullable<System.DateTime> _data;
		
		private System.Nullable<System.TimeSpan> _Laikas;
		
		private System.Nullable<int> _AirTemp;
		
		private System.Nullable<int> _Humidity;
		
		private string _Operator;
		
		private string _Comment;
		
		private EntitySet<TestSetup> _TestSetups;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRunSeqChanging(System.Nullable<int> value);
    partial void OnRunSeqChanged();
    partial void OnSensNoChanging(string value);
    partial void OnSensNoChanged();
    partial void OnTestTempChanging(System.Nullable<int> value);
    partial void OnTestTempChanged();
    partial void OnSupplyChanging(System.Nullable<int> value);
    partial void OnSupplyChanged();
    partial void OnExposureChanging(string value);
    partial void OnExposureChanged();
    partial void OndataChanging(System.Nullable<System.DateTime> value);
    partial void OndataChanged();
    partial void OnLaikasChanging(System.Nullable<System.TimeSpan> value);
    partial void OnLaikasChanged();
    partial void OnAirTempChanging(System.Nullable<int> value);
    partial void OnAirTempChanged();
    partial void OnHumidityChanging(System.Nullable<int> value);
    partial void OnHumidityChanged();
    partial void OnOperatorChanging(string value);
    partial void OnOperatorChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    #endregion
		
		public TestInformation()
		{
			this._TestSetups = new EntitySet<TestSetup>(new Action<TestSetup>(this.attach_TestSetups), new Action<TestSetup>(this.detach_TestSetups));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RunSeq", DbType="Int")]
		public System.Nullable<int> RunSeq
		{
			get
			{
				return this._RunSeq;
			}
			set
			{
				if ((this._RunSeq != value))
				{
					this.OnRunSeqChanging(value);
					this.SendPropertyChanging();
					this._RunSeq = value;
					this.SendPropertyChanged("RunSeq");
					this.OnRunSeqChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SensNo", DbType="NVarChar(50)")]
		public string SensNo
		{
			get
			{
				return this._SensNo;
			}
			set
			{
				if ((this._SensNo != value))
				{
					this.OnSensNoChanging(value);
					this.SendPropertyChanging();
					this._SensNo = value;
					this.SendPropertyChanged("SensNo");
					this.OnSensNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestTemp", DbType="Int")]
		public System.Nullable<int> TestTemp
		{
			get
			{
				return this._TestTemp;
			}
			set
			{
				if ((this._TestTemp != value))
				{
					this.OnTestTempChanging(value);
					this.SendPropertyChanging();
					this._TestTemp = value;
					this.SendPropertyChanged("TestTemp");
					this.OnTestTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Supply", DbType="Int")]
		public System.Nullable<int> Supply
		{
			get
			{
				return this._Supply;
			}
			set
			{
				if ((this._Supply != value))
				{
					this.OnSupplyChanging(value);
					this.SendPropertyChanging();
					this._Supply = value;
					this.SendPropertyChanged("Supply");
					this.OnSupplyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Exposure", DbType="NVarChar(50)")]
		public string Exposure
		{
			get
			{
				return this._Exposure;
			}
			set
			{
				if ((this._Exposure != value))
				{
					this.OnExposureChanging(value);
					this.SendPropertyChanging();
					this._Exposure = value;
					this.SendPropertyChanged("Exposure");
					this.OnExposureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="Date")]
		public System.Nullable<System.DateTime> data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Laikas", DbType="Time")]
		public System.Nullable<System.TimeSpan> Laikas
		{
			get
			{
				return this._Laikas;
			}
			set
			{
				if ((this._Laikas != value))
				{
					this.OnLaikasChanging(value);
					this.SendPropertyChanging();
					this._Laikas = value;
					this.SendPropertyChanged("Laikas");
					this.OnLaikasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AirTemp", DbType="Int")]
		public System.Nullable<int> AirTemp
		{
			get
			{
				return this._AirTemp;
			}
			set
			{
				if ((this._AirTemp != value))
				{
					this.OnAirTempChanging(value);
					this.SendPropertyChanging();
					this._AirTemp = value;
					this.SendPropertyChanged("AirTemp");
					this.OnAirTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Humidity", DbType="Int")]
		public System.Nullable<int> Humidity
		{
			get
			{
				return this._Humidity;
			}
			set
			{
				if ((this._Humidity != value))
				{
					this.OnHumidityChanging(value);
					this.SendPropertyChanging();
					this._Humidity = value;
					this.SendPropertyChanged("Humidity");
					this.OnHumidityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Operator", DbType="NVarChar(50)")]
		public string Operator
		{
			get
			{
				return this._Operator;
			}
			set
			{
				if ((this._Operator != value))
				{
					this.OnOperatorChanging(value);
					this.SendPropertyChanging();
					this._Operator = value;
					this.SendPropertyChanged("Operator");
					this.OnOperatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(MAX)")]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this.OnCommentChanging(value);
					this.SendPropertyChanging();
					this._Comment = value;
					this.SendPropertyChanged("Comment");
					this.OnCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestInformation_TestSetup", Storage="_TestSetups", ThisKey="Id", OtherKey="TestInformationID")]
		public EntitySet<TestSetup> TestSetups
		{
			get
			{
				return this._TestSetups;
			}
			set
			{
				this._TestSetups.Assign(value);
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
		
		private void attach_TestSetups(TestSetup entity)
		{
			this.SendPropertyChanging();
			entity.TestInformation = this;
		}
		
		private void detach_TestSetups(TestSetup entity)
		{
			this.SendPropertyChanging();
			entity.TestInformation = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TestSetup")]
	public partial class TestSetup : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<double> _A;
		
		private System.Nullable<int> _B;
		
		private System.Nullable<int> _C;
		
		private System.Nullable<double> _D;
		
		private System.Nullable<int> _E;
		
		private System.Nullable<double> _F;
		
		private System.Nullable<int> _MaxSupply;
		
		private System.Nullable<double> _MinSupply;
		
		private string _I;
		
		private System.Nullable<double> _ErrorMIN;
		
		private System.Nullable<double> _ErrorMax;
		
		private System.Nullable<double> _ErrorMInA;
		
		private System.Nullable<double> _ErrorMaxA;
		
		private System.Nullable<int> _RejectCode;
		
		private int _TestInformationID;
		
		private EntityRef<TestInformation> _TestInformation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAChanging(System.Nullable<double> value);
    partial void OnAChanged();
    partial void OnBChanging(System.Nullable<int> value);
    partial void OnBChanged();
    partial void OnCChanging(System.Nullable<int> value);
    partial void OnCChanged();
    partial void OnDChanging(System.Nullable<double> value);
    partial void OnDChanged();
    partial void OnEChanging(System.Nullable<int> value);
    partial void OnEChanged();
    partial void OnFChanging(System.Nullable<double> value);
    partial void OnFChanged();
    partial void OnMaxSupplyChanging(System.Nullable<int> value);
    partial void OnMaxSupplyChanged();
    partial void OnMinSupplyChanging(System.Nullable<double> value);
    partial void OnMinSupplyChanged();
    partial void OnIChanging(string value);
    partial void OnIChanged();
    partial void OnErrorMINChanging(System.Nullable<double> value);
    partial void OnErrorMINChanged();
    partial void OnErrorMaxChanging(System.Nullable<double> value);
    partial void OnErrorMaxChanged();
    partial void OnErrorMInAChanging(System.Nullable<double> value);
    partial void OnErrorMInAChanged();
    partial void OnErrorMaxAChanging(System.Nullable<double> value);
    partial void OnErrorMaxAChanged();
    partial void OnRejectCodeChanging(System.Nullable<int> value);
    partial void OnRejectCodeChanged();
    partial void OnTestInformationIDChanging(int value);
    partial void OnTestInformationIDChanged();
    #endregion
		
		public TestSetup()
		{
			this._TestInformation = default(EntityRef<TestInformation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="Float")]
		public System.Nullable<double> A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this.OnAChanging(value);
					this.SendPropertyChanging();
					this._A = value;
					this.SendPropertyChanged("A");
					this.OnAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B", DbType="Int")]
		public System.Nullable<int> B
		{
			get
			{
				return this._B;
			}
			set
			{
				if ((this._B != value))
				{
					this.OnBChanging(value);
					this.SendPropertyChanging();
					this._B = value;
					this.SendPropertyChanged("B");
					this.OnBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C", DbType="Int")]
		public System.Nullable<int> C
		{
			get
			{
				return this._C;
			}
			set
			{
				if ((this._C != value))
				{
					this.OnCChanging(value);
					this.SendPropertyChanging();
					this._C = value;
					this.SendPropertyChanged("C");
					this.OnCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D", DbType="Float")]
		public System.Nullable<double> D
		{
			get
			{
				return this._D;
			}
			set
			{
				if ((this._D != value))
				{
					this.OnDChanging(value);
					this.SendPropertyChanging();
					this._D = value;
					this.SendPropertyChanged("D");
					this.OnDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_E", DbType="Int")]
		public System.Nullable<int> E
		{
			get
			{
				return this._E;
			}
			set
			{
				if ((this._E != value))
				{
					this.OnEChanging(value);
					this.SendPropertyChanging();
					this._E = value;
					this.SendPropertyChanged("E");
					this.OnEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_F", DbType="Float")]
		public System.Nullable<double> F
		{
			get
			{
				return this._F;
			}
			set
			{
				if ((this._F != value))
				{
					this.OnFChanging(value);
					this.SendPropertyChanging();
					this._F = value;
					this.SendPropertyChanged("F");
					this.OnFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxSupply", DbType="Int")]
		public System.Nullable<int> MaxSupply
		{
			get
			{
				return this._MaxSupply;
			}
			set
			{
				if ((this._MaxSupply != value))
				{
					this.OnMaxSupplyChanging(value);
					this.SendPropertyChanging();
					this._MaxSupply = value;
					this.SendPropertyChanged("MaxSupply");
					this.OnMaxSupplyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinSupply", DbType="Float")]
		public System.Nullable<double> MinSupply
		{
			get
			{
				return this._MinSupply;
			}
			set
			{
				if ((this._MinSupply != value))
				{
					this.OnMinSupplyChanging(value);
					this.SendPropertyChanging();
					this._MinSupply = value;
					this.SendPropertyChanged("MinSupply");
					this.OnMinSupplyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_I", DbType="NChar(10)")]
		public string I
		{
			get
			{
				return this._I;
			}
			set
			{
				if ((this._I != value))
				{
					this.OnIChanging(value);
					this.SendPropertyChanging();
					this._I = value;
					this.SendPropertyChanged("I");
					this.OnIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorMIN", DbType="Float")]
		public System.Nullable<double> ErrorMIN
		{
			get
			{
				return this._ErrorMIN;
			}
			set
			{
				if ((this._ErrorMIN != value))
				{
					this.OnErrorMINChanging(value);
					this.SendPropertyChanging();
					this._ErrorMIN = value;
					this.SendPropertyChanged("ErrorMIN");
					this.OnErrorMINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorMax", DbType="Float")]
		public System.Nullable<double> ErrorMax
		{
			get
			{
				return this._ErrorMax;
			}
			set
			{
				if ((this._ErrorMax != value))
				{
					this.OnErrorMaxChanging(value);
					this.SendPropertyChanging();
					this._ErrorMax = value;
					this.SendPropertyChanged("ErrorMax");
					this.OnErrorMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorMInA", DbType="Float")]
		public System.Nullable<double> ErrorMInA
		{
			get
			{
				return this._ErrorMInA;
			}
			set
			{
				if ((this._ErrorMInA != value))
				{
					this.OnErrorMInAChanging(value);
					this.SendPropertyChanging();
					this._ErrorMInA = value;
					this.SendPropertyChanged("ErrorMInA");
					this.OnErrorMInAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorMaxA", DbType="Float")]
		public System.Nullable<double> ErrorMaxA
		{
			get
			{
				return this._ErrorMaxA;
			}
			set
			{
				if ((this._ErrorMaxA != value))
				{
					this.OnErrorMaxAChanging(value);
					this.SendPropertyChanging();
					this._ErrorMaxA = value;
					this.SendPropertyChanged("ErrorMaxA");
					this.OnErrorMaxAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RejectCode", DbType="Int")]
		public System.Nullable<int> RejectCode
		{
			get
			{
				return this._RejectCode;
			}
			set
			{
				if ((this._RejectCode != value))
				{
					this.OnRejectCodeChanging(value);
					this.SendPropertyChanging();
					this._RejectCode = value;
					this.SendPropertyChanged("RejectCode");
					this.OnRejectCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestInformationID", DbType="Int NOT NULL")]
		public int TestInformationID
		{
			get
			{
				return this._TestInformationID;
			}
			set
			{
				if ((this._TestInformationID != value))
				{
					if (this._TestInformation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTestInformationIDChanging(value);
					this.SendPropertyChanging();
					this._TestInformationID = value;
					this.SendPropertyChanged("TestInformationID");
					this.OnTestInformationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestInformation_TestSetup", Storage="_TestInformation", ThisKey="TestInformationID", OtherKey="Id", IsForeignKey=true)]
		public TestInformation TestInformation
		{
			get
			{
				return this._TestInformation.Entity;
			}
			set
			{
				TestInformation previousValue = this._TestInformation.Entity;
				if (((previousValue != value) 
							|| (this._TestInformation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TestInformation.Entity = null;
						previousValue.TestSetups.Remove(this);
					}
					this._TestInformation.Entity = value;
					if ((value != null))
					{
						value.TestSetups.Add(this);
						this._TestInformationID = value.Id;
					}
					else
					{
						this._TestInformationID = default(int);
					}
					this.SendPropertyChanged("TestInformation");
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
