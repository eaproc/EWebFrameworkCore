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

    public class T___BusinessPlan : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___BusinessPlan()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAcademicSessionID = new DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defStudentPopulation = new DataColumnDefinition(TableColumnNames.StudentPopulation.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAveragePricePerStudent = new DataColumnDefinition(TableColumnNames.AveragePricePerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessRevenue = new DataColumnDefinition(TableColumnNames.SCADWAREAccessRevenue.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSideContractRevenue = new DataColumnDefinition(TableColumnNames.SideContractRevenue.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGrossRevenue = new DataColumnDefinition(TableColumnNames.GrossRevenue.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWages = new DataColumnDefinition(TableColumnNames.Wages.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMarketing = new DataColumnDefinition(TableColumnNames.Marketing.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharity = new DataColumnDefinition(TableColumnNames.Charity.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOthers = new DataColumnDefinition(TableColumnNames.Others.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
          ColumnDefns.Add(defStudentPopulation.ColumnName, defStudentPopulation); 
          ColumnDefns.Add(defAveragePricePerStudent.ColumnName, defAveragePricePerStudent); 
          ColumnDefns.Add(defSCADWAREAccessRevenue.ColumnName, defSCADWAREAccessRevenue); 
          ColumnDefns.Add(defSideContractRevenue.ColumnName, defSideContractRevenue); 
          ColumnDefns.Add(defGrossRevenue.ColumnName, defGrossRevenue); 
          ColumnDefns.Add(defWages.ColumnName, defWages); 
          ColumnDefns.Add(defMarketing.ColumnName, defMarketing); 
          ColumnDefns.Add(defCharity.ColumnName, defCharity); 
          ColumnDefns.Add(defOthers.ColumnName, defOthers); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_BusinessPlan_AcademicSessionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.BusinessPlan", "academic.AcademicSession"                  
                            ));                  

          }


                  
       public T___BusinessPlan() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___BusinessPlan(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(DataTable FullTable) : base(FullTable)                                    
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
        public T___BusinessPlan(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.BusinessPlan";
       public const string BusinessPlan__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM accounting.BusinessPlan";
       public const string BusinessPlan__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM accounting.BusinessPlan";


       public enum TableColumnNames
       {

           ID,
           AcademicSessionID,
           StudentPopulation,
           AveragePricePerStudent,
           SCADWAREAccessRevenue,
           SideContractRevenue,
           GrossRevenue,
           Wages,
           Marketing,
           Charity,
           Others,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_accounting_BusinessPlan, 
           fk_accounting_BusinessPlan_AcademicSessionID, 
           uq_accounting_BusinessPlan_AcademicSessionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAcademicSessionID;
       public static readonly DataColumnDefinition defStudentPopulation;
       public static readonly DataColumnDefinition defAveragePricePerStudent;
       public static readonly DataColumnDefinition defSCADWAREAccessRevenue;
       public static readonly DataColumnDefinition defSideContractRevenue;
       public static readonly DataColumnDefinition defGrossRevenue;
       public static readonly DataColumnDefinition defWages;
       public static readonly DataColumnDefinition defMarketing;
       public static readonly DataColumnDefinition defCharity;
       public static readonly DataColumnDefinition defOthers;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int AcademicSessionID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AcademicSessionID.ToString());  set => TargettedRow[TableColumnNames.AcademicSessionID.ToString()] = value; }


       public int StudentPopulation { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.StudentPopulation.ToString());  set => TargettedRow[TableColumnNames.StudentPopulation.ToString()] = value; }


       public decimal AveragePricePerStudent { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.AveragePricePerStudent.ToString());  set => TargettedRow[TableColumnNames.AveragePricePerStudent.ToString()] = value; }


       public decimal SCADWAREAccessRevenue { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.SCADWAREAccessRevenue.ToString());  set => TargettedRow[TableColumnNames.SCADWAREAccessRevenue.ToString()] = value; }


       public decimal SideContractRevenue { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.SideContractRevenue.ToString());  set => TargettedRow[TableColumnNames.SideContractRevenue.ToString()] = value; }


       public decimal GrossRevenue { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.GrossRevenue.ToString());  set => TargettedRow[TableColumnNames.GrossRevenue.ToString()] = value; }


       public decimal Wages { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Wages.ToString());  set => TargettedRow[TableColumnNames.Wages.ToString()] = value; }


       public decimal Marketing { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Marketing.ToString());  set => TargettedRow[TableColumnNames.Marketing.ToString()] = value; }


       public decimal Charity { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Charity.ToString());  set => TargettedRow[TableColumnNames.Charity.ToString()] = value; }


       public decimal Others { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Others.ToString());  set => TargettedRow[TableColumnNames.Others.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___BusinessPlan GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___BusinessPlan GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___BusinessPlan(conn.Fetch(BusinessPlan__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___BusinessPlan GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___BusinessPlan( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___BusinessPlan GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => BusinessPlan__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamAcademicSessionID;
            private DataColumnParameter ParamStudentPopulation;
            private DataColumnParameter ParamAveragePricePerStudent;
            private DataColumnParameter ParamSCADWAREAccessRevenue;
            private DataColumnParameter ParamSideContractRevenue;
            private DataColumnParameter ParamGrossRevenue;
            private DataColumnParameter ParamWages;
            private DataColumnParameter ParamMarketing;
            private DataColumnParameter ParamCharity;
            private DataColumnParameter ParamOthers;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___BusinessPlan v):this(v.ID)                  
            {                  

                ParamAcademicSessionID = new(defAcademicSessionID, v.AcademicSessionID);                  
                ParamStudentPopulation = new(defStudentPopulation, v.StudentPopulation);                  
                ParamAveragePricePerStudent = new(defAveragePricePerStudent, v.AveragePricePerStudent);                  
                ParamSCADWAREAccessRevenue = new(defSCADWAREAccessRevenue, v.SCADWAREAccessRevenue);                  
                ParamSideContractRevenue = new(defSideContractRevenue, v.SideContractRevenue);                  
                ParamGrossRevenue = new(defGrossRevenue, v.GrossRevenue);                  
                ParamWages = new(defWages, v.Wages);                  
                ParamMarketing = new(defMarketing, v.Marketing);                  
                ParamCharity = new(defCharity, v.Charity);                  
                ParamOthers = new(defOthers, v.Others);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetAcademicSessionID(int v)                  
            {                  
                ParamAcademicSessionID = new(defAcademicSessionID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetStudentPopulation(int v)                  
            {                  
                ParamStudentPopulation = new(defStudentPopulation, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAveragePricePerStudent(decimal v)                  
            {                  
                ParamAveragePricePerStudent = new(defAveragePricePerStudent, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSCADWAREAccessRevenue(decimal v)                  
            {                  
                ParamSCADWAREAccessRevenue = new(defSCADWAREAccessRevenue, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSideContractRevenue(decimal v)                  
            {                  
                ParamSideContractRevenue = new(defSideContractRevenue, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGrossRevenue(decimal v)                  
            {                  
                ParamGrossRevenue = new(defGrossRevenue, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetWages(decimal v)                  
            {                  
                ParamWages = new(defWages, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMarketing(decimal v)                  
            {                  
                ParamMarketing = new(defMarketing, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCharity(decimal v)                  
            {                  
                ParamCharity = new(defCharity, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetOthers(decimal v)                  
            {                  
                ParamOthers = new(defOthers, v);                  
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
            int AcademicSessionID
,            int StudentPopulation
,            decimal AveragePricePerStudent
,            decimal SCADWAREAccessRevenue
,            decimal SideContractRevenue
,            decimal GrossRevenue
,            decimal Wages
,            decimal Marketing
,            decimal Charity
,            decimal Others
,            DateTime CreatedAt
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);
                DataColumnParameter paramStudentPopulation = new (defStudentPopulation, StudentPopulation);
                DataColumnParameter paramAveragePricePerStudent = new (defAveragePricePerStudent, AveragePricePerStudent);
                DataColumnParameter paramSCADWAREAccessRevenue = new (defSCADWAREAccessRevenue, SCADWAREAccessRevenue);
                DataColumnParameter paramSideContractRevenue = new (defSideContractRevenue, SideContractRevenue);
                DataColumnParameter paramGrossRevenue = new (defGrossRevenue, GrossRevenue);
                DataColumnParameter paramWages = new (defWages, Wages);
                DataColumnParameter paramMarketing = new (defMarketing, Marketing);
                DataColumnParameter paramCharity = new (defCharity, Charity);
                DataColumnParameter paramOthers = new (defOthers, Others);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramAcademicSessionID.GetSQLValue(),
                        paramStudentPopulation.GetSQLValue(),
                        paramAveragePricePerStudent.GetSQLValue(),
                        paramSCADWAREAccessRevenue.GetSQLValue(),
                        paramSideContractRevenue.GetSQLValue(),
                        paramGrossRevenue.GetSQLValue(),
                        paramWages.GetSQLValue(),
                        paramMarketing.GetSQLValue(),
                        paramCharity.GetSQLValue(),
                        paramOthers.GetSQLValue(),
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
,            int AcademicSessionID
,            int StudentPopulation
,            decimal AveragePricePerStudent
,            decimal SCADWAREAccessRevenue
,            decimal SideContractRevenue
,            decimal GrossRevenue
,            decimal Wages
,            decimal Marketing
,            decimal Charity
,            decimal Others
,            DateTime CreatedAt
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);
                DataColumnParameter paramStudentPopulation = new (defStudentPopulation, StudentPopulation);
                DataColumnParameter paramAveragePricePerStudent = new (defAveragePricePerStudent, AveragePricePerStudent);
                DataColumnParameter paramSCADWAREAccessRevenue = new (defSCADWAREAccessRevenue, SCADWAREAccessRevenue);
                DataColumnParameter paramSideContractRevenue = new (defSideContractRevenue, SideContractRevenue);
                DataColumnParameter paramGrossRevenue = new (defGrossRevenue, GrossRevenue);
                DataColumnParameter paramWages = new (defWages, Wages);
                DataColumnParameter paramMarketing = new (defMarketing, Marketing);
                DataColumnParameter paramCharity = new (defCharity, Charity);
                DataColumnParameter paramOthers = new (defOthers, Others);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramAcademicSessionID.GetSQLValue(),
                        paramStudentPopulation.GetSQLValue(),
                        paramAveragePricePerStudent.GetSQLValue(),
                        paramSCADWAREAccessRevenue.GetSQLValue(),
                        paramSideContractRevenue.GetSQLValue(),
                        paramGrossRevenue.GetSQLValue(),
                        paramWages.GetSQLValue(),
                        paramMarketing.GetSQLValue(),
                        paramCharity.GetSQLValue(),
                        paramOthers.GetSQLValue(),
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
            int AcademicSessionID
,            int StudentPopulation
,            decimal AveragePricePerStudent
,            decimal SCADWAREAccessRevenue
,            decimal SideContractRevenue
,            decimal GrossRevenue
,            decimal Wages
,            decimal Marketing
,            decimal Charity
,            decimal Others
,            DateTime CreatedAt
,            DateTime? UpdatedAt = null
          ){

                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);
                DataColumnParameter paramStudentPopulation = new (defStudentPopulation, StudentPopulation);
                DataColumnParameter paramAveragePricePerStudent = new (defAveragePricePerStudent, AveragePricePerStudent);
                DataColumnParameter paramSCADWAREAccessRevenue = new (defSCADWAREAccessRevenue, SCADWAREAccessRevenue);
                DataColumnParameter paramSideContractRevenue = new (defSideContractRevenue, SideContractRevenue);
                DataColumnParameter paramGrossRevenue = new (defGrossRevenue, GrossRevenue);
                DataColumnParameter paramWages = new (defWages, Wages);
                DataColumnParameter paramMarketing = new (defMarketing, Marketing);
                DataColumnParameter paramCharity = new (defCharity, Charity);
                DataColumnParameter paramOthers = new (defOthers, Others);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramAcademicSessionID.GetSQLValue(),
                        paramStudentPopulation.GetSQLValue(),
                        paramAveragePricePerStudent.GetSQLValue(),
                        paramSCADWAREAccessRevenue.GetSQLValue(),
                        paramSideContractRevenue.GetSQLValue(),
                        paramGrossRevenue.GetSQLValue(),
                        paramWages.GetSQLValue(),
                        paramMarketing.GetSQLValue(),
                        paramCharity.GetSQLValue(),
                        paramOthers.GetSQLValue(),
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
