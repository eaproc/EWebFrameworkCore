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

    public class T___CronjobProceeding : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CronjobProceeding()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCronjobID = new DataColumnDefinition(TableColumnNames.CronjobID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defProceedingStatusID = new DataColumnDefinition(TableColumnNames.ProceedingStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNextExpectedExecutionTime = new DataColumnDefinition(TableColumnNames.NextExpectedExecutionTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuccessful = new DataColumnDefinition(TableColumnNames.IsSuccessful.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCronjobID.ColumnName, defCronjobID); 
          ColumnDefns.Add(defProceedingStatusID.ColumnName, defProceedingStatusID); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defNextExpectedExecutionTime.ColumnName, defNextExpectedExecutionTime); 
          ColumnDefns.Add(defIsSuccessful.ColumnName, defIsSuccessful); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_CronjobProceeding_CronjobID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "system.CronjobProceeding", "system.Cronjob"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_CronjobProceeding_ProceedingStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.CronjobProceeding", "system.CronjobProceedingStatus"                  
                            ));                  

          }


                  
       public T___CronjobProceeding() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CronjobProceeding(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(DataTable FullTable) : base(FullTable)                                    
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
        public T___CronjobProceeding(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.CronjobProceeding";
       public const string CronjobProceeding__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CronjobID], [ProceedingStatusID], [Comments], [NextExpectedExecutionTime], [IsSuccessful], [CreatedAt] FROM system.CronjobProceeding";
       public const string CronjobProceeding__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CronjobID], [ProceedingStatusID], [Comments], [NextExpectedExecutionTime], [IsSuccessful], [CreatedAt] FROM system.CronjobProceeding";


       public enum TableColumnNames
       {

           ID,
           CronjobID,
           ProceedingStatusID,
           Comments,
           NextExpectedExecutionTime,
           IsSuccessful,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_system_CronjobProceeding, 
           fk_system_CronjobProceeding_CronjobID, 
           fk_system_CronjobProceeding_ProceedingStatusID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCronjobID;
       public static readonly DataColumnDefinition defProceedingStatusID;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defNextExpectedExecutionTime;
       public static readonly DataColumnDefinition defIsSuccessful;
       public static readonly DataColumnDefinition defCreatedAt;

       public int CronjobID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CronjobID.ToString());  set => TargettedRow[TableColumnNames.CronjobID.ToString()] = value; }


       public int ProceedingStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ProceedingStatusID.ToString());  set => TargettedRow[TableColumnNames.ProceedingStatusID.ToString()] = value; }


       public string Comments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Comments.ToString());  set => TargettedRow[TableColumnNames.Comments.ToString()] = value; }


       public DateTime? NextExpectedExecutionTime { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.NextExpectedExecutionTime.ToString());  set => TargettedRow[TableColumnNames.NextExpectedExecutionTime.ToString()] = value; }


       public bool IsSuccessful { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsSuccessful.ToString());  set => TargettedRow[TableColumnNames.IsSuccessful.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___CronjobProceeding GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___CronjobProceeding GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___CronjobProceeding(conn.Fetch(CronjobProceeding__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___CronjobProceeding GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___CronjobProceeding( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___CronjobProceeding GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CronjobProceeding__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCronjobID;
            private DataColumnParameter ParamProceedingStatusID;
            private DataColumnParameter ParamComments;
            private DataColumnParameter ParamNextExpectedExecutionTime;
            private DataColumnParameter ParamIsSuccessful;
            private DataColumnParameter ParamCreatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___CronjobProceeding v):this(v.ID)                  
            {                  

                ParamCronjobID = new(defCronjobID, v.CronjobID);                  
                ParamProceedingStatusID = new(defProceedingStatusID, v.ProceedingStatusID);                  
                ParamComments = new(defComments, v.Comments);                  
                ParamNextExpectedExecutionTime = new(defNextExpectedExecutionTime, v.NextExpectedExecutionTime);                  
                ParamIsSuccessful = new(defIsSuccessful, v.IsSuccessful);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetCronjobID(int v)                  
            {                  
                ParamCronjobID = new(defCronjobID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetProceedingStatusID(int v)                  
            {                  
                ParamProceedingStatusID = new(defProceedingStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetComments(string v)                  
            {                  
                ParamComments = new(defComments, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetNextExpectedExecutionTime(DateTime? v)                  
            {                  
                ParamNextExpectedExecutionTime = new(defNextExpectedExecutionTime, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsSuccessful(bool v)                  
            {                  
                ParamIsSuccessful = new(defIsSuccessful, v);                  
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
            int CronjobID
,            int ProceedingStatusID
,            bool IsSuccessful
,            DateTime CreatedAt
,            string Comments = null
,            DateTime? NextExpectedExecutionTime = null
          ){

                DataColumnParameter paramCronjobID = new (defCronjobID, CronjobID);
                DataColumnParameter paramProceedingStatusID = new (defProceedingStatusID, ProceedingStatusID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramNextExpectedExecutionTime = new (defNextExpectedExecutionTime, NextExpectedExecutionTime);
                DataColumnParameter paramIsSuccessful = new (defIsSuccessful, IsSuccessful);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6})  ", TABLE_NAME,
                        paramCronjobID.GetSQLValue(),
                        paramProceedingStatusID.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramNextExpectedExecutionTime.GetSQLValue(),
                        paramIsSuccessful.GetSQLValue(),
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
,            int CronjobID
,            int ProceedingStatusID
,            bool IsSuccessful
,            DateTime CreatedAt
,            string Comments = null
,            DateTime? NextExpectedExecutionTime = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCronjobID = new (defCronjobID, CronjobID);
                DataColumnParameter paramProceedingStatusID = new (defProceedingStatusID, ProceedingStatusID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramNextExpectedExecutionTime = new (defNextExpectedExecutionTime, NextExpectedExecutionTime);
                DataColumnParameter paramIsSuccessful = new (defIsSuccessful, IsSuccessful);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCronjobID.GetSQLValue(),
                        paramProceedingStatusID.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramNextExpectedExecutionTime.GetSQLValue(),
                        paramIsSuccessful.GetSQLValue(),
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
            int CronjobID
,            int ProceedingStatusID
,            bool IsSuccessful
,            DateTime CreatedAt
,            string Comments = null
,            DateTime? NextExpectedExecutionTime = null
          ){

                DataColumnParameter paramCronjobID = new (defCronjobID, CronjobID);
                DataColumnParameter paramProceedingStatusID = new (defProceedingStatusID, ProceedingStatusID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramNextExpectedExecutionTime = new (defNextExpectedExecutionTime, NextExpectedExecutionTime);
                DataColumnParameter paramIsSuccessful = new (defIsSuccessful, IsSuccessful);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6})  ", TABLE_NAME,
                        paramCronjobID.GetSQLValue(),
                        paramProceedingStatusID.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramNextExpectedExecutionTime.GetSQLValue(),
                        paramIsSuccessful.GetSQLValue(),
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
