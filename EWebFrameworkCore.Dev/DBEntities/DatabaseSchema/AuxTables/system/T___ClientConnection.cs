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

    public class T___ClientConnection : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ClientConnection()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFileServerUrl = new DataColumnDefinition(TableColumnNames.FileServerUrl.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerAccessKey = new DataColumnDefinition(TableColumnNames.FileServerAccessKey.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerSecretKey = new DataColumnDefinition(TableColumnNames.FileServerSecretKey.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerBucket = new DataColumnDefinition(TableColumnNames.FileServerBucket.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientAPIID = new DataColumnDefinition(TableColumnNames.ClientAPIID.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientAPIUrl = new DataColumnDefinition(TableColumnNames.ClientAPIUrl.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_HOST = new DataColumnDefinition(TableColumnNames.DB_HOST.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_DATABASE = new DataColumnDefinition(TableColumnNames.DB_DATABASE.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_USERNAME = new DataColumnDefinition(TableColumnNames.DB_USERNAME.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_PASSWORD = new DataColumnDefinition(TableColumnNames.DB_PASSWORD.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_PORT = new DataColumnDefinition(TableColumnNames.DB_PORT.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerUrlHttps = new DataColumnDefinition(TableColumnNames.FileServerUrlHttps.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defFileServerUrl.ColumnName, defFileServerUrl); 
          ColumnDefns.Add(defFileServerAccessKey.ColumnName, defFileServerAccessKey); 
          ColumnDefns.Add(defFileServerSecretKey.ColumnName, defFileServerSecretKey); 
          ColumnDefns.Add(defFileServerBucket.ColumnName, defFileServerBucket); 
          ColumnDefns.Add(defClientAPIID.ColumnName, defClientAPIID); 
          ColumnDefns.Add(defClientAPIUrl.ColumnName, defClientAPIUrl); 
          ColumnDefns.Add(defDB_HOST.ColumnName, defDB_HOST); 
          ColumnDefns.Add(defDB_DATABASE.ColumnName, defDB_DATABASE); 
          ColumnDefns.Add(defDB_USERNAME.ColumnName, defDB_USERNAME); 
          ColumnDefns.Add(defDB_PASSWORD.ColumnName, defDB_PASSWORD); 
          ColumnDefns.Add(defDB_PORT.ColumnName, defDB_PORT); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defFileServerUrlHttps.ColumnName, defFileServerUrlHttps); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_ClientConnection_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.ClientConnection", "hr.Client"                  
                            ));                  

          }


                  
       public T___ClientConnection() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ClientConnection(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(DataTable FullTable) : base(FullTable)                                    
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
        public T___ClientConnection(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.ClientConnection";
       public const string ClientConnection__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [FileServerUrl], [FileServerAccessKey], [FileServerSecretKey], [FileServerBucket], [ClientAPIID], [ClientAPIUrl], [DB_HOST], [DB_DATABASE], [DB_USERNAME], [DB_PASSWORD], [DB_PORT], [CreatedAt], [UpdatedAt], [FileServerUrlHttps] FROM system.ClientConnection";
       public const string ClientConnection__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [FileServerUrl], [FileServerAccessKey], [FileServerSecretKey], [FileServerBucket], [ClientAPIID], [ClientAPIUrl], [DB_HOST], [DB_DATABASE], [DB_USERNAME], [DB_PASSWORD], [DB_PORT], [CreatedAt], [UpdatedAt], [FileServerUrlHttps] FROM system.ClientConnection";


       public enum TableColumnNames
       {

           ID,
           ClientID,
           FileServerUrl,
           FileServerAccessKey,
           FileServerSecretKey,
           FileServerBucket,
           ClientAPIID,
           ClientAPIUrl,
           DB_HOST,
           DB_DATABASE,
           DB_USERNAME,
           DB_PASSWORD,
           DB_PORT,
           CreatedAt,
           UpdatedAt,
           FileServerUrlHttps
       } 



       public enum TableConstraints{

           pk_system_ClientConnection, 
           fk_system_ClientConnection_ClientID, 
           uq_system_ClientConnection_ClientID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defFileServerUrl;
       public static readonly DataColumnDefinition defFileServerAccessKey;
       public static readonly DataColumnDefinition defFileServerSecretKey;
       public static readonly DataColumnDefinition defFileServerBucket;
       public static readonly DataColumnDefinition defClientAPIID;
       public static readonly DataColumnDefinition defClientAPIUrl;
       public static readonly DataColumnDefinition defDB_HOST;
       public static readonly DataColumnDefinition defDB_DATABASE;
       public static readonly DataColumnDefinition defDB_USERNAME;
       public static readonly DataColumnDefinition defDB_PASSWORD;
       public static readonly DataColumnDefinition defDB_PORT;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defFileServerUrlHttps;

       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public string FileServerUrl { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FileServerUrl.ToString());  set => TargettedRow[TableColumnNames.FileServerUrl.ToString()] = value; }


       public string FileServerAccessKey { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FileServerAccessKey.ToString());  set => TargettedRow[TableColumnNames.FileServerAccessKey.ToString()] = value; }


       public string FileServerSecretKey { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FileServerSecretKey.ToString());  set => TargettedRow[TableColumnNames.FileServerSecretKey.ToString()] = value; }


       public string FileServerBucket { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FileServerBucket.ToString());  set => TargettedRow[TableColumnNames.FileServerBucket.ToString()] = value; }


       public string ClientAPIID { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ClientAPIID.ToString());  set => TargettedRow[TableColumnNames.ClientAPIID.ToString()] = value; }


       public string ClientAPIUrl { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ClientAPIUrl.ToString());  set => TargettedRow[TableColumnNames.ClientAPIUrl.ToString()] = value; }


       public string DB_HOST { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.DB_HOST.ToString());  set => TargettedRow[TableColumnNames.DB_HOST.ToString()] = value; }


       public string DB_DATABASE { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.DB_DATABASE.ToString());  set => TargettedRow[TableColumnNames.DB_DATABASE.ToString()] = value; }


       public string DB_USERNAME { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.DB_USERNAME.ToString());  set => TargettedRow[TableColumnNames.DB_USERNAME.ToString()] = value; }


       public string DB_PASSWORD { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.DB_PASSWORD.ToString());  set => TargettedRow[TableColumnNames.DB_PASSWORD.ToString()] = value; }


       public int DB_PORT { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DB_PORT.ToString());  set => TargettedRow[TableColumnNames.DB_PORT.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public string FileServerUrlHttps { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FileServerUrlHttps.ToString());  set => TargettedRow[TableColumnNames.FileServerUrlHttps.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___ClientConnection GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___ClientConnection GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___ClientConnection(conn.Fetch(ClientConnection__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___ClientConnection GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___ClientConnection( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___ClientConnection GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ClientConnection__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamClientID;
            private DataColumnParameter ParamFileServerUrl;
            private DataColumnParameter ParamFileServerAccessKey;
            private DataColumnParameter ParamFileServerSecretKey;
            private DataColumnParameter ParamFileServerBucket;
            private DataColumnParameter ParamClientAPIID;
            private DataColumnParameter ParamClientAPIUrl;
            private DataColumnParameter ParamDB_HOST;
            private DataColumnParameter ParamDB_DATABASE;
            private DataColumnParameter ParamDB_USERNAME;
            private DataColumnParameter ParamDB_PASSWORD;
            private DataColumnParameter ParamDB_PORT;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamFileServerUrlHttps;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___ClientConnection v):this(v.ID)                  
            {                  

                ParamClientID = new(defClientID, v.ClientID);                  
                ParamFileServerUrl = new(defFileServerUrl, v.FileServerUrl);                  
                ParamFileServerAccessKey = new(defFileServerAccessKey, v.FileServerAccessKey);                  
                ParamFileServerSecretKey = new(defFileServerSecretKey, v.FileServerSecretKey);                  
                ParamFileServerBucket = new(defFileServerBucket, v.FileServerBucket);                  
                ParamClientAPIID = new(defClientAPIID, v.ClientAPIID);                  
                ParamClientAPIUrl = new(defClientAPIUrl, v.ClientAPIUrl);                  
                ParamDB_HOST = new(defDB_HOST, v.DB_HOST);                  
                ParamDB_DATABASE = new(defDB_DATABASE, v.DB_DATABASE);                  
                ParamDB_USERNAME = new(defDB_USERNAME, v.DB_USERNAME);                  
                ParamDB_PASSWORD = new(defDB_PASSWORD, v.DB_PASSWORD);                  
                ParamDB_PORT = new(defDB_PORT, v.DB_PORT);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamFileServerUrlHttps = new(defFileServerUrlHttps, v.FileServerUrlHttps);                  
            }                  
                  
            public UpdateQueryBuilder SetClientID(int v)                  
            {                  
                ParamClientID = new(defClientID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFileServerUrl(string v)                  
            {                  
                ParamFileServerUrl = new(defFileServerUrl, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFileServerAccessKey(string v)                  
            {                  
                ParamFileServerAccessKey = new(defFileServerAccessKey, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFileServerSecretKey(string v)                  
            {                  
                ParamFileServerSecretKey = new(defFileServerSecretKey, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFileServerBucket(string v)                  
            {                  
                ParamFileServerBucket = new(defFileServerBucket, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetClientAPIID(string v)                  
            {                  
                ParamClientAPIID = new(defClientAPIID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetClientAPIUrl(string v)                  
            {                  
                ParamClientAPIUrl = new(defClientAPIUrl, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDB_HOST(string v)                  
            {                  
                ParamDB_HOST = new(defDB_HOST, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDB_DATABASE(string v)                  
            {                  
                ParamDB_DATABASE = new(defDB_DATABASE, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDB_USERNAME(string v)                  
            {                  
                ParamDB_USERNAME = new(defDB_USERNAME, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDB_PASSWORD(string v)                  
            {                  
                ParamDB_PASSWORD = new(defDB_PASSWORD, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDB_PORT(int v)                  
            {                  
                ParamDB_PORT = new(defDB_PORT, v);                  
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
                  
            public UpdateQueryBuilder SetFileServerUrlHttps(string v)                  
            {                  
                ParamFileServerUrlHttps = new(defFileServerUrlHttps, v);                  
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
            int ClientID
,            string FileServerUrl
,            string FileServerAccessKey
,            string FileServerSecretKey
,            string FileServerBucket
,            string ClientAPIID
,            string ClientAPIUrl
,            string DB_HOST
,            string DB_DATABASE
,            string DB_USERNAME
,            string DB_PASSWORD
,            int DB_PORT
,            DateTime CreatedAt
,            string FileServerUrlHttps
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramFileServerUrl = new (defFileServerUrl, FileServerUrl);
                DataColumnParameter paramFileServerAccessKey = new (defFileServerAccessKey, FileServerAccessKey);
                DataColumnParameter paramFileServerSecretKey = new (defFileServerSecretKey, FileServerSecretKey);
                DataColumnParameter paramFileServerBucket = new (defFileServerBucket, FileServerBucket);
                DataColumnParameter paramClientAPIID = new (defClientAPIID, ClientAPIID);
                DataColumnParameter paramClientAPIUrl = new (defClientAPIUrl, ClientAPIUrl);
                DataColumnParameter paramDB_HOST = new (defDB_HOST, DB_HOST);
                DataColumnParameter paramDB_DATABASE = new (defDB_DATABASE, DB_DATABASE);
                DataColumnParameter paramDB_USERNAME = new (defDB_USERNAME, DB_USERNAME);
                DataColumnParameter paramDB_PASSWORD = new (defDB_PASSWORD, DB_PASSWORD);
                DataColumnParameter paramDB_PORT = new (defDB_PORT, DB_PORT);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramFileServerUrlHttps = new (defFileServerUrlHttps, FileServerUrlHttps);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})  ", TABLE_NAME,
                        paramClientID.GetSQLValue(),
                        paramFileServerUrl.GetSQLValue(),
                        paramFileServerAccessKey.GetSQLValue(),
                        paramFileServerSecretKey.GetSQLValue(),
                        paramFileServerBucket.GetSQLValue(),
                        paramClientAPIID.GetSQLValue(),
                        paramClientAPIUrl.GetSQLValue(),
                        paramDB_HOST.GetSQLValue(),
                        paramDB_DATABASE.GetSQLValue(),
                        paramDB_USERNAME.GetSQLValue(),
                        paramDB_PASSWORD.GetSQLValue(),
                        paramDB_PORT.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramFileServerUrlHttps.GetSQLValue()                        )
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
,            int ClientID
,            string FileServerUrl
,            string FileServerAccessKey
,            string FileServerSecretKey
,            string FileServerBucket
,            string ClientAPIID
,            string ClientAPIUrl
,            string DB_HOST
,            string DB_DATABASE
,            string DB_USERNAME
,            string DB_PASSWORD
,            int DB_PORT
,            DateTime CreatedAt
,            string FileServerUrlHttps
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramFileServerUrl = new (defFileServerUrl, FileServerUrl);
                DataColumnParameter paramFileServerAccessKey = new (defFileServerAccessKey, FileServerAccessKey);
                DataColumnParameter paramFileServerSecretKey = new (defFileServerSecretKey, FileServerSecretKey);
                DataColumnParameter paramFileServerBucket = new (defFileServerBucket, FileServerBucket);
                DataColumnParameter paramClientAPIID = new (defClientAPIID, ClientAPIID);
                DataColumnParameter paramClientAPIUrl = new (defClientAPIUrl, ClientAPIUrl);
                DataColumnParameter paramDB_HOST = new (defDB_HOST, DB_HOST);
                DataColumnParameter paramDB_DATABASE = new (defDB_DATABASE, DB_DATABASE);
                DataColumnParameter paramDB_USERNAME = new (defDB_USERNAME, DB_USERNAME);
                DataColumnParameter paramDB_PASSWORD = new (defDB_PASSWORD, DB_PASSWORD);
                DataColumnParameter paramDB_PORT = new (defDB_PORT, DB_PORT);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramFileServerUrlHttps = new (defFileServerUrlHttps, FileServerUrlHttps);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramFileServerUrl.GetSQLValue(),
                        paramFileServerAccessKey.GetSQLValue(),
                        paramFileServerSecretKey.GetSQLValue(),
                        paramFileServerBucket.GetSQLValue(),
                        paramClientAPIID.GetSQLValue(),
                        paramClientAPIUrl.GetSQLValue(),
                        paramDB_HOST.GetSQLValue(),
                        paramDB_DATABASE.GetSQLValue(),
                        paramDB_USERNAME.GetSQLValue(),
                        paramDB_PASSWORD.GetSQLValue(),
                        paramDB_PORT.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramFileServerUrlHttps.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int ClientID
,            string FileServerUrl
,            string FileServerAccessKey
,            string FileServerSecretKey
,            string FileServerBucket
,            string ClientAPIID
,            string ClientAPIUrl
,            string DB_HOST
,            string DB_DATABASE
,            string DB_USERNAME
,            string DB_PASSWORD
,            int DB_PORT
,            DateTime CreatedAt
,            string FileServerUrlHttps
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramFileServerUrl = new (defFileServerUrl, FileServerUrl);
                DataColumnParameter paramFileServerAccessKey = new (defFileServerAccessKey, FileServerAccessKey);
                DataColumnParameter paramFileServerSecretKey = new (defFileServerSecretKey, FileServerSecretKey);
                DataColumnParameter paramFileServerBucket = new (defFileServerBucket, FileServerBucket);
                DataColumnParameter paramClientAPIID = new (defClientAPIID, ClientAPIID);
                DataColumnParameter paramClientAPIUrl = new (defClientAPIUrl, ClientAPIUrl);
                DataColumnParameter paramDB_HOST = new (defDB_HOST, DB_HOST);
                DataColumnParameter paramDB_DATABASE = new (defDB_DATABASE, DB_DATABASE);
                DataColumnParameter paramDB_USERNAME = new (defDB_USERNAME, DB_USERNAME);
                DataColumnParameter paramDB_PASSWORD = new (defDB_PASSWORD, DB_PASSWORD);
                DataColumnParameter paramDB_PORT = new (defDB_PORT, DB_PORT);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramFileServerUrlHttps = new (defFileServerUrlHttps, FileServerUrlHttps);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})  ", TABLE_NAME,
                        paramClientID.GetSQLValue(),
                        paramFileServerUrl.GetSQLValue(),
                        paramFileServerAccessKey.GetSQLValue(),
                        paramFileServerSecretKey.GetSQLValue(),
                        paramFileServerBucket.GetSQLValue(),
                        paramClientAPIID.GetSQLValue(),
                        paramClientAPIUrl.GetSQLValue(),
                        paramDB_HOST.GetSQLValue(),
                        paramDB_DATABASE.GetSQLValue(),
                        paramDB_USERNAME.GetSQLValue(),
                        paramDB_PASSWORD.GetSQLValue(),
                        paramDB_PORT.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramFileServerUrlHttps.GetSQLValue()                            
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
