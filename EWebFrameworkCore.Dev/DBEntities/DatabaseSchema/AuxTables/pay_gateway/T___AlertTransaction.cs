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

    public class T___AlertTransaction : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___AlertTransaction()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionDate = new DataColumnDefinition(TableColumnNames.TransactionDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionReference = new DataColumnDefinition(TableColumnNames.TransactionReference.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defDescription = new DataColumnDefinition(TableColumnNames.Description.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(TableColumnNames.Channel.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmed = new DataColumnDefinition(TableColumnNames.Confirmed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defProcessed = new DataColumnDefinition(TableColumnNames.Processed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTransactionDate.ColumnName, defTransactionDate); 
          ColumnDefns.Add(defTransactionReference.ColumnName, defTransactionReference); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
          ColumnDefns.Add(defChannel.ColumnName, defChannel); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defConfirmed.ColumnName, defConfirmed); 
          ColumnDefns.Add(defProcessed.ColumnName, defProcessed); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  


          }


                  
       public T___AlertTransaction() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___AlertTransaction(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AlertTransaction(DataTable FullTable) : base(FullTable)                                    
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
        public T___AlertTransaction(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.AlertTransaction";
       public const string AlertTransaction__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TransactionDate], [TransactionReference], [Description], [Channel], [Total], [Confirmed], [Processed], [CreatedAt], [UpdatedAt] FROM pay_gateway.AlertTransaction";
       public const string AlertTransaction__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TransactionDate], [TransactionReference], [Description], [Channel], [Total], [Confirmed], [Processed], [CreatedAt], [UpdatedAt] FROM pay_gateway.AlertTransaction";


       public enum TableColumnNames
       {

           ID,
           TransactionDate,
           TransactionReference,
           Description,
           Channel,
           Total,
           Confirmed,
           Processed,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_pay_gateway_AlertTransaction, 
           uq_pay_gateway_AlertTransaction_TransactionReference, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTransactionDate;
       public static readonly DataColumnDefinition defTransactionReference;
       public static readonly DataColumnDefinition defDescription;
       public static readonly DataColumnDefinition defChannel;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defConfirmed;
       public static readonly DataColumnDefinition defProcessed;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public DateTime TransactionDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.TransactionDate.ToString());  set => TargettedRow[TableColumnNames.TransactionDate.ToString()] = value; }


       public string TransactionReference { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.TransactionReference.ToString());  set => TargettedRow[TableColumnNames.TransactionReference.ToString()] = value; }


       public string Description { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Description.ToString());  set => TargettedRow[TableColumnNames.Description.ToString()] = value; }


       public string Channel { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Channel.ToString());  set => TargettedRow[TableColumnNames.Channel.ToString()] = value; }


       public decimal Total { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Total.ToString());  set => TargettedRow[TableColumnNames.Total.ToString()] = value; }


       public bool Confirmed { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.Confirmed.ToString());  set => TargettedRow[TableColumnNames.Confirmed.ToString()] = value; }


       public bool Processed { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.Processed.ToString());  set => TargettedRow[TableColumnNames.Processed.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___AlertTransaction GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___AlertTransaction GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___AlertTransaction(conn.Fetch(AlertTransaction__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___AlertTransaction GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___AlertTransaction( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___AlertTransaction GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => AlertTransaction__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTransactionDate;
            private DataColumnParameter ParamTransactionReference;
            private DataColumnParameter ParamDescription;
            private DataColumnParameter ParamChannel;
            private DataColumnParameter ParamTotal;
            private DataColumnParameter ParamConfirmed;
            private DataColumnParameter ParamProcessed;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___AlertTransaction v):this(v.ID)                  
            {                  

                ParamTransactionDate = new(defTransactionDate, v.TransactionDate);                  
                ParamTransactionReference = new(defTransactionReference, v.TransactionReference);                  
                ParamDescription = new(defDescription, v.Description);                  
                ParamChannel = new(defChannel, v.Channel);                  
                ParamTotal = new(defTotal, v.Total);                  
                ParamConfirmed = new(defConfirmed, v.Confirmed);                  
                ParamProcessed = new(defProcessed, v.Processed);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionDate(DateTime v)                  
            {                  
                ParamTransactionDate = new(defTransactionDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTransactionReference(string v)                  
            {                  
                ParamTransactionReference = new(defTransactionReference, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDescription(string v)                  
            {                  
                ParamDescription = new(defDescription, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChannel(string v)                  
            {                  
                ParamChannel = new(defChannel, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTotal(decimal v)                  
            {                  
                ParamTotal = new(defTotal, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetConfirmed(bool v)                  
            {                  
                ParamConfirmed = new(defConfirmed, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetProcessed(bool v)                  
            {                  
                ParamProcessed = new(defProcessed, v);                  
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
            DateTime TransactionDate,
            string TransactionReference,
            string Description,
            string Channel,
            decimal Total,
            bool Confirmed,
            bool Processed,
            DateTime CreatedAt,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramTransactionReference = new (defTransactionReference, TransactionReference);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramConfirmed = new (defConfirmed, Confirmed);
                DataColumnParameter paramProcessed = new (defProcessed, Processed);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionDate],[TransactionReference],[Description],[Channel],[Total],[Confirmed],[Processed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramTransactionDate.GetSQLValue(),
                        paramTransactionReference.GetSQLValue(),
                        paramDescription.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramConfirmed.GetSQLValue(),
                        paramProcessed.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue()                        )
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
            DateTime TransactionDate,
            string TransactionReference,
            string Description,
            string Channel,
            decimal Total,
            bool Confirmed,
            bool Processed,
            DateTime CreatedAt,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramTransactionReference = new (defTransactionReference, TransactionReference);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramConfirmed = new (defConfirmed, Confirmed);
                DataColumnParameter paramProcessed = new (defProcessed, Processed);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionDate],[TransactionReference],[Description],[Channel],[Total],[Confirmed],[Processed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTransactionDate.GetSQLValue(),
                        paramTransactionReference.GetSQLValue(),
                        paramDescription.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramConfirmed.GetSQLValue(),
                        paramProcessed.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            DateTime TransactionDate,
            string TransactionReference,
            string Description,
            string Channel,
            decimal Total,
            bool Confirmed,
            bool Processed,
            DateTime CreatedAt,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramTransactionReference = new (defTransactionReference, TransactionReference);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramTotal = new (defTotal, Total);
                DataColumnParameter paramConfirmed = new (defConfirmed, Confirmed);
                DataColumnParameter paramProcessed = new (defProcessed, Processed);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionDate],[TransactionReference],[Description],[Channel],[Total],[Confirmed],[Processed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramTransactionDate.GetSQLValue(),
                        paramTransactionReference.GetSQLValue(),
                        paramDescription.GetSQLValue(),
                        paramChannel.GetSQLValue(),
                        paramTotal.GetSQLValue(),
                        paramConfirmed.GetSQLValue(),
                        paramProcessed.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue()                            
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
