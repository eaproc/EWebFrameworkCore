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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___Beneficiary : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Beneficiary()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBeneficiaryStatusID = new DataColumnDefinition(TableColumnNames.BeneficiaryStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCity = new DataColumnDefinition(TableColumnNames.City.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defState = new DataColumnDefinition(TableColumnNames.State.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defZipCode = new DataColumnDefinition(TableColumnNames.ZipCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolName = new DataColumnDefinition(TableColumnNames.SchoolName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolAddress = new DataColumnDefinition(TableColumnNames.SchoolAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClassOnEnrollment = new DataColumnDefinition(TableColumnNames.ClassOnEnrollment.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(TableColumnNames.HomePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAlternatePhone = new DataColumnDefinition(TableColumnNames.AlternatePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(TableColumnNames.GenderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDateOfBirth = new DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVocation = new DataColumnDefinition(TableColumnNames.Vocation.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBirthCertificatePath = new DataColumnDefinition(TableColumnNames.BirthCertificatePath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPhotoPath = new DataColumnDefinition(TableColumnNames.PhotoPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defBeneficiaryStatusID.ColumnName, defBeneficiaryStatusID); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defCity.ColumnName, defCity); 
          ColumnDefns.Add(defState.ColumnName, defState); 
          ColumnDefns.Add(defZipCode.ColumnName, defZipCode); 
          ColumnDefns.Add(defSchoolName.ColumnName, defSchoolName); 
          ColumnDefns.Add(defSchoolAddress.ColumnName, defSchoolAddress); 
          ColumnDefns.Add(defClassOnEnrollment.ColumnName, defClassOnEnrollment); 
          ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone); 
          ColumnDefns.Add(defAlternatePhone.ColumnName, defAlternatePhone); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defGenderID.ColumnName, defGenderID); 
          ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth); 
          ColumnDefns.Add(defVocation.ColumnName, defVocation); 
          ColumnDefns.Add(defBirthCertificatePath.ColumnName, defBirthCertificatePath); 
          ColumnDefns.Add(defPhotoPath.ColumnName, defPhotoPath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.Beneficiary", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_GenderID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "common.Gender"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_BeneficiaryStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "charity.BeneficiaryStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "auth.Users"                  
                            ));                  

          }


                  
       public T___Beneficiary() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Beneficiary(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(DataTable FullTable) : base(FullTable)                                    
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
        public T___Beneficiary(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.Beneficiary";
       public const string Beneficiary__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.Beneficiary";
       public const string Beneficiary__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.Beneficiary";


       public enum TableColumnNames
       {

           ID,
           CenterID,
           BeneficiaryStatusID,
           FirstName,
           LastName,
           Address,
           City,
           State,
           ZipCode,
           SchoolName,
           SchoolAddress,
           ClassOnEnrollment,
           HomePhone,
           AlternatePhone,
           Email,
           GenderID,
           DateOfBirth,
           Vocation,
           BirthCertificatePath,
           PhotoPath,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_Beneficiary, 
           fk_charity_Beneficiary_CenterID, 
           fk_charity_Beneficiary_GenderID, 
           fk_charity_Beneficiary_BeneficiaryStatusID, 
           fk_charity_Beneficiary_CreatedByID, 
           fk_charity_Beneficiary_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defBeneficiaryStatusID;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defCity;
       public static readonly DataColumnDefinition defState;
       public static readonly DataColumnDefinition defZipCode;
       public static readonly DataColumnDefinition defSchoolName;
       public static readonly DataColumnDefinition defSchoolAddress;
       public static readonly DataColumnDefinition defClassOnEnrollment;
       public static readonly DataColumnDefinition defHomePhone;
       public static readonly DataColumnDefinition defAlternatePhone;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defGenderID;
       public static readonly DataColumnDefinition defDateOfBirth;
       public static readonly DataColumnDefinition defVocation;
       public static readonly DataColumnDefinition defBirthCertificatePath;
       public static readonly DataColumnDefinition defPhotoPath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int CenterID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CenterID.ToString());  set => TargettedRow[TableColumnNames.CenterID.ToString()] = value; }


       public int BeneficiaryStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BeneficiaryStatusID.ToString());  set => TargettedRow[TableColumnNames.BeneficiaryStatusID.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public string Address { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Address.ToString());  set => TargettedRow[TableColumnNames.Address.ToString()] = value; }


       public string City { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.City.ToString());  set => TargettedRow[TableColumnNames.City.ToString()] = value; }


       public string State { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.State.ToString());  set => TargettedRow[TableColumnNames.State.ToString()] = value; }


       public string ZipCode { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ZipCode.ToString());  set => TargettedRow[TableColumnNames.ZipCode.ToString()] = value; }


       public string SchoolName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SchoolName.ToString());  set => TargettedRow[TableColumnNames.SchoolName.ToString()] = value; }


       public string SchoolAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SchoolAddress.ToString());  set => TargettedRow[TableColumnNames.SchoolAddress.ToString()] = value; }


       public string ClassOnEnrollment { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ClassOnEnrollment.ToString());  set => TargettedRow[TableColumnNames.ClassOnEnrollment.ToString()] = value; }


       public string HomePhone { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HomePhone.ToString());  set => TargettedRow[TableColumnNames.HomePhone.ToString()] = value; }


       public string AlternatePhone { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AlternatePhone.ToString());  set => TargettedRow[TableColumnNames.AlternatePhone.ToString()] = value; }


       public string Email { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Email.ToString());  set => TargettedRow[TableColumnNames.Email.ToString()] = value; }


       public int GenderID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.GenderID.ToString());  set => TargettedRow[TableColumnNames.GenderID.ToString()] = value; }


       public DateTime DateOfBirth { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.DateOfBirth.ToString());  set => TargettedRow[TableColumnNames.DateOfBirth.ToString()] = value; }


       public string Vocation { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Vocation.ToString());  set => TargettedRow[TableColumnNames.Vocation.ToString()] = value; }


       public string BirthCertificatePath { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BirthCertificatePath.ToString());  set => TargettedRow[TableColumnNames.BirthCertificatePath.ToString()] = value; }


       public string PhotoPath { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PhotoPath.ToString());  set => TargettedRow[TableColumnNames.PhotoPath.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime UpdatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int UpdatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Beneficiary GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Beneficiary GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Beneficiary(conn.Fetch(Beneficiary__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Beneficiary GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Beneficiary( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Beneficiary GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Beneficiary__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCenterID;
            private DataColumnParameter ParamBeneficiaryStatusID;
            private DataColumnParameter ParamFirstName;
            private DataColumnParameter ParamLastName;
            private DataColumnParameter ParamAddress;
            private DataColumnParameter ParamCity;
            private DataColumnParameter ParamState;
            private DataColumnParameter ParamZipCode;
            private DataColumnParameter ParamSchoolName;
            private DataColumnParameter ParamSchoolAddress;
            private DataColumnParameter ParamClassOnEnrollment;
            private DataColumnParameter ParamHomePhone;
            private DataColumnParameter ParamAlternatePhone;
            private DataColumnParameter ParamEmail;
            private DataColumnParameter ParamGenderID;
            private DataColumnParameter ParamDateOfBirth;
            private DataColumnParameter ParamVocation;
            private DataColumnParameter ParamBirthCertificatePath;
            private DataColumnParameter ParamPhotoPath;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Beneficiary v):this(v.ID)                  
            {                  

                ParamCenterID = new(defCenterID, v.CenterID);                  
                ParamBeneficiaryStatusID = new(defBeneficiaryStatusID, v.BeneficiaryStatusID);                  
                ParamFirstName = new(defFirstName, v.FirstName);                  
                ParamLastName = new(defLastName, v.LastName);                  
                ParamAddress = new(defAddress, v.Address);                  
                ParamCity = new(defCity, v.City);                  
                ParamState = new(defState, v.State);                  
                ParamZipCode = new(defZipCode, v.ZipCode);                  
                ParamSchoolName = new(defSchoolName, v.SchoolName);                  
                ParamSchoolAddress = new(defSchoolAddress, v.SchoolAddress);                  
                ParamClassOnEnrollment = new(defClassOnEnrollment, v.ClassOnEnrollment);                  
                ParamHomePhone = new(defHomePhone, v.HomePhone);                  
                ParamAlternatePhone = new(defAlternatePhone, v.AlternatePhone);                  
                ParamEmail = new(defEmail, v.Email);                  
                ParamGenderID = new(defGenderID, v.GenderID);                  
                ParamDateOfBirth = new(defDateOfBirth, v.DateOfBirth);                  
                ParamVocation = new(defVocation, v.Vocation);                  
                ParamBirthCertificatePath = new(defBirthCertificatePath, v.BirthCertificatePath);                  
                ParamPhotoPath = new(defPhotoPath, v.PhotoPath);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetCenterID(int v)                  
            {                  
                ParamCenterID = new(defCenterID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBeneficiaryStatusID(int v)                  
            {                  
                ParamBeneficiaryStatusID = new(defBeneficiaryStatusID, v);                  
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
                  
            public UpdateQueryBuilder SetAddress(string v)                  
            {                  
                ParamAddress = new(defAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCity(string v)                  
            {                  
                ParamCity = new(defCity, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetState(string v)                  
            {                  
                ParamState = new(defState, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetZipCode(string v)                  
            {                  
                ParamZipCode = new(defZipCode, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSchoolName(string v)                  
            {                  
                ParamSchoolName = new(defSchoolName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSchoolAddress(string v)                  
            {                  
                ParamSchoolAddress = new(defSchoolAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetClassOnEnrollment(string v)                  
            {                  
                ParamClassOnEnrollment = new(defClassOnEnrollment, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetHomePhone(string v)                  
            {                  
                ParamHomePhone = new(defHomePhone, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAlternatePhone(string v)                  
            {                  
                ParamAlternatePhone = new(defAlternatePhone, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEmail(string v)                  
            {                  
                ParamEmail = new(defEmail, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGenderID(int v)                  
            {                  
                ParamGenderID = new(defGenderID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDateOfBirth(DateTime v)                  
            {                  
                ParamDateOfBirth = new(defDateOfBirth, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetVocation(string v)                  
            {                  
                ParamVocation = new(defVocation, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBirthCertificatePath(string v)                  
            {                  
                ParamBirthCertificatePath = new(defBirthCertificatePath, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPhotoPath(string v)                  
            {                  
                ParamPhotoPath = new(defPhotoPath, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int v)                  
            {                  
                ParamUpdatedByID = new(defUpdatedByID, v);                  
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
            int CenterID,
            int BeneficiaryStatusID,
            string FirstName,
            string LastName,
            string Address,
            int GenderID,
            DateTime DateOfBirth,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string City = null,
            string State = null,
            string ZipCode = null,
            string SchoolName = null,
            string SchoolAddress = null,
            string ClassOnEnrollment = null,
            string HomePhone = null,
            string AlternatePhone = null,
            string Email = null,
            string Vocation = null,
            string BirthCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBeneficiaryStatusID = new (defBeneficiaryStatusID, BeneficiaryStatusID);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramCity = new (defCity, City);
                DataColumnParameter paramState = new (defState, State);
                DataColumnParameter paramZipCode = new (defZipCode, ZipCode);
                DataColumnParameter paramSchoolName = new (defSchoolName, SchoolName);
                DataColumnParameter paramSchoolAddress = new (defSchoolAddress, SchoolAddress);
                DataColumnParameter paramClassOnEnrollment = new (defClassOnEnrollment, ClassOnEnrollment);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramAlternatePhone = new (defAlternatePhone, AlternatePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramVocation = new (defVocation, Vocation);
                DataColumnParameter paramBirthCertificatePath = new (defBirthCertificatePath, BirthCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23})  ", TABLE_NAME,
                        paramCenterID.GetSQLValue(),
                        paramBeneficiaryStatusID.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramCity.GetSQLValue(),
                        paramState.GetSQLValue(),
                        paramZipCode.GetSQLValue(),
                        paramSchoolName.GetSQLValue(),
                        paramSchoolAddress.GetSQLValue(),
                        paramClassOnEnrollment.GetSQLValue(),
                        paramHomePhone.GetSQLValue(),
                        paramAlternatePhone.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramGenderID.GetSQLValue(),
                        paramDateOfBirth.GetSQLValue(),
                        paramVocation.GetSQLValue(),
                        paramBirthCertificatePath.GetSQLValue(),
                        paramPhotoPath.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
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
            int CenterID,
            int BeneficiaryStatusID,
            string FirstName,
            string LastName,
            string Address,
            int GenderID,
            DateTime DateOfBirth,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string City = null,
            string State = null,
            string ZipCode = null,
            string SchoolName = null,
            string SchoolAddress = null,
            string ClassOnEnrollment = null,
            string HomePhone = null,
            string AlternatePhone = null,
            string Email = null,
            string Vocation = null,
            string BirthCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBeneficiaryStatusID = new (defBeneficiaryStatusID, BeneficiaryStatusID);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramCity = new (defCity, City);
                DataColumnParameter paramState = new (defState, State);
                DataColumnParameter paramZipCode = new (defZipCode, ZipCode);
                DataColumnParameter paramSchoolName = new (defSchoolName, SchoolName);
                DataColumnParameter paramSchoolAddress = new (defSchoolAddress, SchoolAddress);
                DataColumnParameter paramClassOnEnrollment = new (defClassOnEnrollment, ClassOnEnrollment);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramAlternatePhone = new (defAlternatePhone, AlternatePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramVocation = new (defVocation, Vocation);
                DataColumnParameter paramBirthCertificatePath = new (defBirthCertificatePath, BirthCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCenterID.GetSQLValue(),
                        paramBeneficiaryStatusID.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramCity.GetSQLValue(),
                        paramState.GetSQLValue(),
                        paramZipCode.GetSQLValue(),
                        paramSchoolName.GetSQLValue(),
                        paramSchoolAddress.GetSQLValue(),
                        paramClassOnEnrollment.GetSQLValue(),
                        paramHomePhone.GetSQLValue(),
                        paramAlternatePhone.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramGenderID.GetSQLValue(),
                        paramDateOfBirth.GetSQLValue(),
                        paramVocation.GetSQLValue(),
                        paramBirthCertificatePath.GetSQLValue(),
                        paramPhotoPath.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int CenterID,
            int BeneficiaryStatusID,
            string FirstName,
            string LastName,
            string Address,
            int GenderID,
            DateTime DateOfBirth,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string City = null,
            string State = null,
            string ZipCode = null,
            string SchoolName = null,
            string SchoolAddress = null,
            string ClassOnEnrollment = null,
            string HomePhone = null,
            string AlternatePhone = null,
            string Email = null,
            string Vocation = null,
            string BirthCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBeneficiaryStatusID = new (defBeneficiaryStatusID, BeneficiaryStatusID);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramCity = new (defCity, City);
                DataColumnParameter paramState = new (defState, State);
                DataColumnParameter paramZipCode = new (defZipCode, ZipCode);
                DataColumnParameter paramSchoolName = new (defSchoolName, SchoolName);
                DataColumnParameter paramSchoolAddress = new (defSchoolAddress, SchoolAddress);
                DataColumnParameter paramClassOnEnrollment = new (defClassOnEnrollment, ClassOnEnrollment);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramAlternatePhone = new (defAlternatePhone, AlternatePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramVocation = new (defVocation, Vocation);
                DataColumnParameter paramBirthCertificatePath = new (defBirthCertificatePath, BirthCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23})  ", TABLE_NAME,
                        paramCenterID.GetSQLValue(),
                        paramBeneficiaryStatusID.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramCity.GetSQLValue(),
                        paramState.GetSQLValue(),
                        paramZipCode.GetSQLValue(),
                        paramSchoolName.GetSQLValue(),
                        paramSchoolAddress.GetSQLValue(),
                        paramClassOnEnrollment.GetSQLValue(),
                        paramHomePhone.GetSQLValue(),
                        paramAlternatePhone.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramGenderID.GetSQLValue(),
                        paramDateOfBirth.GetSQLValue(),
                        paramVocation.GetSQLValue(),
                        paramBirthCertificatePath.GetSQLValue(),
                        paramPhotoPath.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                            
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
