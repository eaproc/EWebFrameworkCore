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
using EWebFrameworkCore.Dev.DBEntities.DatabaseSchema;

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.common                  
{                  

    public class V___ExpandedPersons : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___ExpandedPersons()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defIdentificationNo = new DataColumnDefinition(TableColumnNames.IdentificationNo.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonnelNumber = new DataColumnDefinition(TableColumnNames.PersonnelNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsGuardian = new DataColumnDefinition(TableColumnNames.IsGuardian.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobilePhone = new DataColumnDefinition(TableColumnNames.MobilePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGender = new DataColumnDefinition(TableColumnNames.Gender.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountry = new DataColumnDefinition(TableColumnNames.Country.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(TableColumnNames.CountryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(TableColumnNames.GenderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDateOfBirth = new DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomeAddress = new DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(TableColumnNames.HomePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonTitleID = new DataColumnDefinition(TableColumnNames.PersonTitleID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBloodTypeID = new DataColumnDefinition(TableColumnNames.BloodTypeID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMaritalStatusID = new DataColumnDefinition(TableColumnNames.MaritalStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUsername = new DataColumnDefinition(TableColumnNames.Username.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonnelID = new DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBirthPlace = new DataColumnDefinition(TableColumnNames.BirthPlace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMaritalStatus = new DataColumnDefinition(TableColumnNames.MaritalStatus.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBloodType = new DataColumnDefinition(TableColumnNames.BloodType.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuperUser = new DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeDeleted = new DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeUpdated = new DataColumnDefinition(TableColumnNames.CanBeUpdated.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defPersonnelNumber.ColumnName, defPersonnelNumber); 
          ColumnDefns.Add(defIsGuardian.ColumnName, defIsGuardian); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defMobilePhone.ColumnName, defMobilePhone); 
          ColumnDefns.Add(defGender.ColumnName, defGender); 
          ColumnDefns.Add(defCountry.ColumnName, defCountry); 
          ColumnDefns.Add(defCountryID.ColumnName, defCountryID); 
          ColumnDefns.Add(defGenderID.ColumnName, defGenderID); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth); 
          ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress); 
          ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone); 
          ColumnDefns.Add(defPersonTitleID.ColumnName, defPersonTitleID); 
          ColumnDefns.Add(defBloodTypeID.ColumnName, defBloodTypeID); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defMaritalStatusID.ColumnName, defMaritalStatusID); 
          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defBirthPlace.ColumnName, defBirthPlace); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defMaritalStatus.ColumnName, defMaritalStatus); 
          ColumnDefns.Add(defBloodType.ColumnName, defBloodType); 
          ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defCanBeUpdated.ColumnName, defCanBeUpdated); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("auth.Users");                  
            ReferencedTableNames.Add("common.BloodType");                  
            ReferencedTableNames.Add("common.Country");                  
            ReferencedTableNames.Add("common.Gender");                  
            ReferencedTableNames.Add("common.MaritalStatus");                  
            ReferencedTableNames.Add("common.Person");                  
            ReferencedTableNames.Add("common.PersonPhone");                  
            ReferencedTableNames.Add("common.PersonTitle");                  
            ReferencedTableNames.Add("common.Relation");                  
            ReferencedTableNames.Add("hr.Personnel");                  

          }


                  
       public V___ExpandedPersons() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___ExpandedPersons(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ExpandedPersons(DataTable FullTable) : base(FullTable)                                    
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
        public V___ExpandedPersons(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.ExpandedPersons";
       public const string ExpandedPersons__NO__BINARY___SQL_FILL_QUERY = "SELECT [IdentificationNo], [FirstName], [LastName], [PersonnelNumber], [IsGuardian], [Email], [MobilePhone], [Gender], [Country], [CountryID], [GenderID], [ID], [DateOfBirth], [HomeAddress], [HomePhone], [PersonTitleID], [BloodTypeID], [PictureFileName], [MaritalStatusID], [Username], [IsActive], [PersonnelID], [BirthPlace], [Title], [MaritalStatus], [BloodType], [IsSuperUser], [CanBeDeleted], [CanBeUpdated] FROM common.ExpandedPersons";
       public const string ExpandedPersons__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [IdentificationNo], [FirstName], [LastName], [PersonnelNumber], [IsGuardian], [Email], [MobilePhone], [Gender], [Country], [CountryID], [GenderID], [ID], [DateOfBirth], [HomeAddress], [HomePhone], [PersonTitleID], [BloodTypeID], [PictureFileName], [MaritalStatusID], [Username], [IsActive], [PersonnelID], [BirthPlace], [Title], [MaritalStatus], [BloodType], [IsSuperUser], [CanBeDeleted], [CanBeUpdated] FROM common.ExpandedPersons";


       public enum TableColumnNames
       {

           IdentificationNo,
           FirstName,
           LastName,
           PersonnelNumber,
           IsGuardian,
           Email,
           MobilePhone,
           Gender,
           Country,
           CountryID,
           GenderID,
           ID,
           DateOfBirth,
           HomeAddress,
           HomePhone,
           PersonTitleID,
           BloodTypeID,
           PictureFileName,
           MaritalStatusID,
           Username,
           IsActive,
           PersonnelID,
           BirthPlace,
           Title,
           MaritalStatus,
           BloodType,
           IsSuperUser,
           CanBeDeleted,
           CanBeUpdated
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defIdentificationNo;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defPersonnelNumber;
       public static readonly DataColumnDefinition defIsGuardian;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defMobilePhone;
       public static readonly DataColumnDefinition defGender;
       public static readonly DataColumnDefinition defCountry;
       public static readonly DataColumnDefinition defCountryID;
       public static readonly DataColumnDefinition defGenderID;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDateOfBirth;
       public static readonly DataColumnDefinition defHomeAddress;
       public static readonly DataColumnDefinition defHomePhone;
       public static readonly DataColumnDefinition defPersonTitleID;
       public static readonly DataColumnDefinition defBloodTypeID;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defMaritalStatusID;
       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defBirthPlace;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defMaritalStatus;
       public static readonly DataColumnDefinition defBloodType;
       public static readonly DataColumnDefinition defIsSuperUser;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defCanBeUpdated;

       public string IdentificationNo { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IdentificationNo.ToString());  set => TargettedRow[TableColumnNames.IdentificationNo.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public string PersonnelNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PersonnelNumber.ToString());  set => TargettedRow[TableColumnNames.PersonnelNumber.ToString()] = value; }


       public bool? IsGuardian { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.IsGuardian.ToString());  set => TargettedRow[TableColumnNames.IsGuardian.ToString()] = value; }


       public string Email { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Email.ToString());  set => TargettedRow[TableColumnNames.Email.ToString()] = value; }


       public string MobilePhone { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.MobilePhone.ToString());  set => TargettedRow[TableColumnNames.MobilePhone.ToString()] = value; }


       public string Gender { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Gender.ToString());  set => TargettedRow[TableColumnNames.Gender.ToString()] = value; }


       public string Country { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Country.ToString());  set => TargettedRow[TableColumnNames.Country.ToString()] = value; }


       public int CountryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CountryID.ToString());  set => TargettedRow[TableColumnNames.CountryID.ToString()] = value; }


       public int GenderID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.GenderID.ToString());  set => TargettedRow[TableColumnNames.GenderID.ToString()] = value; }


       public DateTime DateOfBirth { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.DateOfBirth.ToString());  set => TargettedRow[TableColumnNames.DateOfBirth.ToString()] = value; }


       public string HomeAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HomeAddress.ToString());  set => TargettedRow[TableColumnNames.HomeAddress.ToString()] = value; }


       public string HomePhone { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HomePhone.ToString());  set => TargettedRow[TableColumnNames.HomePhone.ToString()] = value; }


       public int? PersonTitleID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.PersonTitleID.ToString());  set => TargettedRow[TableColumnNames.PersonTitleID.ToString()] = value; }


       public int? BloodTypeID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.BloodTypeID.ToString());  set => TargettedRow[TableColumnNames.BloodTypeID.ToString()] = value; }


       public string PictureFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PictureFileName.ToString());  set => TargettedRow[TableColumnNames.PictureFileName.ToString()] = value; }


       public int MaritalStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.MaritalStatusID.ToString());  set => TargettedRow[TableColumnNames.MaritalStatusID.ToString()] = value; }


       public string Username { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Username.ToString());  set => TargettedRow[TableColumnNames.Username.ToString()] = value; }


       public bool? IsActive { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


       public int? PersonnelID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.PersonnelID.ToString());  set => TargettedRow[TableColumnNames.PersonnelID.ToString()] = value; }


       public string BirthPlace { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BirthPlace.ToString());  set => TargettedRow[TableColumnNames.BirthPlace.ToString()] = value; }


       public string Title { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Title.ToString());  set => TargettedRow[TableColumnNames.Title.ToString()] = value; }


       public string MaritalStatus { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.MaritalStatus.ToString());  set => TargettedRow[TableColumnNames.MaritalStatus.ToString()] = value; }


       public string BloodType { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BloodType.ToString());  set => TargettedRow[TableColumnNames.BloodType.ToString()] = value; }


       public bool IsSuperUser { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsSuperUser.ToString());  set => TargettedRow[TableColumnNames.IsSuperUser.ToString()] = value; }


       public bool CanBeDeleted { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.CanBeDeleted.ToString());  set => TargettedRow[TableColumnNames.CanBeDeleted.ToString()] = value; }


       public bool CanBeUpdated { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.CanBeUpdated.ToString());  set => TargettedRow[TableColumnNames.CanBeUpdated.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___ExpandedPersons GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___ExpandedPersons GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new V___ExpandedPersons(conn.Fetch(ExpandedPersons__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static V___ExpandedPersons GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new V___ExpandedPersons( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public V___ExpandedPersons GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ExpandedPersons__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
