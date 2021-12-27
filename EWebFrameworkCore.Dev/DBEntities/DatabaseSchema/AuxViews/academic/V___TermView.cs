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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.academic                  
{                  

    public class V___TermView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___TermView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermOrder = new DataColumnDefinition(TableColumnNames.TermOrder.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAcademicSession = new DataColumnDefinition(TableColumnNames.AcademicSession.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAcademicSessionID = new DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionStartDate = new DataColumnDefinition(TableColumnNames.SessionStartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionEndDate = new DataColumnDefinition(TableColumnNames.SessionEndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermOrderID = new DataColumnDefinition(TableColumnNames.TermOrderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDescription = new DataColumnDefinition(TableColumnNames.Description.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defTermOrder.ColumnName, defTermOrder); 
          ColumnDefns.Add(defAcademicSession.ColumnName, defAcademicSession); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
          ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate); 
          ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate); 
          ColumnDefns.Add(defSessionStartDate.ColumnName, defSessionStartDate); 
          ColumnDefns.Add(defSessionEndDate.ColumnName, defSessionEndDate); 
          ColumnDefns.Add(defTermOrderID.ColumnName, defTermOrderID); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("academic.AcademicSession");                  
            ReferencedTableNames.Add("academic.Term");                  
            ReferencedTableNames.Add("academic.TermOrder");                  

          }


                  
       public V___TermView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___TermView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(DataTable FullTable) : base(FullTable)                                    
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
        public V___TermView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "academic.TermView";
       public const string TermView__NO__BINARY___SQL_FILL_QUERY = "SELECT [Name], [TermOrder], [AcademicSession], [IsActive], [AcademicSessionID], [TermStartDate], [TermEndDate], [SessionStartDate], [SessionEndDate], [TermOrderID], [ID], [Description] FROM academic.TermView";
       public const string TermView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [Name], [TermOrder], [AcademicSession], [IsActive], [AcademicSessionID], [TermStartDate], [TermEndDate], [SessionStartDate], [SessionEndDate], [TermOrderID], [ID], [Description] FROM academic.TermView";


       public enum TableColumnNames
       {

           Name,
           TermOrder,
           AcademicSession,
           IsActive,
           AcademicSessionID,
           TermStartDate,
           TermEndDate,
           SessionStartDate,
           SessionEndDate,
           TermOrderID,
           ID,
           Description
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defTermOrder;
       public static readonly DataColumnDefinition defAcademicSession;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defAcademicSessionID;
       public static readonly DataColumnDefinition defTermStartDate;
       public static readonly DataColumnDefinition defTermEndDate;
       public static readonly DataColumnDefinition defSessionStartDate;
       public static readonly DataColumnDefinition defSessionEndDate;
       public static readonly DataColumnDefinition defTermOrderID;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDescription;

       public string Name { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Name.ToString());  set => TargettedRow[TableColumnNames.Name.ToString()] = value; }


       public string TermOrder { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.TermOrder.ToString());  set => TargettedRow[TableColumnNames.TermOrder.ToString()] = value; }


       public string AcademicSession { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.AcademicSession.ToString());  set => TargettedRow[TableColumnNames.AcademicSession.ToString()] = value; }


       public bool IsActive { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


       public int AcademicSessionID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AcademicSessionID.ToString());  set => TargettedRow[TableColumnNames.AcademicSessionID.ToString()] = value; }


       public DateTime TermStartDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.TermStartDate.ToString());  set => TargettedRow[TableColumnNames.TermStartDate.ToString()] = value; }


       public DateTime TermEndDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.TermEndDate.ToString());  set => TargettedRow[TableColumnNames.TermEndDate.ToString()] = value; }


       public DateTime SessionStartDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.SessionStartDate.ToString());  set => TargettedRow[TableColumnNames.SessionStartDate.ToString()] = value; }


       public DateTime SessionEndDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.SessionEndDate.ToString());  set => TargettedRow[TableColumnNames.SessionEndDate.ToString()] = value; }


       public int TermOrderID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermOrderID.ToString());  set => TargettedRow[TableColumnNames.TermOrderID.ToString()] = value; }


       public string Description { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Description.ToString());  set => TargettedRow[TableColumnNames.Description.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___TermView GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___TermView GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new V___TermView(conn.Fetch(TermView__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static V___TermView GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new V___TermView( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public V___TermView GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => TermView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
