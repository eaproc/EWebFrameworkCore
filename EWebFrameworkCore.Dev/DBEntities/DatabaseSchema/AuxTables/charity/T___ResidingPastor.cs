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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___ResidingPastor : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ResidingPastor()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defActivatedOn = new DataColumnDefinition(TableColumnNames.ActivatedOn.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeactivatedOn = new DataColumnDefinition(TableColumnNames.DeactivatedOn.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIdPictureStoredPath = new DataColumnDefinition(TableColumnNames.IdPictureStoredPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defActivatedOn.ColumnName, defActivatedOn); 
          ColumnDefns.Add(defDeactivatedOn.ColumnName, defDeactivatedOn); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defIdPictureStoredPath.ColumnName, defIdPictureStoredPath); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.ResidingPastor", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "auth.Users"                  
                            ));                  

          }


                  
       public T___ResidingPastor() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ResidingPastor(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(DataTable FullTable) : base(FullTable)                                    
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
        public T___ResidingPastor(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.ResidingPastor";
       public const string ResidingPastor__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BankID], [AccountNumber], [PersonID], [ActivatedOn], [DeactivatedOn], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [IdPictureStoredPath] FROM charity.ResidingPastor";
       public const string ResidingPastor__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BankID], [AccountNumber], [PersonID], [ActivatedOn], [DeactivatedOn], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [IdPictureStoredPath] FROM charity.ResidingPastor";


       public enum TableColumnNames
       {

           ID,
           CenterID,
           BankID,
           AccountNumber,
           PersonID,
           ActivatedOn,
           DeactivatedOn,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID,
           IdPictureStoredPath
       } 



       public enum TableConstraints{

           pk_charity_ResidingPastor, 
           fk_charity_ResidingPastor_CenterID, 
           fk_charity_ResidingPastor_BankID, 
           fk_charity_ResidingPastor_PersonID, 
           fk_charity_ResidingPastor_CreatedByID, 
           fk_charity_ResidingPastor_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defActivatedOn;
       public static readonly DataColumnDefinition defDeactivatedOn;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defIdPictureStoredPath;

       public int CenterID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CenterID.ToString());  set => TargettedRow[TableColumnNames.CenterID.ToString()] = value; }


       public int BankID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BankID.ToString());  set => TargettedRow[TableColumnNames.BankID.ToString()] = value; }


       public string AccountNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountNumber.ToString());  set => TargettedRow[TableColumnNames.AccountNumber.ToString()] = value; }


       public int PersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonID.ToString());  set => TargettedRow[TableColumnNames.PersonID.ToString()] = value; }


       public DateTime ActivatedOn { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.ActivatedOn.ToString());  set => TargettedRow[TableColumnNames.ActivatedOn.ToString()] = value; }


       public DateTime? DeactivatedOn { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.DeactivatedOn.ToString());  set => TargettedRow[TableColumnNames.DeactivatedOn.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime UpdatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int UpdatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


       public string IdPictureStoredPath { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IdPictureStoredPath.ToString());  set => TargettedRow[TableColumnNames.IdPictureStoredPath.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___ResidingPastor GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___ResidingPastor GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___ResidingPastor(conn.Fetch(ResidingPastor__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___ResidingPastor GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___ResidingPastor( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___ResidingPastor GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ResidingPastor__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCenterID;
            private DataColumnParameter ParamBankID;
            private DataColumnParameter ParamAccountNumber;
            private DataColumnParameter ParamPersonID;
            private DataColumnParameter ParamActivatedOn;
            private DataColumnParameter ParamDeactivatedOn;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;
            private DataColumnParameter ParamIdPictureStoredPath;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___ResidingPastor v):this(v.ID)                  
            {                  

                ParamCenterID = new(defCenterID, v.CenterID);                  
                ParamBankID = new(defBankID, v.BankID);                  
                ParamAccountNumber = new(defAccountNumber, v.AccountNumber);                  
                ParamPersonID = new(defPersonID, v.PersonID);                  
                ParamActivatedOn = new(defActivatedOn, v.ActivatedOn);                  
                ParamDeactivatedOn = new(defDeactivatedOn, v.DeactivatedOn);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
                ParamIdPictureStoredPath = new(defIdPictureStoredPath, v.IdPictureStoredPath);                  
            }                  
                  
            public UpdateQueryBuilder SetCenterID(int v)                  
            {                  
                ParamCenterID = new(defCenterID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBankID(int v)                  
            {                  
                ParamBankID = new(defBankID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAccountNumber(string v)                  
            {                  
                ParamAccountNumber = new(defAccountNumber, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPersonID(int v)                  
            {                  
                ParamPersonID = new(defPersonID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetActivatedOn(DateTime v)                  
            {                  
                ParamActivatedOn = new(defActivatedOn, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDeactivatedOn(DateTime? v)                  
            {                  
                ParamDeactivatedOn = new(defDeactivatedOn, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime v)                  
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
                  
            public UpdateQueryBuilder SetIdPictureStoredPath(string v)                  
            {                  
                ParamIdPictureStoredPath = new(defIdPictureStoredPath, v);                  
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
            int CenterID
,            int BankID
,            string AccountNumber
,            int PersonID
,            DateTime ActivatedOn
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            DateTime? DeactivatedOn = null
,            string IdPictureStoredPath = null
          ){

                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramActivatedOn = new (defActivatedOn, ActivatedOn);
                DataColumnParameter paramDeactivatedOn = new (defDeactivatedOn, DeactivatedOn);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramIdPictureStoredPath = new (defIdPictureStoredPath, IdPictureStoredPath);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterID],[BankID],[AccountNumber],[PersonID],[ActivatedOn],[DeactivatedOn],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[IdPictureStoredPath]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  ", TABLE_NAME,
                        paramCenterID.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramActivatedOn.GetSQLValue(),
                        paramDeactivatedOn.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramIdPictureStoredPath.GetSQLValue()                        )
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
,            int CenterID
,            int BankID
,            string AccountNumber
,            int PersonID
,            DateTime ActivatedOn
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            DateTime? DeactivatedOn = null
,            string IdPictureStoredPath = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramActivatedOn = new (defActivatedOn, ActivatedOn);
                DataColumnParameter paramDeactivatedOn = new (defDeactivatedOn, DeactivatedOn);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramIdPictureStoredPath = new (defIdPictureStoredPath, IdPictureStoredPath);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BankID],[AccountNumber],[PersonID],[ActivatedOn],[DeactivatedOn],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[IdPictureStoredPath]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCenterID.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramActivatedOn.GetSQLValue(),
                        paramDeactivatedOn.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramIdPictureStoredPath.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int CenterID
,            int BankID
,            string AccountNumber
,            int PersonID
,            DateTime ActivatedOn
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            DateTime? DeactivatedOn = null
,            string IdPictureStoredPath = null
          ){

                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramActivatedOn = new (defActivatedOn, ActivatedOn);
                DataColumnParameter paramDeactivatedOn = new (defDeactivatedOn, DeactivatedOn);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramIdPictureStoredPath = new (defIdPictureStoredPath, IdPictureStoredPath);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterID],[BankID],[AccountNumber],[PersonID],[ActivatedOn],[DeactivatedOn],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[IdPictureStoredPath]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  ", TABLE_NAME,
                        paramCenterID.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramActivatedOn.GetSQLValue(),
                        paramDeactivatedOn.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramIdPictureStoredPath.GetSQLValue()                            
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
