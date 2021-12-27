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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.hr                  
{                  

    public class V___PayrollPersonnelView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___PayrollPersonnelView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defPersonnelNumber = new DataColumnDefinition(TableColumnNames.PersonnelNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAttendanceCount = new DataColumnDefinition(TableColumnNames.AttendanceCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSalaryAmount = new DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerDay = new DataColumnDefinition(TableColumnNames.RatePerDay.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defApprovedAmount = new DataColumnDefinition(TableColumnNames.ApprovedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonnelID = new DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayrollID = new DataColumnDefinition(TableColumnNames.PayrollID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBursarComments = new DataColumnDefinition(TableColumnNames.BursarComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalculatedAmount = new DataColumnDefinition(TableColumnNames.CalculatedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedAmount = new DataColumnDefinition(TableColumnNames.DisbursedAmount.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHRComments = new DataColumnDefinition(TableColumnNames.HRComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedAt = new DataColumnDefinition(TableColumnNames.DisbursedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartDate = new DataColumnDefinition(TableColumnNames.StartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(TableColumnNames.EndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(TableColumnNames.IsApproved.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayrollWorkingDays = new DataColumnDefinition(TableColumnNames.PayrollWorkingDays.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMonthWorkingDays = new DataColumnDefinition(TableColumnNames.MonthWorkingDays.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankName = new DataColumnDefinition(TableColumnNames.BankName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defPersonnelNumber.ColumnName, defPersonnelNumber); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defAttendanceCount.ColumnName, defAttendanceCount); 
          ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount); 
          ColumnDefns.Add(defRatePerDay.ColumnName, defRatePerDay); 
          ColumnDefns.Add(defApprovedAmount.ColumnName, defApprovedAmount); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defPayrollID.ColumnName, defPayrollID); 
          ColumnDefns.Add(defBursarComments.ColumnName, defBursarComments); 
          ColumnDefns.Add(defCalculatedAmount.ColumnName, defCalculatedAmount); 
          ColumnDefns.Add(defDisbursedAmount.ColumnName, defDisbursedAmount); 
          ColumnDefns.Add(defHRComments.ColumnName, defHRComments); 
          ColumnDefns.Add(defDisbursedAt.ColumnName, defDisbursedAt); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defPayrollWorkingDays.ColumnName, defPayrollWorkingDays); 
          ColumnDefns.Add(defMonthWorkingDays.ColumnName, defMonthWorkingDays); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defBankName.ColumnName, defBankName); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("common.Bank");                  
            ReferencedTableNames.Add("common.PersonView");                  
            ReferencedTableNames.Add("hr.Payroll");                  
            ReferencedTableNames.Add("hr.PayrollPersonnel");                  
            ReferencedTableNames.Add("hr.Personnel");                  
            ReferencedTableNames.Add("hr.PersonnelBankDetail");                  

          }


                  
       public V___PayrollPersonnelView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___PayrollPersonnelView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(DataTable FullTable) : base(FullTable)                                    
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
        public V___PayrollPersonnelView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.PayrollPersonnelView";
       public const string PayrollPersonnelView__NO__BINARY___SQL_FILL_QUERY = "SELECT [PersonnelNumber], [FullName], [FirstName], [LastName], [AttendanceCount], [SalaryAmount], [RatePerDay], [ApprovedAmount], [IsDisbursed], [PersonnelID], [PayrollID], [BursarComments], [CalculatedAmount], [DisbursedAmount], [HRComments], [DisbursedAt], [PictureFileName], [PersonID], [StartDate], [EndDate], [IsApproved], [PayrollWorkingDays], [MonthWorkingDays], [ID], [BankName], [BankID], [AccountNumber] FROM hr.PayrollPersonnelView";
       public const string PayrollPersonnelView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [PersonnelNumber], [FullName], [FirstName], [LastName], [AttendanceCount], [SalaryAmount], [RatePerDay], [ApprovedAmount], [IsDisbursed], [PersonnelID], [PayrollID], [BursarComments], [CalculatedAmount], [DisbursedAmount], [HRComments], [DisbursedAt], [PictureFileName], [PersonID], [StartDate], [EndDate], [IsApproved], [PayrollWorkingDays], [MonthWorkingDays], [ID], [BankName], [BankID], [AccountNumber] FROM hr.PayrollPersonnelView";


       public enum TableColumnNames
       {

           PersonnelNumber,
           FullName,
           FirstName,
           LastName,
           AttendanceCount,
           SalaryAmount,
           RatePerDay,
           ApprovedAmount,
           IsDisbursed,
           PersonnelID,
           PayrollID,
           BursarComments,
           CalculatedAmount,
           DisbursedAmount,
           HRComments,
           DisbursedAt,
           PictureFileName,
           PersonID,
           StartDate,
           EndDate,
           IsApproved,
           PayrollWorkingDays,
           MonthWorkingDays,
           ID,
           BankName,
           BankID,
           AccountNumber
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defPersonnelNumber;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defAttendanceCount;
       public static readonly DataColumnDefinition defSalaryAmount;
       public static readonly DataColumnDefinition defRatePerDay;
       public static readonly DataColumnDefinition defApprovedAmount;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defPayrollID;
       public static readonly DataColumnDefinition defBursarComments;
       public static readonly DataColumnDefinition defCalculatedAmount;
       public static readonly DataColumnDefinition defDisbursedAmount;
       public static readonly DataColumnDefinition defHRComments;
       public static readonly DataColumnDefinition defDisbursedAt;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defPayrollWorkingDays;
       public static readonly DataColumnDefinition defMonthWorkingDays;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defBankName;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;

       public string PersonnelNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PersonnelNumber.ToString());  set => TargettedRow[TableColumnNames.PersonnelNumber.ToString()] = value; }


       public string FullName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FullName.ToString());  set => TargettedRow[TableColumnNames.FullName.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public int AttendanceCount { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AttendanceCount.ToString());  set => TargettedRow[TableColumnNames.AttendanceCount.ToString()] = value; }


       public decimal SalaryAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.SalaryAmount.ToString());  set => TargettedRow[TableColumnNames.SalaryAmount.ToString()] = value; }


       public decimal RatePerDay { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RatePerDay.ToString());  set => TargettedRow[TableColumnNames.RatePerDay.ToString()] = value; }


       public decimal ApprovedAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.ApprovedAmount.ToString());  set => TargettedRow[TableColumnNames.ApprovedAmount.ToString()] = value; }


       public bool IsDisbursed { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsDisbursed.ToString());  set => TargettedRow[TableColumnNames.IsDisbursed.ToString()] = value; }


       public int PersonnelID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonnelID.ToString());  set => TargettedRow[TableColumnNames.PersonnelID.ToString()] = value; }


       public int PayrollID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PayrollID.ToString());  set => TargettedRow[TableColumnNames.PayrollID.ToString()] = value; }


       public string BursarComments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BursarComments.ToString());  set => TargettedRow[TableColumnNames.BursarComments.ToString()] = value; }


       public decimal CalculatedAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.CalculatedAmount.ToString());  set => TargettedRow[TableColumnNames.CalculatedAmount.ToString()] = value; }


       public decimal? DisbursedAmount { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.DisbursedAmount.ToString());  set => TargettedRow[TableColumnNames.DisbursedAmount.ToString()] = value; }


       public string HRComments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HRComments.ToString());  set => TargettedRow[TableColumnNames.HRComments.ToString()] = value; }


       public DateTime? DisbursedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.DisbursedAt.ToString());  set => TargettedRow[TableColumnNames.DisbursedAt.ToString()] = value; }


       public string PictureFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PictureFileName.ToString());  set => TargettedRow[TableColumnNames.PictureFileName.ToString()] = value; }


       public int PersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonID.ToString());  set => TargettedRow[TableColumnNames.PersonID.ToString()] = value; }


       public DateTime StartDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.StartDate.ToString());  set => TargettedRow[TableColumnNames.StartDate.ToString()] = value; }


       public DateTime EndDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.EndDate.ToString());  set => TargettedRow[TableColumnNames.EndDate.ToString()] = value; }


       public bool IsApproved { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsApproved.ToString());  set => TargettedRow[TableColumnNames.IsApproved.ToString()] = value; }


       public int PayrollWorkingDays { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PayrollWorkingDays.ToString());  set => TargettedRow[TableColumnNames.PayrollWorkingDays.ToString()] = value; }


       public int MonthWorkingDays { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.MonthWorkingDays.ToString());  set => TargettedRow[TableColumnNames.MonthWorkingDays.ToString()] = value; }


       public string BankName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BankName.ToString());  set => TargettedRow[TableColumnNames.BankName.ToString()] = value; }


       public int? BankID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.BankID.ToString());  set => TargettedRow[TableColumnNames.BankID.ToString()] = value; }


       public string AccountNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AccountNumber.ToString());  set => TargettedRow[TableColumnNames.AccountNumber.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___PayrollPersonnelView GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___PayrollPersonnelView GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new V___PayrollPersonnelView(conn.Fetch(PayrollPersonnelView__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static V___PayrollPersonnelView GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new V___PayrollPersonnelView( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public V___PayrollPersonnelView GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PayrollPersonnelView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
