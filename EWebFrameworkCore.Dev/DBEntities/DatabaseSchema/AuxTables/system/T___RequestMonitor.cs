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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___RequestMonitor : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___RequestMonitor()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAbsoluteURL = new DataColumnDefinition(TableColumnNames.AbsoluteURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestParametersJSON = new DataColumnDefinition(TableColumnNames.RequestParametersJSON.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionVariables = new DataColumnDefinition(TableColumnNames.SessionVariables.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBrowser = new DataColumnDefinition(TableColumnNames.Browser.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestBody = new DataColumnDefinition(TableColumnNames.RequestBody.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestHeaders = new DataColumnDefinition(TableColumnNames.RequestHeaders.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAbsoluteURL.ColumnName, defAbsoluteURL); 
          ColumnDefns.Add(defRequestParametersJSON.ColumnName, defRequestParametersJSON); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defSessionVariables.ColumnName, defSessionVariables); 
          ColumnDefns.Add(defBrowser.ColumnName, defBrowser); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defRequestBody.ColumnName, defRequestBody); 
          ColumnDefns.Add(defRequestHeaders.ColumnName, defRequestHeaders); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_RequestMonitor_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.RequestMonitor", "auth.Users"                  
                            ));                  

          }


                  
       public T___RequestMonitor() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___RequestMonitor(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(DataTable FullTable) : base(FullTable)                                    
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
        public T___RequestMonitor(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.RequestMonitor";
       public const string RequestMonitor__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AbsoluteURL], [RequestParametersJSON], [IPAddress], [SessionVariables], [Browser], [UserID], [CreatedAt], [RequestBody], [RequestHeaders] FROM system.RequestMonitor";
       public const string RequestMonitor__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AbsoluteURL], [RequestParametersJSON], [IPAddress], [SessionVariables], [Browser], [UserID], [CreatedAt], [RequestBody], [RequestHeaders] FROM system.RequestMonitor";


       public enum TableColumnNames
       {

           ID,
           AbsoluteURL,
           RequestParametersJSON,
           IPAddress,
           SessionVariables,
           Browser,
           UserID,
           CreatedAt,
           RequestBody,
           RequestHeaders
       } 



       public enum TableConstraints{

           pk_system_RequestMonitor, 
           fk_system_RequestMonitor_UserID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAbsoluteURL;
       public static readonly DataColumnDefinition defRequestParametersJSON;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defSessionVariables;
       public static readonly DataColumnDefinition defBrowser;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defRequestBody;
       public static readonly DataColumnDefinition defRequestHeaders;

       public string AbsoluteURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AbsoluteURL.ToString());  set => TargettedRow[TableColumnNames.AbsoluteURL.ToString()] = value; }


       public string RequestParametersJSON { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.RequestParametersJSON.ToString());  set => TargettedRow[TableColumnNames.RequestParametersJSON.ToString()] = value; }


       public string IPAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IPAddress.ToString());  set => TargettedRow[TableColumnNames.IPAddress.ToString()] = value; }


       public string SessionVariables { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SessionVariables.ToString());  set => TargettedRow[TableColumnNames.SessionVariables.ToString()] = value; }


       public string Browser { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Browser.ToString());  set => TargettedRow[TableColumnNames.Browser.ToString()] = value; }


       public int? UserID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.UserID.ToString());  set => TargettedRow[TableColumnNames.UserID.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public string RequestBody { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.RequestBody.ToString());  set => TargettedRow[TableColumnNames.RequestBody.ToString()] = value; }


       public string RequestHeaders { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.RequestHeaders.ToString());  set => TargettedRow[TableColumnNames.RequestHeaders.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___RequestMonitor GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___RequestMonitor GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___RequestMonitor(conn.Fetch(RequestMonitor__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___RequestMonitor GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___RequestMonitor( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___RequestMonitor GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => RequestMonitor__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamAbsoluteURL;
            private DataColumnParameter ParamRequestParametersJSON;
            private DataColumnParameter ParamIPAddress;
            private DataColumnParameter ParamSessionVariables;
            private DataColumnParameter ParamBrowser;
            private DataColumnParameter ParamUserID;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamRequestBody;
            private DataColumnParameter ParamRequestHeaders;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___RequestMonitor v):this(v.ID)                  
            {                  

                ParamAbsoluteURL = new(defAbsoluteURL, v.AbsoluteURL);                  
                ParamRequestParametersJSON = new(defRequestParametersJSON, v.RequestParametersJSON);                  
                ParamIPAddress = new(defIPAddress, v.IPAddress);                  
                ParamSessionVariables = new(defSessionVariables, v.SessionVariables);                  
                ParamBrowser = new(defBrowser, v.Browser);                  
                ParamUserID = new(defUserID, v.UserID);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamRequestBody = new(defRequestBody, v.RequestBody);                  
                ParamRequestHeaders = new(defRequestHeaders, v.RequestHeaders);                  
            }                  
                  
            public UpdateQueryBuilder SetAbsoluteURL(string v)                  
            {                  
                ParamAbsoluteURL = new(defAbsoluteURL, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRequestParametersJSON(string v)                  
            {                  
                ParamRequestParametersJSON = new(defRequestParametersJSON, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIPAddress(string v)                  
            {                  
                ParamIPAddress = new(defIPAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSessionVariables(string v)                  
            {                  
                ParamSessionVariables = new(defSessionVariables, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBrowser(string v)                  
            {                  
                ParamBrowser = new(defBrowser, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUserID(int? v)                  
            {                  
                ParamUserID = new(defUserID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRequestBody(string v)                  
            {                  
                ParamRequestBody = new(defRequestBody, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRequestHeaders(string v)                  
            {                  
                ParamRequestHeaders = new(defRequestHeaders, v);                  
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
            string AbsoluteURL,
            string IPAddress,
            DateTime CreatedAt,
            string RequestParametersJSON = null,
            string SessionVariables = null,
            string Browser = null,
            int? UserID = null,
            string RequestBody = null,
            string RequestHeaders = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramAbsoluteURL = new (defAbsoluteURL, AbsoluteURL);
                DataColumnParameter paramRequestParametersJSON = new (defRequestParametersJSON, RequestParametersJSON);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSessionVariables = new (defSessionVariables, SessionVariables);
                DataColumnParameter paramBrowser = new (defBrowser, Browser);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramRequestBody = new (defRequestBody, RequestBody);
                DataColumnParameter paramRequestHeaders = new (defRequestHeaders, RequestHeaders);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramAbsoluteURL.GetSQLValue(),
                        paramRequestParametersJSON.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramSessionVariables.GetSQLValue(),
                        paramBrowser.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramRequestBody.GetSQLValue(),
                        paramRequestHeaders.GetSQLValue()                        )
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
            string AbsoluteURL,
            string IPAddress,
            DateTime CreatedAt,
            string RequestParametersJSON = null,
            string SessionVariables = null,
            string Browser = null,
            int? UserID = null,
            string RequestBody = null,
            string RequestHeaders = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramAbsoluteURL = new (defAbsoluteURL, AbsoluteURL);
                DataColumnParameter paramRequestParametersJSON = new (defRequestParametersJSON, RequestParametersJSON);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSessionVariables = new (defSessionVariables, SessionVariables);
                DataColumnParameter paramBrowser = new (defBrowser, Browser);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramRequestBody = new (defRequestBody, RequestBody);
                DataColumnParameter paramRequestHeaders = new (defRequestHeaders, RequestHeaders);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramAbsoluteURL.GetSQLValue(),
                        paramRequestParametersJSON.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramSessionVariables.GetSQLValue(),
                        paramBrowser.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramRequestBody.GetSQLValue(),
                        paramRequestHeaders.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            string AbsoluteURL,
            string IPAddress,
            DateTime CreatedAt,
            string RequestParametersJSON = null,
            string SessionVariables = null,
            string Browser = null,
            int? UserID = null,
            string RequestBody = null,
            string RequestHeaders = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramAbsoluteURL = new (defAbsoluteURL, AbsoluteURL);
                DataColumnParameter paramRequestParametersJSON = new (defRequestParametersJSON, RequestParametersJSON);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSessionVariables = new (defSessionVariables, SessionVariables);
                DataColumnParameter paramBrowser = new (defBrowser, Browser);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramRequestBody = new (defRequestBody, RequestBody);
                DataColumnParameter paramRequestHeaders = new (defRequestHeaders, RequestHeaders);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramAbsoluteURL.GetSQLValue(),
                        paramRequestParametersJSON.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramSessionVariables.GetSQLValue(),
                        paramBrowser.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramRequestBody.GetSQLValue(),
                        paramRequestHeaders.GetSQLValue()                            
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
