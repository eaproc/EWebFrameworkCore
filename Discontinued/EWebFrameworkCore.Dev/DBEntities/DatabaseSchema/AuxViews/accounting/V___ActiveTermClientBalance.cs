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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___ActiveTermClientBalance : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___ActiveTermClientBalance()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTerm = new DataColumnDefinition(TableColumnNames.Term.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCompanyName = new DataColumnDefinition(TableColumnNames.CompanyName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillTotal = new DataColumnDefinition(TableColumnNames.BillTotal.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defArrears = new DataColumnDefinition(TableColumnNames.Arrears.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentMade = new DataColumnDefinition(TableColumnNames.PaymentMade.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscount = new DataColumnDefinition(TableColumnNames.Discount.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalanceDue = new DataColumnDefinition(TableColumnNames.BalanceDue.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSurplus = new DataColumnDefinition(TableColumnNames.Surplus.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defTerm.ColumnName, defTerm); 
          ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defBillTotal.ColumnName, defBillTotal); 
          ColumnDefns.Add(defArrears.ColumnName, defArrears); 
          ColumnDefns.Add(defPaymentMade.ColumnName, defPaymentMade); 
          ColumnDefns.Add(defDiscount.ColumnName, defDiscount); 
          ColumnDefns.Add(defBalanceDue.ColumnName, defBalanceDue); 
          ColumnDefns.Add(defSurplus.ColumnName, defSurplus); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("academic.Term");                  
            ReferencedTableNames.Add("accounting.Invoice");                  
            ReferencedTableNames.Add("accounting.Payment");                  
            ReferencedTableNames.Add("common.PersonView");                  
            ReferencedTableNames.Add("hr.Client");                  

          }


                  
       public V___ActiveTermClientBalance() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___ActiveTermClientBalance(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermClientBalance(DataTable FullTable) : base(FullTable)                                    
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
        public V___ActiveTermClientBalance(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.ActiveTermClientBalance";
       public const string ActiveTermClientBalance__NO__BINARY___SQL_FILL_QUERY = "SELECT [ClientID], [TermID], [Term], [CompanyName], [Name], [FullName], [BillTotal], [Arrears], [PaymentMade], [Discount], [BalanceDue], [Surplus] FROM accounting.ActiveTermClientBalance";
       public const string ActiveTermClientBalance__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ClientID], [TermID], [Term], [CompanyName], [Name], [FullName], [BillTotal], [Arrears], [PaymentMade], [Discount], [BalanceDue], [Surplus] FROM accounting.ActiveTermClientBalance";


       public enum TableColumnNames
       {

           ClientID,
           TermID,
           Term,
           CompanyName,
           Name,
           FullName,
           BillTotal,
           Arrears,
           PaymentMade,
           Discount,
           BalanceDue,
           Surplus
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defTerm;
       public static readonly DataColumnDefinition defCompanyName;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defBillTotal;
       public static readonly DataColumnDefinition defArrears;
       public static readonly DataColumnDefinition defPaymentMade;
       public static readonly DataColumnDefinition defDiscount;
       public static readonly DataColumnDefinition defBalanceDue;
       public static readonly DataColumnDefinition defSurplus;

       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public int TermID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermID.ToString());  set => TargettedRow[TableColumnNames.TermID.ToString()] = value; }


       public string Term { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Term.ToString());  set => TargettedRow[TableColumnNames.Term.ToString()] = value; }


       public string CompanyName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.CompanyName.ToString());  set => TargettedRow[TableColumnNames.CompanyName.ToString()] = value; }


       public string Name { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Name.ToString());  set => TargettedRow[TableColumnNames.Name.ToString()] = value; }


       public string FullName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FullName.ToString());  set => TargettedRow[TableColumnNames.FullName.ToString()] = value; }


       public decimal? BillTotal { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.BillTotal.ToString());  set => TargettedRow[TableColumnNames.BillTotal.ToString()] = value; }


       public decimal? Arrears { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.Arrears.ToString());  set => TargettedRow[TableColumnNames.Arrears.ToString()] = value; }


       public decimal? PaymentMade { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.PaymentMade.ToString());  set => TargettedRow[TableColumnNames.PaymentMade.ToString()] = value; }


       public decimal? Discount { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.Discount.ToString());  set => TargettedRow[TableColumnNames.Discount.ToString()] = value; }


       public decimal? BalanceDue { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.BalanceDue.ToString());  set => TargettedRow[TableColumnNames.BalanceDue.ToString()] = value; }


       public decimal? Surplus { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.Surplus.ToString());  set => TargettedRow[TableColumnNames.Surplus.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___ActiveTermClientBalance GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___ActiveTermClientBalance GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new V___ActiveTermClientBalance(conn.Fetch(ActiveTermClientBalance__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static V___ActiveTermClientBalance GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new V___ActiveTermClientBalance( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public V___ActiveTermClientBalance GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ActiveTermClientBalance__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
