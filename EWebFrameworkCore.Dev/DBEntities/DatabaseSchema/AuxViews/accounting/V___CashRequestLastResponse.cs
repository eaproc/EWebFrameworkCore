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

    public class V___CashRequestLastResponse : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___CashRequestLastResponse()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequest = new DataColumnDefinition(TableColumnNames.Request.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeadline = new DataColumnDefinition(TableColumnNames.Deadline.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTrackingID = new DataColumnDefinition(TableColumnNames.TrackingID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingDocumentFileName = new DataColumnDefinition(TableColumnNames.LastProceedingDocumentFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmount = new DataColumnDefinition(TableColumnNames.Amount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCategory = new DataColumnDefinition(TableColumnNames.Category.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestStatus = new DataColumnDefinition(TableColumnNames.RequestStatus.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpenditureCategoryID = new DataColumnDefinition(TableColumnNames.ExpenditureCategoryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRevisedAmount = new DataColumnDefinition(TableColumnNames.RevisedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCashRequestStatusID = new DataColumnDefinition(TableColumnNames.CashRequestStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingCreatedBy = new DataColumnDefinition(TableColumnNames.LastProceedingCreatedBy.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastResponseComments = new DataColumnDefinition(TableColumnNames.LastResponseComments.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingCreatedAt = new DataColumnDefinition(TableColumnNames.LastProceedingCreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingCreatedByID = new DataColumnDefinition(TableColumnNames.LastProceedingCreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCashRequestProceedingID = new DataColumnDefinition(TableColumnNames.CashRequestProceedingID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defDeadline.ColumnName, defDeadline); 
          ColumnDefns.Add(defTrackingID.ColumnName, defTrackingID); 
          ColumnDefns.Add(defLastProceedingDocumentFileName.ColumnName, defLastProceedingDocumentFileName); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defCategory.ColumnName, defCategory); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defRequestStatus.ColumnName, defRequestStatus); 
          ColumnDefns.Add(defExpenditureCategoryID.ColumnName, defExpenditureCategoryID); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defRevisedAmount.ColumnName, defRevisedAmount); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defCashRequestStatusID.ColumnName, defCashRequestStatusID); 
          ColumnDefns.Add(defLastProceedingCreatedBy.ColumnName, defLastProceedingCreatedBy); 
          ColumnDefns.Add(defLastResponseComments.ColumnName, defLastResponseComments); 
          ColumnDefns.Add(defLastProceedingCreatedAt.ColumnName, defLastProceedingCreatedAt); 
          ColumnDefns.Add(defLastProceedingCreatedByID.ColumnName, defLastProceedingCreatedByID); 
          ColumnDefns.Add(defCashRequestProceedingID.ColumnName, defCashRequestProceedingID); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("accounting.CashRequest");                  
            ReferencedTableNames.Add("accounting.CashRequestProceeding");                  
            ReferencedTableNames.Add("accounting.CashRequestStatus");                  
            ReferencedTableNames.Add("accounting.ExpenditureCategory");                  
            ReferencedTableNames.Add("auth.Users");                  
            ReferencedTableNames.Add("common.PersonView");                  

          }


                  
       public V___CashRequestLastResponse() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___CashRequestLastResponse(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(DataTable FullTable) : base(FullTable)                                    
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
        public V___CashRequestLastResponse(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.CashRequestLastResponse";
       public const string CashRequestLastResponse__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Request], [CreatedAt], [Deadline], [TrackingID], [LastProceedingDocumentFileName], [BeneficiaryID], [Amount], [Category], [FullName], [FirstName], [LastName], [PersonID], [PictureFileName], [RequestStatus], [ExpenditureCategoryID], [CreatedByID], [RevisedAmount], [Title], [CashRequestStatusID], [LastProceedingCreatedBy], [LastResponseComments], [LastProceedingCreatedAt], [LastProceedingCreatedByID], [CashRequestProceedingID] FROM accounting.CashRequestLastResponse";
       public const string CashRequestLastResponse__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Request], [CreatedAt], [Deadline], [TrackingID], [LastProceedingDocumentFileName], [BeneficiaryID], [Amount], [Category], [FullName], [FirstName], [LastName], [PersonID], [PictureFileName], [RequestStatus], [ExpenditureCategoryID], [CreatedByID], [RevisedAmount], [Title], [CashRequestStatusID], [LastProceedingCreatedBy], [LastResponseComments], [LastProceedingCreatedAt], [LastProceedingCreatedByID], [CashRequestProceedingID] FROM accounting.CashRequestLastResponse";


       public enum TableColumnNames
       {

           ID,
           Request,
           CreatedAt,
           Deadline,
           TrackingID,
           LastProceedingDocumentFileName,
           BeneficiaryID,
           Amount,
           Category,
           FullName,
           FirstName,
           LastName,
           PersonID,
           PictureFileName,
           RequestStatus,
           ExpenditureCategoryID,
           CreatedByID,
           RevisedAmount,
           Title,
           CashRequestStatusID,
           LastProceedingCreatedBy,
           LastResponseComments,
           LastProceedingCreatedAt,
           LastProceedingCreatedByID,
           CashRequestProceedingID
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defDeadline;
       public static readonly DataColumnDefinition defTrackingID;
       public static readonly DataColumnDefinition defLastProceedingDocumentFileName;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defCategory;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defRequestStatus;
       public static readonly DataColumnDefinition defExpenditureCategoryID;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defRevisedAmount;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defCashRequestStatusID;
       public static readonly DataColumnDefinition defLastProceedingCreatedBy;
       public static readonly DataColumnDefinition defLastResponseComments;
       public static readonly DataColumnDefinition defLastProceedingCreatedAt;
       public static readonly DataColumnDefinition defLastProceedingCreatedByID;
       public static readonly DataColumnDefinition defCashRequestProceedingID;

       public string Request { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Request.ToString());  set => TargettedRow[TableColumnNames.Request.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime Deadline { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.Deadline.ToString());  set => TargettedRow[TableColumnNames.Deadline.ToString()] = value; }


       public int? TrackingID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.TrackingID.ToString());  set => TargettedRow[TableColumnNames.TrackingID.ToString()] = value; }


       public string LastProceedingDocumentFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastProceedingDocumentFileName.ToString());  set => TargettedRow[TableColumnNames.LastProceedingDocumentFileName.ToString()] = value; }


       public int BeneficiaryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BeneficiaryID.ToString());  set => TargettedRow[TableColumnNames.BeneficiaryID.ToString()] = value; }


       public decimal Amount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.Amount.ToString());  set => TargettedRow[TableColumnNames.Amount.ToString()] = value; }


       public string Category { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Category.ToString());  set => TargettedRow[TableColumnNames.Category.ToString()] = value; }


       public string FullName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FullName.ToString());  set => TargettedRow[TableColumnNames.FullName.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public int PersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonID.ToString());  set => TargettedRow[TableColumnNames.PersonID.ToString()] = value; }


       public string PictureFileName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PictureFileName.ToString());  set => TargettedRow[TableColumnNames.PictureFileName.ToString()] = value; }


       public string RequestStatus { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.RequestStatus.ToString());  set => TargettedRow[TableColumnNames.RequestStatus.ToString()] = value; }


       public int ExpenditureCategoryID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ExpenditureCategoryID.ToString());  set => TargettedRow[TableColumnNames.ExpenditureCategoryID.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public decimal RevisedAmount { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RevisedAmount.ToString());  set => TargettedRow[TableColumnNames.RevisedAmount.ToString()] = value; }


       public string Title { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Title.ToString());  set => TargettedRow[TableColumnNames.Title.ToString()] = value; }


       public int CashRequestStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CashRequestStatusID.ToString());  set => TargettedRow[TableColumnNames.CashRequestStatusID.ToString()] = value; }


       public string LastProceedingCreatedBy { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastProceedingCreatedBy.ToString());  set => TargettedRow[TableColumnNames.LastProceedingCreatedBy.ToString()] = value; }


       public string LastResponseComments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastResponseComments.ToString());  set => TargettedRow[TableColumnNames.LastResponseComments.ToString()] = value; }


       public DateTime LastProceedingCreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.LastProceedingCreatedAt.ToString());  set => TargettedRow[TableColumnNames.LastProceedingCreatedAt.ToString()] = value; }


       public int LastProceedingCreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.LastProceedingCreatedByID.ToString());  set => TargettedRow[TableColumnNames.LastProceedingCreatedByID.ToString()] = value; }


       public int CashRequestProceedingID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CashRequestProceedingID.ToString());  set => TargettedRow[TableColumnNames.CashRequestProceedingID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___CashRequestLastResponse GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___CashRequestLastResponse GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new V___CashRequestLastResponse(conn.Fetch(CashRequestLastResponse__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static V___CashRequestLastResponse GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new V___CashRequestLastResponse( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public V___CashRequestLastResponse GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CashRequestLastResponse__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
