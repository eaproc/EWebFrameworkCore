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

    public class T___CashRequest : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CashRequest()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defRequest = new DataColumnDefinition(TableColumnNames.Request.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpenditureCategoryID = new DataColumnDefinition(TableColumnNames.ExpenditureCategoryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAmount = new DataColumnDefinition(TableColumnNames.Amount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeadline = new DataColumnDefinition(TableColumnNames.Deadline.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTrackingID = new DataColumnDefinition(TableColumnNames.TrackingID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defExpenditureCategoryID.ColumnName, defExpenditureCategoryID); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defDeadline.ColumnName, defDeadline); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defTrackingID.ColumnName, defTrackingID); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_ExpenditureCategoryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "accounting.ExpenditureCategory"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "common.Person"                  
                            ));                  

          }


                  
       public T___CashRequest() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CashRequest(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(DataTable FullTable) : base(FullTable)                                    
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
        public T___CashRequest(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.CashRequest";
       public const string CashRequest__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Request], [ExpenditureCategoryID], [Amount], [Deadline], [CreatedAt], [CreatedByID], [BeneficiaryID], [TrackingID], [DataMonitorID] FROM accounting.CashRequest";
       public const string CashRequest__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Request], [ExpenditureCategoryID], [Amount], [Deadline], [CreatedAt], [CreatedByID], [BeneficiaryID], [TrackingID], [DataMonitorID] FROM accounting.CashRequest";


       public enum TableColumnNames
       {

           ID,
           Request,
           ExpenditureCategoryID,
           Amount,
           Deadline,
           CreatedAt,
           CreatedByID,
           BeneficiaryID,
           TrackingID,
           DataMonitorID
       } 



       public enum TableConstraints{

           pk_accounting_CashRequest, 
           fk_accounting_CashRequest_DataMonitorID, 
           fk_accounting_CashRequest_ExpenditureCategoryID, 
           fk_accounting_CashRequest_CreatedByID, 
           fk_accounting_CashRequest_BeneficiaryID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defExpenditureCategoryID;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defDeadline;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defTrackingID;
       public static readonly DataColumnDefinition defDataMonitorID;

       public string Request { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Request.ToString());  set => TargettedRow[TableColumnNames.Request.ToString()] = value; }


       public int ExpenditureCategoryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ExpenditureCategoryID.ToString());  set => TargettedRow[TableColumnNames.ExpenditureCategoryID.ToString()] = value; }


       public decimal Amount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Amount.ToString());  set => TargettedRow[TableColumnNames.Amount.ToString()] = value; }


       public DateTime Deadline { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.Deadline.ToString());  set => TargettedRow[TableColumnNames.Deadline.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int BeneficiaryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BeneficiaryID.ToString());  set => TargettedRow[TableColumnNames.BeneficiaryID.ToString()] = value; }


       public int? TrackingID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.TrackingID.ToString());  set => TargettedRow[TableColumnNames.TrackingID.ToString()] = value; }


       public int? DataMonitorID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.DataMonitorID.ToString());  set => TargettedRow[TableColumnNames.DataMonitorID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___CashRequest GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___CashRequest GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___CashRequest(conn.Fetch(CashRequest__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___CashRequest GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___CashRequest( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___CashRequest GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CashRequest__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamRequest;
            private DataColumnParameter ParamExpenditureCategoryID;
            private DataColumnParameter ParamAmount;
            private DataColumnParameter ParamDeadline;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamBeneficiaryID;
            private DataColumnParameter ParamTrackingID;
            private DataColumnParameter ParamDataMonitorID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___CashRequest v):this(v.ID)                  
            {                  

                ParamRequest = new(defRequest, v.Request);                  
                ParamExpenditureCategoryID = new(defExpenditureCategoryID, v.ExpenditureCategoryID);                  
                ParamAmount = new(defAmount, v.Amount);                  
                ParamDeadline = new(defDeadline, v.Deadline);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamBeneficiaryID = new(defBeneficiaryID, v.BeneficiaryID);                  
                ParamTrackingID = new(defTrackingID, v.TrackingID);                  
                ParamDataMonitorID = new(defDataMonitorID, v.DataMonitorID);                  
            }                  
                  
            public UpdateQueryBuilder SetRequest(string v)                  
            {                  
                ParamRequest = new(defRequest, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetExpenditureCategoryID(int v)                  
            {                  
                ParamExpenditureCategoryID = new(defExpenditureCategoryID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAmount(decimal v)                  
            {                  
                ParamAmount = new(defAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDeadline(DateTime v)                  
            {                  
                ParamDeadline = new(defDeadline, v);                  
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
                  
            public UpdateQueryBuilder SetBeneficiaryID(int v)                  
            {                  
                ParamBeneficiaryID = new(defBeneficiaryID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTrackingID(int? v)                  
            {                  
                ParamTrackingID = new(defTrackingID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDataMonitorID(int? v)                  
            {                  
                ParamDataMonitorID = new(defDataMonitorID, v);                  
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
            string Request
,            int ExpenditureCategoryID
,            decimal Amount
,            DateTime Deadline
,            DateTime CreatedAt
,            int CreatedByID
,            int BeneficiaryID
,            int? TrackingID = null
,            int? DataMonitorID = null
          ){

                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramExpenditureCategoryID = new (defExpenditureCategoryID, ExpenditureCategoryID);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramDeadline = new (defDeadline, Deadline);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramTrackingID = new (defTrackingID, TrackingID);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramRequest.GetSQLValue(),
                        paramExpenditureCategoryID.GetSQLValue(),
                        paramAmount.GetSQLValue(),
                        paramDeadline.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramTrackingID.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue()                        )
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
,            string Request
,            int ExpenditureCategoryID
,            decimal Amount
,            DateTime Deadline
,            DateTime CreatedAt
,            int CreatedByID
,            int BeneficiaryID
,            int? TrackingID = null
,            int? DataMonitorID = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramExpenditureCategoryID = new (defExpenditureCategoryID, ExpenditureCategoryID);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramDeadline = new (defDeadline, Deadline);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramTrackingID = new (defTrackingID, TrackingID);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramRequest.GetSQLValue(),
                        paramExpenditureCategoryID.GetSQLValue(),
                        paramAmount.GetSQLValue(),
                        paramDeadline.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramTrackingID.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            string Request
,            int ExpenditureCategoryID
,            decimal Amount
,            DateTime Deadline
,            DateTime CreatedAt
,            int CreatedByID
,            int BeneficiaryID
,            int? TrackingID = null
,            int? DataMonitorID = null
          ){

                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramExpenditureCategoryID = new (defExpenditureCategoryID, ExpenditureCategoryID);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramDeadline = new (defDeadline, Deadline);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramTrackingID = new (defTrackingID, TrackingID);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramRequest.GetSQLValue(),
                        paramExpenditureCategoryID.GetSQLValue(),
                        paramAmount.GetSQLValue(),
                        paramDeadline.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramTrackingID.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue()                            
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
