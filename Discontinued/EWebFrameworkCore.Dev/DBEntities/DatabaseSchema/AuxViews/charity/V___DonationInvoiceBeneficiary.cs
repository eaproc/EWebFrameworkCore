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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.charity                  
{                  

    public class V___DonationInvoiceBeneficiary : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___DonationInvoiceBeneficiary()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(TableColumnNames.HomePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGuardian = new DataColumnDefinition(TableColumnNames.Guardian.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMonthlyDonationID = new DataColumnDefinition(TableColumnNames.MonthlyDonationID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCashOutID = new DataColumnDefinition(TableColumnNames.CashOutID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationYear = new DataColumnDefinition(TableColumnNames.DonationYear.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationMonth = new DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmount = new DataColumnDefinition(TableColumnNames.Amount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone); 
          ColumnDefns.Add(defGuardian.ColumnName, defGuardian); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defMonthlyDonationID.ColumnName, defMonthlyDonationID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defCashOutID.ColumnName, defCashOutID); 
          ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear); 
          ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("charity.Beneficiary");                  
            ReferencedTableNames.Add("charity.BeneficiaryRelation");                  
            ReferencedTableNames.Add("charity.DonationInvoiceItem");                  

          }


                  
       public V___DonationInvoiceBeneficiary() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___DonationInvoiceBeneficiary(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DonationInvoiceBeneficiary(DataTable FullTable) : base(FullTable)                                    
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
        public V___DonationInvoiceBeneficiary(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.DonationInvoiceBeneficiary";
       public const string DonationInvoiceBeneficiary__NO__BINARY___SQL_FILL_QUERY = "SELECT [FirstName], [LastName], [HomePhone], [Guardian], [Address], [ID], [MonthlyDonationID], [BeneficiaryID], [CashOutID], [DonationYear], [DonationMonth], [Amount], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.DonationInvoiceBeneficiary";
       public const string DonationInvoiceBeneficiary__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [FirstName], [LastName], [HomePhone], [Guardian], [Address], [ID], [MonthlyDonationID], [BeneficiaryID], [CashOutID], [DonationYear], [DonationMonth], [Amount], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.DonationInvoiceBeneficiary";


       public enum TableColumnNames
       {

           FirstName,
           LastName,
           HomePhone,
           Guardian,
           Address,
           ID,
           MonthlyDonationID,
           BeneficiaryID,
           CashOutID,
           DonationYear,
           DonationMonth,
           Amount,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defHomePhone;
       public static readonly DataColumnDefinition defGuardian;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defMonthlyDonationID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defCashOutID;
       public static readonly DataColumnDefinition defDonationYear;
       public static readonly DataColumnDefinition defDonationMonth;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public string HomePhone { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HomePhone.ToString());  set => TargettedRow[TableColumnNames.HomePhone.ToString()] = value; }


       public string Guardian { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Guardian.ToString());  set => TargettedRow[TableColumnNames.Guardian.ToString()] = value; }


       public string Address { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Address.ToString());  set => TargettedRow[TableColumnNames.Address.ToString()] = value; }


       public int MonthlyDonationID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.MonthlyDonationID.ToString());  set => TargettedRow[TableColumnNames.MonthlyDonationID.ToString()] = value; }


       public int BeneficiaryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BeneficiaryID.ToString());  set => TargettedRow[TableColumnNames.BeneficiaryID.ToString()] = value; }


       public int? CashOutID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.CashOutID.ToString());  set => TargettedRow[TableColumnNames.CashOutID.ToString()] = value; }


       public int DonationYear { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DonationYear.ToString());  set => TargettedRow[TableColumnNames.DonationYear.ToString()] = value; }


       public int DonationMonth { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DonationMonth.ToString());  set => TargettedRow[TableColumnNames.DonationMonth.ToString()] = value; }


       public decimal Amount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Amount.ToString());  set => TargettedRow[TableColumnNames.Amount.ToString()] = value; }


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
        public V___DonationInvoiceBeneficiary GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___DonationInvoiceBeneficiary GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new V___DonationInvoiceBeneficiary(conn.Fetch(DonationInvoiceBeneficiary__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static V___DonationInvoiceBeneficiary GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new V___DonationInvoiceBeneficiary( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public V___DonationInvoiceBeneficiary GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => DonationInvoiceBeneficiary__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
