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

    public class T___PayrollPersonnel : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PayrollPersonnel()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPayrollID = new DataColumnDefinition(TableColumnNames.PayrollID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonnelID = new DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defAttendanceCount = new DataColumnDefinition(TableColumnNames.AttendanceCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSalaryAmount = new DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerDay = new DataColumnDefinition(TableColumnNames.RatePerDay.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalculatedAmount = new DataColumnDefinition(TableColumnNames.CalculatedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHRComments = new DataColumnDefinition(TableColumnNames.HRComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defApprovedAmount = new DataColumnDefinition(TableColumnNames.ApprovedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBursarComments = new DataColumnDefinition(TableColumnNames.BursarComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedAmount = new DataColumnDefinition(TableColumnNames.DisbursedAmount.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDisbursedAt = new DataColumnDefinition(TableColumnNames.DisbursedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPayrollID.ColumnName, defPayrollID); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defAttendanceCount.ColumnName, defAttendanceCount); 
          ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount); 
          ColumnDefns.Add(defRatePerDay.ColumnName, defRatePerDay); 
          ColumnDefns.Add(defCalculatedAmount.ColumnName, defCalculatedAmount); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defHRComments.ColumnName, defHRComments); 
          ColumnDefns.Add(defApprovedAmount.ColumnName, defApprovedAmount); 
          ColumnDefns.Add(defBursarComments.ColumnName, defBursarComments); 
          ColumnDefns.Add(defDisbursedAmount.ColumnName, defDisbursedAmount); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defDisbursedAt.ColumnName, defDisbursedAt); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_PayrollID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "hr.PayrollPersonnel", "hr.Payroll"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_PersonnelID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "hr.Personnel"                  
                            ));                  

          }


                  
       public T___PayrollPersonnel() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PayrollPersonnel(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(DataTable FullTable) : base(FullTable)                                    
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
        public T___PayrollPersonnel(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.PayrollPersonnel";
       public const string PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM hr.PayrollPersonnel";
       public const string PayrollPersonnel__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM hr.PayrollPersonnel";


       public enum TableColumnNames
       {

           ID,
           PayrollID,
           PersonnelID,
           AttendanceCount,
           SalaryAmount,
           RatePerDay,
           CalculatedAmount,
           IsDisbursed,
           HRComments,
           ApprovedAmount,
           BursarComments,
           DisbursedAmount,
           UpdatedAt,
           CreatedAt,
           CreatedByID,
           DisbursedAt,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_hr_PayrollPersonnel, 
           fk_hr_PayrollPersonnel_CreatedByID, 
           fk_hr_PayrollPersonnel_UpdatedByID, 
           fk_hr_PayrollPersonnel_PayrollID, 
           fk_hr_PayrollPersonnel_PersonnelID, 
           uq_hr_PayrollPersonnel_PersonnelID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPayrollID;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defAttendanceCount;
       public static readonly DataColumnDefinition defSalaryAmount;
       public static readonly DataColumnDefinition defRatePerDay;
       public static readonly DataColumnDefinition defCalculatedAmount;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defHRComments;
       public static readonly DataColumnDefinition defApprovedAmount;
       public static readonly DataColumnDefinition defBursarComments;
       public static readonly DataColumnDefinition defDisbursedAmount;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defDisbursedAt;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int PayrollID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PayrollID.ToString());  set => TargettedRow[TableColumnNames.PayrollID.ToString()] = value; }


       public int PersonnelID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonnelID.ToString());  set => TargettedRow[TableColumnNames.PersonnelID.ToString()] = value; }


       public int AttendanceCount { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AttendanceCount.ToString());  set => TargettedRow[TableColumnNames.AttendanceCount.ToString()] = value; }


       public decimal SalaryAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.SalaryAmount.ToString());  set => TargettedRow[TableColumnNames.SalaryAmount.ToString()] = value; }


       public decimal RatePerDay { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RatePerDay.ToString());  set => TargettedRow[TableColumnNames.RatePerDay.ToString()] = value; }


       public decimal CalculatedAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.CalculatedAmount.ToString());  set => TargettedRow[TableColumnNames.CalculatedAmount.ToString()] = value; }


       public bool IsDisbursed { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsDisbursed.ToString());  set => TargettedRow[TableColumnNames.IsDisbursed.ToString()] = value; }


       public string HRComments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HRComments.ToString());  set => TargettedRow[TableColumnNames.HRComments.ToString()] = value; }


       public decimal ApprovedAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.ApprovedAmount.ToString());  set => TargettedRow[TableColumnNames.ApprovedAmount.ToString()] = value; }


       public string BursarComments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BursarComments.ToString());  set => TargettedRow[TableColumnNames.BursarComments.ToString()] = value; }


       public decimal? DisbursedAmount { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.DisbursedAmount.ToString());  set => TargettedRow[TableColumnNames.DisbursedAmount.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public DateTime? DisbursedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.DisbursedAt.ToString());  set => TargettedRow[TableColumnNames.DisbursedAt.ToString()] = value; }


       public int? UpdatedByID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PayrollPersonnel GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PayrollPersonnel GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___PayrollPersonnel(conn.Fetch(PayrollPersonnel__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___PayrollPersonnel GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___PayrollPersonnel( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___PayrollPersonnel GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamPayrollID;
            private DataColumnParameter ParamPersonnelID;
            private DataColumnParameter ParamAttendanceCount;
            private DataColumnParameter ParamSalaryAmount;
            private DataColumnParameter ParamRatePerDay;
            private DataColumnParameter ParamCalculatedAmount;
            private DataColumnParameter ParamIsDisbursed;
            private DataColumnParameter ParamHRComments;
            private DataColumnParameter ParamApprovedAmount;
            private DataColumnParameter ParamBursarComments;
            private DataColumnParameter ParamDisbursedAmount;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamDisbursedAt;
            private DataColumnParameter ParamUpdatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PayrollPersonnel v):this(v.ID)                  
            {                  

                ParamPayrollID = new(defPayrollID, v.PayrollID);                  
                ParamPersonnelID = new(defPersonnelID, v.PersonnelID);                  
                ParamAttendanceCount = new(defAttendanceCount, v.AttendanceCount);                  
                ParamSalaryAmount = new(defSalaryAmount, v.SalaryAmount);                  
                ParamRatePerDay = new(defRatePerDay, v.RatePerDay);                  
                ParamCalculatedAmount = new(defCalculatedAmount, v.CalculatedAmount);                  
                ParamIsDisbursed = new(defIsDisbursed, v.IsDisbursed);                  
                ParamHRComments = new(defHRComments, v.HRComments);                  
                ParamApprovedAmount = new(defApprovedAmount, v.ApprovedAmount);                  
                ParamBursarComments = new(defBursarComments, v.BursarComments);                  
                ParamDisbursedAmount = new(defDisbursedAmount, v.DisbursedAmount);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamDisbursedAt = new(defDisbursedAt, v.DisbursedAt);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetPayrollID(int v)                  
            {                  
                ParamPayrollID = new(defPayrollID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPersonnelID(int v)                  
            {                  
                ParamPersonnelID = new(defPersonnelID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAttendanceCount(int v)                  
            {                  
                ParamAttendanceCount = new(defAttendanceCount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSalaryAmount(decimal v)                  
            {                  
                ParamSalaryAmount = new(defSalaryAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRatePerDay(decimal v)                  
            {                  
                ParamRatePerDay = new(defRatePerDay, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCalculatedAmount(decimal v)                  
            {                  
                ParamCalculatedAmount = new(defCalculatedAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsDisbursed(bool v)                  
            {                  
                ParamIsDisbursed = new(defIsDisbursed, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetHRComments(string v)                  
            {                  
                ParamHRComments = new(defHRComments, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetApprovedAmount(decimal v)                  
            {                  
                ParamApprovedAmount = new(defApprovedAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBursarComments(string v)                  
            {                  
                ParamBursarComments = new(defBursarComments, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDisbursedAmount(decimal? v)                  
            {                  
                ParamDisbursedAmount = new(defDisbursedAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime? v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
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
                  
            public UpdateQueryBuilder SetDisbursedAt(DateTime? v)                  
            {                  
                ParamDisbursedAt = new(defDisbursedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int? v)                  
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
            int PayrollID,
            int PersonnelID,
            int AttendanceCount,
            decimal SalaryAmount,
            decimal RatePerDay,
            decimal CalculatedAmount,
            bool IsDisbursed,
            decimal ApprovedAmount,
            DateTime CreatedAt,
            int CreatedByID,
            string HRComments = null,
            string BursarComments = null,
            decimal? DisbursedAmount = null,
            DateTime? UpdatedAt = null,
            DateTime? DisbursedAt = null,
            int? UpdatedByID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramPayrollID = new (defPayrollID, PayrollID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAttendanceCount = new (defAttendanceCount, AttendanceCount);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramRatePerDay = new (defRatePerDay, RatePerDay);
                DataColumnParameter paramCalculatedAmount = new (defCalculatedAmount, CalculatedAmount);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramHRComments = new (defHRComments, HRComments);
                DataColumnParameter paramApprovedAmount = new (defApprovedAmount, ApprovedAmount);
                DataColumnParameter paramBursarComments = new (defBursarComments, BursarComments);
                DataColumnParameter paramDisbursedAmount = new (defDisbursedAmount, DisbursedAmount);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramDisbursedAt = new (defDisbursedAt, DisbursedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramPayrollID.GetSQLValue(),
                        paramPersonnelID.GetSQLValue(),
                        paramAttendanceCount.GetSQLValue(),
                        paramSalaryAmount.GetSQLValue(),
                        paramRatePerDay.GetSQLValue(),
                        paramCalculatedAmount.GetSQLValue(),
                        paramIsDisbursed.GetSQLValue(),
                        paramHRComments.GetSQLValue(),
                        paramApprovedAmount.GetSQLValue(),
                        paramBursarComments.GetSQLValue(),
                        paramDisbursedAmount.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramDisbursedAt.GetSQLValue(),
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
            int PayrollID,
            int PersonnelID,
            int AttendanceCount,
            decimal SalaryAmount,
            decimal RatePerDay,
            decimal CalculatedAmount,
            bool IsDisbursed,
            decimal ApprovedAmount,
            DateTime CreatedAt,
            int CreatedByID,
            string HRComments = null,
            string BursarComments = null,
            decimal? DisbursedAmount = null,
            DateTime? UpdatedAt = null,
            DateTime? DisbursedAt = null,
            int? UpdatedByID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPayrollID = new (defPayrollID, PayrollID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAttendanceCount = new (defAttendanceCount, AttendanceCount);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramRatePerDay = new (defRatePerDay, RatePerDay);
                DataColumnParameter paramCalculatedAmount = new (defCalculatedAmount, CalculatedAmount);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramHRComments = new (defHRComments, HRComments);
                DataColumnParameter paramApprovedAmount = new (defApprovedAmount, ApprovedAmount);
                DataColumnParameter paramBursarComments = new (defBursarComments, BursarComments);
                DataColumnParameter paramDisbursedAmount = new (defDisbursedAmount, DisbursedAmount);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramDisbursedAt = new (defDisbursedAt, DisbursedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramPayrollID.GetSQLValue(),
                        paramPersonnelID.GetSQLValue(),
                        paramAttendanceCount.GetSQLValue(),
                        paramSalaryAmount.GetSQLValue(),
                        paramRatePerDay.GetSQLValue(),
                        paramCalculatedAmount.GetSQLValue(),
                        paramIsDisbursed.GetSQLValue(),
                        paramHRComments.GetSQLValue(),
                        paramApprovedAmount.GetSQLValue(),
                        paramBursarComments.GetSQLValue(),
                        paramDisbursedAmount.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramDisbursedAt.GetSQLValue(),
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
            int PayrollID,
            int PersonnelID,
            int AttendanceCount,
            decimal SalaryAmount,
            decimal RatePerDay,
            decimal CalculatedAmount,
            bool IsDisbursed,
            decimal ApprovedAmount,
            DateTime CreatedAt,
            int CreatedByID,
            string HRComments = null,
            string BursarComments = null,
            decimal? DisbursedAmount = null,
            DateTime? UpdatedAt = null,
            DateTime? DisbursedAt = null,
            int? UpdatedByID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramPayrollID = new (defPayrollID, PayrollID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAttendanceCount = new (defAttendanceCount, AttendanceCount);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramRatePerDay = new (defRatePerDay, RatePerDay);
                DataColumnParameter paramCalculatedAmount = new (defCalculatedAmount, CalculatedAmount);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramHRComments = new (defHRComments, HRComments);
                DataColumnParameter paramApprovedAmount = new (defApprovedAmount, ApprovedAmount);
                DataColumnParameter paramBursarComments = new (defBursarComments, BursarComments);
                DataColumnParameter paramDisbursedAmount = new (defDisbursedAmount, DisbursedAmount);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramDisbursedAt = new (defDisbursedAt, DisbursedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramPayrollID.GetSQLValue(),
                        paramPersonnelID.GetSQLValue(),
                        paramAttendanceCount.GetSQLValue(),
                        paramSalaryAmount.GetSQLValue(),
                        paramRatePerDay.GetSQLValue(),
                        paramCalculatedAmount.GetSQLValue(),
                        paramIsDisbursed.GetSQLValue(),
                        paramHRComments.GetSQLValue(),
                        paramApprovedAmount.GetSQLValue(),
                        paramBursarComments.GetSQLValue(),
                        paramDisbursedAmount.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramDisbursedAt.GetSQLValue(),
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
