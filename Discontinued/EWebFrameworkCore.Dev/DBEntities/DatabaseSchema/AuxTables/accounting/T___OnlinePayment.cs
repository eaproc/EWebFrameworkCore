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

    public class T___OnlinePayment : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___OnlinePayment()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentID = new DataColumnDefinition(TableColumnNames.PaymentID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTransactionDate = new DataColumnDefinition(TableColumnNames.TransactionDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(TableColumnNames.Channel.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayCharges = new DataColumnDefinition(TableColumnNames.GatewayCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayLogReference = new DataColumnDefinition(TableColumnNames.GatewayLogReference.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(TableColumnNames.Gateway.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformCharges = new DataColumnDefinition(TableColumnNames.PlatformCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayAmountReceived = new DataColumnDefinition(TableColumnNames.GatewayAmountReceived.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformAmountReceived = new DataColumnDefinition(TableColumnNames.PlatformAmountReceived.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayChargesExplaination = new DataColumnDefinition(TableColumnNames.GatewayChargesExplaination.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformChargesExplaination = new DataColumnDefinition(TableColumnNames.PlatformChargesExplaination.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPaymentID.ColumnName, defPaymentID); 
          ColumnDefns.Add(defTransactionDate.ColumnName, defTransactionDate); 
          ColumnDefns.Add(defChannel.ColumnName, defChannel); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defGatewayCharges.ColumnName, defGatewayCharges); 
          ColumnDefns.Add(defGatewayLogReference.ColumnName, defGatewayLogReference); 
          ColumnDefns.Add(defGateway.ColumnName, defGateway); 
          ColumnDefns.Add(defPlatformCharges.ColumnName, defPlatformCharges); 
          ColumnDefns.Add(defGatewayAmountReceived.ColumnName, defGatewayAmountReceived); 
          ColumnDefns.Add(defPlatformAmountReceived.ColumnName, defPlatformAmountReceived); 
          ColumnDefns.Add(defGatewayChargesExplaination.ColumnName, defGatewayChargesExplaination); 
          ColumnDefns.Add(defPlatformChargesExplaination.ColumnName, defPlatformChargesExplaination); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_OnlinePayment_PaymentID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.OnlinePayment", "accounting.Payment"                  
                            ));                  

          }


                  
       public T___OnlinePayment() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___OnlinePayment(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(DataTable FullTable) : base(FullTable)                                    
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
        public T___OnlinePayment(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.OnlinePayment";
       public const string OnlinePayment__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM accounting.OnlinePayment";
       public const string OnlinePayment__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM accounting.OnlinePayment";


       public enum TableColumnNames
       {

           ID,
           PaymentID,
           TransactionDate,
           Channel,
           IpAddress,
           GatewayCharges,
           GatewayLogReference,
           Gateway,
           PlatformCharges,
           GatewayAmountReceived,
           PlatformAmountReceived,
           GatewayChargesExplaination,
           PlatformChargesExplaination,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_accounting_OnlinePayment, 
           fk_accounting_OnlinePayment_PaymentID, 
           uq_accounting_OnlinePayment_PaymentID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPaymentID;
       public static readonly DataColumnDefinition defTransactionDate;
       public static readonly DataColumnDefinition defChannel;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defGatewayCharges;
       public static readonly DataColumnDefinition defGatewayLogReference;
       public static readonly DataColumnDefinition defGateway;
       public static readonly DataColumnDefinition defPlatformCharges;
       public static readonly DataColumnDefinition defGatewayAmountReceived;
       public static readonly DataColumnDefinition defPlatformAmountReceived;
       public static readonly DataColumnDefinition defGatewayChargesExplaination;
       public static readonly DataColumnDefinition defPlatformChargesExplaination;
       public static readonly DataColumnDefinition defCreatedAt;

       public int PaymentID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PaymentID.ToString());  set => TargettedRow[TableColumnNames.PaymentID.ToString()] = value; }


       public DateTime TransactionDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.TransactionDate.ToString());  set => TargettedRow[TableColumnNames.TransactionDate.ToString()] = value; }


       public string Channel { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Channel.ToString());  set => TargettedRow[TableColumnNames.Channel.ToString()] = value; }


       public string IpAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IpAddress.ToString());  set => TargettedRow[TableColumnNames.IpAddress.ToString()] = value; }


       public decimal GatewayCharges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.GatewayCharges.ToString());  set => TargettedRow[TableColumnNames.GatewayCharges.ToString()] = value; }


       public string GatewayLogReference { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.GatewayLogReference.ToString());  set => TargettedRow[TableColumnNames.GatewayLogReference.ToString()] = value; }


       public string Gateway { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Gateway.ToString());  set => TargettedRow[TableColumnNames.Gateway.ToString()] = value; }


       public decimal PlatformCharges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PlatformCharges.ToString());  set => TargettedRow[TableColumnNames.PlatformCharges.ToString()] = value; }


       public decimal GatewayAmountReceived { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.GatewayAmountReceived.ToString());  set => TargettedRow[TableColumnNames.GatewayAmountReceived.ToString()] = value; }


       public decimal PlatformAmountReceived { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PlatformAmountReceived.ToString());  set => TargettedRow[TableColumnNames.PlatformAmountReceived.ToString()] = value; }


       public string GatewayChargesExplaination { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.GatewayChargesExplaination.ToString());  set => TargettedRow[TableColumnNames.GatewayChargesExplaination.ToString()] = value; }


       public string PlatformChargesExplaination { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PlatformChargesExplaination.ToString());  set => TargettedRow[TableColumnNames.PlatformChargesExplaination.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___OnlinePayment GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___OnlinePayment GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___OnlinePayment(conn.Fetch(OnlinePayment__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___OnlinePayment GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___OnlinePayment( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___OnlinePayment GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => OnlinePayment__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamPaymentID;
            private DataColumnParameter ParamTransactionDate;
            private DataColumnParameter ParamChannel;
            private DataColumnParameter ParamIpAddress;
            private DataColumnParameter ParamGatewayCharges;
            private DataColumnParameter ParamGatewayLogReference;
            private DataColumnParameter ParamGateway;
            private DataColumnParameter ParamPlatformCharges;
            private DataColumnParameter ParamGatewayAmountReceived;
            private DataColumnParameter ParamPlatformAmountReceived;
            private DataColumnParameter ParamGatewayChargesExplaination;
            private DataColumnParameter ParamPlatformChargesExplaination;
            private DataColumnParameter ParamCreatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___OnlinePayment v):this(v.ID)                  
            {                  

                ParamPaymentID = new(defPaymentID, v.PaymentID);                  
                ParamTransactionDate = new(defTransactionDate, v.TransactionDate);                  
                ParamChannel = new(defChannel, v.Channel);                  
                ParamIpAddress = new(defIpAddress, v.IpAddress);                  
                ParamGatewayCharges = new(defGatewayCharges, v.GatewayCharges);                  
                ParamGatewayLogReference = new(defGatewayLogReference, v.GatewayLogReference);                  
                ParamGateway = new(defGateway, v.Gateway);                  
                ParamPlatformCharges = new(defPlatformCharges, v.PlatformCharges);                  
                ParamGatewayAmountReceived = new(defGatewayAmountReceived, v.GatewayAmountReceived);                  
                ParamPlatformAmountReceived = new(defPlatformAmountReceived, v.PlatformAmountReceived);                  
                ParamGatewayChargesExplaination = new(defGatewayChargesExplaination, v.GatewayChargesExplaination);                  
                ParamPlatformChargesExplaination = new(defPlatformChargesExplaination, v.PlatformChargesExplaination);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentID(int v)                  
            {                  
                ParamPaymentID = new(defPaymentID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionDate(DateTime v)                  
            {                  
                ParamTransactionDate = new(defTransactionDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChannel(string v)                  
            {                  
                ParamChannel = new(defChannel, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIpAddress(string v)                  
            {                  
                ParamIpAddress = new(defIpAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGatewayCharges(decimal v)                  
            {                  
                ParamGatewayCharges = new(defGatewayCharges, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGatewayLogReference(string v)                  
            {                  
                ParamGatewayLogReference = new(defGatewayLogReference, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGateway(string v)                  
            {                  
                ParamGateway = new(defGateway, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPlatformCharges(decimal v)                  
            {                  
                ParamPlatformCharges = new(defPlatformCharges, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGatewayAmountReceived(decimal v)                  
            {                  
                ParamGatewayAmountReceived = new(defGatewayAmountReceived, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPlatformAmountReceived(decimal v)                  
            {                  
                ParamPlatformAmountReceived = new(defPlatformAmountReceived, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGatewayChargesExplaination(string v)                  
            {                  
                ParamGatewayChargesExplaination = new(defGatewayChargesExplaination, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPlatformChargesExplaination(string v)                  
            {                  
                ParamPlatformChargesExplaination = new(defPlatformChargesExplaination, v);                  
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
            int PaymentID
,            DateTime TransactionDate
,            string Channel
,            string IpAddress
,            decimal GatewayCharges
,            string GatewayLogReference
,            string Gateway
,            decimal PlatformCharges
,            decimal GatewayAmountReceived
,            decimal PlatformAmountReceived
,            DateTime CreatedAt
,            string GatewayChargesExplaination = null
,            string PlatformChargesExplaination = null
          ){

                DataColumnParameter paramPaymentID = new (defPaymentID, PaymentID);
                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramGatewayCharges = new (defGatewayCharges, GatewayCharges);
                DataColumnParameter paramGatewayLogReference = new (defGatewayLogReference, GatewayLogReference);
                DataColumnParameter paramGateway = new (defGateway, Gateway);
                DataColumnParameter paramPlatformCharges = new (defPlatformCharges, PlatformCharges);
                DataColumnParameter paramGatewayAmountReceived = new (defGatewayAmountReceived, GatewayAmountReceived);
                DataColumnParameter paramPlatformAmountReceived = new (defPlatformAmountReceived, PlatformAmountReceived);
                DataColumnParameter paramGatewayChargesExplaination = new (defGatewayChargesExplaination, GatewayChargesExplaination);
                DataColumnParameter paramPlatformChargesExplaination = new (defPlatformChargesExplaination, PlatformChargesExplaination);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramPaymentID.GetSQLValue(),
                        paramTransactionDate.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramGatewayCharges.GetSQLValue(),
                        paramGatewayLogReference.GetSQLValue(),
                        paramGateway.GetSQLValue(),
                        paramPlatformCharges.GetSQLValue(),
                        paramGatewayAmountReceived.GetSQLValue(),
                        paramPlatformAmountReceived.GetSQLValue(),
                        paramGatewayChargesExplaination.GetSQLValue(),
                        paramPlatformChargesExplaination.GetSQLValue(),
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
        public static bool AddWithID(TransactionRunner runner,
            int ID
,            int PaymentID
,            DateTime TransactionDate
,            string Channel
,            string IpAddress
,            decimal GatewayCharges
,            string GatewayLogReference
,            string Gateway
,            decimal PlatformCharges
,            decimal GatewayAmountReceived
,            decimal PlatformAmountReceived
,            DateTime CreatedAt
,            string GatewayChargesExplaination = null
,            string PlatformChargesExplaination = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPaymentID = new (defPaymentID, PaymentID);
                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramGatewayCharges = new (defGatewayCharges, GatewayCharges);
                DataColumnParameter paramGatewayLogReference = new (defGatewayLogReference, GatewayLogReference);
                DataColumnParameter paramGateway = new (defGateway, Gateway);
                DataColumnParameter paramPlatformCharges = new (defPlatformCharges, PlatformCharges);
                DataColumnParameter paramGatewayAmountReceived = new (defGatewayAmountReceived, GatewayAmountReceived);
                DataColumnParameter paramPlatformAmountReceived = new (defPlatformAmountReceived, PlatformAmountReceived);
                DataColumnParameter paramGatewayChargesExplaination = new (defGatewayChargesExplaination, GatewayChargesExplaination);
                DataColumnParameter paramPlatformChargesExplaination = new (defPlatformChargesExplaination, PlatformChargesExplaination);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramPaymentID.GetSQLValue(),
                        paramTransactionDate.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramGatewayCharges.GetSQLValue(),
                        paramGatewayLogReference.GetSQLValue(),
                        paramGateway.GetSQLValue(),
                        paramPlatformCharges.GetSQLValue(),
                        paramGatewayAmountReceived.GetSQLValue(),
                        paramPlatformAmountReceived.GetSQLValue(),
                        paramGatewayChargesExplaination.GetSQLValue(),
                        paramPlatformChargesExplaination.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int PaymentID
,            DateTime TransactionDate
,            string Channel
,            string IpAddress
,            decimal GatewayCharges
,            string GatewayLogReference
,            string Gateway
,            decimal PlatformCharges
,            decimal GatewayAmountReceived
,            decimal PlatformAmountReceived
,            DateTime CreatedAt
,            string GatewayChargesExplaination = null
,            string PlatformChargesExplaination = null
          ){

                DataColumnParameter paramPaymentID = new (defPaymentID, PaymentID);
                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramGatewayCharges = new (defGatewayCharges, GatewayCharges);
                DataColumnParameter paramGatewayLogReference = new (defGatewayLogReference, GatewayLogReference);
                DataColumnParameter paramGateway = new (defGateway, Gateway);
                DataColumnParameter paramPlatformCharges = new (defPlatformCharges, PlatformCharges);
                DataColumnParameter paramGatewayAmountReceived = new (defGatewayAmountReceived, GatewayAmountReceived);
                DataColumnParameter paramPlatformAmountReceived = new (defPlatformAmountReceived, PlatformAmountReceived);
                DataColumnParameter paramGatewayChargesExplaination = new (defGatewayChargesExplaination, GatewayChargesExplaination);
                DataColumnParameter paramPlatformChargesExplaination = new (defPlatformChargesExplaination, PlatformChargesExplaination);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramPaymentID.GetSQLValue(),
                        paramTransactionDate.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramIpAddress.GetSQLValue(),
                        paramGatewayCharges.GetSQLValue(),
                        paramGatewayLogReference.GetSQLValue(),
                        paramGateway.GetSQLValue(),
                        paramPlatformCharges.GetSQLValue(),
                        paramGatewayAmountReceived.GetSQLValue(),
                        paramPlatformAmountReceived.GetSQLValue(),
                        paramGatewayChargesExplaination.GetSQLValue(),
                        paramPlatformChargesExplaination.GetSQLValue(),
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
