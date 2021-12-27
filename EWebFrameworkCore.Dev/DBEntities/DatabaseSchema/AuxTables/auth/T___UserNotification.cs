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

    public class T___UserNotification : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___UserNotification()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defQuickNote = new DataColumnDefinition(TableColumnNames.QuickNote.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDescription = new DataColumnDefinition(TableColumnNames.Description.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIconClass = new DataColumnDefinition(TableColumnNames.IconClass.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHeadingColorClass = new DataColumnDefinition(TableColumnNames.HeadingColorClass.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReadAt = new DataColumnDefinition(TableColumnNames.ReadAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIdentifier = new DataColumnDefinition(TableColumnNames.Identifier.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTargetURL = new DataColumnDefinition(TableColumnNames.TargetURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defQuickNote.ColumnName, defQuickNote); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
          ColumnDefns.Add(defIconClass.ColumnName, defIconClass); 
          ColumnDefns.Add(defHeadingColorClass.ColumnName, defHeadingColorClass); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defReadAt.ColumnName, defReadAt); 
          ColumnDefns.Add(defIdentifier.ColumnName, defIdentifier); 
          ColumnDefns.Add(defTargetURL.ColumnName, defTargetURL); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_UserNotification_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.UserNotification", "auth.Users"                  
                            ));                  

          }


                  
       public T___UserNotification() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___UserNotification(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(DataTable FullTable) : base(FullTable)                                    
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
        public T___UserNotification(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.UserNotification";
       public const string UserNotification__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [UserID], [Title], [QuickNote], [Description], [IconClass], [HeadingColorClass], [CreatedAt], [ReadAt], [Identifier], [TargetURL] FROM auth.UserNotification";
       public const string UserNotification__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [UserID], [Title], [QuickNote], [Description], [IconClass], [HeadingColorClass], [CreatedAt], [ReadAt], [Identifier], [TargetURL] FROM auth.UserNotification";


       public enum TableColumnNames
       {

           ID,
           UserID,
           Title,
           QuickNote,
           Description,
           IconClass,
           HeadingColorClass,
           CreatedAt,
           ReadAt,
           Identifier,
           TargetURL
       } 



       public enum TableConstraints{

           pk_auth_UserNotification, 
           fk_auth_UserNotification_UserID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defQuickNote;
       public static readonly DataColumnDefinition defDescription;
       public static readonly DataColumnDefinition defIconClass;
       public static readonly DataColumnDefinition defHeadingColorClass;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defReadAt;
       public static readonly DataColumnDefinition defIdentifier;
       public static readonly DataColumnDefinition defTargetURL;

       public int UserID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UserID.ToString());  set => TargettedRow[TableColumnNames.UserID.ToString()] = value; }


       public string Title { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Title.ToString());  set => TargettedRow[TableColumnNames.Title.ToString()] = value; }


       public string QuickNote { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.QuickNote.ToString());  set => TargettedRow[TableColumnNames.QuickNote.ToString()] = value; }


       public string Description { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Description.ToString());  set => TargettedRow[TableColumnNames.Description.ToString()] = value; }


       public string IconClass { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IconClass.ToString());  set => TargettedRow[TableColumnNames.IconClass.ToString()] = value; }


       public string HeadingColorClass { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HeadingColorClass.ToString());  set => TargettedRow[TableColumnNames.HeadingColorClass.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? ReadAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.ReadAt.ToString());  set => TargettedRow[TableColumnNames.ReadAt.ToString()] = value; }


       public string Identifier { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Identifier.ToString());  set => TargettedRow[TableColumnNames.Identifier.ToString()] = value; }


       public string TargetURL { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.TargetURL.ToString());  set => TargettedRow[TableColumnNames.TargetURL.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___UserNotification GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___UserNotification GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___UserNotification(conn.Fetch(UserNotification__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___UserNotification GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___UserNotification( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___UserNotification GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => UserNotification__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamUserID;
            private DataColumnParameter ParamTitle;
            private DataColumnParameter ParamQuickNote;
            private DataColumnParameter ParamDescription;
            private DataColumnParameter ParamIconClass;
            private DataColumnParameter ParamHeadingColorClass;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamReadAt;
            private DataColumnParameter ParamIdentifier;
            private DataColumnParameter ParamTargetURL;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___UserNotification v):this(v.ID)                  
            {                  

                ParamUserID = new(defUserID, v.UserID);                  
                ParamTitle = new(defTitle, v.Title);                  
                ParamQuickNote = new(defQuickNote, v.QuickNote);                  
                ParamDescription = new(defDescription, v.Description);                  
                ParamIconClass = new(defIconClass, v.IconClass);                  
                ParamHeadingColorClass = new(defHeadingColorClass, v.HeadingColorClass);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamReadAt = new(defReadAt, v.ReadAt);                  
                ParamIdentifier = new(defIdentifier, v.Identifier);                  
                ParamTargetURL = new(defTargetURL, v.TargetURL);                  
            }                  
                  
            public UpdateQueryBuilder SetUserID(int v)                  
            {                  
                ParamUserID = new(defUserID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTitle(string v)                  
            {                  
                ParamTitle = new(defTitle, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetQuickNote(string v)                  
            {                  
                ParamQuickNote = new(defQuickNote, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDescription(string v)                  
            {                  
                ParamDescription = new(defDescription, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIconClass(string v)                  
            {                  
                ParamIconClass = new(defIconClass, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetHeadingColorClass(string v)                  
            {                  
                ParamHeadingColorClass = new(defHeadingColorClass, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetReadAt(DateTime? v)                  
            {                  
                ParamReadAt = new(defReadAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIdentifier(string v)                  
            {                  
                ParamIdentifier = new(defIdentifier, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTargetURL(string v)                  
            {                  
                ParamTargetURL = new(defTargetURL, v);                  
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
            int UserID,
            string Title,
            DateTime CreatedAt,
            string TargetURL,
            string QuickNote = null,
            string Description = null,
            string IconClass = null,
            string HeadingColorClass = null,
            DateTime? ReadAt = null,
            string Identifier = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramQuickNote = new (defQuickNote, QuickNote);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramIconClass = new (defIconClass, IconClass);
                DataColumnParameter paramHeadingColorClass = new (defHeadingColorClass, HeadingColorClass);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramReadAt = new (defReadAt, ReadAt);
                DataColumnParameter paramIdentifier = new (defIdentifier, Identifier);
                DataColumnParameter paramTargetURL = new (defTargetURL, TargetURL);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramUserID.GetSQLValue(),
                        paramTitle.GetSQLValue(),
                        paramQuickNote.GetSQLValue(),
                        paramDescription.GetSQLValue(),
                        paramIconClass.GetSQLValue(),
                        paramHeadingColorClass.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramReadAt.GetSQLValue(),
                        paramIdentifier.GetSQLValue(),
                        paramTargetURL.GetSQLValue()                        )
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
            int UserID,
            string Title,
            DateTime CreatedAt,
            string TargetURL,
            string QuickNote = null,
            string Description = null,
            string IconClass = null,
            string HeadingColorClass = null,
            DateTime? ReadAt = null,
            string Identifier = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramQuickNote = new (defQuickNote, QuickNote);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramIconClass = new (defIconClass, IconClass);
                DataColumnParameter paramHeadingColorClass = new (defHeadingColorClass, HeadingColorClass);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramReadAt = new (defReadAt, ReadAt);
                DataColumnParameter paramIdentifier = new (defIdentifier, Identifier);
                DataColumnParameter paramTargetURL = new (defTargetURL, TargetURL);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramTitle.GetSQLValue(),
                        paramQuickNote.GetSQLValue(),
                        paramDescription.GetSQLValue(),
                        paramIconClass.GetSQLValue(),
                        paramHeadingColorClass.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramReadAt.GetSQLValue(),
                        paramIdentifier.GetSQLValue(),
                        paramTargetURL.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int UserID,
            string Title,
            DateTime CreatedAt,
            string TargetURL,
            string QuickNote = null,
            string Description = null,
            string IconClass = null,
            string HeadingColorClass = null,
            DateTime? ReadAt = null,
            string Identifier = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramQuickNote = new (defQuickNote, QuickNote);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramIconClass = new (defIconClass, IconClass);
                DataColumnParameter paramHeadingColorClass = new (defHeadingColorClass, HeadingColorClass);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramReadAt = new (defReadAt, ReadAt);
                DataColumnParameter paramIdentifier = new (defIdentifier, Identifier);
                DataColumnParameter paramTargetURL = new (defTargetURL, TargetURL);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramUserID.GetSQLValue(),
                        paramTitle.GetSQLValue(),
                        paramQuickNote.GetSQLValue(),
                        paramDescription.GetSQLValue(),
                        paramIconClass.GetSQLValue(),
                        paramHeadingColorClass.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramReadAt.GetSQLValue(),
                        paramIdentifier.GetSQLValue(),
                        paramTargetURL.GetSQLValue()                            
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
