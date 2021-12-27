using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.MSSQL.Schemas;                  
using EEntityCore.DB.MSSQL;                  
using EEntityCore.DB.Modules;                  
using static EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.DatabaseInit;
using EWebFrameworkCore.Dev.DBEntities.DatabaseSchema;

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___Person : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Person()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defIdentificationNo = new DataColumnDefinition(TableColumnNames.IdentificationNo.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(TableColumnNames.CountryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDateOfBirth = new DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(TableColumnNames.GenderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defHomeAddress = new DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonTitleID = new DataColumnDefinition(TableColumnNames.PersonTitleID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsSuperUser = new DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBloodTypeID = new DataColumnDefinition(TableColumnNames.BloodTypeID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBirthPlace = new DataColumnDefinition(TableColumnNames.BirthPlace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMaritalStatusID = new DataColumnDefinition(TableColumnNames.MaritalStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCanBeUpdated = new DataColumnDefinition(TableColumnNames.CanBeUpdated.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeDeleted = new DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defCountryID.ColumnName, defCountryID); 
          ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth); 
          ColumnDefns.Add(defGenderID.ColumnName, defGenderID); 
          ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defPersonTitleID.ColumnName, defPersonTitleID); 
          ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser); 
          ColumnDefns.Add(defBloodTypeID.ColumnName, defBloodTypeID); 
          ColumnDefns.Add(defBirthPlace.ColumnName, defBirthPlace); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defMaritalStatusID.ColumnName, defMaritalStatusID); 
          ColumnDefns.Add(defCanBeUpdated.ColumnName, defCanBeUpdated); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_CountryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.Country"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_GenderID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.Gender"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_PersonTitleID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.PersonTitle"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_BloodTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.BloodType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_MaritalStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.MaritalStatus"                  
                            ));                  

          }


                  
       public T___Person() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
   #region Partial Access                                    
                                    
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                                      
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(DataTable FullTable) : base(FullTable)                                    
        {                                    
        }                                    
                                    
                                    
        #endregion                                    
                                    
                                    
   #region Shallow Access                                    
        // In the real definition, shallow reference partial. Just that it means partial with no DBConn                                                      
                                    
        /// <summary>                                                      
        /// Shallow Access                                                      
        /// </summary>                                                      
        /// <param name="TargettedRow"></param>                                                      
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                                    
        public T___Person(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.Person";
       public const string Person__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [IdentificationNo], [FirstName], [LastName], [CountryID], [DateOfBirth], [GenderID], [HomeAddress], [Email], [PersonTitleID], [IsSuperUser], [BloodTypeID], [BirthPlace], [PictureFileName], [MaritalStatusID], [CanBeUpdated], [CanBeDeleted], [CreatedAt], [UpdatedAt], [DataMonitorID] FROM common.Person";
       public const string Person__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [IdentificationNo], [FirstName], [LastName], [CountryID], [DateOfBirth], [GenderID], [HomeAddress], [Email], [PersonTitleID], [IsSuperUser], [BloodTypeID], [BirthPlace], [PictureFileName], [MaritalStatusID], [CanBeUpdated], [CanBeDeleted], [CreatedAt], [UpdatedAt], [DataMonitorID] FROM common.Person";


       public enum TableColumnNames
       {

           ID,
           IdentificationNo,
           FirstName,
           LastName,
           CountryID,
           DateOfBirth,
           GenderID,
           HomeAddress,
           Email,
           PersonTitleID,
           IsSuperUser,
           BloodTypeID,
           BirthPlace,
           PictureFileName,
           MaritalStatusID,
           CanBeUpdated,
           CanBeDeleted,
           CreatedAt,
           UpdatedAt,
           DataMonitorID
       } 



       public enum TableConstraints{

           pk_common_Person, 
           fk_common_Person_DataMonitorID, 
           fk_common_Person_CountryID, 
           fk_common_Person_GenderID, 
           fk_common_Person_PersonTitleID, 
           fk_common_Person_BloodTypeID, 
           fk_common_Person_MaritalStatusID, 
           uq_common_Person_IdentificationNo, 
           uq_common_Person_Email, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defIdentificationNo;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defCountryID;
       public static readonly DataColumnDefinition defDateOfBirth;
       public static readonly DataColumnDefinition defGenderID;
       public static readonly DataColumnDefinition defHomeAddress;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defPersonTitleID;
       public static readonly DataColumnDefinition defIsSuperUser;
       public static readonly DataColumnDefinition defBloodTypeID;
       public static readonly DataColumnDefinition defBirthPlace;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defMaritalStatusID;
       public static readonly DataColumnDefinition defCanBeUpdated;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defDataMonitorID;

       public string IdentificationNo { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IdentificationNo.ToString());  set => TargettedRow[TableColumnNames.IdentificationNo.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public int CountryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CountryID.ToString());  set => TargettedRow[TableColumnNames.CountryID.ToString()] = value; }


       public DateTime DateOfBirth { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.DateOfBirth.ToString());  set => TargettedRow[TableColumnNames.DateOfBirth.ToString()] = value; }


       public int GenderID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.GenderID.ToString());  set => TargettedRow[TableColumnNames.GenderID.ToString()] = value; }


       public string HomeAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HomeAddress.ToString());  set => TargettedRow[TableColumnNames.HomeAddress.ToString()] = value; }


       public string Email { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Email.ToString());  set => TargettedRow[TableColumnNames.Email.ToString()] = value; }


       public int? PersonTitleID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.PersonTitleID.ToString());  set => TargettedRow[TableColumnNames.PersonTitleID.ToString()] = value; }


       public bool IsSuperUser { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsSuperUser.ToString());  set => TargettedRow[TableColumnNames.IsSuperUser.ToString()] = value; }


       public int? BloodTypeID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.BloodTypeID.ToString());  set => TargettedRow[TableColumnNames.BloodTypeID.ToString()] = value; }


       public string BirthPlace { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BirthPlace.ToString());  set => TargettedRow[TableColumnNames.BirthPlace.ToString()] = value; }


       public string PictureFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PictureFileName.ToString());  set => TargettedRow[TableColumnNames.PictureFileName.ToString()] = value; }


       public int MaritalStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.MaritalStatusID.ToString());  set => TargettedRow[TableColumnNames.MaritalStatusID.ToString()] = value; }


       public bool CanBeUpdated { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.CanBeUpdated.ToString());  set => TargettedRow[TableColumnNames.CanBeUpdated.ToString()] = value; }


       public bool CanBeDeleted { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.CanBeDeleted.ToString());  set => TargettedRow[TableColumnNames.CanBeDeleted.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int? DataMonitorID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.DataMonitorID.ToString());  set => TargettedRow[TableColumnNames.DataMonitorID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Person GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Person GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Person(conn.Fetch(Person__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Person GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Person( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Person GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Person__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamIdentificationNo;
            private DataColumnParameter ParamFirstName;
            private DataColumnParameter ParamLastName;
            private DataColumnParameter ParamCountryID;
            private DataColumnParameter ParamDateOfBirth;
            private DataColumnParameter ParamGenderID;
            private DataColumnParameter ParamHomeAddress;
            private DataColumnParameter ParamEmail;
            private DataColumnParameter ParamPersonTitleID;
            private DataColumnParameter ParamIsSuperUser;
            private DataColumnParameter ParamBloodTypeID;
            private DataColumnParameter ParamBirthPlace;
            private DataColumnParameter ParamPictureFileName;
            private DataColumnParameter ParamMaritalStatusID;
            private DataColumnParameter ParamCanBeUpdated;
            private DataColumnParameter ParamCanBeDeleted;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamDataMonitorID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Person v):this(v.ID)                  
            {                  

                ParamIdentificationNo = new(defIdentificationNo, v.IdentificationNo);                  
                ParamFirstName = new(defFirstName, v.FirstName);                  
                ParamLastName = new(defLastName, v.LastName);                  
                ParamCountryID = new(defCountryID, v.CountryID);                  
                ParamDateOfBirth = new(defDateOfBirth, v.DateOfBirth);                  
                ParamGenderID = new(defGenderID, v.GenderID);                  
                ParamHomeAddress = new(defHomeAddress, v.HomeAddress);                  
                ParamEmail = new(defEmail, v.Email);                  
                ParamPersonTitleID = new(defPersonTitleID, v.PersonTitleID);                  
                ParamIsSuperUser = new(defIsSuperUser, v.IsSuperUser);                  
                ParamBloodTypeID = new(defBloodTypeID, v.BloodTypeID);                  
                ParamBirthPlace = new(defBirthPlace, v.BirthPlace);                  
                ParamPictureFileName = new(defPictureFileName, v.PictureFileName);                  
                ParamMaritalStatusID = new(defMaritalStatusID, v.MaritalStatusID);                  
                ParamCanBeUpdated = new(defCanBeUpdated, v.CanBeUpdated);                  
                ParamCanBeDeleted = new(defCanBeDeleted, v.CanBeDeleted);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamDataMonitorID = new(defDataMonitorID, v.DataMonitorID);                  
            }                  
                  
            public UpdateQueryBuilder SetIdentificationNo(string v)                  
            {                  
                ParamIdentificationNo = new(defIdentificationNo, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFirstName(string v)                  
            {                  
                ParamFirstName = new(defFirstName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLastName(string v)                  
            {                  
                ParamLastName = new(defLastName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCountryID(int v)                  
            {                  
                ParamCountryID = new(defCountryID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDateOfBirth(DateTime v)                  
            {                  
                ParamDateOfBirth = new(defDateOfBirth, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGenderID(int v)                  
            {                  
                ParamGenderID = new(defGenderID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetHomeAddress(string v)                  
            {                  
                ParamHomeAddress = new(defHomeAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEmail(string v)                  
            {                  
                ParamEmail = new(defEmail, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPersonTitleID(int? v)                  
            {                  
                ParamPersonTitleID = new(defPersonTitleID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsSuperUser(bool v)                  
            {                  
                ParamIsSuperUser = new(defIsSuperUser, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBloodTypeID(int? v)                  
            {                  
                ParamBloodTypeID = new(defBloodTypeID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBirthPlace(string v)                  
            {                  
                ParamBirthPlace = new(defBirthPlace, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPictureFileName(string v)                  
            {                  
                ParamPictureFileName = new(defPictureFileName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMaritalStatusID(int v)                  
            {                  
                ParamMaritalStatusID = new(defMaritalStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCanBeUpdated(bool v)                  
            {                  
                ParamCanBeUpdated = new(defCanBeUpdated, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCanBeDeleted(bool v)                  
            {                  
                ParamCanBeDeleted = new(defCanBeDeleted, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime? v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDataMonitorID(int? v)                  
            {                  
                ParamDataMonitorID = new(defDataMonitorID, v);                  
                return this;                  
            }                  

                  
            public string BuildSQL()                  
            {                  
                if (!this.CanUpdate()) throw new InvalidOperationException("Please, set at least a parameter to update.");                  
                  
                var p = this.GetTouchedColumns();                  
                System.Text.StringBuilder builder = new System.Text.StringBuilder($"UPDATE {TABLE_NAME} SET ");                  
                  
                foreach (var v in p) builder.Append($"{v.ColumnDefinition.ColumnName}={v.GetSQLValue()},");                  
                  
                builder = new System.Text.StringBuilder(builder.ToString().TrimEnd(','));                  
                builder.Append($" WHERE ID={ParamID.GetSQLValue()}");                  
                  
                return builder.ToString();                  
            }                  
                  
            public bool CanUpdate() => GetTouchedColumns().Count > 0;                  
                  
            private List<DataColumnParameter> GetTouchedColumns()                  
            {                  
                return this.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)                  
                    .Where(x => x.GetValue(this) is DataColumnParameter)                  
                    .Select(x => (DataColumnParameter)x.GetValue(this))                  
                    .Where(x => !x.Equals(ParamID))                  
                    .ToList();                  
            }                  
                  
            public int Execute(DBTransaction trans = null)                  
            {                  
                return TransactionRunner.InvokeRun((conn) => conn.ExecuteTransactionQuery(this.BuildSQL()), trans);                  
            }                  
        }                  
                  
        #endregion                  
                  





        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            string IdentificationNo,
            string FirstName,
            string LastName,
            int CountryID,
            DateTime DateOfBirth,
            int GenderID,
            bool IsSuperUser,
            int MaritalStatusID,
            bool CanBeUpdated,
            bool CanBeDeleted,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            int? PersonTitleID = null,
            int? BloodTypeID = null,
            string BirthPlace = null,
            string PictureFileName = null,
            DateTime? UpdatedAt = null,
            int? DataMonitorID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountryID = new (defCountryID, CountryID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramPersonTitleID = new (defPersonTitleID, PersonTitleID);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramBloodTypeID = new (defBloodTypeID, BloodTypeID);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramPictureFileName = new (defPictureFileName, PictureFileName);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramCanBeUpdated = new (defCanBeUpdated, CanBeUpdated);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19})  ", TABLE_NAME,
                        paramIdentificationNo.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramCountryID.GetSQLValue(),
                        paramDateOfBirth.GetSQLValue(),
                        paramGenderID.GetSQLValue(),
                        paramHomeAddress.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramPersonTitleID.GetSQLValue(),
                        paramIsSuperUser.GetSQLValue(),
                        paramBloodTypeID.GetSQLValue(),
                        paramBirthPlace.GetSQLValue(),
                        paramPictureFileName.GetSQLValue(),
                        paramMaritalStatusID.GetSQLValue(),
                        paramCanBeUpdated.GetSQLValue(),
                        paramCanBeDeleted.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(
            int ID,
            string IdentificationNo,
            string FirstName,
            string LastName,
            int CountryID,
            DateTime DateOfBirth,
            int GenderID,
            bool IsSuperUser,
            int MaritalStatusID,
            bool CanBeUpdated,
            bool CanBeDeleted,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            int? PersonTitleID = null,
            int? BloodTypeID = null,
            string BirthPlace = null,
            string PictureFileName = null,
            DateTime? UpdatedAt = null,
            int? DataMonitorID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountryID = new (defCountryID, CountryID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramPersonTitleID = new (defPersonTitleID, PersonTitleID);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramBloodTypeID = new (defBloodTypeID, BloodTypeID);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramPictureFileName = new (defPictureFileName, PictureFileName);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramCanBeUpdated = new (defCanBeUpdated, CanBeUpdated);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramIdentificationNo.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramCountryID.GetSQLValue(),
                        paramDateOfBirth.GetSQLValue(),
                        paramGenderID.GetSQLValue(),
                        paramHomeAddress.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramPersonTitleID.GetSQLValue(),
                        paramIsSuperUser.GetSQLValue(),
                        paramBloodTypeID.GetSQLValue(),
                        paramBirthPlace.GetSQLValue(),
                        paramPictureFileName.GetSQLValue(),
                        paramMaritalStatusID.GetSQLValue(),
                        paramCanBeUpdated.GetSQLValue(),
                        paramCanBeDeleted.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            string IdentificationNo,
            string FirstName,
            string LastName,
            int CountryID,
            DateTime DateOfBirth,
            int GenderID,
            bool IsSuperUser,
            int MaritalStatusID,
            bool CanBeUpdated,
            bool CanBeDeleted,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            int? PersonTitleID = null,
            int? BloodTypeID = null,
            string BirthPlace = null,
            string PictureFileName = null,
            DateTime? UpdatedAt = null,
            int? DataMonitorID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountryID = new (defCountryID, CountryID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramPersonTitleID = new (defPersonTitleID, PersonTitleID);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramBloodTypeID = new (defBloodTypeID, BloodTypeID);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramPictureFileName = new (defPictureFileName, PictureFileName);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramCanBeUpdated = new (defCanBeUpdated, CanBeUpdated);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19})  ", TABLE_NAME,
                        paramIdentificationNo.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramCountryID.GetSQLValue(),
                        paramDateOfBirth.GetSQLValue(),
                        paramGenderID.GetSQLValue(),
                        paramHomeAddress.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramPersonTitleID.GetSQLValue(),
                        paramIsSuperUser.GetSQLValue(),
                        paramBloodTypeID.GetSQLValue(),
                        paramBirthPlace.GetSQLValue(),
                        paramPictureFileName.GetSQLValue(),
                        paramMaritalStatusID.GetSQLValue(),
                        paramCanBeUpdated.GetSQLValue(),
                        paramCanBeDeleted.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue()                            
                            )
                        ).ToBoolean()
                    );


        }                  


                  
        /// <summary>                  
        /// Update current table. Works just for Target Row                  
        /// </summary>                  
        /// <param name="reloadTable">if you want this class reloaded</param>                  
        /// <param name="transaction"></param>                  
        /// <returns></returns>                  
        public bool Update(bool reloadTable = false, DBTransaction transaction = null)                  
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => {                  
                   bool r = new UpdateQueryBuilder(this).Execute(conn).ToBoolean();                  
                   if (reloadTable) this.LoadFromRows( GetRowWhereIDUsingSQL(this.ID, conn).TargettedRow );                  
                   return r;                  
               },                  
               transaction                  
               );                  
        }                  
                  



                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(DBTransaction transaction = null)                  
        {                  
            return DeleteItemRow(ID, transaction);                  
        }                  
                  
        public static bool DeleteItemRow(long pID, DBTransaction transaction = null)                                                      
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean(),                  
               transaction                  
               );                  
        }                  



   }


}
