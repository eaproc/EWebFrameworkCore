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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.charity                  
{                  

    public class V___CenterView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___CenterView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorName = new DataColumnDefinition(TableColumnNames.PastorName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorEmail = new DataColumnDefinition(TableColumnNames.PastorEmail.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorPhone = new DataColumnDefinition(TableColumnNames.PastorPhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorAddress = new DataColumnDefinition(TableColumnNames.PastorAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorID = new DataColumnDefinition(TableColumnNames.PastorID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorPersonID = new DataColumnDefinition(TableColumnNames.PastorPersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiaryCount = new DataColumnDefinition(TableColumnNames.BeneficiaryCount.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChurchCapacity = new DataColumnDefinition(TableColumnNames.ChurchCapacity.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatusID = new DataColumnDefinition(TableColumnNames.CenterStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatus = new DataColumnDefinition(TableColumnNames.CenterStatus.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defPastorName.ColumnName, defPastorName); 
          ColumnDefns.Add(defPastorEmail.ColumnName, defPastorEmail); 
          ColumnDefns.Add(defPastorPhone.ColumnName, defPastorPhone); 
          ColumnDefns.Add(defPastorAddress.ColumnName, defPastorAddress); 
          ColumnDefns.Add(defPastorID.ColumnName, defPastorID); 
          ColumnDefns.Add(defPastorPersonID.ColumnName, defPastorPersonID); 
          ColumnDefns.Add(defBeneficiaryCount.ColumnName, defBeneficiaryCount); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defChurchCapacity.ColumnName, defChurchCapacity); 
          ColumnDefns.Add(defCenterStatusID.ColumnName, defCenterStatusID); 
          ColumnDefns.Add(defCenterStatus.ColumnName, defCenterStatus); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("charity.Beneficiary");                  
            ReferencedTableNames.Add("charity.Center");                  
            ReferencedTableNames.Add("charity.CenterStatus");                  
            ReferencedTableNames.Add("charity.ResidingPastor");                  
            ReferencedTableNames.Add("common.PersonView");                  

          }


                  
       public V___CenterView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___CenterView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(DataTable FullTable) : base(FullTable)                                    
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
        public V___CenterView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.CenterView";
       public const string CenterView__NO__BINARY___SQL_FILL_QUERY = "SELECT [Name], [Address], [PastorName], [PastorEmail], [PastorPhone], [PastorAddress], [PastorID], [PastorPersonID], [BeneficiaryCount], [ID], [ChurchCapacity], [CenterStatusID], [CenterStatus] FROM charity.CenterView";
       public const string CenterView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [Name], [Address], [PastorName], [PastorEmail], [PastorPhone], [PastorAddress], [PastorID], [PastorPersonID], [BeneficiaryCount], [ID], [ChurchCapacity], [CenterStatusID], [CenterStatus] FROM charity.CenterView";


       public enum TableColumnNames
       {

           Name,
           Address,
           PastorName,
           PastorEmail,
           PastorPhone,
           PastorAddress,
           PastorID,
           PastorPersonID,
           BeneficiaryCount,
           ID,
           ChurchCapacity,
           CenterStatusID,
           CenterStatus
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defPastorName;
       public static readonly DataColumnDefinition defPastorEmail;
       public static readonly DataColumnDefinition defPastorPhone;
       public static readonly DataColumnDefinition defPastorAddress;
       public static readonly DataColumnDefinition defPastorID;
       public static readonly DataColumnDefinition defPastorPersonID;
       public static readonly DataColumnDefinition defBeneficiaryCount;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defChurchCapacity;
       public static readonly DataColumnDefinition defCenterStatusID;
       public static readonly DataColumnDefinition defCenterStatus;

       public string Name { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Name.ToString());  set => TargettedRow[TableColumnNames.Name.ToString()] = value; }


       public string Address { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Address.ToString());  set => TargettedRow[TableColumnNames.Address.ToString()] = value; }


       public string PastorName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PastorName.ToString());  set => TargettedRow[TableColumnNames.PastorName.ToString()] = value; }


       public string PastorEmail { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PastorEmail.ToString());  set => TargettedRow[TableColumnNames.PastorEmail.ToString()] = value; }


       public string PastorPhone { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PastorPhone.ToString());  set => TargettedRow[TableColumnNames.PastorPhone.ToString()] = value; }


       public string PastorAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PastorAddress.ToString());  set => TargettedRow[TableColumnNames.PastorAddress.ToString()] = value; }


       public int PastorID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PastorID.ToString());  set => TargettedRow[TableColumnNames.PastorID.ToString()] = value; }


       public int PastorPersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PastorPersonID.ToString());  set => TargettedRow[TableColumnNames.PastorPersonID.ToString()] = value; }


       public int? BeneficiaryCount { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.BeneficiaryCount.ToString());  set => TargettedRow[TableColumnNames.BeneficiaryCount.ToString()] = value; }


       public int ChurchCapacity { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ChurchCapacity.ToString());  set => TargettedRow[TableColumnNames.ChurchCapacity.ToString()] = value; }


       public int CenterStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CenterStatusID.ToString());  set => TargettedRow[TableColumnNames.CenterStatusID.ToString()] = value; }


       public string CenterStatus { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.CenterStatus.ToString());  set => TargettedRow[TableColumnNames.CenterStatus.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___CenterView GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___CenterView GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new V___CenterView(conn.Fetch(CenterView__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static V___CenterView GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new V___CenterView( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public V___CenterView GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CenterView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
