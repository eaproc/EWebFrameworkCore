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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___TermInvoiceGuide : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___TermInvoiceGuide()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCompanyName = new DataColumnDefinition(TableColumnNames.CompanyName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOriginalBillID = new DataColumnDefinition(TableColumnNames.OriginalBillID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillDefinition = new DataColumnDefinition(TableColumnNames.BillDefinition.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillDescription = new DataColumnDefinition(TableColumnNames.BillDescription.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCurrentWeek = new DataColumnDefinition(TableColumnNames.CurrentWeek.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstBillDeadline = new DataColumnDefinition(TableColumnNames.FirstBillDeadline.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSecondBillDeadline = new DataColumnDefinition(TableColumnNames.SecondBillDeadline.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerStudent = new DataColumnDefinition(TableColumnNames.RatePerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledRatePerStudent = new DataColumnDefinition(TableColumnNames.BilledRatePerStudent.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRegisteredStudentCount = new DataColumnDefinition(TableColumnNames.RegisteredStudentCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullScholarshipStudentCount = new DataColumnDefinition(TableColumnNames.FullScholarshipStudentCount.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillableStudentCount = new DataColumnDefinition(TableColumnNames.BillableStudentCount.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedMinimumBillable = new DataColumnDefinition(TableColumnNames.ExpectedMinimumBillable.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedTotalBillable = new DataColumnDefinition(TableColumnNames.ExpectedTotalBillable.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledAmount = new DataColumnDefinition(TableColumnNames.BilledAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalanceDue = new DataColumnDefinition(TableColumnNames.BalanceDue.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName); 
          ColumnDefns.Add(defOriginalBillID.ColumnName, defOriginalBillID); 
          ColumnDefns.Add(defBillDefinition.ColumnName, defBillDefinition); 
          ColumnDefns.Add(defBillDescription.ColumnName, defBillDescription); 
          ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate); 
          ColumnDefns.Add(defCurrentWeek.ColumnName, defCurrentWeek); 
          ColumnDefns.Add(defFirstBillDeadline.ColumnName, defFirstBillDeadline); 
          ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate); 
          ColumnDefns.Add(defSecondBillDeadline.ColumnName, defSecondBillDeadline); 
          ColumnDefns.Add(defRatePerStudent.ColumnName, defRatePerStudent); 
          ColumnDefns.Add(defBilledRatePerStudent.ColumnName, defBilledRatePerStudent); 
          ColumnDefns.Add(defRegisteredStudentCount.ColumnName, defRegisteredStudentCount); 
          ColumnDefns.Add(defFullScholarshipStudentCount.ColumnName, defFullScholarshipStudentCount); 
          ColumnDefns.Add(defBillableStudentCount.ColumnName, defBillableStudentCount); 
          ColumnDefns.Add(defExpectedMinimumBillable.ColumnName, defExpectedMinimumBillable); 
          ColumnDefns.Add(defExpectedTotalBillable.ColumnName, defExpectedTotalBillable); 
          ColumnDefns.Add(defBilledAmount.ColumnName, defBilledAmount); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defBalanceDue.ColumnName, defBalanceDue); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("accounting.ActiveTermClientBalance");                  
            ReferencedTableNames.Add("accounting.Invoice");                  
            ReferencedTableNames.Add("accounting.TermBill");                  
            ReferencedTableNames.Add("hr.Client");                  
            ReferencedTableNames.Add("hr.ClientStats");                  

          }


                  
       public V___TermInvoiceGuide() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___TermInvoiceGuide(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermInvoiceGuide(DataTable FullTable) : base(FullTable)                                    
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
        public V___TermInvoiceGuide(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.TermInvoiceGuide";
       public const string TermInvoiceGuide__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TermID], [ClientID], [CompanyName], [OriginalBillID], [BillDefinition], [BillDescription], [TermStartDate], [CurrentWeek], [FirstBillDeadline], [TermEndDate], [SecondBillDeadline], [RatePerStudent], [BilledRatePerStudent], [RegisteredStudentCount], [FullScholarshipStudentCount], [BillableStudentCount], [ExpectedMinimumBillable], [ExpectedTotalBillable], [BilledAmount], [Balance], [BalanceDue] FROM accounting.TermInvoiceGuide";
       public const string TermInvoiceGuide__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TermID], [ClientID], [CompanyName], [OriginalBillID], [BillDefinition], [BillDescription], [TermStartDate], [CurrentWeek], [FirstBillDeadline], [TermEndDate], [SecondBillDeadline], [RatePerStudent], [BilledRatePerStudent], [RegisteredStudentCount], [FullScholarshipStudentCount], [BillableStudentCount], [ExpectedMinimumBillable], [ExpectedTotalBillable], [BilledAmount], [Balance], [BalanceDue] FROM accounting.TermInvoiceGuide";


       public enum TableColumnNames
       {

           ID,
           TermID,
           ClientID,
           CompanyName,
           OriginalBillID,
           BillDefinition,
           BillDescription,
           TermStartDate,
           CurrentWeek,
           FirstBillDeadline,
           TermEndDate,
           SecondBillDeadline,
           RatePerStudent,
           BilledRatePerStudent,
           RegisteredStudentCount,
           FullScholarshipStudentCount,
           BillableStudentCount,
           ExpectedMinimumBillable,
           ExpectedTotalBillable,
           BilledAmount,
           Balance,
           BalanceDue
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defCompanyName;
       public static readonly DataColumnDefinition defOriginalBillID;
       public static readonly DataColumnDefinition defBillDefinition;
       public static readonly DataColumnDefinition defBillDescription;
       public static readonly DataColumnDefinition defTermStartDate;
       public static readonly DataColumnDefinition defCurrentWeek;
       public static readonly DataColumnDefinition defFirstBillDeadline;
       public static readonly DataColumnDefinition defTermEndDate;
       public static readonly DataColumnDefinition defSecondBillDeadline;
       public static readonly DataColumnDefinition defRatePerStudent;
       public static readonly DataColumnDefinition defBilledRatePerStudent;
       public static readonly DataColumnDefinition defRegisteredStudentCount;
       public static readonly DataColumnDefinition defFullScholarshipStudentCount;
       public static readonly DataColumnDefinition defBillableStudentCount;
       public static readonly DataColumnDefinition defExpectedMinimumBillable;
       public static readonly DataColumnDefinition defExpectedTotalBillable;
       public static readonly DataColumnDefinition defBilledAmount;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defBalanceDue;

       public int TermID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermID.ToString());  set => TargettedRow[TableColumnNames.TermID.ToString()] = value; }


       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public string CompanyName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.CompanyName.ToString());  set => TargettedRow[TableColumnNames.CompanyName.ToString()] = value; }


       public int? OriginalBillID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.OriginalBillID.ToString());  set => TargettedRow[TableColumnNames.OriginalBillID.ToString()] = value; }


       public string BillDefinition { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BillDefinition.ToString());  set => TargettedRow[TableColumnNames.BillDefinition.ToString()] = value; }


       public string BillDescription { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BillDescription.ToString());  set => TargettedRow[TableColumnNames.BillDescription.ToString()] = value; }


       public DateTime? TermStartDate { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.TermStartDate.ToString());  set => TargettedRow[TableColumnNames.TermStartDate.ToString()] = value; }


       public int? CurrentWeek { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.CurrentWeek.ToString());  set => TargettedRow[TableColumnNames.CurrentWeek.ToString()] = value; }


       public DateTime? FirstBillDeadline { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.FirstBillDeadline.ToString());  set => TargettedRow[TableColumnNames.FirstBillDeadline.ToString()] = value; }


       public DateTime? TermEndDate { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.TermEndDate.ToString());  set => TargettedRow[TableColumnNames.TermEndDate.ToString()] = value; }


       public DateTime? SecondBillDeadline { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.SecondBillDeadline.ToString());  set => TargettedRow[TableColumnNames.SecondBillDeadline.ToString()] = value; }


       public decimal RatePerStudent { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RatePerStudent.ToString());  set => TargettedRow[TableColumnNames.RatePerStudent.ToString()] = value; }


       public decimal? BilledRatePerStudent { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.BilledRatePerStudent.ToString());  set => TargettedRow[TableColumnNames.BilledRatePerStudent.ToString()] = value; }


       public int RegisteredStudentCount { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.RegisteredStudentCount.ToString());  set => TargettedRow[TableColumnNames.RegisteredStudentCount.ToString()] = value; }


       public int? FullScholarshipStudentCount { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.FullScholarshipStudentCount.ToString());  set => TargettedRow[TableColumnNames.FullScholarshipStudentCount.ToString()] = value; }


       public int? BillableStudentCount { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.BillableStudentCount.ToString());  set => TargettedRow[TableColumnNames.BillableStudentCount.ToString()] = value; }


       public decimal? ExpectedMinimumBillable { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.ExpectedMinimumBillable.ToString());  set => TargettedRow[TableColumnNames.ExpectedMinimumBillable.ToString()] = value; }


       public decimal? ExpectedTotalBillable { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.ExpectedTotalBillable.ToString());  set => TargettedRow[TableColumnNames.ExpectedTotalBillable.ToString()] = value; }


       public decimal BilledAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.BilledAmount.ToString());  set => TargettedRow[TableColumnNames.BilledAmount.ToString()] = value; }


       public decimal? Balance { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.Balance.ToString());  set => TargettedRow[TableColumnNames.Balance.ToString()] = value; }


       public decimal? BalanceDue { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.BalanceDue.ToString());  set => TargettedRow[TableColumnNames.BalanceDue.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___TermInvoiceGuide GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___TermInvoiceGuide GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new V___TermInvoiceGuide(conn.Fetch(TermInvoiceGuide__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static V___TermInvoiceGuide GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new V___TermInvoiceGuide( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public V___TermInvoiceGuide GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => TermInvoiceGuide__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
