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

    public class T___Users : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Users()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUsername = new DataColumnDefinition(TableColumnNames.Username.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defUserPassword = new DataColumnDefinition(TableColumnNames.UserPassword.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRememberToken = new DataColumnDefinition(TableColumnNames.RememberToken.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResetModeCarrier = new DataColumnDefinition(TableColumnNames.ResetModeCarrier.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defUserPassword.ColumnName, defUserPassword); 
          ColumnDefns.Add(defRememberToken.ColumnName, defRememberToken); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defResetModeCarrier.ColumnName, defResetModeCarrier); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Users_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "auth.Users", "common.Person"                  
                            ));                  

          }


                  
       public T___Users() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Users(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(DataTable FullTable) : base(FullTable)                                    
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
        public T___Users(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.Users";
       public const string Users__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Username], [PersonID], [UserPassword], [RememberToken], [IsActive], [CreatedAt], [UpdatedAt], [ResetModeCarrier] FROM auth.Users";
       public const string Users__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Username], [PersonID], [UserPassword], [RememberToken], [IsActive], [CreatedAt], [UpdatedAt], [ResetModeCarrier] FROM auth.Users";


       public enum TableColumnNames
       {

           ID,
           Username,
           PersonID,
           UserPassword,
           RememberToken,
           IsActive,
           CreatedAt,
           UpdatedAt,
           ResetModeCarrier
       } 



       public enum TableConstraints{

           pk_auth_Users, 
           fk_auth_Users_PersonID, 
           uq_auth_Users_PersonID, 
           uq_auth_Users_Username, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defUserPassword;
       public static readonly DataColumnDefinition defRememberToken;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defResetModeCarrier;

       public string Username { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Username.ToString());  set => TargettedRow[TableColumnNames.Username.ToString()] = value; }


       public int PersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonID.ToString());  set => TargettedRow[TableColumnNames.PersonID.ToString()] = value; }


       public string UserPassword { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.UserPassword.ToString());  set => TargettedRow[TableColumnNames.UserPassword.ToString()] = value; }


       public string RememberToken { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.RememberToken.ToString());  set => TargettedRow[TableColumnNames.RememberToken.ToString()] = value; }


       public bool IsActive { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public string ResetModeCarrier { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ResetModeCarrier.ToString());  set => TargettedRow[TableColumnNames.ResetModeCarrier.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Users GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Users GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Users(conn.Fetch(Users__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Users GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Users( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Users GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Users__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamUsername;
            private DataColumnParameter ParamPersonID;
            private DataColumnParameter ParamUserPassword;
            private DataColumnParameter ParamRememberToken;
            private DataColumnParameter ParamIsActive;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamResetModeCarrier;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Users v):this(v.ID)                  
            {                  

                ParamUsername = new(defUsername, v.Username);                  
                ParamPersonID = new(defPersonID, v.PersonID);                  
                ParamUserPassword = new(defUserPassword, v.UserPassword);                  
                ParamRememberToken = new(defRememberToken, v.RememberToken);                  
                ParamIsActive = new(defIsActive, v.IsActive);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamResetModeCarrier = new(defResetModeCarrier, v.ResetModeCarrier);                  
            }                  
                  
            public UpdateQueryBuilder SetUsername(string v)                  
            {                  
                ParamUsername = new(defUsername, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPersonID(int v)                  
            {                  
                ParamPersonID = new(defPersonID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUserPassword(string v)                  
            {                  
                ParamUserPassword = new(defUserPassword, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRememberToken(string v)                  
            {                  
                ParamRememberToken = new(defRememberToken, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsActive(bool v)                  
            {                  
                ParamIsActive = new(defIsActive, v);                  
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
                  
            public UpdateQueryBuilder SetResetModeCarrier(string v)                  
            {                  
                ParamResetModeCarrier = new(defResetModeCarrier, v);                  
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
            string Username,
            int PersonID,
            string UserPassword,
            bool IsActive,
            DateTime CreatedAt,
            string RememberToken = null,
            DateTime? UpdatedAt = null,
            string ResetModeCarrier = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUsername = new (defUsername, Username);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramUserPassword = new (defUserPassword, UserPassword);
                DataColumnParameter paramRememberToken = new (defRememberToken, RememberToken);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramResetModeCarrier = new (defResetModeCarrier, ResetModeCarrier);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Username],[PersonID],[UserPassword],[RememberToken],[IsActive],[CreatedAt],[UpdatedAt],[ResetModeCarrier]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramUsername.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramUserPassword.GetSQLValue(),
                        paramRememberToken.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramResetModeCarrier.GetSQLValue()                        )
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
            string Username,
            int PersonID,
            string UserPassword,
            bool IsActive,
            DateTime CreatedAt,
            string RememberToken = null,
            DateTime? UpdatedAt = null,
            string ResetModeCarrier = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramUsername = new (defUsername, Username);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramUserPassword = new (defUserPassword, UserPassword);
                DataColumnParameter paramRememberToken = new (defRememberToken, RememberToken);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramResetModeCarrier = new (defResetModeCarrier, ResetModeCarrier);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Username],[PersonID],[UserPassword],[RememberToken],[IsActive],[CreatedAt],[UpdatedAt],[ResetModeCarrier]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramUsername.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramUserPassword.GetSQLValue(),
                        paramRememberToken.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramResetModeCarrier.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            string Username,
            int PersonID,
            string UserPassword,
            bool IsActive,
            DateTime CreatedAt,
            string RememberToken = null,
            DateTime? UpdatedAt = null,
            string ResetModeCarrier = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUsername = new (defUsername, Username);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramUserPassword = new (defUserPassword, UserPassword);
                DataColumnParameter paramRememberToken = new (defRememberToken, RememberToken);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramResetModeCarrier = new (defResetModeCarrier, ResetModeCarrier);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Username],[PersonID],[UserPassword],[RememberToken],[IsActive],[CreatedAt],[UpdatedAt],[ResetModeCarrier]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramUsername.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramUserPassword.GetSQLValue(),
                        paramRememberToken.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramResetModeCarrier.GetSQLValue()                            
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
