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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___OnlinePaymentAuthorization : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___OnlinePaymentAuthorization()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defOnlinePaymentID = new DataColumnDefinition(TableColumnNames.OnlinePaymentID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defAuthorizationCode = new DataColumnDefinition(TableColumnNames.AuthorizationCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCardType = new DataColumnDefinition(TableColumnNames.CardType.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBIN = new DataColumnDefinition(TableColumnNames.BIN.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLast4Digits = new DataColumnDefinition(TableColumnNames.Last4Digits.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpirationMonth = new DataColumnDefinition(TableColumnNames.ExpirationMonth.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpirationYear = new DataColumnDefinition(TableColumnNames.ExpirationYear.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(TableColumnNames.Bank.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryCode = new DataColumnDefinition(TableColumnNames.CountryCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defOnlinePaymentID.ColumnName, defOnlinePaymentID); 
          ColumnDefns.Add(defAuthorizationCode.ColumnName, defAuthorizationCode); 
          ColumnDefns.Add(defCardType.ColumnName, defCardType); 
          ColumnDefns.Add(defBIN.ColumnName, defBIN); 
          ColumnDefns.Add(defLast4Digits.ColumnName, defLast4Digits); 
          ColumnDefns.Add(defExpirationMonth.ColumnName, defExpirationMonth); 
          ColumnDefns.Add(defExpirationYear.ColumnName, defExpirationYear); 
          ColumnDefns.Add(defBank.ColumnName, defBank); 
          ColumnDefns.Add(defCountryCode.ColumnName, defCountryCode); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_OnlinePaymentAuthorization_OnlinePaymentID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.OnlinePaymentAuthorization", "accounting.OnlinePayment"                  
                            ));                  

          }


                  
       public T___OnlinePaymentAuthorization() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___OnlinePaymentAuthorization(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(DataTable FullTable) : base(FullTable)                                    
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
        public T___OnlinePaymentAuthorization(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.OnlinePaymentAuthorization";
       public const string OnlinePaymentAuthorization__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [OnlinePaymentID], [AuthorizationCode], [CardType], [BIN], [Last4Digits], [ExpirationMonth], [ExpirationYear], [Bank], [CountryCode], [CreatedAt] FROM accounting.OnlinePaymentAuthorization";
       public const string OnlinePaymentAuthorization__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [OnlinePaymentID], [AuthorizationCode], [CardType], [BIN], [Last4Digits], [ExpirationMonth], [ExpirationYear], [Bank], [CountryCode], [CreatedAt] FROM accounting.OnlinePaymentAuthorization";


       public enum TableColumnNames
       {

           ID,
           OnlinePaymentID,
           AuthorizationCode,
           CardType,
           BIN,
           Last4Digits,
           ExpirationMonth,
           ExpirationYear,
           Bank,
           CountryCode,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_accounting_OnlinePaymentAuthorization, 
           fk_accounting_OnlinePaymentAuthorization_OnlinePaymentID, 
           uq_accounting_OnlinePaymentAuthorization_OnlinePaymentID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defOnlinePaymentID;
       public static readonly DataColumnDefinition defAuthorizationCode;
       public static readonly DataColumnDefinition defCardType;
       public static readonly DataColumnDefinition defBIN;
       public static readonly DataColumnDefinition defLast4Digits;
       public static readonly DataColumnDefinition defExpirationMonth;
       public static readonly DataColumnDefinition defExpirationYear;
       public static readonly DataColumnDefinition defBank;
       public static readonly DataColumnDefinition defCountryCode;
       public static readonly DataColumnDefinition defCreatedAt;

       public int OnlinePaymentID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.OnlinePaymentID.ToString());  set => TargettedRow[TableColumnNames.OnlinePaymentID.ToString()] = value; }


       public string AuthorizationCode { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AuthorizationCode.ToString());  set => TargettedRow[TableColumnNames.AuthorizationCode.ToString()] = value; }


       public string CardType { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.CardType.ToString());  set => TargettedRow[TableColumnNames.CardType.ToString()] = value; }


       public string BIN { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BIN.ToString());  set => TargettedRow[TableColumnNames.BIN.ToString()] = value; }


       public string Last4Digits { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Last4Digits.ToString());  set => TargettedRow[TableColumnNames.Last4Digits.ToString()] = value; }


       public int? ExpirationMonth { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.ExpirationMonth.ToString());  set => TargettedRow[TableColumnNames.ExpirationMonth.ToString()] = value; }


       public int? ExpirationYear { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.ExpirationYear.ToString());  set => TargettedRow[TableColumnNames.ExpirationYear.ToString()] = value; }


       public string Bank { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Bank.ToString());  set => TargettedRow[TableColumnNames.Bank.ToString()] = value; }


       public string CountryCode { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.CountryCode.ToString());  set => TargettedRow[TableColumnNames.CountryCode.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___OnlinePaymentAuthorization GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___OnlinePaymentAuthorization GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___OnlinePaymentAuthorization(conn.Fetch(OnlinePaymentAuthorization__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___OnlinePaymentAuthorization GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___OnlinePaymentAuthorization( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___OnlinePaymentAuthorization GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => OnlinePaymentAuthorization__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamOnlinePaymentID;
            private DataColumnParameter ParamAuthorizationCode;
            private DataColumnParameter ParamCardType;
            private DataColumnParameter ParamBIN;
            private DataColumnParameter ParamLast4Digits;
            private DataColumnParameter ParamExpirationMonth;
            private DataColumnParameter ParamExpirationYear;
            private DataColumnParameter ParamBank;
            private DataColumnParameter ParamCountryCode;
            private DataColumnParameter ParamCreatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___OnlinePaymentAuthorization v):this(v.ID)                  
            {                  

                ParamOnlinePaymentID = new(defOnlinePaymentID, v.OnlinePaymentID);                  
                ParamAuthorizationCode = new(defAuthorizationCode, v.AuthorizationCode);                  
                ParamCardType = new(defCardType, v.CardType);                  
                ParamBIN = new(defBIN, v.BIN);                  
                ParamLast4Digits = new(defLast4Digits, v.Last4Digits);                  
                ParamExpirationMonth = new(defExpirationMonth, v.ExpirationMonth);                  
                ParamExpirationYear = new(defExpirationYear, v.ExpirationYear);                  
                ParamBank = new(defBank, v.Bank);                  
                ParamCountryCode = new(defCountryCode, v.CountryCode);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetOnlinePaymentID(int v)                  
            {                  
                ParamOnlinePaymentID = new(defOnlinePaymentID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAuthorizationCode(string v)                  
            {                  
                ParamAuthorizationCode = new(defAuthorizationCode, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCardType(string v)                  
            {                  
                ParamCardType = new(defCardType, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBIN(string v)                  
            {                  
                ParamBIN = new(defBIN, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLast4Digits(string v)                  
            {                  
                ParamLast4Digits = new(defLast4Digits, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetExpirationMonth(int? v)                  
            {                  
                ParamExpirationMonth = new(defExpirationMonth, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetExpirationYear(int? v)                  
            {                  
                ParamExpirationYear = new(defExpirationYear, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBank(string v)                  
            {                  
                ParamBank = new(defBank, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCountryCode(string v)                  
            {                  
                ParamCountryCode = new(defCountryCode, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
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
            int OnlinePaymentID
,            DateTime CreatedAt
,            string AuthorizationCode = null
,            string CardType = null
,            string BIN = null
,            string Last4Digits = null
,            int? ExpirationMonth = null
,            int? ExpirationYear = null
,            string Bank = null
,            string CountryCode = null
          ){

                DataColumnParameter paramOnlinePaymentID = new (defOnlinePaymentID, OnlinePaymentID);
                DataColumnParameter paramAuthorizationCode = new (defAuthorizationCode, AuthorizationCode);
                DataColumnParameter paramCardType = new (defCardType, CardType);
                DataColumnParameter paramBIN = new (defBIN, BIN);
                DataColumnParameter paramLast4Digits = new (defLast4Digits, Last4Digits);
                DataColumnParameter paramExpirationMonth = new (defExpirationMonth, ExpirationMonth);
                DataColumnParameter paramExpirationYear = new (defExpirationYear, ExpirationYear);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramCountryCode = new (defCountryCode, CountryCode);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramOnlinePaymentID.GetSQLValue(),
                        paramAuthorizationCode.GetSQLValue(),
                        paramCardType.GetSQLValue(),
                        paramBIN.GetSQLValue(),
                        paramLast4Digits.GetSQLValue(),
                        paramExpirationMonth.GetSQLValue(),
                        paramExpirationYear.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramCountryCode.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                        )
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
,            int OnlinePaymentID
,            DateTime CreatedAt
,            string AuthorizationCode = null
,            string CardType = null
,            string BIN = null
,            string Last4Digits = null
,            int? ExpirationMonth = null
,            int? ExpirationYear = null
,            string Bank = null
,            string CountryCode = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramOnlinePaymentID = new (defOnlinePaymentID, OnlinePaymentID);
                DataColumnParameter paramAuthorizationCode = new (defAuthorizationCode, AuthorizationCode);
                DataColumnParameter paramCardType = new (defCardType, CardType);
                DataColumnParameter paramBIN = new (defBIN, BIN);
                DataColumnParameter paramLast4Digits = new (defLast4Digits, Last4Digits);
                DataColumnParameter paramExpirationMonth = new (defExpirationMonth, ExpirationMonth);
                DataColumnParameter paramExpirationYear = new (defExpirationYear, ExpirationYear);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramCountryCode = new (defCountryCode, CountryCode);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramOnlinePaymentID.GetSQLValue(),
                        paramAuthorizationCode.GetSQLValue(),
                        paramCardType.GetSQLValue(),
                        paramBIN.GetSQLValue(),
                        paramLast4Digits.GetSQLValue(),
                        paramExpirationMonth.GetSQLValue(),
                        paramExpirationYear.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramCountryCode.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int OnlinePaymentID
,            DateTime CreatedAt
,            string AuthorizationCode = null
,            string CardType = null
,            string BIN = null
,            string Last4Digits = null
,            int? ExpirationMonth = null
,            int? ExpirationYear = null
,            string Bank = null
,            string CountryCode = null
          ){

                DataColumnParameter paramOnlinePaymentID = new (defOnlinePaymentID, OnlinePaymentID);
                DataColumnParameter paramAuthorizationCode = new (defAuthorizationCode, AuthorizationCode);
                DataColumnParameter paramCardType = new (defCardType, CardType);
                DataColumnParameter paramBIN = new (defBIN, BIN);
                DataColumnParameter paramLast4Digits = new (defLast4Digits, Last4Digits);
                DataColumnParameter paramExpirationMonth = new (defExpirationMonth, ExpirationMonth);
                DataColumnParameter paramExpirationYear = new (defExpirationYear, ExpirationYear);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramCountryCode = new (defCountryCode, CountryCode);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramOnlinePaymentID.GetSQLValue(),
                        paramAuthorizationCode.GetSQLValue(),
                        paramCardType.GetSQLValue(),
                        paramBIN.GetSQLValue(),
                        paramLast4Digits.GetSQLValue(),
                        paramExpirationMonth.GetSQLValue(),
                        paramExpirationYear.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramCountryCode.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                            
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
