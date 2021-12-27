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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___SMSUsage : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___SMSUsage()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defSMSDeliveryStatusID = new DataColumnDefinition(TableColumnNames.SMSDeliveryStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSender = new DataColumnDefinition(TableColumnNames.Sender.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReceiver = new DataColumnDefinition(TableColumnNames.Receiver.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMessage = new DataColumnDefinition(TableColumnNames.Message.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUID = new DataColumnDefinition(TableColumnNames.UID.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAPICreateResponse = new DataColumnDefinition(TableColumnNames.APICreateResponse.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAPIUpdateResponse = new DataColumnDefinition(TableColumnNames.APIUpdateResponse.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSMSCostNaira = new DataColumnDefinition(TableColumnNames.SMSCostNaira.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(TableColumnNames.ExceptionMessage.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionStackTrace = new DataColumnDefinition(TableColumnNames.ExceptionStackTrace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(TableColumnNames.Gateway.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defSMSDeliveryStatusID.ColumnName, defSMSDeliveryStatusID); 
          ColumnDefns.Add(defSender.ColumnName, defSender); 
          ColumnDefns.Add(defReceiver.ColumnName, defReceiver); 
          ColumnDefns.Add(defMessage.ColumnName, defMessage); 
          ColumnDefns.Add(defUID.ColumnName, defUID); 
          ColumnDefns.Add(defAPICreateResponse.ColumnName, defAPICreateResponse); 
          ColumnDefns.Add(defAPIUpdateResponse.ColumnName, defAPIUpdateResponse); 
          ColumnDefns.Add(defSMSCostNaira.ColumnName, defSMSCostNaira); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defExceptionMessage.ColumnName, defExceptionMessage); 
          ColumnDefns.Add(defExceptionStackTrace.ColumnName, defExceptionStackTrace); 
          ColumnDefns.Add(defGateway.ColumnName, defGateway); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_SMSUsage_SMSDeliveryStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.SMSUsage", "system.SMSDeliveryStatus"                  
                            ));                  

          }


                  
       public T___SMSUsage() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___SMSUsage(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(DataTable FullTable) : base(FullTable)                                    
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
        public T___SMSUsage(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.SMSUsage";
       public const string SMSUsage__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [SMSDeliveryStatusID], [Sender], [Receiver], [Message], [UID], [APICreateResponse], [APIUpdateResponse], [SMSCostNaira], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM system.SMSUsage";
       public const string SMSUsage__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [SMSDeliveryStatusID], [Sender], [Receiver], [Message], [UID], [APICreateResponse], [APIUpdateResponse], [SMSCostNaira], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM system.SMSUsage";


       public enum TableColumnNames
       {

           ID,
           SMSDeliveryStatusID,
           Sender,
           Receiver,
           Message,
           UID,
           APICreateResponse,
           APIUpdateResponse,
           SMSCostNaira,
           CreatedAt,
           UpdatedAt,
           ExceptionMessage,
           ExceptionStackTrace,
           Gateway
       } 



       public enum TableConstraints{

           pk_system_SMSUsage, 
           fk_system_SMSUsage_SMSDeliveryStatusID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defSMSDeliveryStatusID;
       public static readonly DataColumnDefinition defSender;
       public static readonly DataColumnDefinition defReceiver;
       public static readonly DataColumnDefinition defMessage;
       public static readonly DataColumnDefinition defUID;
       public static readonly DataColumnDefinition defAPICreateResponse;
       public static readonly DataColumnDefinition defAPIUpdateResponse;
       public static readonly DataColumnDefinition defSMSCostNaira;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defExceptionMessage;
       public static readonly DataColumnDefinition defExceptionStackTrace;
       public static readonly DataColumnDefinition defGateway;

       public int SMSDeliveryStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.SMSDeliveryStatusID.ToString());  set => TargettedRow[TableColumnNames.SMSDeliveryStatusID.ToString()] = value; }


       public string Sender { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Sender.ToString());  set => TargettedRow[TableColumnNames.Sender.ToString()] = value; }


       public string Receiver { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Receiver.ToString());  set => TargettedRow[TableColumnNames.Receiver.ToString()] = value; }


       public string Message { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Message.ToString());  set => TargettedRow[TableColumnNames.Message.ToString()] = value; }


       public string UID { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.UID.ToString());  set => TargettedRow[TableColumnNames.UID.ToString()] = value; }


       public string APICreateResponse { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.APICreateResponse.ToString());  set => TargettedRow[TableColumnNames.APICreateResponse.ToString()] = value; }


       public string APIUpdateResponse { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.APIUpdateResponse.ToString());  set => TargettedRow[TableColumnNames.APIUpdateResponse.ToString()] = value; }


       public decimal? SMSCostNaira { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.SMSCostNaira.ToString());  set => TargettedRow[TableColumnNames.SMSCostNaira.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public string ExceptionMessage { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ExceptionMessage.ToString());  set => TargettedRow[TableColumnNames.ExceptionMessage.ToString()] = value; }


       public string ExceptionStackTrace { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ExceptionStackTrace.ToString());  set => TargettedRow[TableColumnNames.ExceptionStackTrace.ToString()] = value; }


       public string Gateway { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Gateway.ToString());  set => TargettedRow[TableColumnNames.Gateway.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___SMSUsage GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___SMSUsage GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___SMSUsage(conn.Fetch(SMSUsage__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___SMSUsage GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___SMSUsage( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___SMSUsage GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => SMSUsage__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamSMSDeliveryStatusID;
            private DataColumnParameter ParamSender;
            private DataColumnParameter ParamReceiver;
            private DataColumnParameter ParamMessage;
            private DataColumnParameter ParamUID;
            private DataColumnParameter ParamAPICreateResponse;
            private DataColumnParameter ParamAPIUpdateResponse;
            private DataColumnParameter ParamSMSCostNaira;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamExceptionMessage;
            private DataColumnParameter ParamExceptionStackTrace;
            private DataColumnParameter ParamGateway;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___SMSUsage v):this(v.ID)                  
            {                  

                ParamSMSDeliveryStatusID = new(defSMSDeliveryStatusID, v.SMSDeliveryStatusID);                  
                ParamSender = new(defSender, v.Sender);                  
                ParamReceiver = new(defReceiver, v.Receiver);                  
                ParamMessage = new(defMessage, v.Message);                  
                ParamUID = new(defUID, v.UID);                  
                ParamAPICreateResponse = new(defAPICreateResponse, v.APICreateResponse);                  
                ParamAPIUpdateResponse = new(defAPIUpdateResponse, v.APIUpdateResponse);                  
                ParamSMSCostNaira = new(defSMSCostNaira, v.SMSCostNaira);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamExceptionMessage = new(defExceptionMessage, v.ExceptionMessage);                  
                ParamExceptionStackTrace = new(defExceptionStackTrace, v.ExceptionStackTrace);                  
                ParamGateway = new(defGateway, v.Gateway);                  
            }                  
                  
            public UpdateQueryBuilder SetSMSDeliveryStatusID(int v)                  
            {                  
                ParamSMSDeliveryStatusID = new(defSMSDeliveryStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSender(string v)                  
            {                  
                ParamSender = new(defSender, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetReceiver(string v)                  
            {                  
                ParamReceiver = new(defReceiver, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMessage(string v)                  
            {                  
                ParamMessage = new(defMessage, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUID(string v)                  
            {                  
                ParamUID = new(defUID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAPICreateResponse(string v)                  
            {                  
                ParamAPICreateResponse = new(defAPICreateResponse, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAPIUpdateResponse(string v)                  
            {                  
                ParamAPIUpdateResponse = new(defAPIUpdateResponse, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSMSCostNaira(decimal? v)                  
            {                  
                ParamSMSCostNaira = new(defSMSCostNaira, v);                  
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
                  
            public UpdateQueryBuilder SetExceptionMessage(string v)                  
            {                  
                ParamExceptionMessage = new(defExceptionMessage, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetExceptionStackTrace(string v)                  
            {                  
                ParamExceptionStackTrace = new(defExceptionStackTrace, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGateway(string v)                  
            {                  
                ParamGateway = new(defGateway, v);                  
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
            int SMSDeliveryStatusID
,            string Sender
,            string Receiver
,            string Message
,            DateTime CreatedAt
,            string Gateway
,            string UID = null
,            string APICreateResponse = null
,            string APIUpdateResponse = null
,            decimal? SMSCostNaira = null
,            DateTime? UpdatedAt = null
,            string ExceptionMessage = null
,            string ExceptionStackTrace = null
          ){

                DataColumnParameter paramSMSDeliveryStatusID = new (defSMSDeliveryStatusID, SMSDeliveryStatusID);
                DataColumnParameter paramSender = new (defSender, Sender);
                DataColumnParameter paramReceiver = new (defReceiver, Receiver);
                DataColumnParameter paramMessage = new (defMessage, Message);
                DataColumnParameter paramUID = new (defUID, UID);
                DataColumnParameter paramAPICreateResponse = new (defAPICreateResponse, APICreateResponse);
                DataColumnParameter paramAPIUpdateResponse = new (defAPIUpdateResponse, APIUpdateResponse);
                DataColumnParameter paramSMSCostNaira = new (defSMSCostNaira, SMSCostNaira);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new (defExceptionStackTrace, ExceptionStackTrace);
                DataColumnParameter paramGateway = new (defGateway, Gateway);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramSMSDeliveryStatusID.GetSQLValue(),
                        paramSender.GetSQLValue(),
                        paramReceiver.GetSQLValue(),
                        paramMessage.GetSQLValue(),
                        paramUID.GetSQLValue(),
                        paramAPICreateResponse.GetSQLValue(),
                        paramAPIUpdateResponse.GetSQLValue(),
                        paramSMSCostNaira.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramExceptionMessage.GetSQLValue(),
                        paramExceptionStackTrace.GetSQLValue(),
                        paramGateway.GetSQLValue()                        )
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
,            int SMSDeliveryStatusID
,            string Sender
,            string Receiver
,            string Message
,            DateTime CreatedAt
,            string Gateway
,            string UID = null
,            string APICreateResponse = null
,            string APIUpdateResponse = null
,            decimal? SMSCostNaira = null
,            DateTime? UpdatedAt = null
,            string ExceptionMessage = null
,            string ExceptionStackTrace = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramSMSDeliveryStatusID = new (defSMSDeliveryStatusID, SMSDeliveryStatusID);
                DataColumnParameter paramSender = new (defSender, Sender);
                DataColumnParameter paramReceiver = new (defReceiver, Receiver);
                DataColumnParameter paramMessage = new (defMessage, Message);
                DataColumnParameter paramUID = new (defUID, UID);
                DataColumnParameter paramAPICreateResponse = new (defAPICreateResponse, APICreateResponse);
                DataColumnParameter paramAPIUpdateResponse = new (defAPIUpdateResponse, APIUpdateResponse);
                DataColumnParameter paramSMSCostNaira = new (defSMSCostNaira, SMSCostNaira);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new (defExceptionStackTrace, ExceptionStackTrace);
                DataColumnParameter paramGateway = new (defGateway, Gateway);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramSMSDeliveryStatusID.GetSQLValue(),
                        paramSender.GetSQLValue(),
                        paramReceiver.GetSQLValue(),
                        paramMessage.GetSQLValue(),
                        paramUID.GetSQLValue(),
                        paramAPICreateResponse.GetSQLValue(),
                        paramAPIUpdateResponse.GetSQLValue(),
                        paramSMSCostNaira.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramExceptionMessage.GetSQLValue(),
                        paramExceptionStackTrace.GetSQLValue(),
                        paramGateway.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int SMSDeliveryStatusID
,            string Sender
,            string Receiver
,            string Message
,            DateTime CreatedAt
,            string Gateway
,            string UID = null
,            string APICreateResponse = null
,            string APIUpdateResponse = null
,            decimal? SMSCostNaira = null
,            DateTime? UpdatedAt = null
,            string ExceptionMessage = null
,            string ExceptionStackTrace = null
          ){

                DataColumnParameter paramSMSDeliveryStatusID = new (defSMSDeliveryStatusID, SMSDeliveryStatusID);
                DataColumnParameter paramSender = new (defSender, Sender);
                DataColumnParameter paramReceiver = new (defReceiver, Receiver);
                DataColumnParameter paramMessage = new (defMessage, Message);
                DataColumnParameter paramUID = new (defUID, UID);
                DataColumnParameter paramAPICreateResponse = new (defAPICreateResponse, APICreateResponse);
                DataColumnParameter paramAPIUpdateResponse = new (defAPIUpdateResponse, APIUpdateResponse);
                DataColumnParameter paramSMSCostNaira = new (defSMSCostNaira, SMSCostNaira);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new (defExceptionStackTrace, ExceptionStackTrace);
                DataColumnParameter paramGateway = new (defGateway, Gateway);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramSMSDeliveryStatusID.GetSQLValue(),
                        paramSender.GetSQLValue(),
                        paramReceiver.GetSQLValue(),
                        paramMessage.GetSQLValue(),
                        paramUID.GetSQLValue(),
                        paramAPICreateResponse.GetSQLValue(),
                        paramAPIUpdateResponse.GetSQLValue(),
                        paramSMSCostNaira.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramExceptionMessage.GetSQLValue(),
                        paramExceptionStackTrace.GetSQLValue(),
                        paramGateway.GetSQLValue()                            
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
