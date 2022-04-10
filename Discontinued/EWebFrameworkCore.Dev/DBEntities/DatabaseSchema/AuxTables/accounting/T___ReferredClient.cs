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

    public class T___ReferredClient : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ReferredClient()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDealerID = new DataColumnDefinition(TableColumnNames.DealerID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defReferralTypeID = new DataColumnDefinition(TableColumnNames.ReferralTypeID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defReferralBenefitStatusID = new DataColumnDefinition(TableColumnNames.ReferralBenefitStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDealerID.ColumnName, defDealerID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defReferralTypeID.ColumnName, defReferralTypeID); 
          ColumnDefns.Add(defReferralBenefitStatusID.ColumnName, defReferralBenefitStatusID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_DealerID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "accounting.Dealer"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "academic.Term"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_ReferralTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "accounting.ReferralType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_ReferralBenefitStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "accounting.ReferralBenefitStatus"                  
                            ));                  

          }


                  
       public T___ReferredClient() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ReferredClient(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(DataTable FullTable) : base(FullTable)                                    
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
        public T___ReferredClient(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.ReferredClient";
       public const string ReferredClient__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [DealerID], [ClientID], [TermID], [ReferralTypeID], [ReferralBenefitStatusID], [CreatedAt], [UpdatedAt] FROM accounting.ReferredClient";
       public const string ReferredClient__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [DealerID], [ClientID], [TermID], [ReferralTypeID], [ReferralBenefitStatusID], [CreatedAt], [UpdatedAt] FROM accounting.ReferredClient";


       public enum TableColumnNames
       {

           ID,
           DealerID,
           ClientID,
           TermID,
           ReferralTypeID,
           ReferralBenefitStatusID,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_accounting_ReferredClient, 
           fk_accounting_ReferredClient_DealerID, 
           fk_accounting_ReferredClient_ClientID, 
           fk_accounting_ReferredClient_TermID, 
           fk_accounting_ReferredClient_ReferralTypeID, 
           fk_accounting_ReferredClient_ReferralBenefitStatusID, 
           uq_accounting_ReferredClient_ClientID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDealerID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defReferralTypeID;
       public static readonly DataColumnDefinition defReferralBenefitStatusID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int DealerID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DealerID.ToString());  set => TargettedRow[TableColumnNames.DealerID.ToString()] = value; }


       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public int TermID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermID.ToString());  set => TargettedRow[TableColumnNames.TermID.ToString()] = value; }


       public int ReferralTypeID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ReferralTypeID.ToString());  set => TargettedRow[TableColumnNames.ReferralTypeID.ToString()] = value; }


       public int ReferralBenefitStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ReferralBenefitStatusID.ToString());  set => TargettedRow[TableColumnNames.ReferralBenefitStatusID.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___ReferredClient GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___ReferredClient GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___ReferredClient(conn.Fetch(ReferredClient__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___ReferredClient GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___ReferredClient( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___ReferredClient GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ReferredClient__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamDealerID;
            private DataColumnParameter ParamClientID;
            private DataColumnParameter ParamTermID;
            private DataColumnParameter ParamReferralTypeID;
            private DataColumnParameter ParamReferralBenefitStatusID;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___ReferredClient v):this(v.ID)                  
            {                  

                ParamDealerID = new(defDealerID, v.DealerID);                  
                ParamClientID = new(defClientID, v.ClientID);                  
                ParamTermID = new(defTermID, v.TermID);                  
                ParamReferralTypeID = new(defReferralTypeID, v.ReferralTypeID);                  
                ParamReferralBenefitStatusID = new(defReferralBenefitStatusID, v.ReferralBenefitStatusID);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetDealerID(int v)                  
            {                  
                ParamDealerID = new(defDealerID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetClientID(int v)                  
            {                  
                ParamClientID = new(defClientID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTermID(int v)                  
            {                  
                ParamTermID = new(defTermID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetReferralTypeID(int v)                  
            {                  
                ParamReferralTypeID = new(defReferralTypeID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetReferralBenefitStatusID(int v)                  
            {                  
                ParamReferralBenefitStatusID = new(defReferralBenefitStatusID, v);                  
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
            int DealerID
,            int ClientID
,            int TermID
,            int ReferralTypeID
,            int ReferralBenefitStatusID
,            DateTime CreatedAt
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramDealerID = new (defDealerID, DealerID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramReferralTypeID = new (defReferralTypeID, ReferralTypeID);
                DataColumnParameter paramReferralBenefitStatusID = new (defReferralBenefitStatusID, ReferralBenefitStatusID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([DealerID],[ClientID],[TermID],[ReferralTypeID],[ReferralBenefitStatusID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7})  ", TABLE_NAME,
                        paramDealerID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramReferralTypeID.GetSQLValue(),
                        paramReferralBenefitStatusID.GetSQLValue(),
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
        public static bool AddWithID(TransactionRunner runner,
            int ID
,            int DealerID
,            int ClientID
,            int TermID
,            int ReferralTypeID
,            int ReferralBenefitStatusID
,            DateTime CreatedAt
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramDealerID = new (defDealerID, DealerID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramReferralTypeID = new (defReferralTypeID, ReferralTypeID);
                DataColumnParameter paramReferralBenefitStatusID = new (defReferralBenefitStatusID, ReferralBenefitStatusID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DealerID],[ClientID],[TermID],[ReferralTypeID],[ReferralBenefitStatusID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramDealerID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramReferralTypeID.GetSQLValue(),
                        paramReferralBenefitStatusID.GetSQLValue(),
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
        public static bool Add(TransactionRunner runner,
            int DealerID
,            int ClientID
,            int TermID
,            int ReferralTypeID
,            int ReferralBenefitStatusID
,            DateTime CreatedAt
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramDealerID = new (defDealerID, DealerID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramReferralTypeID = new (defReferralTypeID, ReferralTypeID);
                DataColumnParameter paramReferralBenefitStatusID = new (defReferralBenefitStatusID, ReferralBenefitStatusID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([DealerID],[ClientID],[TermID],[ReferralTypeID],[ReferralBenefitStatusID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7})  ", TABLE_NAME,
                        paramDealerID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramReferralTypeID.GetSQLValue(),
                        paramReferralBenefitStatusID.GetSQLValue(),
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
