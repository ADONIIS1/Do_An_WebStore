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

namespace WebStoreFZF.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebStoreFZF")]
	public partial class MyDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCTDONHANG(CTDONHANG instance);
    partial void UpdateCTDONHANG(CTDONHANG instance);
    partial void DeleteCTDONHANG(CTDONHANG instance);
    partial void InsertDONHANG(DONHANG instance);
    partial void UpdateDONHANG(DONHANG instance);
    partial void DeleteDONHANG(DONHANG instance);
    partial void InsertKIEUSANPHAM(KIEUSANPHAM instance);
    partial void UpdateKIEUSANPHAM(KIEUSANPHAM instance);
    partial void DeleteKIEUSANPHAM(KIEUSANPHAM instance);
    partial void InsertLOAISANPHAM(LOAISANPHAM instance);
    partial void UpdateLOAISANPHAM(LOAISANPHAM instance);
    partial void DeleteLOAISANPHAM(LOAISANPHAM instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public MyDataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebStoreFZFConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CTDONHANG> CTDONHANGs
		{
			get
			{
				return this.GetTable<CTDONHANG>();
			}
		}
		
		public System.Data.Linq.Table<DONHANG> DONHANGs
		{
			get
			{
				return this.GetTable<DONHANG>();
			}
		}
		
		public System.Data.Linq.Table<KIEUSANPHAM> KIEUSANPHAMs
		{
			get
			{
				return this.GetTable<KIEUSANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<LOAISANPHAM> LOAISANPHAMs
		{
			get
			{
				return this.GetTable<LOAISANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTDONHANG")]
	public partial class CTDONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdDONHANG;
		
		private int _IdSANPHAN;
		
		private System.Nullable<int> _SOLUONG;
		
		private System.Nullable<double> _DONGIA;
		
		private System.Nullable<double> _THANHTIEN;
		
		private EntityRef<DONHANG> _DONHANG;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdDONHANGChanging(int value);
    partial void OnIdDONHANGChanged();
    partial void OnIdSANPHANChanging(int value);
    partial void OnIdSANPHANChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    partial void OnDONGIAChanging(System.Nullable<double> value);
    partial void OnDONGIAChanged();
    partial void OnTHANHTIENChanging(System.Nullable<double> value);
    partial void OnTHANHTIENChanged();
    #endregion
		
		public CTDONHANG()
		{
			this._DONHANG = default(EntityRef<DONHANG>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDONHANG", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdDONHANG
		{
			get
			{
				return this._IdDONHANG;
			}
			set
			{
				if ((this._IdDONHANG != value))
				{
					if (this._DONHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDONHANGChanging(value);
					this.SendPropertyChanging();
					this._IdDONHANG = value;
					this.SendPropertyChanged("IdDONHANG");
					this.OnIdDONHANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSANPHAN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdSANPHAN
		{
			get
			{
				return this._IdSANPHAN;
			}
			set
			{
				if ((this._IdSANPHAN != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdSANPHANChanging(value);
					this.SendPropertyChanging();
					this._IdSANPHAN = value;
					this.SendPropertyChanged("IdSANPHAN");
					this.OnIdSANPHANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Float")]
		public System.Nullable<double> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_THANHTIEN", DbType="Float")]
		public System.Nullable<double> THANHTIEN
		{
			get
			{
				return this._THANHTIEN;
			}
			set
			{
				if ((this._THANHTIEN != value))
				{
					this.OnTHANHTIENChanging(value);
					this.SendPropertyChanging();
					this._THANHTIEN = value;
					this.SendPropertyChanged("THANHTIEN");
					this.OnTHANHTIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONHANG_CTDONHANG", Storage="_DONHANG", ThisKey="IdDONHANG", OtherKey="IdDONHANG", IsForeignKey=true)]
		public DONHANG DONHANG
		{
			get
			{
				return this._DONHANG.Entity;
			}
			set
			{
				DONHANG previousValue = this._DONHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONHANG.Entity = null;
						previousValue.CTDONHANGs.Remove(this);
					}
					this._DONHANG.Entity = value;
					if ((value != null))
					{
						value.CTDONHANGs.Add(this);
						this._IdDONHANG = value.IdDONHANG;
					}
					else
					{
						this._IdDONHANG = default(int);
					}
					this.SendPropertyChanged("DONHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CTDONHANG", Storage="_SANPHAM", ThisKey="IdSANPHAN", OtherKey="IdSANPHAN", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.CTDONHANGs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.CTDONHANGs.Add(this);
						this._IdSANPHAN = value.IdSANPHAN;
					}
					else
					{
						this._IdSANPHAN = default(int);
					}
					this.SendPropertyChanged("SANPHAM");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONHANG")]
	public partial class DONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdDONHANG;
		
		private System.Nullable<System.DateTime> _NGAYDAT;
		
		private System.Nullable<int> _TINHTRANG;
		
		private System.Nullable<int> _IdUser;
		
		private EntitySet<CTDONHANG> _CTDONHANGs;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdDONHANGChanging(int value);
    partial void OnIdDONHANGChanged();
    partial void OnNGAYDATChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYDATChanged();
    partial void OnTINHTRANGChanging(System.Nullable<int> value);
    partial void OnTINHTRANGChanged();
    partial void OnIdUserChanging(System.Nullable<int> value);
    partial void OnIdUserChanged();
    #endregion
		
		public DONHANG()
		{
			this._CTDONHANGs = new EntitySet<CTDONHANG>(new Action<CTDONHANG>(this.attach_CTDONHANGs), new Action<CTDONHANG>(this.detach_CTDONHANGs));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDONHANG", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdDONHANG
		{
			get
			{
				return this._IdDONHANG;
			}
			set
			{
				if ((this._IdDONHANG != value))
				{
					this.OnIdDONHANGChanging(value);
					this.SendPropertyChanging();
					this._IdDONHANG = value;
					this.SendPropertyChanged("IdDONHANG");
					this.OnIdDONHANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYDAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYDAT
		{
			get
			{
				return this._NGAYDAT;
			}
			set
			{
				if ((this._NGAYDAT != value))
				{
					this.OnNGAYDATChanging(value);
					this.SendPropertyChanging();
					this._NGAYDAT = value;
					this.SendPropertyChanged("NGAYDAT");
					this.OnNGAYDATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TINHTRANG", DbType="Int")]
		public System.Nullable<int> TINHTRANG
		{
			get
			{
				return this._TINHTRANG;
			}
			set
			{
				if ((this._TINHTRANG != value))
				{
					this.OnTINHTRANGChanging(value);
					this.SendPropertyChanging();
					this._TINHTRANG = value;
					this.SendPropertyChanged("TINHTRANG");
					this.OnTINHTRANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", DbType="Int")]
		public System.Nullable<int> IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONHANG_CTDONHANG", Storage="_CTDONHANGs", ThisKey="IdDONHANG", OtherKey="IdDONHANG")]
		public EntitySet<CTDONHANG> CTDONHANGs
		{
			get
			{
				return this._CTDONHANGs;
			}
			set
			{
				this._CTDONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_DONHANG", Storage="_User", ThisKey="IdUser", OtherKey="IdUser", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.DONHANGs.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.DONHANGs.Add(this);
						this._IdUser = value.IdUser;
					}
					else
					{
						this._IdUser = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONHANG = this;
		}
		
		private void detach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KIEUSANPHAM")]
	public partial class KIEUSANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdKIEUSP;
		
		private string _TENKIEUSANPHAM;
		
		private System.Nullable<int> _IdLOAISP;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
		private EntityRef<LOAISANPHAM> _LOAISANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdKIEUSPChanging(int value);
    partial void OnIdKIEUSPChanged();
    partial void OnTENKIEUSANPHAMChanging(string value);
    partial void OnTENKIEUSANPHAMChanged();
    partial void OnIdLOAISPChanging(System.Nullable<int> value);
    partial void OnIdLOAISPChanged();
    #endregion
		
		public KIEUSANPHAM()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			this._LOAISANPHAM = default(EntityRef<LOAISANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdKIEUSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdKIEUSP
		{
			get
			{
				return this._IdKIEUSP;
			}
			set
			{
				if ((this._IdKIEUSP != value))
				{
					this.OnIdKIEUSPChanging(value);
					this.SendPropertyChanging();
					this._IdKIEUSP = value;
					this.SendPropertyChanged("IdKIEUSP");
					this.OnIdKIEUSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKIEUSANPHAM", DbType="NVarChar(100)")]
		public string TENKIEUSANPHAM
		{
			get
			{
				return this._TENKIEUSANPHAM;
			}
			set
			{
				if ((this._TENKIEUSANPHAM != value))
				{
					this.OnTENKIEUSANPHAMChanging(value);
					this.SendPropertyChanging();
					this._TENKIEUSANPHAM = value;
					this.SendPropertyChanged("TENKIEUSANPHAM");
					this.OnTENKIEUSANPHAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLOAISP", DbType="Int")]
		public System.Nullable<int> IdLOAISP
		{
			get
			{
				return this._IdLOAISP;
			}
			set
			{
				if ((this._IdLOAISP != value))
				{
					if (this._LOAISANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdLOAISPChanging(value);
					this.SendPropertyChanging();
					this._IdLOAISP = value;
					this.SendPropertyChanged("IdLOAISP");
					this.OnIdLOAISPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KIEUSANPHAM_SANPHAM", Storage="_SANPHAMs", ThisKey="IdKIEUSP", OtherKey="IdKIEUSP")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISANPHAM_KIEUSANPHAM", Storage="_LOAISANPHAM", ThisKey="IdLOAISP", OtherKey="IdLOAISP", IsForeignKey=true)]
		public LOAISANPHAM LOAISANPHAM
		{
			get
			{
				return this._LOAISANPHAM.Entity;
			}
			set
			{
				LOAISANPHAM previousValue = this._LOAISANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._LOAISANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAISANPHAM.Entity = null;
						previousValue.KIEUSANPHAMs.Remove(this);
					}
					this._LOAISANPHAM.Entity = value;
					if ((value != null))
					{
						value.KIEUSANPHAMs.Add(this);
						this._IdLOAISP = value.IdLOAISP;
					}
					else
					{
						this._IdLOAISP = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAISANPHAM");
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.KIEUSANPHAM = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.KIEUSANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAISANPHAM")]
	public partial class LOAISANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdLOAISP;
		
		private string _TENLOAISP;
		
		private EntitySet<KIEUSANPHAM> _KIEUSANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdLOAISPChanging(int value);
    partial void OnIdLOAISPChanged();
    partial void OnTENLOAISPChanging(string value);
    partial void OnTENLOAISPChanged();
    #endregion
		
		public LOAISANPHAM()
		{
			this._KIEUSANPHAMs = new EntitySet<KIEUSANPHAM>(new Action<KIEUSANPHAM>(this.attach_KIEUSANPHAMs), new Action<KIEUSANPHAM>(this.detach_KIEUSANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLOAISP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdLOAISP
		{
			get
			{
				return this._IdLOAISP;
			}
			set
			{
				if ((this._IdLOAISP != value))
				{
					this.OnIdLOAISPChanging(value);
					this.SendPropertyChanging();
					this._IdLOAISP = value;
					this.SendPropertyChanged("IdLOAISP");
					this.OnIdLOAISPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOAISP", DbType="NVarChar(100)")]
		public string TENLOAISP
		{
			get
			{
				return this._TENLOAISP;
			}
			set
			{
				if ((this._TENLOAISP != value))
				{
					this.OnTENLOAISPChanging(value);
					this.SendPropertyChanging();
					this._TENLOAISP = value;
					this.SendPropertyChanged("TENLOAISP");
					this.OnTENLOAISPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISANPHAM_KIEUSANPHAM", Storage="_KIEUSANPHAMs", ThisKey="IdLOAISP", OtherKey="IdLOAISP")]
		public EntitySet<KIEUSANPHAM> KIEUSANPHAMs
		{
			get
			{
				return this._KIEUSANPHAMs;
			}
			set
			{
				this._KIEUSANPHAMs.Assign(value);
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
		
		private void attach_KIEUSANPHAMs(KIEUSANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISANPHAM = this;
		}
		
		private void detach_KIEUSANPHAMs(KIEUSANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdSANPHAN;
		
		private string _TENSANPHAM;
		
		private string _MOTA;
		
		private System.Nullable<double> _DONGIA;
		
		private System.Nullable<int> _SOLUONGTON;
		
		private System.Nullable<int> _ROM;
		
		private System.Nullable<int> _RAM;
		
		private string _ANHBIA;
		
		private System.Nullable<int> _IdKIEUSP;
		
		private EntitySet<CTDONHANG> _CTDONHANGs;
		
		private EntityRef<KIEUSANPHAM> _KIEUSANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSANPHANChanging(int value);
    partial void OnIdSANPHANChanged();
    partial void OnTENSANPHAMChanging(string value);
    partial void OnTENSANPHAMChanged();
    partial void OnMOTAChanging(string value);
    partial void OnMOTAChanged();
    partial void OnDONGIAChanging(System.Nullable<double> value);
    partial void OnDONGIAChanged();
    partial void OnSOLUONGTONChanging(System.Nullable<int> value);
    partial void OnSOLUONGTONChanged();
    partial void OnROMChanging(System.Nullable<int> value);
    partial void OnROMChanged();
    partial void OnRAMChanging(System.Nullable<int> value);
    partial void OnRAMChanged();
    partial void OnANHBIAChanging(string value);
    partial void OnANHBIAChanged();
    partial void OnIdKIEUSPChanging(System.Nullable<int> value);
    partial void OnIdKIEUSPChanged();
    #endregion
		
		public SANPHAM()
		{
			this._CTDONHANGs = new EntitySet<CTDONHANG>(new Action<CTDONHANG>(this.attach_CTDONHANGs), new Action<CTDONHANG>(this.detach_CTDONHANGs));
			this._KIEUSANPHAM = default(EntityRef<KIEUSANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSANPHAN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdSANPHAN
		{
			get
			{
				return this._IdSANPHAN;
			}
			set
			{
				if ((this._IdSANPHAN != value))
				{
					this.OnIdSANPHANChanging(value);
					this.SendPropertyChanging();
					this._IdSANPHAN = value;
					this.SendPropertyChanged("IdSANPHAN");
					this.OnIdSANPHANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENSANPHAM", DbType="NVarChar(100)")]
		public string TENSANPHAM
		{
			get
			{
				return this._TENSANPHAM;
			}
			set
			{
				if ((this._TENSANPHAM != value))
				{
					this.OnTENSANPHAMChanging(value);
					this.SendPropertyChanging();
					this._TENSANPHAM = value;
					this.SendPropertyChanged("TENSANPHAM");
					this.OnTENSANPHAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTA", DbType="NVarChar(500)")]
		public string MOTA
		{
			get
			{
				return this._MOTA;
			}
			set
			{
				if ((this._MOTA != value))
				{
					this.OnMOTAChanging(value);
					this.SendPropertyChanging();
					this._MOTA = value;
					this.SendPropertyChanged("MOTA");
					this.OnMOTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Float")]
		public System.Nullable<double> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONGTON", DbType="Int")]
		public System.Nullable<int> SOLUONGTON
		{
			get
			{
				return this._SOLUONGTON;
			}
			set
			{
				if ((this._SOLUONGTON != value))
				{
					this.OnSOLUONGTONChanging(value);
					this.SendPropertyChanging();
					this._SOLUONGTON = value;
					this.SendPropertyChanged("SOLUONGTON");
					this.OnSOLUONGTONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ROM", DbType="Int")]
		public System.Nullable<int> ROM
		{
			get
			{
				return this._ROM;
			}
			set
			{
				if ((this._ROM != value))
				{
					this.OnROMChanging(value);
					this.SendPropertyChanging();
					this._ROM = value;
					this.SendPropertyChanged("ROM");
					this.OnROMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM", DbType="Int")]
		public System.Nullable<int> RAM
		{
			get
			{
				return this._RAM;
			}
			set
			{
				if ((this._RAM != value))
				{
					this.OnRAMChanging(value);
					this.SendPropertyChanging();
					this._RAM = value;
					this.SendPropertyChanged("RAM");
					this.OnRAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ANHBIA", DbType="NVarChar(10)")]
		public string ANHBIA
		{
			get
			{
				return this._ANHBIA;
			}
			set
			{
				if ((this._ANHBIA != value))
				{
					this.OnANHBIAChanging(value);
					this.SendPropertyChanging();
					this._ANHBIA = value;
					this.SendPropertyChanged("ANHBIA");
					this.OnANHBIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdKIEUSP", DbType="Int")]
		public System.Nullable<int> IdKIEUSP
		{
			get
			{
				return this._IdKIEUSP;
			}
			set
			{
				if ((this._IdKIEUSP != value))
				{
					if (this._KIEUSANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdKIEUSPChanging(value);
					this.SendPropertyChanging();
					this._IdKIEUSP = value;
					this.SendPropertyChanged("IdKIEUSP");
					this.OnIdKIEUSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CTDONHANG", Storage="_CTDONHANGs", ThisKey="IdSANPHAN", OtherKey="IdSANPHAN")]
		public EntitySet<CTDONHANG> CTDONHANGs
		{
			get
			{
				return this._CTDONHANGs;
			}
			set
			{
				this._CTDONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KIEUSANPHAM_SANPHAM", Storage="_KIEUSANPHAM", ThisKey="IdKIEUSP", OtherKey="IdKIEUSP", IsForeignKey=true)]
		public KIEUSANPHAM KIEUSANPHAM
		{
			get
			{
				return this._KIEUSANPHAM.Entity;
			}
			set
			{
				KIEUSANPHAM previousValue = this._KIEUSANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._KIEUSANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KIEUSANPHAM.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._KIEUSANPHAM.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._IdKIEUSP = value.IdKIEUSP;
					}
					else
					{
						this._IdKIEUSP = default(Nullable<int>);
					}
					this.SendPropertyChanged("KIEUSANPHAM");
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
		
		private void attach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdUser;
		
		private string _Email;
		
		private string _Password;
		
		private string _PhoneNumber;
		
		private string _UserName;
		
		private System.Nullable<bool> _Quyen;
		
		private EntitySet<DONHANG> _DONHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUserChanging(int value);
    partial void OnIdUserChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnQuyenChanging(System.Nullable<bool> value);
    partial void OnQuyenChanged();
    #endregion
		
		public User()
		{
			this._DONHANGs = new EntitySet<DONHANG>(new Action<DONHANG>(this.attach_DONHANGs), new Action<DONHANG>(this.detach_DONHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(200)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(200)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(11)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(200)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quyen", DbType="Bit")]
		public System.Nullable<bool> Quyen
		{
			get
			{
				return this._Quyen;
			}
			set
			{
				if ((this._Quyen != value))
				{
					this.OnQuyenChanging(value);
					this.SendPropertyChanging();
					this._Quyen = value;
					this.SendPropertyChanged("Quyen");
					this.OnQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_DONHANG", Storage="_DONHANGs", ThisKey="IdUser", OtherKey="IdUser")]
		public EntitySet<DONHANG> DONHANGs
		{
			get
			{
				return this._DONHANGs;
			}
			set
			{
				this._DONHANGs.Assign(value);
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
		
		private void attach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591