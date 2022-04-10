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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___DonationInvoiceItem : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___DonationInvoiceItem()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defMonthlyDonationID = new DataColumnDefinition(TableColumnNames.MonthlyDonationID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCashOutID = new DataColumnDefinition(TableColumnNames.CashOutID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDonationYear = new DataColumnDefinition(TableColumnNames.DonationYear.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defDonationMonth = new DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defAmount = new DataColumnDefinition(TableColumnNames.Amount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defMonthlyDonationID.ColumnName, defMonthlyDonationID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defCashOutID.ColumnName, defCashOutID); 
          ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear); 
          ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_MonthlyDonationID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.DonationInvoiceItem", "charity.MonthlyDonation"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "charity.Beneficiary"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_CashOutID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "charity.CashOut"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "auth.Users"                  
                            ));                  

          }


                  
       public T___DonationInvoiceItem() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___DonationInvoiceItem(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(DataTable FullTable) : base(FullTable)                                    
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
        public T___DonationInvoiceItem(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.DonationInvoiceItem";
       public const string DonationInvoiceItem__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [MonthlyDonationID], [BeneficiaryID], [CashOutID], [DonationYear], [DonationMonth], [Amount], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.DonationInvoiceItem";
       public const string DonationInvoiceItem__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [MonthlyDonationID], [BeneficiaryID], [CashOutID], [DonationYear], [DonationMonth], [Amount], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.DonationInvoiceItem";


       public enum TableColumnNames
       {

           ID,
           MonthlyDonationID,
           BeneficiaryID,
           CashOutID,
           DonationYear,
           DonationMonth,
           Amount,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_DonationInvoiceItem, 
           fk_charity_DonationInvoiceItem_MonthlyDonationID, 
           fk_charity_DonationInvoiceItem_BeneficiaryID, 
           fk_charity_DonationInvoiceItem_CashOutID, 
           fk_charity_DonationInvoiceItem_CreatedByID, 
           fk_charity_DonationInvoiceItem_UpdatedByID, 
           uq_charity_DonationInvoiceItem_BeneficiaryID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defMonthlyDonationID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defCashOutID;
       public static readonly DataColumnDefinition defDonationYear;
       public static readonly DataColumnDefinition defDonationMonth;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int MonthlyDonationID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.MonthlyDonationID.ToString());  set => TargettedRow[TableColumnNames.MonthlyDonationID.ToString()] = value; }


       public int BeneficiaryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BeneficiaryID.ToString());  set => TargettedRow[TableColumnNames.BeneficiaryID.ToString()] = value; }


       public int? CashOutID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.CashOutID.ToString());  set => TargettedRow[TableColumnNames.CashOutID.ToString()] = value; }


       public int DonationYear { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DonationYear.ToString());  set => TargettedRow[TableColumnNames.DonationYear.ToString()] = value; }


       public int DonationMonth { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DonationMonth.ToString());  set => TargettedRow[TableColumnNames.DonationMonth.ToString()] = value; }


       public decimal Amount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Amount.ToString());  set => TargettedRow[TableColumnNames.Amount.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime UpdatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int UpdatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___DonationInvoiceItem GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___DonationInvoiceItem GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___DonationInvoiceItem(conn.Fetch(DonationInvoiceItem__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___DonationInvoiceItem GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___DonationInvoiceItem( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___DonationInvoiceItem GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => DonationInvoiceItem__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamMonthlyDonationID;
            private DataColumnParameter ParamBeneficiaryID;
            private DataColumnParameter ParamCashOutID;
            private DataColumnParameter ParamDonationYear;
            private DataColumnParameter ParamDonationMonth;
            private DataColumnParameter ParamAmount;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___DonationInvoiceItem v):this(v.ID)                  
            {                  

                ParamMonthlyDonationID = new(defMonthlyDonationID, v.MonthlyDonationID);                  
                ParamBeneficiaryID = new(defBeneficiaryID, v.BeneficiaryID);                  
                ParamCashOutID = new(defCashOutID, v.CashOutID);                  
                ParamDonationYear = new(defDonationYear, v.DonationYear);                  
                ParamDonationMonth = new(defDonationMonth, v.DonationMonth);                  
                ParamAmount = new(defAmount, v.Amount);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetMonthlyDonationID(int v)                  
            {                  
                ParamMonthlyDonationID = new(defMonthlyDonationID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBeneficiaryID(int v)                  
            {                  
                ParamBeneficiaryID = new(defBeneficiaryID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCashOutID(int? v)                  
            {                  
                ParamCashOutID = new(defCashOutID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDonationYear(int v)                  
            {                  
                ParamDonationYear = new(defDonationYear, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDonationMonth(int v)                  
            {                  
                ParamDonationMonth = new(defDonationMonth, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAmount(decimal v)                  
            {                  
                ParamAmount = new(defAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int v)                  
            {                  
                ParamUpdatedByID = new(defUpdatedByID, v);                  
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
            int MonthlyDonationID
,            int BeneficiaryID
,            int DonationYear
,            int DonationMonth
,            decimal Amount
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            int? CashOutID = null
          ){

                DataColumnParameter paramMonthlyDonationID = new (defMonthlyDonationID, MonthlyDonationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramCashOutID = new (defCashOutID, CashOutID);
                DataColumnParameter paramDonationYear = new (defDonationYear, DonationYear);
                DataColumnParameter paramDonationMonth = new (defDonationMonth, DonationMonth);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([MonthlyDonationID],[BeneficiaryID],[CashOutID],[DonationYear],[DonationMonth],[Amount],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramMonthlyDonationID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramCashOutID.GetSQLValue(),
                        paramDonationYear.GetSQLValue(),
                        paramDonationMonth.GetSQLValue(),
                        paramAmount.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
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
,            int MonthlyDonationID
,            int BeneficiaryID
,            int DonationYear
,            int DonationMonth
,            decimal Amount
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            int? CashOutID = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramMonthlyDonationID = new (defMonthlyDonationID, MonthlyDonationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramCashOutID = new (defCashOutID, CashOutID);
                DataColumnParameter paramDonationYear = new (defDonationYear, DonationYear);
                DataColumnParameter paramDonationMonth = new (defDonationMonth, DonationMonth);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[MonthlyDonationID],[BeneficiaryID],[CashOutID],[DonationYear],[DonationMonth],[Amount],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramMonthlyDonationID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramCashOutID.GetSQLValue(),
                        paramDonationYear.GetSQLValue(),
                        paramDonationMonth.GetSQLValue(),
                        paramAmount.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int MonthlyDonationID
,            int BeneficiaryID
,            int DonationYear
,            int DonationMonth
,            decimal Amount
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            int? CashOutID = null
          ){

                DataColumnParameter paramMonthlyDonationID = new (defMonthlyDonationID, MonthlyDonationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramCashOutID = new (defCashOutID, CashOutID);
                DataColumnParameter paramDonationYear = new (defDonationYear, DonationYear);
                DataColumnParameter paramDonationMonth = new (defDonationMonth, DonationMonth);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([MonthlyDonationID],[BeneficiaryID],[CashOutID],[DonationYear],[DonationMonth],[Amount],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramMonthlyDonationID.GetSQLValue(),
                        paramBeneficiaryID.GetSQLValue(),
                        paramCashOutID.GetSQLValue(),
                        paramDonationYear.GetSQLValue(),
                        paramDonationMonth.GetSQLValue(),
                        paramAmount.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                            
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
