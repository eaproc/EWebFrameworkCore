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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___PersonnelBankDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PersonnelBankDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPersonnelID = new DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defSwiftCode = new DataColumnDefinition(TableColumnNames.SwiftCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIBAN = new DataColumnDefinition(TableColumnNames.IBAN.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defSwiftCode.ColumnName, defSwiftCode); 
          ColumnDefns.Add(defIBAN.ColumnName, defIBAN); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PersonnelBankDetail_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PersonnelBankDetail", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PersonnelBankDetail_PersonnelID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PersonnelBankDetail", "hr.Personnel"                  
                            ));                  

          }


                  
       public T___PersonnelBankDetail() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PersonnelBankDetail(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(DataTable FullTable) : base(FullTable)                                    
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
        public T___PersonnelBankDetail(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.PersonnelBankDetail";
       public const string PersonnelBankDetail__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [BankID], [PersonnelID], [AccountNumber], [SwiftCode], [IBAN], [CreatedAt], [UpdatedAt], [IsActive] FROM hr.PersonnelBankDetail";
       public const string PersonnelBankDetail__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [BankID], [PersonnelID], [AccountNumber], [SwiftCode], [IBAN], [CreatedAt], [UpdatedAt], [IsActive] FROM hr.PersonnelBankDetail";


       public enum TableColumnNames
       {

           ID,
           BankID,
           PersonnelID,
           AccountNumber,
           SwiftCode,
           IBAN,
           CreatedAt,
           UpdatedAt,
           IsActive
       } 



       public enum TableConstraints{

           pk_hr_PersonnelBankDetail, 
           fk_hr_PersonnelBankDetail_BankID, 
           fk_hr_PersonnelBankDetail_PersonnelID, 
           uq_hr_PersonnelBankDetail_AccountNumber, 
           uq_hr_PersonnelBankDetail_ActiveBankAccount, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defSwiftCode;
       public static readonly DataColumnDefinition defIBAN;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defIsActive;

       public int BankID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BankID.ToString());  set => TargettedRow[TableColumnNames.BankID.ToString()] = value; }


       public int PersonnelID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonnelID.ToString());  set => TargettedRow[TableColumnNames.PersonnelID.ToString()] = value; }


       public string AccountNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountNumber.ToString());  set => TargettedRow[TableColumnNames.AccountNumber.ToString()] = value; }


       public string SwiftCode { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SwiftCode.ToString());  set => TargettedRow[TableColumnNames.SwiftCode.ToString()] = value; }


       public string IBAN { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IBAN.ToString());  set => TargettedRow[TableColumnNames.IBAN.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public bool IsActive { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PersonnelBankDetail GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PersonnelBankDetail GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___PersonnelBankDetail(conn.Fetch(PersonnelBankDetail__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___PersonnelBankDetail GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___PersonnelBankDetail( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___PersonnelBankDetail GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PersonnelBankDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamBankID;
            private DataColumnParameter ParamPersonnelID;
            private DataColumnParameter ParamAccountNumber;
            private DataColumnParameter ParamSwiftCode;
            private DataColumnParameter ParamIBAN;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamIsActive;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PersonnelBankDetail v):this(v.ID)                  
            {                  

                ParamBankID = new(defBankID, v.BankID);                  
                ParamPersonnelID = new(defPersonnelID, v.PersonnelID);                  
                ParamAccountNumber = new(defAccountNumber, v.AccountNumber);                  
                ParamSwiftCode = new(defSwiftCode, v.SwiftCode);                  
                ParamIBAN = new(defIBAN, v.IBAN);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamIsActive = new(defIsActive, v.IsActive);                  
            }                  
                  
            public UpdateQueryBuilder SetBankID(int v)                  
            {                  
                ParamBankID = new(defBankID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPersonnelID(int v)                  
            {                  
                ParamPersonnelID = new(defPersonnelID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccountNumber(string v)                  
            {                  
                ParamAccountNumber = new(defAccountNumber, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSwiftCode(string v)                  
            {                  
                ParamSwiftCode = new(defSwiftCode, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIBAN(string v)                  
            {                  
                ParamIBAN = new(defIBAN, v);                  
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
                  
            public UpdateQueryBuilder SetIsActive(bool v)                  
            {                  
                ParamIsActive = new(defIsActive, v);                  
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
                  
            public int Execute(TransactionRunner runner)                  
            {                  
                return runner.Run((conn) => conn.ExecuteTransactionQuery(this.BuildSQL()));                  
            }                  
        }                  
                  
        #endregion                  
                  





        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID( TransactionRunner runner, 
            int BankID
,            int PersonnelID
,            string AccountNumber
,            DateTime CreatedAt
,            bool IsActive
,            string SwiftCode = null
,            string IBAN = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramSwiftCode = new (defSwiftCode, SwiftCode);
                DataColumnParameter paramIBAN = new (defIBAN, IBAN);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramBankID.GetSQLValue(),
                        paramPersonnelID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramSwiftCode.GetSQLValue(),
                        paramIBAN.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramIsActive.GetSQLValue()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(TransactionRunner runner,
            int ID
,            int BankID
,            int PersonnelID
,            string AccountNumber
,            DateTime CreatedAt
,            bool IsActive
,            string SwiftCode = null
,            string IBAN = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramSwiftCode = new (defSwiftCode, SwiftCode);
                DataColumnParameter paramIBAN = new (defIBAN, IBAN);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramPersonnelID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramSwiftCode.GetSQLValue(),
                        paramIBAN.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramIsActive.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int BankID
,            int PersonnelID
,            string AccountNumber
,            DateTime CreatedAt
,            bool IsActive
,            string SwiftCode = null
,            string IBAN = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramSwiftCode = new (defSwiftCode, SwiftCode);
                DataColumnParameter paramIBAN = new (defIBAN, IBAN);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramBankID.GetSQLValue(),
                        paramPersonnelID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramSwiftCode.GetSQLValue(),
                        paramIBAN.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramIsActive.GetSQLValue()                            
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
        public bool Update(TransactionRunner runner, bool reloadTable = false)                  
        {                  
            return runner.Run(                  
               (conn) => {                  
                   bool r = new UpdateQueryBuilder(this).Execute(new (conn, false)).ToBoolean();                  
                   if (reloadTable) this.LoadFromRows( GetRowWhereIDUsingSQL(this.ID, new (conn, false)).TargettedRow );                  
                   return r;                  
               }                  
               );                  
        }                  
                  



                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(TransactionRunner runner)                  
        {                  
            return DeleteItemRow(runner, ID);                  
        }                  
                  
        public static bool DeleteItemRow(TransactionRunner runner, long pID)                                                      
        {                  
            return runner.Run(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean()                  
               );                  
        }                  



   }


}
