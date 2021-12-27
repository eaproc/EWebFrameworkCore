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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___Client : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Client()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCompanyName = new DataColumnDefinition(TableColumnNames.CompanyName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOwnerID = new DataColumnDefinition(TableColumnNames.OwnerID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSLAFileName = new DataColumnDefinition(TableColumnNames.SLAFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defScadwareURL = new DataColumnDefinition(TableColumnNames.ScadwareURL.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobile = new DataColumnDefinition(TableColumnNames.Mobile.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebsiteURL = new DataColumnDefinition(TableColumnNames.WebsiteURL.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLogoFileName = new DataColumnDefinition(TableColumnNames.LogoFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNameAbbreviation = new DataColumnDefinition(TableColumnNames.NameAbbreviation.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defOwnerID.ColumnName, defOwnerID); 
          ColumnDefns.Add(defSLAFileName.ColumnName, defSLAFileName); 
          ColumnDefns.Add(defScadwareURL.ColumnName, defScadwareURL); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defMobile.ColumnName, defMobile); 
          ColumnDefns.Add(defWebsiteURL.ColumnName, defWebsiteURL); 
          ColumnDefns.Add(defLogoFileName.ColumnName, defLogoFileName); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defNameAbbreviation.ColumnName, defNameAbbreviation); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Client", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_OwnerID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Client", "common.Person"                  
                            ));                  

          }


                  
       public T___Client() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Client(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(DataTable FullTable) : base(FullTable)                                    
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
        public T___Client(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.Client";
       public const string Client__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CompanyName], [CreatedAt], [OwnerID], [SLAFileName], [ScadwareURL], [Email], [Mobile], [WebsiteURL], [LogoFileName], [UpdatedAt], [IsActive], [NameAbbreviation], [Address], [BankID], [AccountName], [AccountNumber] FROM hr.Client";
       public const string Client__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CompanyName], [CreatedAt], [OwnerID], [SLAFileName], [ScadwareURL], [Email], [Mobile], [WebsiteURL], [LogoFileName], [UpdatedAt], [IsActive], [NameAbbreviation], [Address], [BankID], [AccountName], [AccountNumber] FROM hr.Client";


       public enum TableColumnNames
       {

           ID,
           CompanyName,
           CreatedAt,
           OwnerID,
           SLAFileName,
           ScadwareURL,
           Email,
           Mobile,
           WebsiteURL,
           LogoFileName,
           UpdatedAt,
           IsActive,
           NameAbbreviation,
           Address,
           BankID,
           AccountName,
           AccountNumber
       } 



       public enum TableConstraints{

           pk_hr_Client, 
           fk_hr_Client_BankID, 
           fk_hr_Client_OwnerID, 
           uq_hr_Client_CompanyName, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCompanyName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defOwnerID;
       public static readonly DataColumnDefinition defSLAFileName;
       public static readonly DataColumnDefinition defScadwareURL;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defMobile;
       public static readonly DataColumnDefinition defWebsiteURL;
       public static readonly DataColumnDefinition defLogoFileName;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defNameAbbreviation;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defAccountNumber;

       public string CompanyName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.CompanyName.ToString());  set => TargettedRow[TableColumnNames.CompanyName.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int OwnerID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.OwnerID.ToString());  set => TargettedRow[TableColumnNames.OwnerID.ToString()] = value; }


       public string SLAFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SLAFileName.ToString());  set => TargettedRow[TableColumnNames.SLAFileName.ToString()] = value; }


       public string ScadwareURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ScadwareURL.ToString());  set => TargettedRow[TableColumnNames.ScadwareURL.ToString()] = value; }


       public string Email { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Email.ToString());  set => TargettedRow[TableColumnNames.Email.ToString()] = value; }


       public string Mobile { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Mobile.ToString());  set => TargettedRow[TableColumnNames.Mobile.ToString()] = value; }


       public string WebsiteURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.WebsiteURL.ToString());  set => TargettedRow[TableColumnNames.WebsiteURL.ToString()] = value; }


       public string LogoFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LogoFileName.ToString());  set => TargettedRow[TableColumnNames.LogoFileName.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public bool IsActive { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


       public string NameAbbreviation { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.NameAbbreviation.ToString());  set => TargettedRow[TableColumnNames.NameAbbreviation.ToString()] = value; }


       public string Address { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Address.ToString());  set => TargettedRow[TableColumnNames.Address.ToString()] = value; }


       public int? BankID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.BankID.ToString());  set => TargettedRow[TableColumnNames.BankID.ToString()] = value; }


       public string AccountName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountName.ToString());  set => TargettedRow[TableColumnNames.AccountName.ToString()] = value; }


       public string AccountNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountNumber.ToString());  set => TargettedRow[TableColumnNames.AccountNumber.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Client GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Client GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Client(conn.Fetch(Client__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Client GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Client( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Client GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Client__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCompanyName;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamOwnerID;
            private DataColumnParameter ParamSLAFileName;
            private DataColumnParameter ParamScadwareURL;
            private DataColumnParameter ParamEmail;
            private DataColumnParameter ParamMobile;
            private DataColumnParameter ParamWebsiteURL;
            private DataColumnParameter ParamLogoFileName;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamIsActive;
            private DataColumnParameter ParamNameAbbreviation;
            private DataColumnParameter ParamAddress;
            private DataColumnParameter ParamBankID;
            private DataColumnParameter ParamAccountName;
            private DataColumnParameter ParamAccountNumber;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Client v):this(v.ID)                  
            {                  

                ParamCompanyName = new(defCompanyName, v.CompanyName);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamOwnerID = new(defOwnerID, v.OwnerID);                  
                ParamSLAFileName = new(defSLAFileName, v.SLAFileName);                  
                ParamScadwareURL = new(defScadwareURL, v.ScadwareURL);                  
                ParamEmail = new(defEmail, v.Email);                  
                ParamMobile = new(defMobile, v.Mobile);                  
                ParamWebsiteURL = new(defWebsiteURL, v.WebsiteURL);                  
                ParamLogoFileName = new(defLogoFileName, v.LogoFileName);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamIsActive = new(defIsActive, v.IsActive);                  
                ParamNameAbbreviation = new(defNameAbbreviation, v.NameAbbreviation);                  
                ParamAddress = new(defAddress, v.Address);                  
                ParamBankID = new(defBankID, v.BankID);                  
                ParamAccountName = new(defAccountName, v.AccountName);                  
                ParamAccountNumber = new(defAccountNumber, v.AccountNumber);                  
            }                  
                  
            public UpdateQueryBuilder SetCompanyName(string v)                  
            {                  
                ParamCompanyName = new(defCompanyName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetOwnerID(int v)                  
            {                  
                ParamOwnerID = new(defOwnerID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSLAFileName(string v)                  
            {                  
                ParamSLAFileName = new(defSLAFileName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetScadwareURL(string v)                  
            {                  
                ParamScadwareURL = new(defScadwareURL, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEmail(string v)                  
            {                  
                ParamEmail = new(defEmail, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMobile(string v)                  
            {                  
                ParamMobile = new(defMobile, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetWebsiteURL(string v)                  
            {                  
                ParamWebsiteURL = new(defWebsiteURL, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLogoFileName(string v)                  
            {                  
                ParamLogoFileName = new(defLogoFileName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime? v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsActive(bool v)                  
            {                  
                ParamIsActive = new(defIsActive, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetNameAbbreviation(string v)                  
            {                  
                ParamNameAbbreviation = new(defNameAbbreviation, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAddress(string v)                  
            {                  
                ParamAddress = new(defAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBankID(int? v)                  
            {                  
                ParamBankID = new(defBankID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccountName(string v)                  
            {                  
                ParamAccountName = new(defAccountName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccountNumber(string v)                  
            {                  
                ParamAccountNumber = new(defAccountNumber, v);                  
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
            string CompanyName,
            DateTime CreatedAt,
            int OwnerID,
            bool IsActive,
            string NameAbbreviation,
            string SLAFileName = null,
            string ScadwareURL = null,
            string Email = null,
            string Mobile = null,
            string WebsiteURL = null,
            string LogoFileName = null,
            DateTime? UpdatedAt = null,
            string Address = null,
            int? BankID = null,
            string AccountName = null,
            string AccountNumber = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCompanyName = new (defCompanyName, CompanyName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramOwnerID = new (defOwnerID, OwnerID);
                DataColumnParameter paramSLAFileName = new (defSLAFileName, SLAFileName);
                DataColumnParameter paramScadwareURL = new (defScadwareURL, ScadwareURL);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramMobile = new (defMobile, Mobile);
                DataColumnParameter paramWebsiteURL = new (defWebsiteURL, WebsiteURL);
                DataColumnParameter paramLogoFileName = new (defLogoFileName, LogoFileName);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramNameAbbreviation = new (defNameAbbreviation, NameAbbreviation);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramCompanyName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramOwnerID.GetSQLValue(),
                        paramSLAFileName.GetSQLValue(),
                        paramScadwareURL.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramMobile.GetSQLValue(),
                        paramWebsiteURL.GetSQLValue(),
                        paramLogoFileName.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramNameAbbreviation.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue()                        )
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
            string CompanyName,
            DateTime CreatedAt,
            int OwnerID,
            bool IsActive,
            string NameAbbreviation,
            string SLAFileName = null,
            string ScadwareURL = null,
            string Email = null,
            string Mobile = null,
            string WebsiteURL = null,
            string LogoFileName = null,
            DateTime? UpdatedAt = null,
            string Address = null,
            int? BankID = null,
            string AccountName = null,
            string AccountNumber = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCompanyName = new (defCompanyName, CompanyName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramOwnerID = new (defOwnerID, OwnerID);
                DataColumnParameter paramSLAFileName = new (defSLAFileName, SLAFileName);
                DataColumnParameter paramScadwareURL = new (defScadwareURL, ScadwareURL);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramMobile = new (defMobile, Mobile);
                DataColumnParameter paramWebsiteURL = new (defWebsiteURL, WebsiteURL);
                DataColumnParameter paramLogoFileName = new (defLogoFileName, LogoFileName);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramNameAbbreviation = new (defNameAbbreviation, NameAbbreviation);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCompanyName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramOwnerID.GetSQLValue(),
                        paramSLAFileName.GetSQLValue(),
                        paramScadwareURL.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramMobile.GetSQLValue(),
                        paramWebsiteURL.GetSQLValue(),
                        paramLogoFileName.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramNameAbbreviation.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            string CompanyName,
            DateTime CreatedAt,
            int OwnerID,
            bool IsActive,
            string NameAbbreviation,
            string SLAFileName = null,
            string ScadwareURL = null,
            string Email = null,
            string Mobile = null,
            string WebsiteURL = null,
            string LogoFileName = null,
            DateTime? UpdatedAt = null,
            string Address = null,
            int? BankID = null,
            string AccountName = null,
            string AccountNumber = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCompanyName = new (defCompanyName, CompanyName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramOwnerID = new (defOwnerID, OwnerID);
                DataColumnParameter paramSLAFileName = new (defSLAFileName, SLAFileName);
                DataColumnParameter paramScadwareURL = new (defScadwareURL, ScadwareURL);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramMobile = new (defMobile, Mobile);
                DataColumnParameter paramWebsiteURL = new (defWebsiteURL, WebsiteURL);
                DataColumnParameter paramLogoFileName = new (defLogoFileName, LogoFileName);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramNameAbbreviation = new (defNameAbbreviation, NameAbbreviation);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramCompanyName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramOwnerID.GetSQLValue(),
                        paramSLAFileName.GetSQLValue(),
                        paramScadwareURL.GetSQLValue(),
                        paramEmail.GetSQLValue(),
                        paramMobile.GetSQLValue(),
                        paramWebsiteURL.GetSQLValue(),
                        paramLogoFileName.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramNameAbbreviation.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue()                            
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
