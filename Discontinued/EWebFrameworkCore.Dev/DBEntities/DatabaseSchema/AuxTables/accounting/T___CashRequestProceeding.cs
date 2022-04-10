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

    public class T___CashRequestProceeding : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CashRequestProceeding()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCashRequestID = new DataColumnDefinition(TableColumnNames.CashRequestID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCashRequestStatusID = new DataColumnDefinition(TableColumnNames.CashRequestStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRevisedAmount = new DataColumnDefinition(TableColumnNames.RevisedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDocumentFileName = new DataColumnDefinition(TableColumnNames.DocumentFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defCashRequestID.ColumnName, defCashRequestID); 
          ColumnDefns.Add(defCashRequestStatusID.ColumnName, defCashRequestStatusID); 
          ColumnDefns.Add(defRevisedAmount.ColumnName, defRevisedAmount); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defDocumentFileName.ColumnName, defDocumentFileName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CashRequestStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequestProceeding", "accounting.CashRequestStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequestProceeding", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CashRequestID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.CashRequestProceeding", "accounting.CashRequest"                  
                            ));                  

          }


                  
       public T___CashRequestProceeding() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CashRequestProceeding(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(DataTable FullTable) : base(FullTable)                                    
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
        public T___CashRequestProceeding(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.CashRequestProceeding";
       public const string CashRequestProceeding__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Title], [CashRequestID], [CashRequestStatusID], [RevisedAmount], [Comments], [DocumentFileName], [CreatedAt], [CreatedByID] FROM accounting.CashRequestProceeding";
       public const string CashRequestProceeding__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Title], [CashRequestID], [CashRequestStatusID], [RevisedAmount], [Comments], [DocumentFileName], [CreatedAt], [CreatedByID] FROM accounting.CashRequestProceeding";


       public enum TableColumnNames
       {

           ID,
           Title,
           CashRequestID,
           CashRequestStatusID,
           RevisedAmount,
           Comments,
           DocumentFileName,
           CreatedAt,
           CreatedByID
       } 



       public enum TableConstraints{

           pk_accounting_CashRequestProceeding, 
           fk_accounting_CashRequestProceeding_CashRequestStatusID, 
           fk_accounting_CashRequestProceeding_CreatedByID, 
           fk_accounting_CashRequestProceeding_CashRequestID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defCashRequestID;
       public static readonly DataColumnDefinition defCashRequestStatusID;
       public static readonly DataColumnDefinition defRevisedAmount;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defDocumentFileName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;

       public string Title { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Title.ToString());  set => TargettedRow[TableColumnNames.Title.ToString()] = value; }


       public int CashRequestID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CashRequestID.ToString());  set => TargettedRow[TableColumnNames.CashRequestID.ToString()] = value; }


       public int CashRequestStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CashRequestStatusID.ToString());  set => TargettedRow[TableColumnNames.CashRequestStatusID.ToString()] = value; }


       public decimal RevisedAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RevisedAmount.ToString());  set => TargettedRow[TableColumnNames.RevisedAmount.ToString()] = value; }


       public string Comments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Comments.ToString());  set => TargettedRow[TableColumnNames.Comments.ToString()] = value; }


       public string DocumentFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.DocumentFileName.ToString());  set => TargettedRow[TableColumnNames.DocumentFileName.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___CashRequestProceeding GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___CashRequestProceeding GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___CashRequestProceeding(conn.Fetch(CashRequestProceeding__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___CashRequestProceeding GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___CashRequestProceeding( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___CashRequestProceeding GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CashRequestProceeding__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTitle;
            private DataColumnParameter ParamCashRequestID;
            private DataColumnParameter ParamCashRequestStatusID;
            private DataColumnParameter ParamRevisedAmount;
            private DataColumnParameter ParamComments;
            private DataColumnParameter ParamDocumentFileName;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___CashRequestProceeding v):this(v.ID)                  
            {                  

                ParamTitle = new(defTitle, v.Title);                  
                ParamCashRequestID = new(defCashRequestID, v.CashRequestID);                  
                ParamCashRequestStatusID = new(defCashRequestStatusID, v.CashRequestStatusID);                  
                ParamRevisedAmount = new(defRevisedAmount, v.RevisedAmount);                  
                ParamComments = new(defComments, v.Comments);                  
                ParamDocumentFileName = new(defDocumentFileName, v.DocumentFileName);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetTitle(string v)                  
            {                  
                ParamTitle = new(defTitle, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCashRequestID(int v)                  
            {                  
                ParamCashRequestID = new(defCashRequestID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCashRequestStatusID(int v)                  
            {                  
                ParamCashRequestStatusID = new(defCashRequestStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRevisedAmount(decimal v)                  
            {                  
                ParamRevisedAmount = new(defRevisedAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetComments(string v)                  
            {                  
                ParamComments = new(defComments, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDocumentFileName(string v)                  
            {                  
                ParamDocumentFileName = new(defDocumentFileName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
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
            string Title
,            int CashRequestID
,            int CashRequestStatusID
,            decimal RevisedAmount
,            string Comments
,            DateTime CreatedAt
,            int CreatedByID
,            string DocumentFileName = null
          ){

                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramCashRequestID = new (defCashRequestID, CashRequestID);
                DataColumnParameter paramCashRequestStatusID = new (defCashRequestStatusID, CashRequestStatusID);
                DataColumnParameter paramRevisedAmount = new (defRevisedAmount, RevisedAmount);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramDocumentFileName = new (defDocumentFileName, DocumentFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramTitle.GetSQLValue(),
                        paramCashRequestID.GetSQLValue(),
                        paramCashRequestStatusID.GetSQLValue(),
                        paramRevisedAmount.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramDocumentFileName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue()                        )
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
,            string Title
,            int CashRequestID
,            int CashRequestStatusID
,            decimal RevisedAmount
,            string Comments
,            DateTime CreatedAt
,            int CreatedByID
,            string DocumentFileName = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramCashRequestID = new (defCashRequestID, CashRequestID);
                DataColumnParameter paramCashRequestStatusID = new (defCashRequestStatusID, CashRequestStatusID);
                DataColumnParameter paramRevisedAmount = new (defRevisedAmount, RevisedAmount);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramDocumentFileName = new (defDocumentFileName, DocumentFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTitle.GetSQLValue(),
                        paramCashRequestID.GetSQLValue(),
                        paramCashRequestStatusID.GetSQLValue(),
                        paramRevisedAmount.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramDocumentFileName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            string Title
,            int CashRequestID
,            int CashRequestStatusID
,            decimal RevisedAmount
,            string Comments
,            DateTime CreatedAt
,            int CreatedByID
,            string DocumentFileName = null
          ){

                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramCashRequestID = new (defCashRequestID, CashRequestID);
                DataColumnParameter paramCashRequestStatusID = new (defCashRequestStatusID, CashRequestStatusID);
                DataColumnParameter paramRevisedAmount = new (defRevisedAmount, RevisedAmount);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramDocumentFileName = new (defDocumentFileName, DocumentFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramTitle.GetSQLValue(),
                        paramCashRequestID.GetSQLValue(),
                        paramCashRequestStatusID.GetSQLValue(),
                        paramRevisedAmount.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramDocumentFileName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue()                            
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
