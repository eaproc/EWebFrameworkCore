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

    public class T___Expenditure : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Expenditure()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCashRequestID = new DataColumnDefinition(TableColumnNames.CashRequestID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCharges = new DataColumnDefinition(TableColumnNames.Charges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSpentAmount = new DataColumnDefinition(TableColumnNames.SpentAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChargesComments = new DataColumnDefinition(TableColumnNames.ChargesComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCashRequestID.ColumnName, defCashRequestID); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
          ColumnDefns.Add(defCharges.ColumnName, defCharges); 
          ColumnDefns.Add(defSpentAmount.ColumnName, defSpentAmount); 
          ColumnDefns.Add(defChargesComments.ColumnName, defChargesComments); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "academic.Term"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_CashRequestID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "accounting.CashRequest"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "import.DataMonitor"                  
                            ));                  

          }


                  
       public T___Expenditure() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Expenditure(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(DataTable FullTable) : base(FullTable)                                    
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
        public T___Expenditure(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.Expenditure";
       public const string Expenditure__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TermID], [IpAddress], [CreatedAt], [CreatedByID], [CashRequestID], [Total], [DataMonitorID], [Charges], [SpentAmount], [ChargesComments] FROM accounting.Expenditure";
       public const string Expenditure__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TermID], [IpAddress], [CreatedAt], [CreatedByID], [CashRequestID], [Total], [DataMonitorID], [Charges], [SpentAmount], [ChargesComments] FROM accounting.Expenditure";


       public enum TableColumnNames
       {

           ID,
           TermID,
           IpAddress,
           CreatedAt,
           CreatedByID,
           CashRequestID,
           Total,
           DataMonitorID,
           Charges,
           SpentAmount,
           ChargesComments
       } 



       public enum TableConstraints{

           pk_accounting_Expenditure, 
           fk_accounting_Expenditure_TermID, 
           fk_accounting_Expenditure_CreatedByID, 
           fk_accounting_Expenditure_CashRequestID, 
           fk_accounting_Expenditure_DataMonitorID, 
           uq_accounting_Expenditure_CashRequestID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCashRequestID;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defDataMonitorID;
       public static readonly DataColumnDefinition defCharges;
       public static readonly DataColumnDefinition defSpentAmount;
       public static readonly DataColumnDefinition defChargesComments;

       public int TermID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermID.ToString());  set => TargettedRow[TableColumnNames.TermID.ToString()] = value; }


       public string IpAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IpAddress.ToString());  set => TargettedRow[TableColumnNames.IpAddress.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int CashRequestID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CashRequestID.ToString());  set => TargettedRow[TableColumnNames.CashRequestID.ToString()] = value; }


       public decimal Total { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Total.ToString());  set => TargettedRow[TableColumnNames.Total.ToString()] = value; }


       public int? DataMonitorID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.DataMonitorID.ToString());  set => TargettedRow[TableColumnNames.DataMonitorID.ToString()] = value; }


       public decimal Charges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Charges.ToString());  set => TargettedRow[TableColumnNames.Charges.ToString()] = value; }


       public decimal SpentAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.SpentAmount.ToString());  set => TargettedRow[TableColumnNames.SpentAmount.ToString()] = value; }


       public string ChargesComments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ChargesComments.ToString());  set => TargettedRow[TableColumnNames.ChargesComments.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Expenditure GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Expenditure GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___Expenditure(conn.Fetch(Expenditure__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___Expenditure GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___Expenditure( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___Expenditure GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Expenditure__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTermID;
            private DataColumnParameter ParamIpAddress;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamCashRequestID;
            private DataColumnParameter ParamTotal;
            private DataColumnParameter ParamDataMonitorID;
            private DataColumnParameter ParamCharges;
            private DataColumnParameter ParamSpentAmount;
            private DataColumnParameter ParamChargesComments;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Expenditure v):this(v.ID)                  
            {                  

                ParamTermID = new(defTermID, v.TermID);                  
                ParamIpAddress = new(defIpAddress, v.IpAddress);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamCashRequestID = new(defCashRequestID, v.CashRequestID);                  
                ParamTotal = new(defTotal, v.Total);                  
                ParamDataMonitorID = new(defDataMonitorID, v.DataMonitorID);                  
                ParamCharges = new(defCharges, v.Charges);                  
                ParamSpentAmount = new(defSpentAmount, v.SpentAmount);                  
                ParamChargesComments = new(defChargesComments, v.ChargesComments);                  
            }                  
                  
            public UpdateQueryBuilder SetTermID(int v)                  
            {                  
                ParamTermID = new(defTermID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIpAddress(string v)                  
            {                  
                ParamIpAddress = new(defIpAddress, v);                  
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
                  
            public UpdateQueryBuilder SetCashRequestID(int v)                  
            {                  
                ParamCashRequestID = new(defCashRequestID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTotal(decimal v)                  
            {                  
                ParamTotal = new(defTotal, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDataMonitorID(int? v)                  
            {                  
                ParamDataMonitorID = new(defDataMonitorID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCharges(decimal v)                  
            {                  
                ParamCharges = new(defCharges, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSpentAmount(decimal v)                  
            {                  
                ParamSpentAmount = new(defSpentAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChargesComments(string v)                  
            {                  
                ParamChargesComments = new(defChargesComments, v);                  
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
            int TermID
,            string IpAddress
,            DateTime CreatedAt
,            int CreatedByID
,            int CashRequestID
,            decimal Total
,            decimal Charges
,            decimal SpentAmount
,            int? DataMonitorID = null
,            string ChargesComments = null
          ){

                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCashRequestID = new (defCashRequestID, CashRequestID);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramSpentAmount = new (defSpentAmount, SpentAmount);
                DataColumnParameter paramChargesComments = new (defChargesComments, ChargesComments);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TermID],[IpAddress],[CreatedAt],[CreatedByID],[CashRequestID],[Total],[DataMonitorID],[Charges],[SpentAmount],[ChargesComments]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramTermID.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCashRequestID.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramSpentAmount.GetSQLValue(),
                        paramChargesComments.GetSQLValue()                        )
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
,            int TermID
,            string IpAddress
,            DateTime CreatedAt
,            int CreatedByID
,            int CashRequestID
,            decimal Total
,            decimal Charges
,            decimal SpentAmount
,            int? DataMonitorID = null
,            string ChargesComments = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCashRequestID = new (defCashRequestID, CashRequestID);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramSpentAmount = new (defSpentAmount, SpentAmount);
                DataColumnParameter paramChargesComments = new (defChargesComments, ChargesComments);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[IpAddress],[CreatedAt],[CreatedByID],[CashRequestID],[Total],[DataMonitorID],[Charges],[SpentAmount],[ChargesComments]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCashRequestID.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramSpentAmount.GetSQLValue(),
                        paramChargesComments.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int TermID
,            string IpAddress
,            DateTime CreatedAt
,            int CreatedByID
,            int CashRequestID
,            decimal Total
,            decimal Charges
,            decimal SpentAmount
,            int? DataMonitorID = null
,            string ChargesComments = null
          ){

                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCashRequestID = new (defCashRequestID, CashRequestID);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramSpentAmount = new (defSpentAmount, SpentAmount);
                DataColumnParameter paramChargesComments = new (defChargesComments, ChargesComments);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TermID],[IpAddress],[CreatedAt],[CreatedByID],[CashRequestID],[Total],[DataMonitorID],[Charges],[SpentAmount],[ChargesComments]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramTermID.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCashRequestID.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramDataMonitorID.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramSpentAmount.GetSQLValue(),
                        paramChargesComments.GetSQLValue()                            
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
