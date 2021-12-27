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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.auth                  
{                  

    public class T___Session : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Session()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defSessionID = new DataColumnDefinition(TableColumnNames.SessionID.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defSessionTimeoutMins = new DataColumnDefinition(TableColumnNames.SessionTimeoutMins.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsNewSession = new DataColumnDefinition(TableColumnNames.IsNewSession.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsReadOnly = new DataColumnDefinition(TableColumnNames.IsReadOnly.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastActive = new DataColumnDefinition(TableColumnNames.LastActive.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBrowser = new DataColumnDefinition(TableColumnNames.Browser.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionVariables = new DataColumnDefinition(TableColumnNames.SessionVariables.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defSessionID.ColumnName, defSessionID); 
          ColumnDefns.Add(defSessionTimeoutMins.ColumnName, defSessionTimeoutMins); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defIsNewSession.ColumnName, defIsNewSession); 
          ColumnDefns.Add(defIsReadOnly.ColumnName, defIsReadOnly); 
          ColumnDefns.Add(defLastActive.ColumnName, defLastActive); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defBrowser.ColumnName, defBrowser); 
          ColumnDefns.Add(defSessionVariables.ColumnName, defSessionVariables); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  


          }


                  
       public T___Session() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Session(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(DataTable FullTable) : base(FullTable)                                    
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
        public T___Session(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.Session";
       public const string Session__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [SessionID], [SessionTimeoutMins], [UserID], [IsNewSession], [IsReadOnly], [LastActive], [IpAddress], [Browser], [SessionVariables], [CreatedAt], [UpdatedAt] FROM auth.Session";
       public const string Session__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [SessionID], [SessionTimeoutMins], [UserID], [IsNewSession], [IsReadOnly], [LastActive], [IpAddress], [Browser], [SessionVariables], [CreatedAt], [UpdatedAt] FROM auth.Session";


       public enum TableColumnNames
       {

           ID,
           SessionID,
           SessionTimeoutMins,
           UserID,
           IsNewSession,
           IsReadOnly,
           LastActive,
           IpAddress,
           Browser,
           SessionVariables,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_auth_Session, 
           uq_auth_SessionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defSessionID;
       public static readonly DataColumnDefinition defSessionTimeoutMins;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defIsNewSession;
       public static readonly DataColumnDefinition defIsReadOnly;
       public static readonly DataColumnDefinition defLastActive;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defBrowser;
       public static readonly DataColumnDefinition defSessionVariables;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public string SessionID { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SessionID.ToString());  set => TargettedRow[TableColumnNames.SessionID.ToString()] = value; }


       public int SessionTimeoutMins { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.SessionTimeoutMins.ToString());  set => TargettedRow[TableColumnNames.SessionTimeoutMins.ToString()] = value; }


       public int? UserID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.UserID.ToString());  set => TargettedRow[TableColumnNames.UserID.ToString()] = value; }


       public bool? IsNewSession { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.IsNewSession.ToString());  set => TargettedRow[TableColumnNames.IsNewSession.ToString()] = value; }


       public bool? IsReadOnly { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.IsReadOnly.ToString());  set => TargettedRow[TableColumnNames.IsReadOnly.ToString()] = value; }


       public DateTime? LastActive { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.LastActive.ToString());  set => TargettedRow[TableColumnNames.LastActive.ToString()] = value; }


       public string IpAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IpAddress.ToString());  set => TargettedRow[TableColumnNames.IpAddress.ToString()] = value; }


       public string Browser { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Browser.ToString());  set => TargettedRow[TableColumnNames.Browser.ToString()] = value; }


       public string SessionVariables { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SessionVariables.ToString());  set => TargettedRow[TableColumnNames.SessionVariables.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Session GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Session GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Session(conn.Fetch(Session__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Session GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Session( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Session GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Session__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamSessionID;
            private DataColumnParameter ParamSessionTimeoutMins;
            private DataColumnParameter ParamUserID;
            private DataColumnParameter ParamIsNewSession;
            private DataColumnParameter ParamIsReadOnly;
            private DataColumnParameter ParamLastActive;
            private DataColumnParameter ParamIpAddress;
            private DataColumnParameter ParamBrowser;
            private DataColumnParameter ParamSessionVariables;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Session v):this(v.ID)                  
            {                  

                ParamSessionID = new(defSessionID, v.SessionID);                  
                ParamSessionTimeoutMins = new(defSessionTimeoutMins, v.SessionTimeoutMins);                  
                ParamUserID = new(defUserID, v.UserID);                  
                ParamIsNewSession = new(defIsNewSession, v.IsNewSession);                  
                ParamIsReadOnly = new(defIsReadOnly, v.IsReadOnly);                  
                ParamLastActive = new(defLastActive, v.LastActive);                  
                ParamIpAddress = new(defIpAddress, v.IpAddress);                  
                ParamBrowser = new(defBrowser, v.Browser);                  
                ParamSessionVariables = new(defSessionVariables, v.SessionVariables);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetSessionID(string v)                  
            {                  
                ParamSessionID = new(defSessionID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSessionTimeoutMins(int v)                  
            {                  
                ParamSessionTimeoutMins = new(defSessionTimeoutMins, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUserID(int? v)                  
            {                  
                ParamUserID = new(defUserID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsNewSession(bool? v)                  
            {                  
                ParamIsNewSession = new(defIsNewSession, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsReadOnly(bool? v)                  
            {                  
                ParamIsReadOnly = new(defIsReadOnly, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLastActive(DateTime? v)                  
            {                  
                ParamLastActive = new(defLastActive, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIpAddress(string v)                  
            {                  
                ParamIpAddress = new(defIpAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBrowser(string v)                  
            {                  
                ParamBrowser = new(defBrowser, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSessionVariables(string v)                  
            {                  
                ParamSessionVariables = new(defSessionVariables, v);                  
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
            string SessionID,
            int SessionTimeoutMins,
            DateTime CreatedAt,
            int? UserID = null,
            bool? IsNewSession = null,
            bool? IsReadOnly = null,
            DateTime? LastActive = null,
            string IpAddress = null,
            string Browser = null,
            string SessionVariables = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramSessionID = new (defSessionID, SessionID);
                DataColumnParameter paramSessionTimeoutMins = new (defSessionTimeoutMins, SessionTimeoutMins);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramIsNewSession = new (defIsNewSession, IsNewSession);
                DataColumnParameter paramIsReadOnly = new (defIsReadOnly, IsReadOnly);
                DataColumnParameter paramLastActive = new (defLastActive, LastActive);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramBrowser = new (defBrowser, Browser);
                DataColumnParameter paramSessionVariables = new (defSessionVariables, SessionVariables);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  ", TABLE_NAME,
                        paramSessionID.GetSQLValue(),
                        paramSessionTimeoutMins.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramIsNewSession.GetSQLValue(),
                        paramIsReadOnly.GetSQLValue(),
                        paramLastActive.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramBrowser.GetSQLValue(),
                        paramSessionVariables.GetSQLValue(),
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
        public static bool AddWithID(
            int ID,
            string SessionID,
            int SessionTimeoutMins,
            DateTime CreatedAt,
            int? UserID = null,
            bool? IsNewSession = null,
            bool? IsReadOnly = null,
            DateTime? LastActive = null,
            string IpAddress = null,
            string Browser = null,
            string SessionVariables = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramSessionID = new (defSessionID, SessionID);
                DataColumnParameter paramSessionTimeoutMins = new (defSessionTimeoutMins, SessionTimeoutMins);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramIsNewSession = new (defIsNewSession, IsNewSession);
                DataColumnParameter paramIsReadOnly = new (defIsReadOnly, IsReadOnly);
                DataColumnParameter paramLastActive = new (defLastActive, LastActive);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramBrowser = new (defBrowser, Browser);
                DataColumnParameter paramSessionVariables = new (defSessionVariables, SessionVariables);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramSessionID.GetSQLValue(),
                        paramSessionTimeoutMins.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramIsNewSession.GetSQLValue(),
                        paramIsReadOnly.GetSQLValue(),
                        paramLastActive.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramBrowser.GetSQLValue(),
                        paramSessionVariables.GetSQLValue(),
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
        public static bool Add(
            string SessionID,
            int SessionTimeoutMins,
            DateTime CreatedAt,
            int? UserID = null,
            bool? IsNewSession = null,
            bool? IsReadOnly = null,
            DateTime? LastActive = null,
            string IpAddress = null,
            string Browser = null,
            string SessionVariables = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramSessionID = new (defSessionID, SessionID);
                DataColumnParameter paramSessionTimeoutMins = new (defSessionTimeoutMins, SessionTimeoutMins);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramIsNewSession = new (defIsNewSession, IsNewSession);
                DataColumnParameter paramIsReadOnly = new (defIsReadOnly, IsReadOnly);
                DataColumnParameter paramLastActive = new (defLastActive, LastActive);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramBrowser = new (defBrowser, Browser);
                DataColumnParameter paramSessionVariables = new (defSessionVariables, SessionVariables);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  ", TABLE_NAME,
                        paramSessionID.GetSQLValue(),
                        paramSessionTimeoutMins.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramIsNewSession.GetSQLValue(),
                        paramIsReadOnly.GetSQLValue(),
                        paramLastActive.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramBrowser.GetSQLValue(),
                        paramSessionVariables.GetSQLValue(),
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
