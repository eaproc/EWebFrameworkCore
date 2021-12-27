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

    public class T___AccountingExpenditureDisbursed : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___AccountingExpenditureDisbursed()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defImportStatusID = new DataColumnDefinition(TableColumnNames.ImportStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRequest = new DataColumnDefinition(TableColumnNames.Request.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedDate = new DataColumnDefinition(TableColumnNames.DisbursedDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCategory = new DataColumnDefinition(TableColumnNames.Category.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiary = new DataColumnDefinition(TableColumnNames.Beneficiary.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNotes = new DataColumnDefinition(TableColumnNames.Notes.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defImportComment = new DataColumnDefinition(TableColumnNames.ImportComment.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
          ColumnDefns.Add(defImportStatusID.ColumnName, defImportStatusID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defDisbursedDate.ColumnName, defDisbursedDate); 
          ColumnDefns.Add(defCategory.ColumnName, defCategory); 
          ColumnDefns.Add(defBeneficiary.ColumnName, defBeneficiary); 
          ColumnDefns.Add(defNotes.ColumnName, defNotes); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defImportComment.ColumnName, defImportComment); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "import.AccountingExpenditureDisbursed", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_ImportStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.AccountingExpenditureDisbursed", "import.ImportStatus"                  
                            ));                  

          }


                  
       public T___AccountingExpenditureDisbursed() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___AccountingExpenditureDisbursed(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(DataTable FullTable) : base(FullTable)                                    
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
        public T___AccountingExpenditureDisbursed(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "import.AccountingExpenditureDisbursed";
       public const string AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM import.AccountingExpenditureDisbursed";
       public const string AccountingExpenditureDisbursed__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM import.AccountingExpenditureDisbursed";


       public enum TableColumnNames
       {

           ID,
           DataMonitorID,
           ImportStatusID,
           Request,
           DisbursedDate,
           Category,
           Beneficiary,
           Notes,
           Total,
           ImportComment,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_import_AccountingExpenditureDisbursed, 
           fk_import_AccountingExpenditureDisbursed_DataMonitorID, 
           fk_import_AccountingExpenditureDisbursed_ImportStatusID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDataMonitorID;
       public static readonly DataColumnDefinition defImportStatusID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defDisbursedDate;
       public static readonly DataColumnDefinition defCategory;
       public static readonly DataColumnDefinition defBeneficiary;
       public static readonly DataColumnDefinition defNotes;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defImportComment;
       public static readonly DataColumnDefinition defCreatedAt;

       public int DataMonitorID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DataMonitorID.ToString());  set => TargettedRow[TableColumnNames.DataMonitorID.ToString()] = value; }


       public int ImportStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ImportStatusID.ToString());  set => TargettedRow[TableColumnNames.ImportStatusID.ToString()] = value; }


       public string Request { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Request.ToString());  set => TargettedRow[TableColumnNames.Request.ToString()] = value; }


       public DateTime DisbursedDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.DisbursedDate.ToString());  set => TargettedRow[TableColumnNames.DisbursedDate.ToString()] = value; }


       public string Category { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Category.ToString());  set => TargettedRow[TableColumnNames.Category.ToString()] = value; }


       public string Beneficiary { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Beneficiary.ToString());  set => TargettedRow[TableColumnNames.Beneficiary.ToString()] = value; }


       public string Notes { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Notes.ToString());  set => TargettedRow[TableColumnNames.Notes.ToString()] = value; }


       public decimal Total { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Total.ToString());  set => TargettedRow[TableColumnNames.Total.ToString()] = value; }


       public string ImportComment { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ImportComment.ToString());  set => TargettedRow[TableColumnNames.ImportComment.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___AccountingExpenditureDisbursed GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___AccountingExpenditureDisbursed GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___AccountingExpenditureDisbursed(conn.Fetch(AccountingExpenditureDisbursed__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___AccountingExpenditureDisbursed GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___AccountingExpenditureDisbursed( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___AccountingExpenditureDisbursed GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamDataMonitorID;
            private DataColumnParameter ParamImportStatusID;
            private DataColumnParameter ParamRequest;
            private DataColumnParameter ParamDisbursedDate;
            private DataColumnParameter ParamCategory;
            private DataColumnParameter ParamBeneficiary;
            private DataColumnParameter ParamNotes;
            private DataColumnParameter ParamTotal;
            private DataColumnParameter ParamImportComment;
            private DataColumnParameter ParamCreatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___AccountingExpenditureDisbursed v):this(v.ID)                  
            {                  

                ParamDataMonitorID = new(defDataMonitorID, v.DataMonitorID);                  
                ParamImportStatusID = new(defImportStatusID, v.ImportStatusID);                  
                ParamRequest = new(defRequest, v.Request);                  
                ParamDisbursedDate = new(defDisbursedDate, v.DisbursedDate);                  
                ParamCategory = new(defCategory, v.Category);                  
                ParamBeneficiary = new(defBeneficiary, v.Beneficiary);                  
                ParamNotes = new(defNotes, v.Notes);                  
                ParamTotal = new(defTotal, v.Total);                  
                ParamImportComment = new(defImportComment, v.ImportComment);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetDataMonitorID(int v)                  
            {                  
                ParamDataMonitorID = new(defDataMonitorID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetImportStatusID(int v)                  
            {                  
                ParamImportStatusID = new(defImportStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRequest(string v)                  
            {                  
                ParamRequest = new(defRequest, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDisbursedDate(DateTime v)                  
            {                  
                ParamDisbursedDate = new(defDisbursedDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCategory(string v)                  
            {                  
                ParamCategory = new(defCategory, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBeneficiary(string v)                  
            {                  
                ParamBeneficiary = new(defBeneficiary, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetNotes(string v)                  
            {                  
                ParamNotes = new(defNotes, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTotal(decimal v)                  
            {                  
                ParamTotal = new(defTotal, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetImportComment(string v)                  
            {                  
                ParamImportComment = new(defImportComment, v);                  
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
            int DataMonitorID,
            int ImportStatusID,
            string Request,
            DateTime DisbursedDate,
            string Category,
            string Beneficiary,
            decimal Total,
            string ImportComment,
            DateTime CreatedAt,
            string Notes = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramImportStatusID = new (defImportStatusID, ImportStatusID);
                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramDisbursedDate = new (defDisbursedDate, DisbursedDate);
                DataColumnParameter paramCategory = new (defCategory, Category);
                DataColumnParameter paramBeneficiary = new (defBeneficiary, Beneficiary);
                DataColumnParameter paramNotes = new (defNotes, Notes);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramImportComment = new (defImportComment, ImportComment);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramDataMonitorID.GetSQLValue(),
                        paramImportStatusID.GetSQLValue(),
                        paramRequest.GetSQLValue(),
                        paramDisbursedDate.GetSQLValue(),
                        paramCategory.GetSQLValue(),
                        paramBeneficiary.GetSQLValue(),
                        paramNotes.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramImportComment.GetSQLValue(),
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
        public static bool AddWithID(
            int ID,
            int DataMonitorID,
            int ImportStatusID,
            string Request,
            DateTime DisbursedDate,
            string Category,
            string Beneficiary,
            decimal Total,
            string ImportComment,
            DateTime CreatedAt,
            string Notes = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramImportStatusID = new (defImportStatusID, ImportStatusID);
                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramDisbursedDate = new (defDisbursedDate, DisbursedDate);
                DataColumnParameter paramCategory = new (defCategory, Category);
                DataColumnParameter paramBeneficiary = new (defBeneficiary, Beneficiary);
                DataColumnParameter paramNotes = new (defNotes, Notes);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramImportComment = new (defImportComment, ImportComment);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue(),
                        paramImportStatusID.GetSQLValue(),
                        paramRequest.GetSQLValue(),
                        paramDisbursedDate.GetSQLValue(),
                        paramCategory.GetSQLValue(),
                        paramBeneficiary.GetSQLValue(),
                        paramNotes.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramImportComment.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int DataMonitorID,
            int ImportStatusID,
            string Request,
            DateTime DisbursedDate,
            string Category,
            string Beneficiary,
            decimal Total,
            string ImportComment,
            DateTime CreatedAt,
            string Notes = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramImportStatusID = new (defImportStatusID, ImportStatusID);
                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramDisbursedDate = new (defDisbursedDate, DisbursedDate);
                DataColumnParameter paramCategory = new (defCategory, Category);
                DataColumnParameter paramBeneficiary = new (defBeneficiary, Beneficiary);
                DataColumnParameter paramNotes = new (defNotes, Notes);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramImportComment = new (defImportComment, ImportComment);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramDataMonitorID.GetSQLValue(),
                        paramImportStatusID.GetSQLValue(),
                        paramRequest.GetSQLValue(),
                        paramDisbursedDate.GetSQLValue(),
                        paramCategory.GetSQLValue(),
                        paramBeneficiary.GetSQLValue(),
                        paramNotes.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramImportComment.GetSQLValue(),
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
