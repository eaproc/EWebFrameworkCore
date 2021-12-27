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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___Payment : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Payment()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAmountCharged = new DataColumnDefinition(TableColumnNames.AmountCharged.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscountGiven = new DataColumnDefinition(TableColumnNames.DiscountGiven.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscountRateApplied = new DataColumnDefinition(TableColumnNames.DiscountRateApplied.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentChannelID = new DataColumnDefinition(TableColumnNames.PaymentChannelID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentEntryModeID = new DataColumnDefinition(TableColumnNames.PaymentEntryModeID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionFileName = new DataColumnDefinition(TableColumnNames.TransactionFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defAmountCharged.ColumnName, defAmountCharged); 
          ColumnDefns.Add(defDiscountGiven.ColumnName, defDiscountGiven); 
          ColumnDefns.Add(defDiscountRateApplied.ColumnName, defDiscountRateApplied); 
          ColumnDefns.Add(defPaymentChannelID.ColumnName, defPaymentChannelID); 
          ColumnDefns.Add(defPaymentEntryModeID.ColumnName, defPaymentEntryModeID); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defTransactionFileName.ColumnName, defTransactionFileName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "academic.Term"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_PaymentChannelID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "accounting.PaymentChannel"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_PaymentEntryModeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "accounting.PaymentEntryMode"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "hr.Client"                  
                            ));                  

          }


                  
       public T___Payment() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Payment(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(DataTable FullTable) : base(FullTable)                                    
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
        public T___Payment(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.Payment";
       public const string Payment__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TermID], [AmountCharged], [DiscountGiven], [DiscountRateApplied], [PaymentChannelID], [PaymentEntryModeID], [Comments], [TransactionFileName], [CreatedAt], [CreatedByID], [IpAddress], [Total], [ClientID] FROM accounting.Payment";
       public const string Payment__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TermID], [AmountCharged], [DiscountGiven], [DiscountRateApplied], [PaymentChannelID], [PaymentEntryModeID], [Comments], [TransactionFileName], [CreatedAt], [CreatedByID], [IpAddress], [Total], [ClientID] FROM accounting.Payment";


       public enum TableColumnNames
       {

           ID,
           TermID,
           AmountCharged,
           DiscountGiven,
           DiscountRateApplied,
           PaymentChannelID,
           PaymentEntryModeID,
           Comments,
           TransactionFileName,
           CreatedAt,
           CreatedByID,
           IpAddress,
           Total,
           ClientID
       } 



       public enum TableConstraints{

           pk_accounting_Payment, 
           fk_accounting_Payment_CreatedByID, 
           fk_accounting_Payment_TermID, 
           fk_accounting_Payment_PaymentChannelID, 
           fk_accounting_Payment_PaymentEntryModeID, 
           fk_accounting_Payment_ClientID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defAmountCharged;
       public static readonly DataColumnDefinition defDiscountGiven;
       public static readonly DataColumnDefinition defDiscountRateApplied;
       public static readonly DataColumnDefinition defPaymentChannelID;
       public static readonly DataColumnDefinition defPaymentEntryModeID;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defTransactionFileName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defClientID;

       public int TermID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermID.ToString());  set => TargettedRow[TableColumnNames.TermID.ToString()] = value; }


       public decimal AmountCharged { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.AmountCharged.ToString());  set => TargettedRow[TableColumnNames.AmountCharged.ToString()] = value; }


       public decimal DiscountGiven { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.DiscountGiven.ToString());  set => TargettedRow[TableColumnNames.DiscountGiven.ToString()] = value; }


       public decimal DiscountRateApplied { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.DiscountRateApplied.ToString());  set => TargettedRow[TableColumnNames.DiscountRateApplied.ToString()] = value; }


       public int PaymentChannelID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PaymentChannelID.ToString());  set => TargettedRow[TableColumnNames.PaymentChannelID.ToString()] = value; }


       public int PaymentEntryModeID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PaymentEntryModeID.ToString());  set => TargettedRow[TableColumnNames.PaymentEntryModeID.ToString()] = value; }


       public string Comments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Comments.ToString());  set => TargettedRow[TableColumnNames.Comments.ToString()] = value; }


       public string TransactionFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.TransactionFileName.ToString());  set => TargettedRow[TableColumnNames.TransactionFileName.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public string IpAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IpAddress.ToString());  set => TargettedRow[TableColumnNames.IpAddress.ToString()] = value; }


       public decimal Total { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Total.ToString());  set => TargettedRow[TableColumnNames.Total.ToString()] = value; }


       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Payment GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Payment GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Payment(conn.Fetch(Payment__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Payment GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Payment( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Payment GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Payment__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTermID;
            private DataColumnParameter ParamAmountCharged;
            private DataColumnParameter ParamDiscountGiven;
            private DataColumnParameter ParamDiscountRateApplied;
            private DataColumnParameter ParamPaymentChannelID;
            private DataColumnParameter ParamPaymentEntryModeID;
            private DataColumnParameter ParamComments;
            private DataColumnParameter ParamTransactionFileName;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamIpAddress;
            private DataColumnParameter ParamTotal;
            private DataColumnParameter ParamClientID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Payment v):this(v.ID)                  
            {                  

                ParamTermID = new(defTermID, v.TermID);                  
                ParamAmountCharged = new(defAmountCharged, v.AmountCharged);                  
                ParamDiscountGiven = new(defDiscountGiven, v.DiscountGiven);                  
                ParamDiscountRateApplied = new(defDiscountRateApplied, v.DiscountRateApplied);                  
                ParamPaymentChannelID = new(defPaymentChannelID, v.PaymentChannelID);                  
                ParamPaymentEntryModeID = new(defPaymentEntryModeID, v.PaymentEntryModeID);                  
                ParamComments = new(defComments, v.Comments);                  
                ParamTransactionFileName = new(defTransactionFileName, v.TransactionFileName);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamIpAddress = new(defIpAddress, v.IpAddress);                  
                ParamTotal = new(defTotal, v.Total);                  
                ParamClientID = new(defClientID, v.ClientID);                  
            }                  
                  
            public UpdateQueryBuilder SetTermID(int v)                  
            {                  
                ParamTermID = new(defTermID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAmountCharged(decimal v)                  
            {                  
                ParamAmountCharged = new(defAmountCharged, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDiscountGiven(decimal v)                  
            {                  
                ParamDiscountGiven = new(defDiscountGiven, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDiscountRateApplied(decimal v)                  
            {                  
                ParamDiscountRateApplied = new(defDiscountRateApplied, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentChannelID(int v)                  
            {                  
                ParamPaymentChannelID = new(defPaymentChannelID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentEntryModeID(int v)                  
            {                  
                ParamPaymentEntryModeID = new(defPaymentEntryModeID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetComments(string v)                  
            {                  
                ParamComments = new(defComments, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionFileName(string v)                  
            {                  
                ParamTransactionFileName = new(defTransactionFileName, v);                  
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
                  
            public UpdateQueryBuilder SetIpAddress(string v)                  
            {                  
                ParamIpAddress = new(defIpAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTotal(decimal v)                  
            {                  
                ParamTotal = new(defTotal, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetClientID(int v)                  
            {                  
                ParamClientID = new(defClientID, v);                  
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
            int TermID,
            decimal AmountCharged,
            decimal DiscountGiven,
            decimal DiscountRateApplied,
            int PaymentChannelID,
            int PaymentEntryModeID,
            DateTime CreatedAt,
            int CreatedByID,
            string IpAddress,
            decimal Total,
            int ClientID,
            string Comments = null,
            string TransactionFileName = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramAmountCharged = new (defAmountCharged, AmountCharged);
                DataColumnParameter paramDiscountGiven = new (defDiscountGiven, DiscountGiven);
                DataColumnParameter paramDiscountRateApplied = new (defDiscountRateApplied, DiscountRateApplied);
                DataColumnParameter paramPaymentChannelID = new (defPaymentChannelID, PaymentChannelID);
                DataColumnParameter paramPaymentEntryModeID = new (defPaymentEntryModeID, PaymentEntryModeID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramTransactionFileName = new (defTransactionFileName, TransactionFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramClientID = new (defClientID, ClientID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramTermID.GetSQLValue(),
                        paramAmountCharged.GetSQLValue(),
                        paramDiscountGiven.GetSQLValue(),
                        paramDiscountRateApplied.GetSQLValue(),
                        paramPaymentChannelID.GetSQLValue(),
                        paramPaymentEntryModeID.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramTransactionFileName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramClientID.GetSQLValue()                        )
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
            int TermID,
            decimal AmountCharged,
            decimal DiscountGiven,
            decimal DiscountRateApplied,
            int PaymentChannelID,
            int PaymentEntryModeID,
            DateTime CreatedAt,
            int CreatedByID,
            string IpAddress,
            decimal Total,
            int ClientID,
            string Comments = null,
            string TransactionFileName = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramAmountCharged = new (defAmountCharged, AmountCharged);
                DataColumnParameter paramDiscountGiven = new (defDiscountGiven, DiscountGiven);
                DataColumnParameter paramDiscountRateApplied = new (defDiscountRateApplied, DiscountRateApplied);
                DataColumnParameter paramPaymentChannelID = new (defPaymentChannelID, PaymentChannelID);
                DataColumnParameter paramPaymentEntryModeID = new (defPaymentEntryModeID, PaymentEntryModeID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramTransactionFileName = new (defTransactionFileName, TransactionFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramClientID = new (defClientID, ClientID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramAmountCharged.GetSQLValue(),
                        paramDiscountGiven.GetSQLValue(),
                        paramDiscountRateApplied.GetSQLValue(),
                        paramPaymentChannelID.GetSQLValue(),
                        paramPaymentEntryModeID.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramTransactionFileName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramClientID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int TermID,
            decimal AmountCharged,
            decimal DiscountGiven,
            decimal DiscountRateApplied,
            int PaymentChannelID,
            int PaymentEntryModeID,
            DateTime CreatedAt,
            int CreatedByID,
            string IpAddress,
            decimal Total,
            int ClientID,
            string Comments = null,
            string TransactionFileName = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramAmountCharged = new (defAmountCharged, AmountCharged);
                DataColumnParameter paramDiscountGiven = new (defDiscountGiven, DiscountGiven);
                DataColumnParameter paramDiscountRateApplied = new (defDiscountRateApplied, DiscountRateApplied);
                DataColumnParameter paramPaymentChannelID = new (defPaymentChannelID, PaymentChannelID);
                DataColumnParameter paramPaymentEntryModeID = new (defPaymentEntryModeID, PaymentEntryModeID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramTransactionFileName = new (defTransactionFileName, TransactionFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramClientID = new (defClientID, ClientID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramTermID.GetSQLValue(),
                        paramAmountCharged.GetSQLValue(),
                        paramDiscountGiven.GetSQLValue(),
                        paramDiscountRateApplied.GetSQLValue(),
                        paramPaymentChannelID.GetSQLValue(),
                        paramPaymentEntryModeID.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramTransactionFileName.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramClientID.GetSQLValue()                            
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
