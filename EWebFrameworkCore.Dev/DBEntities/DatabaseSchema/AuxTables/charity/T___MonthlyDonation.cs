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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___MonthlyDonation : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___MonthlyDonation()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defResidingPastorID = new DataColumnDefinition(TableColumnNames.ResidingPastorID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationYear = new DataColumnDefinition(TableColumnNames.DonationYear.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationMonth = new DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(TableColumnNames.IsApproved.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defResidingPastorID.ColumnName, defResidingPastorID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear); 
          ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.MonthlyDonation", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_ResidingPastorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "charity.ResidingPastor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "common.Bank"                  
                            ));                  

          }


                  
       public T___MonthlyDonation() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___MonthlyDonation(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(DataTable FullTable) : base(FullTable)                                    
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
        public T___MonthlyDonation(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.MonthlyDonation";
       public const string MonthlyDonation__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.MonthlyDonation";
       public const string MonthlyDonation__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.MonthlyDonation";


       public enum TableColumnNames
       {

           ID,
           CenterID,
           ResidingPastorID,
           BankID,
           AccountNumber,
           DonationYear,
           DonationMonth,
           IsApproved,
           IsDisbursed,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_MonthlyDonation, 
           fk_charity_MonthlyDonation_UpdatedByID, 
           fk_charity_MonthlyDonation_CenterID, 
           fk_charity_MonthlyDonation_ResidingPastorID, 
           fk_charity_MonthlyDonation_CreatedByID, 
           fk_charity_MonthlyDonation_BankID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defResidingPastorID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defDonationYear;
       public static readonly DataColumnDefinition defDonationMonth;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int CenterID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CenterID.ToString());  set => TargettedRow[TableColumnNames.CenterID.ToString()] = value; }


       public int ResidingPastorID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ResidingPastorID.ToString());  set => TargettedRow[TableColumnNames.ResidingPastorID.ToString()] = value; }


       public int BankID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BankID.ToString());  set => TargettedRow[TableColumnNames.BankID.ToString()] = value; }


       public string AccountNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountNumber.ToString());  set => TargettedRow[TableColumnNames.AccountNumber.ToString()] = value; }


       public int DonationYear { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DonationYear.ToString());  set => TargettedRow[TableColumnNames.DonationYear.ToString()] = value; }


       public int DonationMonth { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DonationMonth.ToString());  set => TargettedRow[TableColumnNames.DonationMonth.ToString()] = value; }


       public bool IsApproved { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsApproved.ToString());  set => TargettedRow[TableColumnNames.IsApproved.ToString()] = value; }


       public bool IsDisbursed { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsDisbursed.ToString());  set => TargettedRow[TableColumnNames.IsDisbursed.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime UpdatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int UpdatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___MonthlyDonation GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___MonthlyDonation GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___MonthlyDonation(conn.Fetch(MonthlyDonation__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___MonthlyDonation GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___MonthlyDonation( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___MonthlyDonation GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => MonthlyDonation__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCenterID;
            private DataColumnParameter ParamResidingPastorID;
            private DataColumnParameter ParamBankID;
            private DataColumnParameter ParamAccountNumber;
            private DataColumnParameter ParamDonationYear;
            private DataColumnParameter ParamDonationMonth;
            private DataColumnParameter ParamIsApproved;
            private DataColumnParameter ParamIsDisbursed;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___MonthlyDonation v):this(v.ID)                  
            {                  

                ParamCenterID = new(defCenterID, v.CenterID);                  
                ParamResidingPastorID = new(defResidingPastorID, v.ResidingPastorID);                  
                ParamBankID = new(defBankID, v.BankID);                  
                ParamAccountNumber = new(defAccountNumber, v.AccountNumber);                  
                ParamDonationYear = new(defDonationYear, v.DonationYear);                  
                ParamDonationMonth = new(defDonationMonth, v.DonationMonth);                  
                ParamIsApproved = new(defIsApproved, v.IsApproved);                  
                ParamIsDisbursed = new(defIsDisbursed, v.IsDisbursed);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetCenterID(int v)                  
            {                  
                ParamCenterID = new(defCenterID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetResidingPastorID(int v)                  
            {                  
                ParamResidingPastorID = new(defResidingPastorID, v);                  
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
                  
            public UpdateQueryBuilder SetDonationYear(int v)                  
            {                  
                ParamDonationYear = new(defDonationYear, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDonationMonth(int v)                  
            {                  
                ParamDonationMonth = new(defDonationMonth, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsApproved(bool v)                  
            {                  
                ParamIsApproved = new(defIsApproved, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsDisbursed(bool v)                  
            {                  
                ParamIsDisbursed = new(defIsDisbursed, v);                  
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
            int CenterID,
            int ResidingPastorID,
            int BankID,
            string AccountNumber,
            int DonationYear,
            int DonationMonth,
            bool IsApproved,
            bool IsDisbursed,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramResidingPastorID = new (defResidingPastorID, ResidingPastorID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramDonationYear = new (defDonationYear, DonationYear);
                DataColumnParameter paramDonationMonth = new (defDonationMonth, DonationMonth);
                DataColumnParameter paramIsApproved = new (defIsApproved, IsApproved);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramCenterID.GetSQLValue(),
                        paramResidingPastorID.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramDonationYear.GetSQLValue(),
                        paramDonationMonth.GetSQLValue(),
                        paramIsApproved.GetSQLValue(),
                        paramIsDisbursed.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
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
            int CenterID,
            int ResidingPastorID,
            int BankID,
            string AccountNumber,
            int DonationYear,
            int DonationMonth,
            bool IsApproved,
            bool IsDisbursed,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramResidingPastorID = new (defResidingPastorID, ResidingPastorID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramDonationYear = new (defDonationYear, DonationYear);
                DataColumnParameter paramDonationMonth = new (defDonationMonth, DonationMonth);
                DataColumnParameter paramIsApproved = new (defIsApproved, IsApproved);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCenterID.GetSQLValue(),
                        paramResidingPastorID.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramDonationYear.GetSQLValue(),
                        paramDonationMonth.GetSQLValue(),
                        paramIsApproved.GetSQLValue(),
                        paramIsDisbursed.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int CenterID,
            int ResidingPastorID,
            int BankID,
            string AccountNumber,
            int DonationYear,
            int DonationMonth,
            bool IsApproved,
            bool IsDisbursed,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramResidingPastorID = new (defResidingPastorID, ResidingPastorID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramDonationYear = new (defDonationYear, DonationYear);
                DataColumnParameter paramDonationMonth = new (defDonationMonth, DonationMonth);
                DataColumnParameter paramIsApproved = new (defIsApproved, IsApproved);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramCenterID.GetSQLValue(),
                        paramResidingPastorID.GetSQLValue(),
                        paramBankID.GetSQLValue(),
                        paramAccountNumber.GetSQLValue(),
                        paramDonationYear.GetSQLValue(),
                        paramDonationMonth.GetSQLValue(),
                        paramIsApproved.GetSQLValue(),
                        paramIsDisbursed.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                            
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
