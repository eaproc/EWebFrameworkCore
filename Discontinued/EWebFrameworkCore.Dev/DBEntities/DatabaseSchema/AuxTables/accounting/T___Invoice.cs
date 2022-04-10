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

    public class T___Invoice : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Invoice()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBillDefinition = new DataColumnDefinition(TableColumnNames.BillDefinition.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillDescription = new DataColumnDefinition(TableColumnNames.BillDescription.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillAmount = new DataColumnDefinition(TableColumnNames.BillAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCanBeDeleted = new DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defQuantity = new DataColumnDefinition(TableColumnNames.Quantity.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defOriginalBillID = new DataColumnDefinition(TableColumnNames.OriginalBillID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentTransactionID = new DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defBillDefinition.ColumnName, defBillDefinition); 
          ColumnDefns.Add(defBillDescription.ColumnName, defBillDescription); 
          ColumnDefns.Add(defBillAmount.ColumnName, defBillAmount); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defQuantity.ColumnName, defQuantity); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defOriginalBillID.ColumnName, defOriginalBillID); 
          ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_PaymentTransactionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "pay_gateway.PaymentTransaction"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_OriginalBillID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "accounting.Bill"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "academic.Term"                  
                            ));                  

          }


                  
       public T___Invoice() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Invoice(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(DataTable FullTable) : base(FullTable)                                    
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
        public T___Invoice(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.Invoice";
       public const string Invoice__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [BillDefinition], [BillDescription], [BillAmount], [Total], [CreatedAt], [CreatedByID], [CanBeDeleted], [Quantity], [IpAddress], [TermID], [OriginalBillID], [PaymentTransactionID] FROM accounting.Invoice";
       public const string Invoice__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [BillDefinition], [BillDescription], [BillAmount], [Total], [CreatedAt], [CreatedByID], [CanBeDeleted], [Quantity], [IpAddress], [TermID], [OriginalBillID], [PaymentTransactionID] FROM accounting.Invoice";


       public enum TableColumnNames
       {

           ID,
           ClientID,
           BillDefinition,
           BillDescription,
           BillAmount,
           Total,
           CreatedAt,
           CreatedByID,
           CanBeDeleted,
           Quantity,
           IpAddress,
           TermID,
           OriginalBillID,
           PaymentTransactionID
       } 



       public enum TableConstraints{

           pk_accounting_Invoice, 
           fk_accounting_Invoice_PaymentTransactionID, 
           fk_accounting_Invoice_OriginalBillID, 
           fk_accounting_Invoice_ClientID, 
           fk_accounting_Invoice_CreatedByID, 
           fk_accounting_Invoice_TermID, 
           uq_accounting_Invoice_PaymentTransactionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defBillDefinition;
       public static readonly DataColumnDefinition defBillDescription;
       public static readonly DataColumnDefinition defBillAmount;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defQuantity;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defOriginalBillID;
       public static readonly DataColumnDefinition defPaymentTransactionID;

       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public string BillDefinition { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BillDefinition.ToString());  set => TargettedRow[TableColumnNames.BillDefinition.ToString()] = value; }


       public string BillDescription { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BillDescription.ToString());  set => TargettedRow[TableColumnNames.BillDescription.ToString()] = value; }


       public decimal BillAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.BillAmount.ToString());  set => TargettedRow[TableColumnNames.BillAmount.ToString()] = value; }


       public decimal Total { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Total.ToString());  set => TargettedRow[TableColumnNames.Total.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public bool CanBeDeleted { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.CanBeDeleted.ToString());  set => TargettedRow[TableColumnNames.CanBeDeleted.ToString()] = value; }


       public int Quantity { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.Quantity.ToString());  set => TargettedRow[TableColumnNames.Quantity.ToString()] = value; }


       public string IpAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IpAddress.ToString());  set => TargettedRow[TableColumnNames.IpAddress.ToString()] = value; }


       public int TermID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermID.ToString());  set => TargettedRow[TableColumnNames.TermID.ToString()] = value; }


       public int OriginalBillID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.OriginalBillID.ToString());  set => TargettedRow[TableColumnNames.OriginalBillID.ToString()] = value; }


       public int? PaymentTransactionID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.PaymentTransactionID.ToString());  set => TargettedRow[TableColumnNames.PaymentTransactionID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Invoice GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Invoice GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___Invoice(conn.Fetch(Invoice__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___Invoice GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___Invoice( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___Invoice GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Invoice__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamClientID;
            private DataColumnParameter ParamBillDefinition;
            private DataColumnParameter ParamBillDescription;
            private DataColumnParameter ParamBillAmount;
            private DataColumnParameter ParamTotal;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamCanBeDeleted;
            private DataColumnParameter ParamQuantity;
            private DataColumnParameter ParamIpAddress;
            private DataColumnParameter ParamTermID;
            private DataColumnParameter ParamOriginalBillID;
            private DataColumnParameter ParamPaymentTransactionID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Invoice v):this(v.ID)                  
            {                  

                ParamClientID = new(defClientID, v.ClientID);                  
                ParamBillDefinition = new(defBillDefinition, v.BillDefinition);                  
                ParamBillDescription = new(defBillDescription, v.BillDescription);                  
                ParamBillAmount = new(defBillAmount, v.BillAmount);                  
                ParamTotal = new(defTotal, v.Total);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamCanBeDeleted = new(defCanBeDeleted, v.CanBeDeleted);                  
                ParamQuantity = new(defQuantity, v.Quantity);                  
                ParamIpAddress = new(defIpAddress, v.IpAddress);                  
                ParamTermID = new(defTermID, v.TermID);                  
                ParamOriginalBillID = new(defOriginalBillID, v.OriginalBillID);                  
                ParamPaymentTransactionID = new(defPaymentTransactionID, v.PaymentTransactionID);                  
            }                  
                  
            public UpdateQueryBuilder SetClientID(int v)                  
            {                  
                ParamClientID = new(defClientID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBillDefinition(string v)                  
            {                  
                ParamBillDefinition = new(defBillDefinition, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBillDescription(string v)                  
            {                  
                ParamBillDescription = new(defBillDescription, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBillAmount(decimal v)                  
            {                  
                ParamBillAmount = new(defBillAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTotal(decimal v)                  
            {                  
                ParamTotal = new(defTotal, v);                  
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
                  
            public UpdateQueryBuilder SetCanBeDeleted(bool v)                  
            {                  
                ParamCanBeDeleted = new(defCanBeDeleted, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetQuantity(int v)                  
            {                  
                ParamQuantity = new(defQuantity, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIpAddress(string v)                  
            {                  
                ParamIpAddress = new(defIpAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTermID(int v)                  
            {                  
                ParamTermID = new(defTermID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetOriginalBillID(int v)                  
            {                  
                ParamOriginalBillID = new(defOriginalBillID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentTransactionID(int? v)                  
            {                  
                ParamPaymentTransactionID = new(defPaymentTransactionID, v);                  
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
            int ClientID
,            string BillDefinition
,            decimal BillAmount
,            decimal Total
,            DateTime CreatedAt
,            int CreatedByID
,            bool CanBeDeleted
,            int Quantity
,            string IpAddress
,            int TermID
,            int OriginalBillID
,            string BillDescription = null
,            int? PaymentTransactionID = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramBillDefinition = new (defBillDefinition, BillDefinition);
                DataColumnParameter paramBillDescription = new (defBillDescription, BillDescription);
                DataColumnParameter paramBillAmount = new (defBillAmount, BillAmount);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramQuantity = new (defQuantity, Quantity);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramOriginalBillID = new (defOriginalBillID, OriginalBillID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramClientID.GetSQLValue(),
                        paramBillDefinition.GetSQLValue(),
                        paramBillDescription.GetSQLValue(),
                        paramBillAmount.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCanBeDeleted.GetSQLValue(),
                        paramQuantity.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramOriginalBillID.GetSQLValue(),
                        paramPaymentTransactionID.GetSQLValue()                        )
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
,            int ClientID
,            string BillDefinition
,            decimal BillAmount
,            decimal Total
,            DateTime CreatedAt
,            int CreatedByID
,            bool CanBeDeleted
,            int Quantity
,            string IpAddress
,            int TermID
,            int OriginalBillID
,            string BillDescription = null
,            int? PaymentTransactionID = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramBillDefinition = new (defBillDefinition, BillDefinition);
                DataColumnParameter paramBillDescription = new (defBillDescription, BillDescription);
                DataColumnParameter paramBillAmount = new (defBillAmount, BillAmount);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramQuantity = new (defQuantity, Quantity);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramOriginalBillID = new (defOriginalBillID, OriginalBillID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramBillDefinition.GetSQLValue(),
                        paramBillDescription.GetSQLValue(),
                        paramBillAmount.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCanBeDeleted.GetSQLValue(),
                        paramQuantity.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramOriginalBillID.GetSQLValue(),
                        paramPaymentTransactionID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int ClientID
,            string BillDefinition
,            decimal BillAmount
,            decimal Total
,            DateTime CreatedAt
,            int CreatedByID
,            bool CanBeDeleted
,            int Quantity
,            string IpAddress
,            int TermID
,            int OriginalBillID
,            string BillDescription = null
,            int? PaymentTransactionID = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramBillDefinition = new (defBillDefinition, BillDefinition);
                DataColumnParameter paramBillDescription = new (defBillDescription, BillDescription);
                DataColumnParameter paramBillAmount = new (defBillAmount, BillAmount);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramQuantity = new (defQuantity, Quantity);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramOriginalBillID = new (defOriginalBillID, OriginalBillID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramClientID.GetSQLValue(),
                        paramBillDefinition.GetSQLValue(),
                        paramBillDescription.GetSQLValue(),
                        paramBillAmount.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramCanBeDeleted.GetSQLValue(),
                        paramQuantity.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramOriginalBillID.GetSQLValue(),
                        paramPaymentTransactionID.GetSQLValue()                            
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
