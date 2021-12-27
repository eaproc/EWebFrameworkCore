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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___PaymentTransactionAudit : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaymentTransactionAudit()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionStatusID = new DataColumnDefinition(TableColumnNames.TransactionStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentTransactionID = new DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(TableColumnNames.Bank.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequired = new DataColumnDefinition(TableColumnNames.PaymentRequired.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharges = new DataColumnDefinition(TableColumnNames.Charges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRefundAmount = new DataColumnDefinition(TableColumnNames.RefundAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTransactionStatusID.ColumnName, defTransactionStatusID); 
          ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defBank.ColumnName, defBank); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defPaymentRequired.ColumnName, defPaymentRequired); 
          ColumnDefns.Add(defCharges.ColumnName, defCharges); 
          ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges); 
          ColumnDefns.Add(defRefundAmount.ColumnName, defRefundAmount); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransactionAudit_TransactionStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransactionAudit", "pay_gateway.TransactionStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransactionAudit_PaymentTransactionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "pay_gateway.PaymentTransactionAudit", "pay_gateway.PaymentTransaction"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransactionAudit_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransactionAudit", "auth.Users"                  
                            ));                  

          }


                  
       public T___PaymentTransactionAudit() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaymentTransactionAudit(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(DataTable FullTable) : base(FullTable)                                    
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
        public T___PaymentTransactionAudit(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.PaymentTransactionAudit";
       public const string PaymentTransactionAudit__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [PaymentTransactionID], [AccountName], [Bank], [IPAddress], [PaymentRequired], [Charges], [PaymentRequiredWithoutCharges], [RefundAmount], [Balance], [CreatedAt], [CreatedByID] FROM pay_gateway.PaymentTransactionAudit";
       public const string PaymentTransactionAudit__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [PaymentTransactionID], [AccountName], [Bank], [IPAddress], [PaymentRequired], [Charges], [PaymentRequiredWithoutCharges], [RefundAmount], [Balance], [CreatedAt], [CreatedByID] FROM pay_gateway.PaymentTransactionAudit";


       public enum TableColumnNames
       {

           ID,
           TransactionStatusID,
           PaymentTransactionID,
           AccountName,
           Bank,
           IPAddress,
           PaymentRequired,
           Charges,
           PaymentRequiredWithoutCharges,
           RefundAmount,
           Balance,
           CreatedAt,
           CreatedByID
       } 



       public enum TableConstraints{

           pk_pay_gateway_PaymentTransactionAudit, 
           fk_pay_gateway_PaymentTransactionAudit_TransactionStatusID, 
           fk_PaymentTransactionAudit_PaymentTransactionID, 
           fk_PaymentTransactionAudit_CreatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTransactionStatusID;
       public static readonly DataColumnDefinition defPaymentTransactionID;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defBank;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defPaymentRequired;
       public static readonly DataColumnDefinition defCharges;
       public static readonly DataColumnDefinition defPaymentRequiredWithoutCharges;
       public static readonly DataColumnDefinition defRefundAmount;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;

       public int TransactionStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TransactionStatusID.ToString());  set => TargettedRow[TableColumnNames.TransactionStatusID.ToString()] = value; }


       public int PaymentTransactionID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PaymentTransactionID.ToString());  set => TargettedRow[TableColumnNames.PaymentTransactionID.ToString()] = value; }


       public string AccountName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountName.ToString());  set => TargettedRow[TableColumnNames.AccountName.ToString()] = value; }


       public string Bank { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Bank.ToString());  set => TargettedRow[TableColumnNames.Bank.ToString()] = value; }


       public string IPAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IPAddress.ToString());  set => TargettedRow[TableColumnNames.IPAddress.ToString()] = value; }


       public decimal PaymentRequired { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PaymentRequired.ToString());  set => TargettedRow[TableColumnNames.PaymentRequired.ToString()] = value; }


       public decimal Charges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Charges.ToString());  set => TargettedRow[TableColumnNames.Charges.ToString()] = value; }


       public decimal PaymentRequiredWithoutCharges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PaymentRequiredWithoutCharges.ToString());  set => TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()] = value; }


       public decimal RefundAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RefundAmount.ToString());  set => TargettedRow[TableColumnNames.RefundAmount.ToString()] = value; }


       public decimal Balance { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Balance.ToString());  set => TargettedRow[TableColumnNames.Balance.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PaymentTransactionAudit GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PaymentTransactionAudit GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___PaymentTransactionAudit(conn.Fetch(PaymentTransactionAudit__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___PaymentTransactionAudit GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___PaymentTransactionAudit( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___PaymentTransactionAudit GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PaymentTransactionAudit__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTransactionStatusID;
            private DataColumnParameter ParamPaymentTransactionID;
            private DataColumnParameter ParamAccountName;
            private DataColumnParameter ParamBank;
            private DataColumnParameter ParamIPAddress;
            private DataColumnParameter ParamPaymentRequired;
            private DataColumnParameter ParamCharges;
            private DataColumnParameter ParamPaymentRequiredWithoutCharges;
            private DataColumnParameter ParamRefundAmount;
            private DataColumnParameter ParamBalance;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PaymentTransactionAudit v):this(v.ID)                  
            {                  

                ParamTransactionStatusID = new(defTransactionStatusID, v.TransactionStatusID);                  
                ParamPaymentTransactionID = new(defPaymentTransactionID, v.PaymentTransactionID);                  
                ParamAccountName = new(defAccountName, v.AccountName);                  
                ParamBank = new(defBank, v.Bank);                  
                ParamIPAddress = new(defIPAddress, v.IPAddress);                  
                ParamPaymentRequired = new(defPaymentRequired, v.PaymentRequired);                  
                ParamCharges = new(defCharges, v.Charges);                  
                ParamPaymentRequiredWithoutCharges = new(defPaymentRequiredWithoutCharges, v.PaymentRequiredWithoutCharges);                  
                ParamRefundAmount = new(defRefundAmount, v.RefundAmount);                  
                ParamBalance = new(defBalance, v.Balance);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionStatusID(int v)                  
            {                  
                ParamTransactionStatusID = new(defTransactionStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentTransactionID(int v)                  
            {                  
                ParamPaymentTransactionID = new(defPaymentTransactionID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccountName(string v)                  
            {                  
                ParamAccountName = new(defAccountName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBank(string v)                  
            {                  
                ParamBank = new(defBank, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIPAddress(string v)                  
            {                  
                ParamIPAddress = new(defIPAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentRequired(decimal v)                  
            {                  
                ParamPaymentRequired = new(defPaymentRequired, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCharges(decimal v)                  
            {                  
                ParamCharges = new(defCharges, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentRequiredWithoutCharges(decimal v)                  
            {                  
                ParamPaymentRequiredWithoutCharges = new(defPaymentRequiredWithoutCharges, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRefundAmount(decimal v)                  
            {                  
                ParamRefundAmount = new(defRefundAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBalance(decimal v)                  
            {                  
                ParamBalance = new(defBalance, v);                  
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
            int TransactionStatusID,
            int PaymentTransactionID,
            string AccountName,
            string Bank,
            string IPAddress,
            decimal PaymentRequired,
            decimal Charges,
            decimal PaymentRequiredWithoutCharges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionStatusID],[PaymentTransactionID],[AccountName],[Bank],[IPAddress],[PaymentRequired],[Charges],[PaymentRequiredWithoutCharges],[RefundAmount],[Balance],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramTransactionStatusID.GetSQLValue(),
                        paramPaymentTransactionID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramPaymentRequired.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue(),
                        paramRefundAmount.GetSQLValue(),
                        paramBalance.GetSQLValue(),
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
        public static bool AddWithID(
            int ID,
            int TransactionStatusID,
            int PaymentTransactionID,
            string AccountName,
            string Bank,
            string IPAddress,
            decimal PaymentRequired,
            decimal Charges,
            decimal PaymentRequiredWithoutCharges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[PaymentTransactionID],[AccountName],[Bank],[IPAddress],[PaymentRequired],[Charges],[PaymentRequiredWithoutCharges],[RefundAmount],[Balance],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTransactionStatusID.GetSQLValue(),
                        paramPaymentTransactionID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramPaymentRequired.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue(),
                        paramRefundAmount.GetSQLValue(),
                        paramBalance.GetSQLValue(),
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
        public static bool Add(
            int TransactionStatusID,
            int PaymentTransactionID,
            string AccountName,
            string Bank,
            string IPAddress,
            decimal PaymentRequired,
            decimal Charges,
            decimal PaymentRequiredWithoutCharges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionStatusID],[PaymentTransactionID],[AccountName],[Bank],[IPAddress],[PaymentRequired],[Charges],[PaymentRequiredWithoutCharges],[RefundAmount],[Balance],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramTransactionStatusID.GetSQLValue(),
                        paramPaymentTransactionID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramPaymentRequired.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue(),
                        paramRefundAmount.GetSQLValue(),
                        paramBalance.GetSQLValue(),
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
