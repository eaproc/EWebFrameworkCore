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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___Payroll : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Payroll()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defStartDate = new DataColumnDefinition(TableColumnNames.StartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(TableColumnNames.EndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayrollWorkingDays = new DataColumnDefinition(TableColumnNames.PayrollWorkingDays.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(TableColumnNames.IsApproved.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMonthWorkingDays = new DataColumnDefinition(TableColumnNames.MonthWorkingDays.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defPayrollWorkingDays.ColumnName, defPayrollWorkingDays); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defMonthWorkingDays.ColumnName, defMonthWorkingDays); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Payroll_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Payroll", "auth.Users"                  
                            ));                  

          }


                  
       public T___Payroll() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Payroll(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(DataTable FullTable) : base(FullTable)                                    
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
        public T___Payroll(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.Payroll";
       public const string Payroll__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [StartDate], [EndDate], [PayrollWorkingDays], [IsApproved], [MonthWorkingDays], [CreatedAt], [CreatedByID] FROM hr.Payroll";
       public const string Payroll__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [StartDate], [EndDate], [PayrollWorkingDays], [IsApproved], [MonthWorkingDays], [CreatedAt], [CreatedByID] FROM hr.Payroll";


       public enum TableColumnNames
       {

           ID,
           StartDate,
           EndDate,
           PayrollWorkingDays,
           IsApproved,
           MonthWorkingDays,
           CreatedAt,
           CreatedByID
       } 



       public enum TableConstraints{

           pk_hr_Payroll, 
           fk_hr_Payroll_CreatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defPayrollWorkingDays;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defMonthWorkingDays;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;

       public DateTime StartDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.StartDate.ToString());  set => TargettedRow[TableColumnNames.StartDate.ToString()] = value; }


       public DateTime EndDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.EndDate.ToString());  set => TargettedRow[TableColumnNames.EndDate.ToString()] = value; }


       public int PayrollWorkingDays { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PayrollWorkingDays.ToString());  set => TargettedRow[TableColumnNames.PayrollWorkingDays.ToString()] = value; }


       public bool IsApproved { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsApproved.ToString());  set => TargettedRow[TableColumnNames.IsApproved.ToString()] = value; }


       public int MonthWorkingDays { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.MonthWorkingDays.ToString());  set => TargettedRow[TableColumnNames.MonthWorkingDays.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Payroll GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Payroll GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Payroll(conn.Fetch(Payroll__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Payroll GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Payroll( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Payroll GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Payroll__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamStartDate;
            private DataColumnParameter ParamEndDate;
            private DataColumnParameter ParamPayrollWorkingDays;
            private DataColumnParameter ParamIsApproved;
            private DataColumnParameter ParamMonthWorkingDays;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Payroll v):this(v.ID)                  
            {                  

                ParamStartDate = new(defStartDate, v.StartDate);                  
                ParamEndDate = new(defEndDate, v.EndDate);                  
                ParamPayrollWorkingDays = new(defPayrollWorkingDays, v.PayrollWorkingDays);                  
                ParamIsApproved = new(defIsApproved, v.IsApproved);                  
                ParamMonthWorkingDays = new(defMonthWorkingDays, v.MonthWorkingDays);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetStartDate(DateTime v)                  
            {                  
                ParamStartDate = new(defStartDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEndDate(DateTime v)                  
            {                  
                ParamEndDate = new(defEndDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPayrollWorkingDays(int v)                  
            {                  
                ParamPayrollWorkingDays = new(defPayrollWorkingDays, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsApproved(bool v)                  
            {                  
                ParamIsApproved = new(defIsApproved, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMonthWorkingDays(int v)                  
            {                  
                ParamMonthWorkingDays = new(defMonthWorkingDays, v);                  
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
            DateTime StartDate,
            DateTime EndDate,
            int PayrollWorkingDays,
            bool IsApproved,
            int MonthWorkingDays,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramPayrollWorkingDays = new (defPayrollWorkingDays, PayrollWorkingDays);
                DataColumnParameter paramIsApproved = new (defIsApproved, IsApproved);
                DataColumnParameter paramMonthWorkingDays = new (defMonthWorkingDays, MonthWorkingDays);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([StartDate],[EndDate],[PayrollWorkingDays],[IsApproved],[MonthWorkingDays],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7})  ", TABLE_NAME,
                        paramStartDate.GetSQLValue(),
                        paramEndDate.GetSQLValue(),
                        paramPayrollWorkingDays.GetSQLValue(),
                        paramIsApproved.GetSQLValue(),
                        paramMonthWorkingDays.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue()                        )
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
            DateTime StartDate,
            DateTime EndDate,
            int PayrollWorkingDays,
            bool IsApproved,
            int MonthWorkingDays,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramPayrollWorkingDays = new (defPayrollWorkingDays, PayrollWorkingDays);
                DataColumnParameter paramIsApproved = new (defIsApproved, IsApproved);
                DataColumnParameter paramMonthWorkingDays = new (defMonthWorkingDays, MonthWorkingDays);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[StartDate],[EndDate],[PayrollWorkingDays],[IsApproved],[MonthWorkingDays],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramStartDate.GetSQLValue(),
                        paramEndDate.GetSQLValue(),
                        paramPayrollWorkingDays.GetSQLValue(),
                        paramIsApproved.GetSQLValue(),
                        paramMonthWorkingDays.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            DateTime StartDate,
            DateTime EndDate,
            int PayrollWorkingDays,
            bool IsApproved,
            int MonthWorkingDays,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramPayrollWorkingDays = new (defPayrollWorkingDays, PayrollWorkingDays);
                DataColumnParameter paramIsApproved = new (defIsApproved, IsApproved);
                DataColumnParameter paramMonthWorkingDays = new (defMonthWorkingDays, MonthWorkingDays);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([StartDate],[EndDate],[PayrollWorkingDays],[IsApproved],[MonthWorkingDays],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7})  ", TABLE_NAME,
                        paramStartDate.GetSQLValue(),
                        paramEndDate.GetSQLValue(),
                        paramPayrollWorkingDays.GetSQLValue(),
                        paramIsApproved.GetSQLValue(),
                        paramMonthWorkingDays.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue()                            
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
