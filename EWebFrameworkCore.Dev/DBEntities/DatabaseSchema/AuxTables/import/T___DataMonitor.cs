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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.import                  
{                  

    public class T___DataMonitor : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___DataMonitor()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defImportTypeID = new DataColumnDefinition(TableColumnNames.ImportTypeID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defImportedFileName = new DataColumnDefinition(TableColumnNames.ImportedFileName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFileSizeBytes = new DataColumnDefinition(TableColumnNames.FileSizeBytes.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalRowsRead = new DataColumnDefinition(TableColumnNames.TotalRowsRead.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defImportTypeID.ColumnName, defImportTypeID); 
          ColumnDefns.Add(defImportedFileName.ColumnName, defImportedFileName); 
          ColumnDefns.Add(defFileSizeBytes.ColumnName, defFileSizeBytes); 
          ColumnDefns.Add(defTotalRowsRead.ColumnName, defTotalRowsRead); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_ImportTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "import.ImportType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "auth.Users"                  
                            ));                  

          }


                  
       public T___DataMonitor() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___DataMonitor(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(DataTable FullTable) : base(FullTable)                                    
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
        public T___DataMonitor(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "import.DataMonitor";
       public const string DataMonitor__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ImportTypeID], [ImportedFileName], [FileSizeBytes], [TotalRowsRead], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt] FROM import.DataMonitor";
       public const string DataMonitor__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ImportTypeID], [ImportedFileName], [FileSizeBytes], [TotalRowsRead], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt] FROM import.DataMonitor";


       public enum TableColumnNames
       {

           ID,
           ImportTypeID,
           ImportedFileName,
           FileSizeBytes,
           TotalRowsRead,
           CreatedByID,
           CreatedAt,
           UpdatedByID,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_import_DataMonitor, 
           fk_import_DataMonitor_ImportTypeID, 
           fk_import_DataMonitor_CreatedByID, 
           fk_import_DataMonitor_UpdatedByID, 
           uq_import_DataMonitor_ImportedFileName, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defImportTypeID;
       public static readonly DataColumnDefinition defImportedFileName;
       public static readonly DataColumnDefinition defFileSizeBytes;
       public static readonly DataColumnDefinition defTotalRowsRead;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int ImportTypeID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ImportTypeID.ToString());  set => TargettedRow[TableColumnNames.ImportTypeID.ToString()] = value; }


       public string ImportedFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ImportedFileName.ToString());  set => TargettedRow[TableColumnNames.ImportedFileName.ToString()] = value; }


       public int FileSizeBytes { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.FileSizeBytes.ToString());  set => TargettedRow[TableColumnNames.FileSizeBytes.ToString()] = value; }


       public int TotalRowsRead { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TotalRowsRead.ToString());  set => TargettedRow[TableColumnNames.TotalRowsRead.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int? UpdatedByID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___DataMonitor GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___DataMonitor GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___DataMonitor(conn.Fetch(DataMonitor__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___DataMonitor GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___DataMonitor( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___DataMonitor GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => DataMonitor__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamImportTypeID;
            private DataColumnParameter ParamImportedFileName;
            private DataColumnParameter ParamFileSizeBytes;
            private DataColumnParameter ParamTotalRowsRead;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedByID;
            private DataColumnParameter ParamUpdatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___DataMonitor v):this(v.ID)                  
            {                  

                ParamImportTypeID = new(defImportTypeID, v.ImportTypeID);                  
                ParamImportedFileName = new(defImportedFileName, v.ImportedFileName);                  
                ParamFileSizeBytes = new(defFileSizeBytes, v.FileSizeBytes);                  
                ParamTotalRowsRead = new(defTotalRowsRead, v.TotalRowsRead);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetImportTypeID(int v)                  
            {                  
                ParamImportTypeID = new(defImportTypeID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetImportedFileName(string v)                  
            {                  
                ParamImportedFileName = new(defImportedFileName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFileSizeBytes(int v)                  
            {                  
                ParamFileSizeBytes = new(defFileSizeBytes, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTotalRowsRead(int v)                  
            {                  
                ParamTotalRowsRead = new(defTotalRowsRead, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int? v)                  
            {                  
                ParamUpdatedByID = new(defUpdatedByID, v);                  
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
            int ImportTypeID,
            string ImportedFileName,
            int FileSizeBytes,
            int TotalRowsRead,
            int CreatedByID,
            DateTime CreatedAt,
            int? UpdatedByID = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramImportTypeID = new (defImportTypeID, ImportTypeID);
                DataColumnParameter paramImportedFileName = new (defImportedFileName, ImportedFileName);
                DataColumnParameter paramFileSizeBytes = new (defFileSizeBytes, FileSizeBytes);
                DataColumnParameter paramTotalRowsRead = new (defTotalRowsRead, TotalRowsRead);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramImportTypeID.GetSQLValue(),
                        paramImportedFileName.GetSQLValue(),
                        paramFileSizeBytes.GetSQLValue(),
                        paramTotalRowsRead.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
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
            int ImportTypeID,
            string ImportedFileName,
            int FileSizeBytes,
            int TotalRowsRead,
            int CreatedByID,
            DateTime CreatedAt,
            int? UpdatedByID = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramImportTypeID = new (defImportTypeID, ImportTypeID);
                DataColumnParameter paramImportedFileName = new (defImportedFileName, ImportedFileName);
                DataColumnParameter paramFileSizeBytes = new (defFileSizeBytes, FileSizeBytes);
                DataColumnParameter paramTotalRowsRead = new (defTotalRowsRead, TotalRowsRead);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramImportTypeID.GetSQLValue(),
                        paramImportedFileName.GetSQLValue(),
                        paramFileSizeBytes.GetSQLValue(),
                        paramTotalRowsRead.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
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
            int ImportTypeID,
            string ImportedFileName,
            int FileSizeBytes,
            int TotalRowsRead,
            int CreatedByID,
            DateTime CreatedAt,
            int? UpdatedByID = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramImportTypeID = new (defImportTypeID, ImportTypeID);
                DataColumnParameter paramImportedFileName = new (defImportedFileName, ImportedFileName);
                DataColumnParameter paramFileSizeBytes = new (defFileSizeBytes, FileSizeBytes);
                DataColumnParameter paramTotalRowsRead = new (defTotalRowsRead, TotalRowsRead);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramImportTypeID.GetSQLValue(),
                        paramImportedFileName.GetSQLValue(),
                        paramFileSizeBytes.GetSQLValue(),
                        paramTotalRowsRead.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
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
