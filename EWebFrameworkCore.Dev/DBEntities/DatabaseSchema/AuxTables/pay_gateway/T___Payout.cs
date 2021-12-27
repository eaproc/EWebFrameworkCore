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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___Payout : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Payout()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaidInAmount = new DataColumnDefinition(TableColumnNames.PaidInAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaidInCharges = new DataColumnDefinition(TableColumnNames.PaidInCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayoutAmount = new DataColumnDefinition(TableColumnNames.PayoutAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayoutCharge = new DataColumnDefinition(TableColumnNames.PayoutCharge.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionStartDate = new DataColumnDefinition(TableColumnNames.TransactionStartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionEndDate = new DataColumnDefinition(TableColumnNames.TransactionEndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAwaitingPayout = new DataColumnDefinition(TableColumnNames.AwaitingPayout.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSynced = new DataColumnDefinition(TableColumnNames.Synced.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defPaidInAmount.ColumnName, defPaidInAmount); 
          ColumnDefns.Add(defPaidInCharges.ColumnName, defPaidInCharges); 
          ColumnDefns.Add(defPayoutAmount.ColumnName, defPayoutAmount); 
          ColumnDefns.Add(defPayoutCharge.ColumnName, defPayoutCharge); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defTransactionStartDate.ColumnName, defTransactionStartDate); 
          ColumnDefns.Add(defTransactionEndDate.ColumnName, defTransactionEndDate); 
          ColumnDefns.Add(defAwaitingPayout.ColumnName, defAwaitingPayout); 
          ColumnDefns.Add(defSynced.ColumnName, defSynced); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "common.Bank"                  
                            ));                  

          }


                  
       public T___Payout() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Payout(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(DataTable FullTable) : base(FullTable)                                    
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
        public T___Payout(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.Payout";
       public const string Payout__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM pay_gateway.Payout";
       public const string Payout__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM pay_gateway.Payout";


       public enum TableColumnNames
       {

           ID,
           CreatedByID,
           UpdatedByID,
           ClientID,
           PaidInAmount,
           PaidInCharges,
           PayoutAmount,
           PayoutCharge,
           Balance,
           TransactionStartDate,
           TransactionEndDate,
           AwaitingPayout,
           Synced,
           CreatedAt,
           UpdatedAt,
           BankID,
           AccountName,
           AccountNumber
       } 



       public enum TableConstraints{

           pk_pay_gateway_Payout, 
           fk_pay_gateway_Payout_CreatedByID, 
           fk_pay_gateway_Payout_UpdatedByID, 
           fk_pay_gateway_Payout_ClientID, 
           fk_hr_Client_BankID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defPaidInAmount;
       public static readonly DataColumnDefinition defPaidInCharges;
       public static readonly DataColumnDefinition defPayoutAmount;
       public static readonly DataColumnDefinition defPayoutCharge;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defTransactionStartDate;
       public static readonly DataColumnDefinition defTransactionEndDate;
       public static readonly DataColumnDefinition defAwaitingPayout;
       public static readonly DataColumnDefinition defSynced;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defAccountNumber;

       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int? UpdatedByID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public decimal PaidInAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PaidInAmount.ToString());  set => TargettedRow[TableColumnNames.PaidInAmount.ToString()] = value; }


       public decimal PaidInCharges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PaidInCharges.ToString());  set => TargettedRow[TableColumnNames.PaidInCharges.ToString()] = value; }


       public decimal PayoutAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PayoutAmount.ToString());  set => TargettedRow[TableColumnNames.PayoutAmount.ToString()] = value; }


       public decimal PayoutCharge { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PayoutCharge.ToString());  set => TargettedRow[TableColumnNames.PayoutCharge.ToString()] = value; }


       public decimal Balance { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Balance.ToString());  set => TargettedRow[TableColumnNames.Balance.ToString()] = value; }


       public DateTime TransactionStartDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.TransactionStartDate.ToString());  set => TargettedRow[TableColumnNames.TransactionStartDate.ToString()] = value; }


       public DateTime TransactionEndDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.TransactionEndDate.ToString());  set => TargettedRow[TableColumnNames.TransactionEndDate.ToString()] = value; }


       public bool? AwaitingPayout { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.AwaitingPayout.ToString());  set => TargettedRow[TableColumnNames.AwaitingPayout.ToString()] = value; }


       public bool? Synced { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.Synced.ToString());  set => TargettedRow[TableColumnNames.Synced.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int BankID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BankID.ToString());  set => TargettedRow[TableColumnNames.BankID.ToString()] = value; }


       public string AccountName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountName.ToString());  set => TargettedRow[TableColumnNames.AccountName.ToString()] = value; }


       public string AccountNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountNumber.ToString());  set => TargettedRow[TableColumnNames.AccountNumber.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Payout GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Payout GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___Payout(conn.Fetch(Payout__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___Payout GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___Payout( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___Payout GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Payout__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;
            private DataColumnParameter ParamClientID;
            private DataColumnParameter ParamPaidInAmount;
            private DataColumnParameter ParamPaidInCharges;
            private DataColumnParameter ParamPayoutAmount;
            private DataColumnParameter ParamPayoutCharge;
            private DataColumnParameter ParamBalance;
            private DataColumnParameter ParamTransactionStartDate;
            private DataColumnParameter ParamTransactionEndDate;
            private DataColumnParameter ParamAwaitingPayout;
            private DataColumnParameter ParamSynced;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamBankID;
            private DataColumnParameter ParamAccountName;
            private DataColumnParameter ParamAccountNumber;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Payout v):this(v.ID)                  
            {                  

                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
                ParamClientID = new(defClientID, v.ClientID);                  
                ParamPaidInAmount = new(defPaidInAmount, v.PaidInAmount);                  
                ParamPaidInCharges = new(defPaidInCharges, v.PaidInCharges);                  
                ParamPayoutAmount = new(defPayoutAmount, v.PayoutAmount);                  
                ParamPayoutCharge = new(defPayoutCharge, v.PayoutCharge);                  
                ParamBalance = new(defBalance, v.Balance);                  
                ParamTransactionStartDate = new(defTransactionStartDate, v.TransactionStartDate);                  
                ParamTransactionEndDate = new(defTransactionEndDate, v.TransactionEndDate);                  
                ParamAwaitingPayout = new(defAwaitingPayout, v.AwaitingPayout);                  
                ParamSynced = new(defSynced, v.Synced);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamBankID = new(defBankID, v.BankID);                  
                ParamAccountName = new(defAccountName, v.AccountName);                  
                ParamAccountNumber = new(defAccountNumber, v.AccountNumber);                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int? v)                  
            {                  
                ParamUpdatedByID = new(defUpdatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetClientID(int v)                  
            {                  
                ParamClientID = new(defClientID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaidInAmount(decimal v)                  
            {                  
                ParamPaidInAmount = new(defPaidInAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaidInCharges(decimal v)                  
            {                  
                ParamPaidInCharges = new(defPaidInCharges, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPayoutAmount(decimal v)                  
            {                  
                ParamPayoutAmount = new(defPayoutAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPayoutCharge(decimal v)                  
            {                  
                ParamPayoutCharge = new(defPayoutCharge, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBalance(decimal v)                  
            {                  
                ParamBalance = new(defBalance, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionStartDate(DateTime v)                  
            {                  
                ParamTransactionStartDate = new(defTransactionStartDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionEndDate(DateTime v)                  
            {                  
                ParamTransactionEndDate = new(defTransactionEndDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAwaitingPayout(bool? v)                  
            {                  
                ParamAwaitingPayout = new(defAwaitingPayout, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSynced(bool? v)                  
            {                  
                ParamSynced = new(defSynced, v);                  
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
                  
            public UpdateQueryBuilder SetBankID(int v)                  
            {                  
                ParamBankID = new(defBankID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccountName(string v)                  
            {                  
                ParamAccountName = new(defAccountName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccountNumber(string v)                  
            {                  
                ParamAccountNumber = new(defAccountNumber, v);                  
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
            int CreatedByID
,            int ClientID
,            decimal PaidInAmount
,            decimal PaidInCharges
,            decimal PayoutAmount
,            decimal PayoutCharge
,            decimal Balance
,            DateTime TransactionStartDate
,            DateTime TransactionEndDate
,            DateTime CreatedAt
,            int BankID
,            string AccountName
,            string AccountNumber
,            int? UpdatedByID = null
,            bool? AwaitingPayout = null
,            bool? Synced = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramPaidInAmount = new (defPaidInAmount, PaidInAmount);
                DataColumnParameter paramPaidInCharges = new (defPaidInCharges, PaidInCharges);
                DataColumnParameter paramPayoutAmount = new (defPayoutAmount, PayoutAmount);
                DataColumnParameter paramPayoutCharge = new (defPayoutCharge, PayoutCharge);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramTransactionStartDate = new (defTransactionStartDate, TransactionStartDate);
                DataColumnParameter paramTransactionEndDate = new (defTransactionEndDate, TransactionEndDate);
                DataColumnParameter paramAwaitingPayout = new (defAwaitingPayout, AwaitingPayout);
                DataColumnParameter paramSynced = new (defSynced, Synced);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  ", TABLE_NAME,
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramPaidInAmount.GetSQLValue(),
                        paramPaidInCharges.GetSQLValue(),
                        paramPayoutAmount.GetSQLValue(),
                        paramPayoutCharge.GetSQLValue(),
                        paramBalance.GetSQLValue(),
                        paramTransactionStartDate.GetSQLValue(),
                        paramTransactionEndDate.GetSQLValue(),
                        paramAwaitingPayout.GetSQLValue(),
                        paramSynced.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue()                        )
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
,            int CreatedByID
,            int ClientID
,            decimal PaidInAmount
,            decimal PaidInCharges
,            decimal PayoutAmount
,            decimal PayoutCharge
,            decimal Balance
,            DateTime TransactionStartDate
,            DateTime TransactionEndDate
,            DateTime CreatedAt
,            int BankID
,            string AccountName
,            string AccountNumber
,            int? UpdatedByID = null
,            bool? AwaitingPayout = null
,            bool? Synced = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramPaidInAmount = new (defPaidInAmount, PaidInAmount);
                DataColumnParameter paramPaidInCharges = new (defPaidInCharges, PaidInCharges);
                DataColumnParameter paramPayoutAmount = new (defPayoutAmount, PayoutAmount);
                DataColumnParameter paramPayoutCharge = new (defPayoutCharge, PayoutCharge);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramTransactionStartDate = new (defTransactionStartDate, TransactionStartDate);
                DataColumnParameter paramTransactionEndDate = new (defTransactionEndDate, TransactionEndDate);
                DataColumnParameter paramAwaitingPayout = new (defAwaitingPayout, AwaitingPayout);
                DataColumnParameter paramSynced = new (defSynced, Synced);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramPaidInAmount.GetSQLValue(),
                        paramPaidInCharges.GetSQLValue(),
                        paramPayoutAmount.GetSQLValue(),
                        paramPayoutCharge.GetSQLValue(),
                        paramBalance.GetSQLValue(),
                        paramTransactionStartDate.GetSQLValue(),
                        paramTransactionEndDate.GetSQLValue(),
                        paramAwaitingPayout.GetSQLValue(),
                        paramSynced.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int CreatedByID
,            int ClientID
,            decimal PaidInAmount
,            decimal PaidInCharges
,            decimal PayoutAmount
,            decimal PayoutCharge
,            decimal Balance
,            DateTime TransactionStartDate
,            DateTime TransactionEndDate
,            DateTime CreatedAt
,            int BankID
,            string AccountName
,            string AccountNumber
,            int? UpdatedByID = null
,            bool? AwaitingPayout = null
,            bool? Synced = null
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramPaidInAmount = new (defPaidInAmount, PaidInAmount);
                DataColumnParameter paramPaidInCharges = new (defPaidInCharges, PaidInCharges);
                DataColumnParameter paramPayoutAmount = new (defPayoutAmount, PayoutAmount);
                DataColumnParameter paramPayoutCharge = new (defPayoutCharge, PayoutCharge);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramTransactionStartDate = new (defTransactionStartDate, TransactionStartDate);
                DataColumnParameter paramTransactionEndDate = new (defTransactionEndDate, TransactionEndDate);
                DataColumnParameter paramAwaitingPayout = new (defAwaitingPayout, AwaitingPayout);
                DataColumnParameter paramSynced = new (defSynced, Synced);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  ", TABLE_NAME,
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramPaidInAmount.GetSQLValue(),
                        paramPaidInCharges.GetSQLValue(),
                        paramPayoutAmount.GetSQLValue(),
                        paramPayoutCharge.GetSQLValue(),
                        paramBalance.GetSQLValue(),
                        paramTransactionStartDate.GetSQLValue(),
                        paramTransactionEndDate.GetSQLValue(),
                        paramAwaitingPayout.GetSQLValue(),
                        paramSynced.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue()                            
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
