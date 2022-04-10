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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___PaystackLog : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaystackLog()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentGatewayStatusID = new DataColumnDefinition(TableColumnNames.PaymentGatewayStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsFinalized = new DataColumnDefinition(TableColumnNames.IsFinalized.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInitializedByUserID = new DataColumnDefinition(TableColumnNames.InitializedByUserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defReference = new DataColumnDefinition(TableColumnNames.Reference.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccessCode = new DataColumnDefinition(TableColumnNames.AccessCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInitialLizeURL = new DataColumnDefinition(TableColumnNames.InitialLizeURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentURL = new DataColumnDefinition(TableColumnNames.PaymentURL.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiyURL = new DataColumnDefinition(TableColumnNames.VerifiyURL.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmountKobo = new DataColumnDefinition(TableColumnNames.AmountKobo.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifyResponseJSON = new DataColumnDefinition(TableColumnNames.VerifyResponseJSON.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiedByUserID = new DataColumnDefinition(TableColumnNames.VerifiedByUserID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPaymentGatewayStatusID.ColumnName, defPaymentGatewayStatusID); 
          ColumnDefns.Add(defIsFinalized.ColumnName, defIsFinalized); 
          ColumnDefns.Add(defInitializedByUserID.ColumnName, defInitializedByUserID); 
          ColumnDefns.Add(defReference.ColumnName, defReference); 
          ColumnDefns.Add(defAccessCode.ColumnName, defAccessCode); 
          ColumnDefns.Add(defInitialLizeURL.ColumnName, defInitialLizeURL); 
          ColumnDefns.Add(defPaymentURL.ColumnName, defPaymentURL); 
          ColumnDefns.Add(defVerifiyURL.ColumnName, defVerifiyURL); 
          ColumnDefns.Add(defAmountKobo.ColumnName, defAmountKobo); 
          ColumnDefns.Add(defVerifyResponseJSON.ColumnName, defVerifyResponseJSON); 
          ColumnDefns.Add(defVerifiedByUserID.ColumnName, defVerifiedByUserID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_PaymentGatewayStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "system.PaymentGatewayStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_InitializedByUserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_VerifiedByUserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "auth.Users"                  
                            ));                  

          }


                  
       public T___PaystackLog() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaystackLog(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(DataTable FullTable) : base(FullTable)                                    
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
        public T___PaystackLog(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.PaystackLog";
       public const string PaystackLog__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PaymentGatewayStatusID], [IsFinalized], [InitializedByUserID], [Reference], [AccessCode], [InitialLizeURL], [PaymentURL], [VerifiyURL], [AmountKobo], [VerifyResponseJSON], [VerifiedByUserID], [CreatedAt], [UpdatedAt] FROM system.PaystackLog";
       public const string PaystackLog__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PaymentGatewayStatusID], [IsFinalized], [InitializedByUserID], [Reference], [AccessCode], [InitialLizeURL], [PaymentURL], [VerifiyURL], [AmountKobo], [VerifyResponseJSON], [VerifiedByUserID], [CreatedAt], [UpdatedAt] FROM system.PaystackLog";


       public enum TableColumnNames
       {

           ID,
           PaymentGatewayStatusID,
           IsFinalized,
           InitializedByUserID,
           Reference,
           AccessCode,
           InitialLizeURL,
           PaymentURL,
           VerifiyURL,
           AmountKobo,
           VerifyResponseJSON,
           VerifiedByUserID,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_system_PaystackLog, 
           fk_system_PaystackLog_PaymentGatewayStatusID, 
           fk_system_PaystackLog_InitializedByUserID, 
           fk_system_PaystackLog_VerifiedByUserID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPaymentGatewayStatusID;
       public static readonly DataColumnDefinition defIsFinalized;
       public static readonly DataColumnDefinition defInitializedByUserID;
       public static readonly DataColumnDefinition defReference;
       public static readonly DataColumnDefinition defAccessCode;
       public static readonly DataColumnDefinition defInitialLizeURL;
       public static readonly DataColumnDefinition defPaymentURL;
       public static readonly DataColumnDefinition defVerifiyURL;
       public static readonly DataColumnDefinition defAmountKobo;
       public static readonly DataColumnDefinition defVerifyResponseJSON;
       public static readonly DataColumnDefinition defVerifiedByUserID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int PaymentGatewayStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PaymentGatewayStatusID.ToString());  set => TargettedRow[TableColumnNames.PaymentGatewayStatusID.ToString()] = value; }


       public bool IsFinalized { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsFinalized.ToString());  set => TargettedRow[TableColumnNames.IsFinalized.ToString()] = value; }


       public int InitializedByUserID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.InitializedByUserID.ToString());  set => TargettedRow[TableColumnNames.InitializedByUserID.ToString()] = value; }


       public string Reference { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Reference.ToString());  set => TargettedRow[TableColumnNames.Reference.ToString()] = value; }


       public string AccessCode { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccessCode.ToString());  set => TargettedRow[TableColumnNames.AccessCode.ToString()] = value; }


       public string InitialLizeURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.InitialLizeURL.ToString());  set => TargettedRow[TableColumnNames.InitialLizeURL.ToString()] = value; }


       public string PaymentURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PaymentURL.ToString());  set => TargettedRow[TableColumnNames.PaymentURL.ToString()] = value; }


       public string VerifiyURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.VerifiyURL.ToString());  set => TargettedRow[TableColumnNames.VerifiyURL.ToString()] = value; }


       public int AmountKobo { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AmountKobo.ToString());  set => TargettedRow[TableColumnNames.AmountKobo.ToString()] = value; }


       public string VerifyResponseJSON { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.VerifyResponseJSON.ToString());  set => TargettedRow[TableColumnNames.VerifyResponseJSON.ToString()] = value; }


       public int? VerifiedByUserID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.VerifiedByUserID.ToString());  set => TargettedRow[TableColumnNames.VerifiedByUserID.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PaystackLog GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PaystackLog GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___PaystackLog(conn.Fetch(PaystackLog__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___PaystackLog GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___PaystackLog( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___PaystackLog GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PaystackLog__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamPaymentGatewayStatusID;
            private DataColumnParameter ParamIsFinalized;
            private DataColumnParameter ParamInitializedByUserID;
            private DataColumnParameter ParamReference;
            private DataColumnParameter ParamAccessCode;
            private DataColumnParameter ParamInitialLizeURL;
            private DataColumnParameter ParamPaymentURL;
            private DataColumnParameter ParamVerifiyURL;
            private DataColumnParameter ParamAmountKobo;
            private DataColumnParameter ParamVerifyResponseJSON;
            private DataColumnParameter ParamVerifiedByUserID;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PaystackLog v):this(v.ID)                  
            {                  

                ParamPaymentGatewayStatusID = new(defPaymentGatewayStatusID, v.PaymentGatewayStatusID);                  
                ParamIsFinalized = new(defIsFinalized, v.IsFinalized);                  
                ParamInitializedByUserID = new(defInitializedByUserID, v.InitializedByUserID);                  
                ParamReference = new(defReference, v.Reference);                  
                ParamAccessCode = new(defAccessCode, v.AccessCode);                  
                ParamInitialLizeURL = new(defInitialLizeURL, v.InitialLizeURL);                  
                ParamPaymentURL = new(defPaymentURL, v.PaymentURL);                  
                ParamVerifiyURL = new(defVerifiyURL, v.VerifiyURL);                  
                ParamAmountKobo = new(defAmountKobo, v.AmountKobo);                  
                ParamVerifyResponseJSON = new(defVerifyResponseJSON, v.VerifyResponseJSON);                  
                ParamVerifiedByUserID = new(defVerifiedByUserID, v.VerifiedByUserID);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentGatewayStatusID(int v)                  
            {                  
                ParamPaymentGatewayStatusID = new(defPaymentGatewayStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsFinalized(bool v)                  
            {                  
                ParamIsFinalized = new(defIsFinalized, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetInitializedByUserID(int v)                  
            {                  
                ParamInitializedByUserID = new(defInitializedByUserID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetReference(string v)                  
            {                  
                ParamReference = new(defReference, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccessCode(string v)                  
            {                  
                ParamAccessCode = new(defAccessCode, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetInitialLizeURL(string v)                  
            {                  
                ParamInitialLizeURL = new(defInitialLizeURL, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentURL(string v)                  
            {                  
                ParamPaymentURL = new(defPaymentURL, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetVerifiyURL(string v)                  
            {                  
                ParamVerifiyURL = new(defVerifiyURL, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAmountKobo(int v)                  
            {                  
                ParamAmountKobo = new(defAmountKobo, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetVerifyResponseJSON(string v)                  
            {                  
                ParamVerifyResponseJSON = new(defVerifyResponseJSON, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetVerifiedByUserID(int? v)                  
            {                  
                ParamVerifiedByUserID = new(defVerifiedByUserID, v);                  
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
            int PaymentGatewayStatusID
,            bool IsFinalized
,            int InitializedByUserID
,            string InitialLizeURL
,            int AmountKobo
,            DateTime CreatedAt
,            string Reference = null
,            string AccessCode = null
,            string PaymentURL = null
,            string VerifiyURL = null
,            string VerifyResponseJSON = null
,            int? VerifiedByUserID = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramPaymentGatewayStatusID = new (defPaymentGatewayStatusID, PaymentGatewayStatusID);
                DataColumnParameter paramIsFinalized = new (defIsFinalized, IsFinalized);
                DataColumnParameter paramInitializedByUserID = new (defInitializedByUserID, InitializedByUserID);
                DataColumnParameter paramReference = new (defReference, Reference);
                DataColumnParameter paramAccessCode = new (defAccessCode, AccessCode);
                DataColumnParameter paramInitialLizeURL = new (defInitialLizeURL, InitialLizeURL);
                DataColumnParameter paramPaymentURL = new (defPaymentURL, PaymentURL);
                DataColumnParameter paramVerifiyURL = new (defVerifiyURL, VerifiyURL);
                DataColumnParameter paramAmountKobo = new (defAmountKobo, AmountKobo);
                DataColumnParameter paramVerifyResponseJSON = new (defVerifyResponseJSON, VerifyResponseJSON);
                DataColumnParameter paramVerifiedByUserID = new (defVerifiedByUserID, VerifiedByUserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramPaymentGatewayStatusID.GetSQLValue(),
                        paramIsFinalized.GetSQLValue(),
                        paramInitializedByUserID.GetSQLValue(),
                        paramReference.GetSQLValue(),
                        paramAccessCode.GetSQLValue(),
                        paramInitialLizeURL.GetSQLValue(),
                        paramPaymentURL.GetSQLValue(),
                        paramVerifiyURL.GetSQLValue(),
                        paramAmountKobo.GetSQLValue(),
                        paramVerifyResponseJSON.GetSQLValue(),
                        paramVerifiedByUserID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue()                        )
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
,            int PaymentGatewayStatusID
,            bool IsFinalized
,            int InitializedByUserID
,            string InitialLizeURL
,            int AmountKobo
,            DateTime CreatedAt
,            string Reference = null
,            string AccessCode = null
,            string PaymentURL = null
,            string VerifiyURL = null
,            string VerifyResponseJSON = null
,            int? VerifiedByUserID = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPaymentGatewayStatusID = new (defPaymentGatewayStatusID, PaymentGatewayStatusID);
                DataColumnParameter paramIsFinalized = new (defIsFinalized, IsFinalized);
                DataColumnParameter paramInitializedByUserID = new (defInitializedByUserID, InitializedByUserID);
                DataColumnParameter paramReference = new (defReference, Reference);
                DataColumnParameter paramAccessCode = new (defAccessCode, AccessCode);
                DataColumnParameter paramInitialLizeURL = new (defInitialLizeURL, InitialLizeURL);
                DataColumnParameter paramPaymentURL = new (defPaymentURL, PaymentURL);
                DataColumnParameter paramVerifiyURL = new (defVerifiyURL, VerifiyURL);
                DataColumnParameter paramAmountKobo = new (defAmountKobo, AmountKobo);
                DataColumnParameter paramVerifyResponseJSON = new (defVerifyResponseJSON, VerifyResponseJSON);
                DataColumnParameter paramVerifiedByUserID = new (defVerifiedByUserID, VerifiedByUserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramPaymentGatewayStatusID.GetSQLValue(),
                        paramIsFinalized.GetSQLValue(),
                        paramInitializedByUserID.GetSQLValue(),
                        paramReference.GetSQLValue(),
                        paramAccessCode.GetSQLValue(),
                        paramInitialLizeURL.GetSQLValue(),
                        paramPaymentURL.GetSQLValue(),
                        paramVerifiyURL.GetSQLValue(),
                        paramAmountKobo.GetSQLValue(),
                        paramVerifyResponseJSON.GetSQLValue(),
                        paramVerifiedByUserID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int PaymentGatewayStatusID
,            bool IsFinalized
,            int InitializedByUserID
,            string InitialLizeURL
,            int AmountKobo
,            DateTime CreatedAt
,            string Reference = null
,            string AccessCode = null
,            string PaymentURL = null
,            string VerifiyURL = null
,            string VerifyResponseJSON = null
,            int? VerifiedByUserID = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramPaymentGatewayStatusID = new (defPaymentGatewayStatusID, PaymentGatewayStatusID);
                DataColumnParameter paramIsFinalized = new (defIsFinalized, IsFinalized);
                DataColumnParameter paramInitializedByUserID = new (defInitializedByUserID, InitializedByUserID);
                DataColumnParameter paramReference = new (defReference, Reference);
                DataColumnParameter paramAccessCode = new (defAccessCode, AccessCode);
                DataColumnParameter paramInitialLizeURL = new (defInitialLizeURL, InitialLizeURL);
                DataColumnParameter paramPaymentURL = new (defPaymentURL, PaymentURL);
                DataColumnParameter paramVerifiyURL = new (defVerifiyURL, VerifiyURL);
                DataColumnParameter paramAmountKobo = new (defAmountKobo, AmountKobo);
                DataColumnParameter paramVerifyResponseJSON = new (defVerifyResponseJSON, VerifyResponseJSON);
                DataColumnParameter paramVerifiedByUserID = new (defVerifiedByUserID, VerifiedByUserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramPaymentGatewayStatusID.GetSQLValue(),
                        paramIsFinalized.GetSQLValue(),
                        paramInitializedByUserID.GetSQLValue(),
                        paramReference.GetSQLValue(),
                        paramAccessCode.GetSQLValue(),
                        paramInitialLizeURL.GetSQLValue(),
                        paramPaymentURL.GetSQLValue(),
                        paramVerifiyURL.GetSQLValue(),
                        paramAmountKobo.GetSQLValue(),
                        paramVerifyResponseJSON.GetSQLValue(),
                        paramVerifiedByUserID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue()                            
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
