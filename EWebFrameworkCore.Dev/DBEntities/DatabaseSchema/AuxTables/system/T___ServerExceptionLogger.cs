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

    public class T___ServerExceptionLogger : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ServerExceptionLogger()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTraceID = new DataColumnDefinition(TableColumnNames.TraceID.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defRequestParametersJSON = new DataColumnDefinition(TableColumnNames.RequestParametersJSON.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(TableColumnNames.ExceptionMessage.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStackTrace = new DataColumnDefinition(TableColumnNames.StackTrace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsResolved = new DataColumnDefinition(TableColumnNames.IsResolved.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAbsoluteURL = new DataColumnDefinition(TableColumnNames.AbsoluteURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTraceID.ColumnName, defTraceID); 
          ColumnDefns.Add(defRequestParametersJSON.ColumnName, defRequestParametersJSON); 
          ColumnDefns.Add(defExceptionMessage.ColumnName, defExceptionMessage); 
          ColumnDefns.Add(defStackTrace.ColumnName, defStackTrace); 
          ColumnDefns.Add(defIsResolved.ColumnName, defIsResolved); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defAbsoluteURL.ColumnName, defAbsoluteURL); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_ServerExceptionLogger_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.ServerExceptionLogger", "auth.Users"                  
                            ));                  

          }


                  
       public T___ServerExceptionLogger() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ServerExceptionLogger(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(DataTable FullTable) : base(FullTable)                                    
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
        public T___ServerExceptionLogger(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.ServerExceptionLogger";
       public const string ServerExceptionLogger__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TraceID], [RequestParametersJSON], [ExceptionMessage], [StackTrace], [IsResolved], [Comments], [CreatedAt], [UpdatedAt], [AbsoluteURL], [IPAddress], [UserID] FROM system.ServerExceptionLogger";
       public const string ServerExceptionLogger__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TraceID], [RequestParametersJSON], [ExceptionMessage], [StackTrace], [IsResolved], [Comments], [CreatedAt], [UpdatedAt], [AbsoluteURL], [IPAddress], [UserID] FROM system.ServerExceptionLogger";


       public enum TableColumnNames
       {

           ID,
           TraceID,
           RequestParametersJSON,
           ExceptionMessage,
           StackTrace,
           IsResolved,
           Comments,
           CreatedAt,
           UpdatedAt,
           AbsoluteURL,
           IPAddress,
           UserID
       } 



       public enum TableConstraints{

           pk_system_ServerExceptionLogger, 
           fk_system_ServerExceptionLogger_UserID, 
           uq_system_ServerExceptionLogger_TraceID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTraceID;
       public static readonly DataColumnDefinition defRequestParametersJSON;
       public static readonly DataColumnDefinition defExceptionMessage;
       public static readonly DataColumnDefinition defStackTrace;
       public static readonly DataColumnDefinition defIsResolved;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defAbsoluteURL;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defUserID;

       public string TraceID { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.TraceID.ToString());  set => TargettedRow[TableColumnNames.TraceID.ToString()] = value; }


       public string RequestParametersJSON { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.RequestParametersJSON.ToString());  set => TargettedRow[TableColumnNames.RequestParametersJSON.ToString()] = value; }


       public string ExceptionMessage { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ExceptionMessage.ToString());  set => TargettedRow[TableColumnNames.ExceptionMessage.ToString()] = value; }


       public string StackTrace { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.StackTrace.ToString());  set => TargettedRow[TableColumnNames.StackTrace.ToString()] = value; }


       public bool IsResolved { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsResolved.ToString());  set => TargettedRow[TableColumnNames.IsResolved.ToString()] = value; }


       public string Comments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Comments.ToString());  set => TargettedRow[TableColumnNames.Comments.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public string AbsoluteURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AbsoluteURL.ToString());  set => TargettedRow[TableColumnNames.AbsoluteURL.ToString()] = value; }


       public string IPAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IPAddress.ToString());  set => TargettedRow[TableColumnNames.IPAddress.ToString()] = value; }


       public int? UserID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.UserID.ToString());  set => TargettedRow[TableColumnNames.UserID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___ServerExceptionLogger GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___ServerExceptionLogger GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___ServerExceptionLogger(conn.Fetch(ServerExceptionLogger__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___ServerExceptionLogger GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___ServerExceptionLogger( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___ServerExceptionLogger GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ServerExceptionLogger__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTraceID;
            private DataColumnParameter ParamRequestParametersJSON;
            private DataColumnParameter ParamExceptionMessage;
            private DataColumnParameter ParamStackTrace;
            private DataColumnParameter ParamIsResolved;
            private DataColumnParameter ParamComments;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamAbsoluteURL;
            private DataColumnParameter ParamIPAddress;
            private DataColumnParameter ParamUserID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___ServerExceptionLogger v):this(v.ID)                  
            {                  

                ParamTraceID = new(defTraceID, v.TraceID);                  
                ParamRequestParametersJSON = new(defRequestParametersJSON, v.RequestParametersJSON);                  
                ParamExceptionMessage = new(defExceptionMessage, v.ExceptionMessage);                  
                ParamStackTrace = new(defStackTrace, v.StackTrace);                  
                ParamIsResolved = new(defIsResolved, v.IsResolved);                  
                ParamComments = new(defComments, v.Comments);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamAbsoluteURL = new(defAbsoluteURL, v.AbsoluteURL);                  
                ParamIPAddress = new(defIPAddress, v.IPAddress);                  
                ParamUserID = new(defUserID, v.UserID);                  
            }                  
                  
            public UpdateQueryBuilder SetTraceID(string v)                  
            {                  
                ParamTraceID = new(defTraceID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRequestParametersJSON(string v)                  
            {                  
                ParamRequestParametersJSON = new(defRequestParametersJSON, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetExceptionMessage(string v)                  
            {                  
                ParamExceptionMessage = new(defExceptionMessage, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetStackTrace(string v)                  
            {                  
                ParamStackTrace = new(defStackTrace, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsResolved(bool v)                  
            {                  
                ParamIsResolved = new(defIsResolved, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetComments(string v)                  
            {                  
                ParamComments = new(defComments, v);                  
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
                  
            public UpdateQueryBuilder SetAbsoluteURL(string v)                  
            {                  
                ParamAbsoluteURL = new(defAbsoluteURL, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIPAddress(string v)                  
            {                  
                ParamIPAddress = new(defIPAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUserID(int? v)                  
            {                  
                ParamUserID = new(defUserID, v);                  
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
            string TraceID
,            string ExceptionMessage
,            bool IsResolved
,            DateTime CreatedAt
,            string AbsoluteURL
,            string IPAddress
,            string RequestParametersJSON = null
,            string StackTrace = null
,            string Comments = null
,            DateTime? UpdatedAt = null
,            int? UserID = null
          ){

                DataColumnParameter paramTraceID = new (defTraceID, TraceID);
                DataColumnParameter paramRequestParametersJSON = new (defRequestParametersJSON, RequestParametersJSON);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramStackTrace = new (defStackTrace, StackTrace);
                DataColumnParameter paramIsResolved = new (defIsResolved, IsResolved);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramAbsoluteURL = new (defAbsoluteURL, AbsoluteURL);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramUserID = new (defUserID, UserID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  ", TABLE_NAME,
                        paramTraceID.GetSQLValue(),
                        paramRequestParametersJSON.GetSQLValue(),
                        paramExceptionMessage.GetSQLValue(),
                        paramStackTrace.GetSQLValue(),
                        paramIsResolved.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramAbsoluteURL.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramUserID.GetSQLValue()                        )
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
,            string TraceID
,            string ExceptionMessage
,            bool IsResolved
,            DateTime CreatedAt
,            string AbsoluteURL
,            string IPAddress
,            string RequestParametersJSON = null
,            string StackTrace = null
,            string Comments = null
,            DateTime? UpdatedAt = null
,            int? UserID = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTraceID = new (defTraceID, TraceID);
                DataColumnParameter paramRequestParametersJSON = new (defRequestParametersJSON, RequestParametersJSON);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramStackTrace = new (defStackTrace, StackTrace);
                DataColumnParameter paramIsResolved = new (defIsResolved, IsResolved);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramAbsoluteURL = new (defAbsoluteURL, AbsoluteURL);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramUserID = new (defUserID, UserID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTraceID.GetSQLValue(),
                        paramRequestParametersJSON.GetSQLValue(),
                        paramExceptionMessage.GetSQLValue(),
                        paramStackTrace.GetSQLValue(),
                        paramIsResolved.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramAbsoluteURL.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramUserID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            string TraceID
,            string ExceptionMessage
,            bool IsResolved
,            DateTime CreatedAt
,            string AbsoluteURL
,            string IPAddress
,            string RequestParametersJSON = null
,            string StackTrace = null
,            string Comments = null
,            DateTime? UpdatedAt = null
,            int? UserID = null
          ){

                DataColumnParameter paramTraceID = new (defTraceID, TraceID);
                DataColumnParameter paramRequestParametersJSON = new (defRequestParametersJSON, RequestParametersJSON);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramStackTrace = new (defStackTrace, StackTrace);
                DataColumnParameter paramIsResolved = new (defIsResolved, IsResolved);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramAbsoluteURL = new (defAbsoluteURL, AbsoluteURL);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramUserID = new (defUserID, UserID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  ", TABLE_NAME,
                        paramTraceID.GetSQLValue(),
                        paramRequestParametersJSON.GetSQLValue(),
                        paramExceptionMessage.GetSQLValue(),
                        paramStackTrace.GetSQLValue(),
                        paramIsResolved.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramAbsoluteURL.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramUserID.GetSQLValue()                            
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
