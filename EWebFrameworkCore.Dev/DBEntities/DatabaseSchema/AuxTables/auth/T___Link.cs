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

    public class T___Link : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Link()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAppModuleID = new DataColumnDefinition(TableColumnNames.AppModuleID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLink = new DataColumnDefinition(TableColumnNames.Link.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defLinkPermissionID = new DataColumnDefinition(TableColumnNames.LinkPermissionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defLinkParentID = new DataColumnDefinition(TableColumnNames.LinkParentID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defOwnedByRoleID = new DataColumnDefinition(TableColumnNames.OwnedByRoleID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDescription = new DataColumnDefinition(TableColumnNames.Description.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAppModuleID.ColumnName, defAppModuleID); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defLink.ColumnName, defLink); 
          ColumnDefns.Add(defLinkPermissionID.ColumnName, defLinkPermissionID); 
          ColumnDefns.Add(defLinkParentID.ColumnName, defLinkParentID); 
          ColumnDefns.Add(defOwnedByRoleID.ColumnName, defOwnedByRoleID); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_AppModuleID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.AppModule"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_LinkPermissionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.LinkPermission"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_LinkParentID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.Link"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_OwnedByRoleID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.Role"                  
                            ));                  

          }


                  
       public T___Link() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Link(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(DataTable FullTable) : base(FullTable)                                    
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
        public T___Link(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.Link";
       public const string Link__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AppModuleID], [Name], [Link], [LinkPermissionID], [LinkParentID], [OwnedByRoleID], [Description], [CreatedAt], [UpdatedAt] FROM auth.Link";
       public const string Link__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AppModuleID], [Name], [Link], [LinkPermissionID], [LinkParentID], [OwnedByRoleID], [Description], [CreatedAt], [UpdatedAt] FROM auth.Link";


       public enum TableColumnNames
       {

           ID,
           AppModuleID,
           Name,
           Link,
           LinkPermissionID,
           LinkParentID,
           OwnedByRoleID,
           Description,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_auth_Link, 
           fk_auth_Link_AppModuleID, 
           fk_auth_Link_LinkPermissionID, 
           fk_auth_Link_LinkParentID, 
           fk_auth_Link_OwnedByRoleID, 
           uq_auth_Link_Link, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAppModuleID;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defLink;
       public static readonly DataColumnDefinition defLinkPermissionID;
       public static readonly DataColumnDefinition defLinkParentID;
       public static readonly DataColumnDefinition defOwnedByRoleID;
       public static readonly DataColumnDefinition defDescription;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int AppModuleID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AppModuleID.ToString());  set => TargettedRow[TableColumnNames.AppModuleID.ToString()] = value; }


       public string Name { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Name.ToString());  set => TargettedRow[TableColumnNames.Name.ToString()] = value; }


       public string Link { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Link.ToString());  set => TargettedRow[TableColumnNames.Link.ToString()] = value; }


       public int LinkPermissionID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.LinkPermissionID.ToString());  set => TargettedRow[TableColumnNames.LinkPermissionID.ToString()] = value; }


       public int? LinkParentID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.LinkParentID.ToString());  set => TargettedRow[TableColumnNames.LinkParentID.ToString()] = value; }


       public int? OwnedByRoleID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.OwnedByRoleID.ToString());  set => TargettedRow[TableColumnNames.OwnedByRoleID.ToString()] = value; }


       public string Description { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Description.ToString());  set => TargettedRow[TableColumnNames.Description.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Link GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Link GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Link(conn.Fetch(Link__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Link GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Link( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Link GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Link__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamAppModuleID;
            private DataColumnParameter ParamName;
            private DataColumnParameter ParamLink;
            private DataColumnParameter ParamLinkPermissionID;
            private DataColumnParameter ParamLinkParentID;
            private DataColumnParameter ParamOwnedByRoleID;
            private DataColumnParameter ParamDescription;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Link v):this(v.ID)                  
            {                  

                ParamAppModuleID = new(defAppModuleID, v.AppModuleID);                  
                ParamName = new(defName, v.Name);                  
                ParamLink = new(defLink, v.Link);                  
                ParamLinkPermissionID = new(defLinkPermissionID, v.LinkPermissionID);                  
                ParamLinkParentID = new(defLinkParentID, v.LinkParentID);                  
                ParamOwnedByRoleID = new(defOwnedByRoleID, v.OwnedByRoleID);                  
                ParamDescription = new(defDescription, v.Description);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetAppModuleID(int v)                  
            {                  
                ParamAppModuleID = new(defAppModuleID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetName(string v)                  
            {                  
                ParamName = new(defName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLink(string v)                  
            {                  
                ParamLink = new(defLink, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLinkPermissionID(int v)                  
            {                  
                ParamLinkPermissionID = new(defLinkPermissionID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLinkParentID(int? v)                  
            {                  
                ParamLinkParentID = new(defLinkParentID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetOwnedByRoleID(int? v)                  
            {                  
                ParamOwnedByRoleID = new(defOwnedByRoleID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDescription(string v)                  
            {                  
                ParamDescription = new(defDescription, v);                  
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
            int AppModuleID,
            string Name,
            string Link,
            int LinkPermissionID,
            DateTime CreatedAt,
            int? LinkParentID = null,
            int? OwnedByRoleID = null,
            string Description = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramAppModuleID = new (defAppModuleID, AppModuleID);
                DataColumnParameter paramName = new (defName, Name);
                DataColumnParameter paramLink = new (defLink, Link);
                DataColumnParameter paramLinkPermissionID = new (defLinkPermissionID, LinkPermissionID);
                DataColumnParameter paramLinkParentID = new (defLinkParentID, LinkParentID);
                DataColumnParameter paramOwnedByRoleID = new (defOwnedByRoleID, OwnedByRoleID);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramAppModuleID.GetSQLValue(),
                        paramName.GetSQLValue(),
                        paramLink.GetSQLValue(),
                        paramLinkPermissionID.GetSQLValue(),
                        paramLinkParentID.GetSQLValue(),
                        paramOwnedByRoleID.GetSQLValue(),
                        paramDescription.GetSQLValue(),
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
            int AppModuleID,
            string Name,
            string Link,
            int LinkPermissionID,
            DateTime CreatedAt,
            int? LinkParentID = null,
            int? OwnedByRoleID = null,
            string Description = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramAppModuleID = new (defAppModuleID, AppModuleID);
                DataColumnParameter paramName = new (defName, Name);
                DataColumnParameter paramLink = new (defLink, Link);
                DataColumnParameter paramLinkPermissionID = new (defLinkPermissionID, LinkPermissionID);
                DataColumnParameter paramLinkParentID = new (defLinkParentID, LinkParentID);
                DataColumnParameter paramOwnedByRoleID = new (defOwnedByRoleID, OwnedByRoleID);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramAppModuleID.GetSQLValue(),
                        paramName.GetSQLValue(),
                        paramLink.GetSQLValue(),
                        paramLinkPermissionID.GetSQLValue(),
                        paramLinkParentID.GetSQLValue(),
                        paramOwnedByRoleID.GetSQLValue(),
                        paramDescription.GetSQLValue(),
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
            int AppModuleID,
            string Name,
            string Link,
            int LinkPermissionID,
            DateTime CreatedAt,
            int? LinkParentID = null,
            int? OwnedByRoleID = null,
            string Description = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramAppModuleID = new (defAppModuleID, AppModuleID);
                DataColumnParameter paramName = new (defName, Name);
                DataColumnParameter paramLink = new (defLink, Link);
                DataColumnParameter paramLinkPermissionID = new (defLinkPermissionID, LinkPermissionID);
                DataColumnParameter paramLinkParentID = new (defLinkParentID, LinkParentID);
                DataColumnParameter paramOwnedByRoleID = new (defOwnedByRoleID, OwnedByRoleID);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramAppModuleID.GetSQLValue(),
                        paramName.GetSQLValue(),
                        paramLink.GetSQLValue(),
                        paramLinkPermissionID.GetSQLValue(),
                        paramLinkParentID.GetSQLValue(),
                        paramOwnedByRoleID.GetSQLValue(),
                        paramDescription.GetSQLValue(),
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
