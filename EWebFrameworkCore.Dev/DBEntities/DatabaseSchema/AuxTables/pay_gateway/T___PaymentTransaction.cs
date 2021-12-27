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

    public class T___PaymentTransaction : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaymentTransaction()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionStatusID = new DataColumnDefinition(TableColumnNames.TransactionStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStudentNumber = new DataColumnDefinition(TableColumnNames.StudentNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(TableColumnNames.Bank.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(TableColumnNames.Channel.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolDiscountGiven = new DataColumnDefinition(TableColumnNames.SchoolDiscountGiven.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequired = new DataColumnDefinition(TableColumnNames.PaymentRequired.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharges = new DataColumnDefinition(TableColumnNames.Charges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRefundAmount = new DataColumnDefinition(TableColumnNames.RefundAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationThreshold = new DataColumnDefinition(TableColumnNames.ConfirmationThreshold.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationDate = new DataColumnDefinition(TableColumnNames.ConfirmationDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAwaitingDisbursement = new DataColumnDefinition(TableColumnNames.AwaitingDisbursement.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defConfirmedExplanation = new DataColumnDefinition(TableColumnNames.ConfirmedExplanation.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChargesBilledToClient = new DataColumnDefinition(TableColumnNames.ChargesBilledToClient.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsMultiTarget = new DataColumnDefinition(TableColumnNames.IsMultiTarget.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTransactionStatusID.ColumnName, defTransactionStatusID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defStudentNumber.ColumnName, defStudentNumber); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defBank.ColumnName, defBank); 
          ColumnDefns.Add(defChannel.ColumnName, defChannel); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defSchoolDiscountGiven.ColumnName, defSchoolDiscountGiven); 
          ColumnDefns.Add(defPaymentRequired.ColumnName, defPaymentRequired); 
          ColumnDefns.Add(defCharges.ColumnName, defCharges); 
          ColumnDefns.Add(defRefundAmount.ColumnName, defRefundAmount); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defConfirmationThreshold.ColumnName, defConfirmationThreshold); 
          ColumnDefns.Add(defConfirmationDate.ColumnName, defConfirmationDate); 
          ColumnDefns.Add(defAwaitingDisbursement.ColumnName, defAwaitingDisbursement); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defConfirmedExplanation.ColumnName, defConfirmedExplanation); 
          ColumnDefns.Add(defChargesBilledToClient.ColumnName, defChargesBilledToClient); 
          ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges); 
          ColumnDefns.Add(defIsMultiTarget.ColumnName, defIsMultiTarget); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransaction_TransactionStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "pay_gateway.TransactionStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransaction_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransaction_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransaction_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "auth.Users"                  
                            ));                  

          }


                  
       public T___PaymentTransaction() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaymentTransaction(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(DataTable FullTable) : base(FullTable)                                    
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
        public T___PaymentTransaction(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.PaymentTransaction";
       public const string PaymentTransaction__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [ClientID], [StudentNumber], [FirstName], [LastName], [AccountName], [AccountNumber], [Bank], [Channel], [IPAddress], [SchoolDiscountGiven], [PaymentRequired], [Charges], [RefundAmount], [Balance], [ConfirmationThreshold], [ConfirmationDate], [AwaitingDisbursement], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [ConfirmedExplanation], [ChargesBilledToClient], [PaymentRequiredWithoutCharges], [IsMultiTarget] FROM pay_gateway.PaymentTransaction";
       public const string PaymentTransaction__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [ClientID], [StudentNumber], [FirstName], [LastName], [AccountName], [AccountNumber], [Bank], [Channel], [IPAddress], [SchoolDiscountGiven], [PaymentRequired], [Charges], [RefundAmount], [Balance], [ConfirmationThreshold], [ConfirmationDate], [AwaitingDisbursement], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [ConfirmedExplanation], [ChargesBilledToClient], [PaymentRequiredWithoutCharges], [IsMultiTarget] FROM pay_gateway.PaymentTransaction";


       public enum TableColumnNames
       {

           ID,
           TransactionStatusID,
           ClientID,
           StudentNumber,
           FirstName,
           LastName,
           AccountName,
           AccountNumber,
           Bank,
           Channel,
           IPAddress,
           SchoolDiscountGiven,
           PaymentRequired,
           Charges,
           RefundAmount,
           Balance,
           ConfirmationThreshold,
           ConfirmationDate,
           AwaitingDisbursement,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID,
           ConfirmedExplanation,
           ChargesBilledToClient,
           PaymentRequiredWithoutCharges,
           IsMultiTarget
       } 



       public enum TableConstraints{

           pk_pay_gateway_PaymentTransaction, 
           fk_pay_gateway_PaymentTransaction_TransactionStatusID, 
           fk_pay_gateway_PaymentTransaction_ClientID, 
           fk_PaymentTransaction_CreatedByID, 
           fk_PaymentTransaction_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTransactionStatusID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defStudentNumber;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defBank;
       public static readonly DataColumnDefinition defChannel;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defSchoolDiscountGiven;
       public static readonly DataColumnDefinition defPaymentRequired;
       public static readonly DataColumnDefinition defCharges;
       public static readonly DataColumnDefinition defRefundAmount;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defConfirmationThreshold;
       public static readonly DataColumnDefinition defConfirmationDate;
       public static readonly DataColumnDefinition defAwaitingDisbursement;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defConfirmedExplanation;
       public static readonly DataColumnDefinition defChargesBilledToClient;
       public static readonly DataColumnDefinition defPaymentRequiredWithoutCharges;
       public static readonly DataColumnDefinition defIsMultiTarget;

       public int TransactionStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TransactionStatusID.ToString());  set => TargettedRow[TableColumnNames.TransactionStatusID.ToString()] = value; }


       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public string StudentNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.StudentNumber.ToString());  set => TargettedRow[TableColumnNames.StudentNumber.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public string AccountName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountName.ToString());  set => TargettedRow[TableColumnNames.AccountName.ToString()] = value; }


       public string AccountNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountNumber.ToString());  set => TargettedRow[TableColumnNames.AccountNumber.ToString()] = value; }


       public string Bank { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Bank.ToString());  set => TargettedRow[TableColumnNames.Bank.ToString()] = value; }


       public string Channel { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Channel.ToString());  set => TargettedRow[TableColumnNames.Channel.ToString()] = value; }


       public string IPAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IPAddress.ToString());  set => TargettedRow[TableColumnNames.IPAddress.ToString()] = value; }


       public decimal SchoolDiscountGiven { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.SchoolDiscountGiven.ToString());  set => TargettedRow[TableColumnNames.SchoolDiscountGiven.ToString()] = value; }


       public decimal PaymentRequired { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PaymentRequired.ToString());  set => TargettedRow[TableColumnNames.PaymentRequired.ToString()] = value; }


       public decimal Charges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Charges.ToString());  set => TargettedRow[TableColumnNames.Charges.ToString()] = value; }


       public decimal RefundAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RefundAmount.ToString());  set => TargettedRow[TableColumnNames.RefundAmount.ToString()] = value; }


       public decimal Balance { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Balance.ToString());  set => TargettedRow[TableColumnNames.Balance.ToString()] = value; }


       public decimal? ConfirmationThreshold { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.ConfirmationThreshold.ToString());  set => TargettedRow[TableColumnNames.ConfirmationThreshold.ToString()] = value; }


       public DateTime? ConfirmationDate { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.ConfirmationDate.ToString());  set => TargettedRow[TableColumnNames.ConfirmationDate.ToString()] = value; }


       public bool? AwaitingDisbursement { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.AwaitingDisbursement.ToString());  set => TargettedRow[TableColumnNames.AwaitingDisbursement.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int UpdatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


       public string ConfirmedExplanation { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ConfirmedExplanation.ToString());  set => TargettedRow[TableColumnNames.ConfirmedExplanation.ToString()] = value; }


       public bool? ChargesBilledToClient { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.ChargesBilledToClient.ToString());  set => TargettedRow[TableColumnNames.ChargesBilledToClient.ToString()] = value; }


       public decimal PaymentRequiredWithoutCharges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PaymentRequiredWithoutCharges.ToString());  set => TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()] = value; }


       public bool? IsMultiTarget { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.IsMultiTarget.ToString());  set => TargettedRow[TableColumnNames.IsMultiTarget.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PaymentTransaction GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PaymentTransaction GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___PaymentTransaction(conn.Fetch(PaymentTransaction__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___PaymentTransaction GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___PaymentTransaction( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___PaymentTransaction GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PaymentTransaction__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTransactionStatusID;
            private DataColumnParameter ParamClientID;
            private DataColumnParameter ParamStudentNumber;
            private DataColumnParameter ParamFirstName;
            private DataColumnParameter ParamLastName;
            private DataColumnParameter ParamAccountName;
            private DataColumnParameter ParamAccountNumber;
            private DataColumnParameter ParamBank;
            private DataColumnParameter ParamChannel;
            private DataColumnParameter ParamIPAddress;
            private DataColumnParameter ParamSchoolDiscountGiven;
            private DataColumnParameter ParamPaymentRequired;
            private DataColumnParameter ParamCharges;
            private DataColumnParameter ParamRefundAmount;
            private DataColumnParameter ParamBalance;
            private DataColumnParameter ParamConfirmationThreshold;
            private DataColumnParameter ParamConfirmationDate;
            private DataColumnParameter ParamAwaitingDisbursement;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;
            private DataColumnParameter ParamConfirmedExplanation;
            private DataColumnParameter ParamChargesBilledToClient;
            private DataColumnParameter ParamPaymentRequiredWithoutCharges;
            private DataColumnParameter ParamIsMultiTarget;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PaymentTransaction v):this(v.ID)                  
            {                  

                ParamTransactionStatusID = new(defTransactionStatusID, v.TransactionStatusID);                  
                ParamClientID = new(defClientID, v.ClientID);                  
                ParamStudentNumber = new(defStudentNumber, v.StudentNumber);                  
                ParamFirstName = new(defFirstName, v.FirstName);                  
                ParamLastName = new(defLastName, v.LastName);                  
                ParamAccountName = new(defAccountName, v.AccountName);                  
                ParamAccountNumber = new(defAccountNumber, v.AccountNumber);                  
                ParamBank = new(defBank, v.Bank);                  
                ParamChannel = new(defChannel, v.Channel);                  
                ParamIPAddress = new(defIPAddress, v.IPAddress);                  
                ParamSchoolDiscountGiven = new(defSchoolDiscountGiven, v.SchoolDiscountGiven);                  
                ParamPaymentRequired = new(defPaymentRequired, v.PaymentRequired);                  
                ParamCharges = new(defCharges, v.Charges);                  
                ParamRefundAmount = new(defRefundAmount, v.RefundAmount);                  
                ParamBalance = new(defBalance, v.Balance);                  
                ParamConfirmationThreshold = new(defConfirmationThreshold, v.ConfirmationThreshold);                  
                ParamConfirmationDate = new(defConfirmationDate, v.ConfirmationDate);                  
                ParamAwaitingDisbursement = new(defAwaitingDisbursement, v.AwaitingDisbursement);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
                ParamConfirmedExplanation = new(defConfirmedExplanation, v.ConfirmedExplanation);                  
                ParamChargesBilledToClient = new(defChargesBilledToClient, v.ChargesBilledToClient);                  
                ParamPaymentRequiredWithoutCharges = new(defPaymentRequiredWithoutCharges, v.PaymentRequiredWithoutCharges);                  
                ParamIsMultiTarget = new(defIsMultiTarget, v.IsMultiTarget);                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionStatusID(int v)                  
            {                  
                ParamTransactionStatusID = new(defTransactionStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetClientID(int v)                  
            {                  
                ParamClientID = new(defClientID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetStudentNumber(string v)                  
            {                  
                ParamStudentNumber = new(defStudentNumber, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFirstName(string v)                  
            {                  
                ParamFirstName = new(defFirstName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLastName(string v)                  
            {                  
                ParamLastName = new(defLastName, v);                  
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
                  
            public UpdateQueryBuilder SetBank(string v)                  
            {                  
                ParamBank = new(defBank, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChannel(string v)                  
            {                  
                ParamChannel = new(defChannel, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIPAddress(string v)                  
            {                  
                ParamIPAddress = new(defIPAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSchoolDiscountGiven(decimal v)                  
            {                  
                ParamSchoolDiscountGiven = new(defSchoolDiscountGiven, v);                  
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
                  
            public UpdateQueryBuilder SetConfirmationThreshold(decimal? v)                  
            {                  
                ParamConfirmationThreshold = new(defConfirmationThreshold, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetConfirmationDate(DateTime? v)                  
            {                  
                ParamConfirmationDate = new(defConfirmationDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAwaitingDisbursement(bool? v)                  
            {                  
                ParamAwaitingDisbursement = new(defAwaitingDisbursement, v);                  
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
                  
            public UpdateQueryBuilder SetConfirmedExplanation(string v)                  
            {                  
                ParamConfirmedExplanation = new(defConfirmedExplanation, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChargesBilledToClient(bool? v)                  
            {                  
                ParamChargesBilledToClient = new(defChargesBilledToClient, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentRequiredWithoutCharges(decimal v)                  
            {                  
                ParamPaymentRequiredWithoutCharges = new(defPaymentRequiredWithoutCharges, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsMultiTarget(bool? v)                  
            {                  
                ParamIsMultiTarget = new(defIsMultiTarget, v);                  
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
            int ClientID,
            string StudentNumber,
            string FirstName,
            string LastName,
            string AccountName,
            string AccountNumber,
            string Bank,
            string Channel,
            string IPAddress,
            decimal SchoolDiscountGiven,
            decimal PaymentRequired,
            decimal Charges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            int UpdatedByID,
            decimal PaymentRequiredWithoutCharges,
            decimal? ConfirmationThreshold = null,
            DateTime? ConfirmationDate = null,
            bool? AwaitingDisbursement = null,
            DateTime? UpdatedAt = null,
            string ConfirmedExplanation = null,
            bool? ChargesBilledToClient = null,
            bool? IsMultiTarget = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSchoolDiscountGiven = new (defSchoolDiscountGiven, SchoolDiscountGiven);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramConfirmationThreshold = new (defConfirmationThreshold, ConfirmationThreshold);
                DataColumnParameter paramConfirmationDate = new (defConfirmationDate, ConfirmationDate);
                DataColumnParameter paramAwaitingDisbursement = new (defAwaitingDisbursement, AwaitingDisbursement);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramConfirmedExplanation = new (defConfirmedExplanation, ConfirmedExplanation);
                DataColumnParameter paramChargesBilledToClient = new (defChargesBilledToClient, ChargesBilledToClient);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramIsMultiTarget = new (defIsMultiTarget, IsMultiTarget);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26})  ", TABLE_NAME,
                        paramTransactionStatusID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramStudentNumber.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramSchoolDiscountGiven.GetSQLValue(),
                        paramPaymentRequired.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramRefundAmount.GetSQLValue(),
                        paramBalance.GetSQLValue(),
                        paramConfirmationThreshold.GetSQLValue(),
                        paramConfirmationDate.GetSQLValue(),
                        paramAwaitingDisbursement.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramConfirmedExplanation.GetSQLValue(),
                        paramChargesBilledToClient.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue(),
                        paramIsMultiTarget.GetSQLValue()                        )
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
            int ClientID,
            string StudentNumber,
            string FirstName,
            string LastName,
            string AccountName,
            string AccountNumber,
            string Bank,
            string Channel,
            string IPAddress,
            decimal SchoolDiscountGiven,
            decimal PaymentRequired,
            decimal Charges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            int UpdatedByID,
            decimal PaymentRequiredWithoutCharges,
            decimal? ConfirmationThreshold = null,
            DateTime? ConfirmationDate = null,
            bool? AwaitingDisbursement = null,
            DateTime? UpdatedAt = null,
            string ConfirmedExplanation = null,
            bool? ChargesBilledToClient = null,
            bool? IsMultiTarget = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSchoolDiscountGiven = new (defSchoolDiscountGiven, SchoolDiscountGiven);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramConfirmationThreshold = new (defConfirmationThreshold, ConfirmationThreshold);
                DataColumnParameter paramConfirmationDate = new (defConfirmationDate, ConfirmationDate);
                DataColumnParameter paramAwaitingDisbursement = new (defAwaitingDisbursement, AwaitingDisbursement);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramConfirmedExplanation = new (defConfirmedExplanation, ConfirmedExplanation);
                DataColumnParameter paramChargesBilledToClient = new (defChargesBilledToClient, ChargesBilledToClient);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramIsMultiTarget = new (defIsMultiTarget, IsMultiTarget);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTransactionStatusID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramStudentNumber.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramSchoolDiscountGiven.GetSQLValue(),
                        paramPaymentRequired.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramRefundAmount.GetSQLValue(),
                        paramBalance.GetSQLValue(),
                        paramConfirmationThreshold.GetSQLValue(),
                        paramConfirmationDate.GetSQLValue(),
                        paramAwaitingDisbursement.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramConfirmedExplanation.GetSQLValue(),
                        paramChargesBilledToClient.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue(),
                        paramIsMultiTarget.GetSQLValue()                        )
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
            int ClientID,
            string StudentNumber,
            string FirstName,
            string LastName,
            string AccountName,
            string AccountNumber,
            string Bank,
            string Channel,
            string IPAddress,
            decimal SchoolDiscountGiven,
            decimal PaymentRequired,
            decimal Charges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            int UpdatedByID,
            decimal PaymentRequiredWithoutCharges,
            decimal? ConfirmationThreshold = null,
            DateTime? ConfirmationDate = null,
            bool? AwaitingDisbursement = null,
            DateTime? UpdatedAt = null,
            string ConfirmedExplanation = null,
            bool? ChargesBilledToClient = null,
            bool? IsMultiTarget = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSchoolDiscountGiven = new (defSchoolDiscountGiven, SchoolDiscountGiven);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramConfirmationThreshold = new (defConfirmationThreshold, ConfirmationThreshold);
                DataColumnParameter paramConfirmationDate = new (defConfirmationDate, ConfirmationDate);
                DataColumnParameter paramAwaitingDisbursement = new (defAwaitingDisbursement, AwaitingDisbursement);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramConfirmedExplanation = new (defConfirmedExplanation, ConfirmedExplanation);
                DataColumnParameter paramChargesBilledToClient = new (defChargesBilledToClient, ChargesBilledToClient);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramIsMultiTarget = new (defIsMultiTarget, IsMultiTarget);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26})  ", TABLE_NAME,
                        paramTransactionStatusID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramStudentNumber.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramAccountName.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramBank.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramSchoolDiscountGiven.GetSQLValue(),
                        paramPaymentRequired.GetSQLValue(),
                        paramCharges.GetSQLValue(),
                        paramRefundAmount.GetSQLValue(),
                        paramBalance.GetSQLValue(),
                        paramConfirmationThreshold.GetSQLValue(),
                        paramConfirmationDate.GetSQLValue(),
                        paramAwaitingDisbursement.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramConfirmedExplanation.GetSQLValue(),
                        paramChargesBilledToClient.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue(),
                        paramIsMultiTarget.GetSQLValue()                            
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
