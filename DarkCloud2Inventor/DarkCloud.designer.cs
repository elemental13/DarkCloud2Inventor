﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DarkCloud2Inventor
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="darkcloud2")]
	public partial class DarkCloudDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertinvention(invention instance);
    partial void Updateinvention(invention instance);
    partial void Deleteinvention(invention instance);
    partial void Insertinventions_have_inventtype(inventions_have_inventtype instance);
    partial void Updateinventions_have_inventtype(inventions_have_inventtype instance);
    partial void Deleteinventions_have_inventtype(inventions_have_inventtype instance);
    partial void Insertinventions_have_item(inventions_have_item instance);
    partial void Updateinventions_have_item(inventions_have_item instance);
    partial void Deleteinventions_have_item(inventions_have_item instance);
    partial void Insertinventions_have_photo(inventions_have_photo instance);
    partial void Updateinventions_have_photo(inventions_have_photo instance);
    partial void Deleteinventions_have_photo(inventions_have_photo instance);
    partial void Insertinventtype(inventtype instance);
    partial void Updateinventtype(inventtype instance);
    partial void Deleteinventtype(inventtype instance);
    partial void Insertitem(item instance);
    partial void Updateitem(item instance);
    partial void Deleteitem(item instance);
    partial void Insertphoto(photo instance);
    partial void Updatephoto(photo instance);
    partial void Deletephoto(photo instance);
    partial void Insertphotos_have_phototype(photos_have_phototype instance);
    partial void Updatephotos_have_phototype(photos_have_phototype instance);
    partial void Deletephotos_have_phototype(photos_have_phototype instance);
    partial void Insertphotostaken(photostaken instance);
    partial void Updatephotostaken(photostaken instance);
    partial void Deletephotostaken(photostaken instance);
    partial void Insertphototype(phototype instance);
    partial void Updatephototype(phototype instance);
    partial void Deletephototype(phototype instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public DarkCloudDataContext() : 
				base(global::DarkCloud2Inventor.Properties.Settings.Default.darkcloud2ConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DarkCloudDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DarkCloudDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DarkCloudDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DarkCloudDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<invention> inventions
		{
			get
			{
				return this.GetTable<invention>();
			}
		}
		
		public System.Data.Linq.Table<inventions_have_inventtype> inventions_have_inventtypes
		{
			get
			{
				return this.GetTable<inventions_have_inventtype>();
			}
		}
		
		public System.Data.Linq.Table<inventions_have_item> inventions_have_items
		{
			get
			{
				return this.GetTable<inventions_have_item>();
			}
		}
		
		public System.Data.Linq.Table<inventions_have_photo> inventions_have_photos
		{
			get
			{
				return this.GetTable<inventions_have_photo>();
			}
		}
		
		public System.Data.Linq.Table<inventtype> inventtypes
		{
			get
			{
				return this.GetTable<inventtype>();
			}
		}
		
		public System.Data.Linq.Table<item> items
		{
			get
			{
				return this.GetTable<item>();
			}
		}
		
		public System.Data.Linq.Table<photo> photos
		{
			get
			{
				return this.GetTable<photo>();
			}
		}
		
		public System.Data.Linq.Table<photos_have_phototype> photos_have_phototypes
		{
			get
			{
				return this.GetTable<photos_have_phototype>();
			}
		}
		
		public System.Data.Linq.Table<photostaken> photostakens
		{
			get
			{
				return this.GetTable<photostaken>();
			}
		}
		
		public System.Data.Linq.Table<phototype> phototypes
		{
			get
			{
				return this.GetTable<phototype>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.VerifyUser")]
		public ISingleResult<VerifyUserResult> VerifyUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(25)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(25)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user, pass);
			return ((ISingleResult<VerifyUserResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventions")]
	public partial class invention : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<int> _chapter;
		
		private string _description;
		
		private string _pic;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnchapterChanging(System.Nullable<int> value);
    partial void OnchapterChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnpicChanging(string value);
    partial void OnpicChanged();
    #endregion
		
		public invention()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chapter", DbType="Int")]
		public System.Nullable<int> chapter
		{
			get
			{
				return this._chapter;
			}
			set
			{
				if ((this._chapter != value))
				{
					this.OnchapterChanging(value);
					this.SendPropertyChanging();
					this._chapter = value;
					this.SendPropertyChanged("chapter");
					this.OnchapterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pic", DbType="VarChar(20)")]
		public string pic
		{
			get
			{
				return this._pic;
			}
			set
			{
				if ((this._pic != value))
				{
					this.OnpicChanging(value);
					this.SendPropertyChanging();
					this._pic = value;
					this.SendPropertyChanged("pic");
					this.OnpicChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventions_have_inventtypes")]
	public partial class inventions_have_inventtype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _inventID;
		
		private int _typeID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninventIDChanging(int value);
    partial void OninventIDChanged();
    partial void OntypeIDChanging(int value);
    partial void OntypeIDChanged();
    #endregion
		
		public inventions_have_inventtype()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int inventID
		{
			get
			{
				return this._inventID;
			}
			set
			{
				if ((this._inventID != value))
				{
					this.OninventIDChanging(value);
					this.SendPropertyChanging();
					this._inventID = value;
					this.SendPropertyChanged("inventID");
					this.OninventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int typeID
		{
			get
			{
				return this._typeID;
			}
			set
			{
				if ((this._typeID != value))
				{
					this.OntypeIDChanging(value);
					this.SendPropertyChanging();
					this._typeID = value;
					this.SendPropertyChanged("typeID");
					this.OntypeIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventions_have_items")]
	public partial class inventions_have_item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _inventID;
		
		private int _itemID;
		
		private System.Nullable<int> _amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninventIDChanging(int value);
    partial void OninventIDChanged();
    partial void OnitemIDChanging(int value);
    partial void OnitemIDChanged();
    partial void OnamountChanging(System.Nullable<int> value);
    partial void OnamountChanged();
    #endregion
		
		public inventions_have_item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int inventID
		{
			get
			{
				return this._inventID;
			}
			set
			{
				if ((this._inventID != value))
				{
					this.OninventIDChanging(value);
					this.SendPropertyChanging();
					this._inventID = value;
					this.SendPropertyChanged("inventID");
					this.OninventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int itemID
		{
			get
			{
				return this._itemID;
			}
			set
			{
				if ((this._itemID != value))
				{
					this.OnitemIDChanging(value);
					this.SendPropertyChanging();
					this._itemID = value;
					this.SendPropertyChanged("itemID");
					this.OnitemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int")]
		public System.Nullable<int> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventions_have_photos")]
	public partial class inventions_have_photo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _inventID;
		
		private int _photoID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninventIDChanging(int value);
    partial void OninventIDChanged();
    partial void OnphotoIDChanging(int value);
    partial void OnphotoIDChanged();
    #endregion
		
		public inventions_have_photo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int inventID
		{
			get
			{
				return this._inventID;
			}
			set
			{
				if ((this._inventID != value))
				{
					this.OninventIDChanging(value);
					this.SendPropertyChanging();
					this._inventID = value;
					this.SendPropertyChanged("inventID");
					this.OninventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photoID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int photoID
		{
			get
			{
				return this._photoID;
			}
			set
			{
				if ((this._photoID != value))
				{
					this.OnphotoIDChanging(value);
					this.SendPropertyChanging();
					this._photoID = value;
					this.SendPropertyChanged("photoID");
					this.OnphotoIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventtypes")]
	public partial class inventtype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OncategoryChanging(string value);
    partial void OncategoryChanged();
    #endregion
		
		public inventtype()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="VarChar(20)")]
		public string category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.items")]
	public partial class item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<int> _cost;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncostChanging(System.Nullable<int> value);
    partial void OncostChanged();
    #endregion
		
		public item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cost", DbType="Int")]
		public System.Nullable<int> cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				if ((this._cost != value))
				{
					this.OncostChanging(value);
					this.SendPropertyChanging();
					this._cost = value;
					this.SendPropertyChanged("cost");
					this.OncostChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.photos")]
	public partial class photo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<int> _chapter;
		
		private string _location;
		
		private string _pic;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnchapterChanging(System.Nullable<int> value);
    partial void OnchapterChanged();
    partial void OnlocationChanging(string value);
    partial void OnlocationChanged();
    partial void OnpicChanging(string value);
    partial void OnpicChanged();
    #endregion
		
		public photo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chapter", DbType="Int")]
		public System.Nullable<int> chapter
		{
			get
			{
				return this._chapter;
			}
			set
			{
				if ((this._chapter != value))
				{
					this.OnchapterChanging(value);
					this.SendPropertyChanging();
					this._chapter = value;
					this.SendPropertyChanged("chapter");
					this.OnchapterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_location", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string location
		{
			get
			{
				return this._location;
			}
			set
			{
				if ((this._location != value))
				{
					this.OnlocationChanging(value);
					this.SendPropertyChanging();
					this._location = value;
					this.SendPropertyChanged("location");
					this.OnlocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pic", DbType="VarChar(20)")]
		public string pic
		{
			get
			{
				return this._pic;
			}
			set
			{
				if ((this._pic != value))
				{
					this.OnpicChanging(value);
					this.SendPropertyChanging();
					this._pic = value;
					this.SendPropertyChanged("pic");
					this.OnpicChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.photos_have_phototypes")]
	public partial class photos_have_phototype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _photoID;
		
		private int _typeID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnphotoIDChanging(int value);
    partial void OnphotoIDChanged();
    partial void OntypeIDChanging(int value);
    partial void OntypeIDChanged();
    #endregion
		
		public photos_have_phototype()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photoID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int photoID
		{
			get
			{
				return this._photoID;
			}
			set
			{
				if ((this._photoID != value))
				{
					this.OnphotoIDChanging(value);
					this.SendPropertyChanging();
					this._photoID = value;
					this.SendPropertyChanged("photoID");
					this.OnphotoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int typeID
		{
			get
			{
				return this._typeID;
			}
			set
			{
				if ((this._typeID != value))
				{
					this.OntypeIDChanging(value);
					this.SendPropertyChanging();
					this._typeID = value;
					this.SendPropertyChanged("typeID");
					this.OntypeIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.photostaken")]
	public partial class photostaken : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private int _photoID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnphotoIDChanging(int value);
    partial void OnphotoIDChanged();
    #endregion
		
		public photostaken()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photoID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int photoID
		{
			get
			{
				return this._photoID;
			}
			set
			{
				if ((this._photoID != value))
				{
					this.OnphotoIDChanging(value);
					this.SendPropertyChanging();
					this._photoID = value;
					this.SendPropertyChanged("photoID");
					this.OnphotoIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.phototypes")]
	public partial class phototype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OncategoryChanging(string value);
    partial void OncategoryChanged();
    #endregion
		
		public phototype()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="VarChar(20)")]
		public string category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _userpass;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnuserpassChanging(string value);
    partial void OnuserpassChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userpass", DbType="VarChar(20)")]
		public string userpass
		{
			get
			{
				return this._userpass;
			}
			set
			{
				if ((this._userpass != value))
				{
					this.OnuserpassChanging(value);
					this.SendPropertyChanging();
					this._userpass = value;
					this.SendPropertyChanged("userpass");
					this.OnuserpassChanged();
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
	
	public partial class VerifyUserResult
	{
		
		private string _userpass;
		
		public VerifyUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userpass", DbType="VarChar(20)")]
		public string userpass
		{
			get
			{
				return this._userpass;
			}
			set
			{
				if ((this._userpass != value))
				{
					this._userpass = value;
				}
			}
		}
	}
}
#pragma warning restore 1591