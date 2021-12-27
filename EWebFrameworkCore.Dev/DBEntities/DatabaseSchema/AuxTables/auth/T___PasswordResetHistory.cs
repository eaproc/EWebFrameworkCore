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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.auth                  
{                  

    public class T___PasswordResetHistory : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PasswordResetHistory()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defOldPassword = new DataColumnDefinition(TableColumnNames.OldPassword.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNewPassword = new DataColumnDefinition(TableColumnNames.NewPassword.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPasswordResetTypeID = new DataColumnDefinition(TableColumnNames.PasswordResetTypeID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChangedByUserID = new DataColumnDefinition(TableColumnNames.ChangedByUserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defOldPassword.ColumnName, defOldPassword); 
          ColumnDefns.Add(defNewPassword.ColumnName, defNewPassword); 
          ColumnDefns.Add(defPasswordResetTypeID.ColumnName, defPasswordResetTypeID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defChangedByUserID.ColumnName, defChangedByUserID); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetHistory_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetHistory", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetHistory_PasswordResetTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetHistory", "auth.PasswordResetType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetHistory_ChangedByUserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetHistory", "auth.Users"                  
                            ));                  

          }


                  
       public T___PasswordResetHistory() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PasswordResetHistory(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(DataTable FullTable) : base(FullTable)                                    
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
        public T___PasswordResetHistory(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.PasswordResetHistory";
       public const string PasswordResetHistory__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [UserID], [OldPassword], [NewPassword], [PasswordResetTypeID], [CreatedAt], [ChangedByUserID], [IpAddress] FROM auth.PasswordResetHistory";
       public const string PasswordResetHistory__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [UserID], [OldPassword], [NewPassword], [PasswordResetTypeID], [CreatedAt], [ChangedByUserID], [IpAddress] FROM auth.PasswordResetHistory";


       public enum TableColumnNames
       {

           ID,
           UserID,
           OldPassword,
           NewPassword,
           PasswordResetTypeID,
           CreatedAt,
           ChangedByUserID,
           IpAddress
       } 



       public enum TableConstraints{

           pk_auth_PasswordResetHistory, 
           fk_auth_PasswordResetHistory_UserID, 
           fk_auth_PasswordResetHistory_PasswordResetTypeID, 
           fk_auth_PasswordResetHistory_ChangedByUserID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defOldPassword;
       public static readonly DataColumnDefinition defNewPassword;
       public static readonly DataColumnDefinition defPasswordResetTypeID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defChangedByUserID;
       public static readonly DataColumnDefinition defIpAddress;

       public int UserID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UserID.ToString());  set => TargettedRow[TableColumnNames.UserID.ToString()] = value; }


       public string OldPassword { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.OldPassword.ToString());  set => TargettedRow[TableColumnNames.OldPassword.ToString()] = value; }


       public string NewPassword { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.NewPassword.ToString());  set => TargettedRow[TableColumnNames.NewPassword.ToString()] = value; }


       public int PasswordResetTypeID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PasswordResetTypeID.ToString());  set => TargettedRow[TableColumnNames.PasswordResetTypeID.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int ChangedByUserID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ChangedByUserID.ToString());  set => TargettedRow[TableColumnNames.ChangedByUserID.ToString()] = value; }


       public string IpAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IpAddress.ToString());  set => TargettedRow[TableColumnNames.IpAddress.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PasswordResetHistory GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PasswordResetHistory GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___PasswordResetHistory(conn.Fetch(PasswordResetHistory__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___PasswordResetHistory GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___PasswordResetHistory( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___PasswordResetHistory GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PasswordResetHistory__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamUserID;
            private DataColumnParameter ParamOldPassword;
            private DataColumnParameter ParamNewPassword;
            private DataColumnParameter ParamPasswordResetTypeID;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamChangedByUserID;
            private DataColumnParameter ParamIpAddress;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PasswordResetHistory v):this(v.ID)                  
            {                  

                ParamUserID = new(defUserID, v.UserID);                  
                ParamOldPassword = new(defOldPassword, v.OldPassword);                  
                ParamNewPassword = new(defNewPassword, v.NewPassword);                  
                ParamPasswordResetTypeID = new(defPasswordResetTypeID, v.PasswordResetTypeID);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamChangedByUserID = new(defChangedByUserID, v.ChangedByUserID);                  
                ParamIpAddress = new(defIpAddress, v.IpAddress);                  
            }                  
                  
            public UpdateQueryBuilder SetUserID(int v)                  
            {                  
                ParamUserID = new(defUserID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetOldPassword(string v)                  
            {                  
                ParamOldPassword = new(defOldPassword, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetNewPassword(string v)                  
            {                  
                ParamNewPassword = new(defNewPassword, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPasswordResetTypeID(int v)                  
            {                  
                ParamPasswordResetTypeID = new(defPasswordResetTypeID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChangedByUserID(int v)                  
            {                  
                ParamChangedByUserID = new(defChangedByUserID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIpAddress(string v)                  
            {                  
                ParamIpAddress = new(defIpAddress, v);                  
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
            int UserID,
            string OldPassword,
            string NewPassword,
            int PasswordResetTypeID,
            DateTime CreatedAt,
            int ChangedByUserID,
            string IpAddress,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramOldPassword = new (defOldPassword, OldPassword);
                DataColumnParameter paramNewPassword = new (defNewPassword, NewPassword);
                DataColumnParameter paramPasswordResetTypeID = new (defPasswordResetTypeID, PasswordResetTypeID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramChangedByUserID = new (defChangedByUserID, ChangedByUserID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([UserID],[OldPassword],[NewPassword],[PasswordResetTypeID],[CreatedAt],[ChangedByUserID],[IpAddress]) VALUES({1},{2},{3},{4},{5},{6},{7})  ", TABLE_NAME,
                        paramUserID.GetSQLValue(),
                        paramOldPassword.GetSQLValue(),
                        paramNewPassword.GetSQLValue(),
                        paramPasswordResetTypeID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramChangedByUserID.GetSQLValue(),
                        paramIpAddress.GetSQLValue()                        )
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
            int UserID,
            string OldPassword,
            string NewPassword,
            int PasswordResetTypeID,
            DateTime CreatedAt,
            int ChangedByUserID,
            string IpAddress,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramOldPassword = new (defOldPassword, OldPassword);
                DataColumnParameter paramNewPassword = new (defNewPassword, NewPassword);
                DataColumnParameter paramPasswordResetTypeID = new (defPasswordResetTypeID, PasswordResetTypeID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramChangedByUserID = new (defChangedByUserID, ChangedByUserID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[OldPassword],[NewPassword],[PasswordResetTypeID],[CreatedAt],[ChangedByUserID],[IpAddress]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramUserID.GetSQLValue(),
                        paramOldPassword.GetSQLValue(),
                        paramNewPassword.GetSQLValue(),
                        paramPasswordResetTypeID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramChangedByUserID.GetSQLValue(),
                        paramIpAddress.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int UserID,
            string OldPassword,
            string NewPassword,
            int PasswordResetTypeID,
            DateTime CreatedAt,
            int ChangedByUserID,
            string IpAddress,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramOldPassword = new (defOldPassword, OldPassword);
                DataColumnParameter paramNewPassword = new (defNewPassword, NewPassword);
                DataColumnParameter paramPasswordResetTypeID = new (defPasswordResetTypeID, PasswordResetTypeID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramChangedByUserID = new (defChangedByUserID, ChangedByUserID);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([UserID],[OldPassword],[NewPassword],[PasswordResetTypeID],[CreatedAt],[ChangedByUserID],[IpAddress]) VALUES({1},{2},{3},{4},{5},{6},{7})  ", TABLE_NAME,
                        paramUserID.GetSQLValue(),
                        paramOldPassword.GetSQLValue(),
                        paramNewPassword.GetSQLValue(),
                        paramPasswordResetTypeID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramChangedByUserID.GetSQLValue(),
                        paramIpAddress.GetSQLValue()                            
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
