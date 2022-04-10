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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.common                  
{                  

    public class V___PlannedEventIntervalView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___PlannedEventIntervalView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defPlannedEventID = new DataColumnDefinition(TableColumnNames.PlannedEventID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDayOfWeekID = new DataColumnDefinition(TableColumnNames.DayOfWeekID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartTime = new DataColumnDefinition(TableColumnNames.StartTime.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndTime = new DataColumnDefinition(TableColumnNames.EndTime.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIntervalDate = new DataColumnDefinition(TableColumnNames.IntervalDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartDate = new DataColumnDefinition(TableColumnNames.StartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(TableColumnNames.EndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalendarEventID = new DataColumnDefinition(TableColumnNames.CalendarEventID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeDeleted = new DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClassColor = new DataColumnDefinition(TableColumnNames.ClassColor.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalendarEvent = new DataColumnDefinition(TableColumnNames.CalendarEvent.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defPlannedEventID.ColumnName, defPlannedEventID); 
          ColumnDefns.Add(defDayOfWeekID.ColumnName, defDayOfWeekID); 
          ColumnDefns.Add(defStartTime.ColumnName, defStartTime); 
          ColumnDefns.Add(defEndTime.ColumnName, defEndTime); 
          ColumnDefns.Add(defIntervalDate.ColumnName, defIntervalDate); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defCalendarEventID.ColumnName, defCalendarEventID); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defClassColor.ColumnName, defClassColor); 
          ColumnDefns.Add(defCalendarEvent.ColumnName, defCalendarEvent); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("common.CalendarEvent");                  
            ReferencedTableNames.Add("common.PlannedEvent");                  
            ReferencedTableNames.Add("common.PlannedEventInterval");                  

          }


                  
       public V___PlannedEventIntervalView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___PlannedEventIntervalView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(DataTable FullTable) : base(FullTable)                                    
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
        public V___PlannedEventIntervalView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.PlannedEventIntervalView";
       public const string PlannedEventIntervalView__NO__BINARY___SQL_FILL_QUERY = "SELECT [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [IntervalDate], [ID], [StartDate], [EndDate], [Comments], [Title], [CalendarEventID], [CreatedByID], [CanBeDeleted], [ClassColor], [CalendarEvent] FROM common.PlannedEventIntervalView";
       public const string PlannedEventIntervalView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [IntervalDate], [ID], [StartDate], [EndDate], [Comments], [Title], [CalendarEventID], [CreatedByID], [CanBeDeleted], [ClassColor], [CalendarEvent] FROM common.PlannedEventIntervalView";


       public enum TableColumnNames
       {

           PlannedEventID,
           DayOfWeekID,
           StartTime,
           EndTime,
           IntervalDate,
           ID,
           StartDate,
           EndDate,
           Comments,
           Title,
           CalendarEventID,
           CreatedByID,
           CanBeDeleted,
           ClassColor,
           CalendarEvent
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defPlannedEventID;
       public static readonly DataColumnDefinition defDayOfWeekID;
       public static readonly DataColumnDefinition defStartTime;
       public static readonly DataColumnDefinition defEndTime;
       public static readonly DataColumnDefinition defIntervalDate;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defCalendarEventID;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defClassColor;
       public static readonly DataColumnDefinition defCalendarEvent;

       public int PlannedEventID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PlannedEventID.ToString());  set => TargettedRow[TableColumnNames.PlannedEventID.ToString()] = value; }


       public int DayOfWeekID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DayOfWeekID.ToString());  set => TargettedRow[TableColumnNames.DayOfWeekID.ToString()] = value; }


       public DateTime StartTime { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.StartTime.ToString());  set => TargettedRow[TableColumnNames.StartTime.ToString()] = value; }


       public DateTime EndTime { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.EndTime.ToString());  set => TargettedRow[TableColumnNames.EndTime.ToString()] = value; }


       public DateTime? IntervalDate { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.IntervalDate.ToString());  set => TargettedRow[TableColumnNames.IntervalDate.ToString()] = value; }


       public DateTime StartDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.StartDate.ToString());  set => TargettedRow[TableColumnNames.StartDate.ToString()] = value; }


       public DateTime EndDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.EndDate.ToString());  set => TargettedRow[TableColumnNames.EndDate.ToString()] = value; }


       public string Comments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Comments.ToString());  set => TargettedRow[TableColumnNames.Comments.ToString()] = value; }


       public string Title { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Title.ToString());  set => TargettedRow[TableColumnNames.Title.ToString()] = value; }


       public int CalendarEventID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CalendarEventID.ToString());  set => TargettedRow[TableColumnNames.CalendarEventID.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public bool CanBeDeleted { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.CanBeDeleted.ToString());  set => TargettedRow[TableColumnNames.CanBeDeleted.ToString()] = value; }


       public string ClassColor { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ClassColor.ToString());  set => TargettedRow[TableColumnNames.ClassColor.ToString()] = value; }


       public string CalendarEvent { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.CalendarEvent.ToString());  set => TargettedRow[TableColumnNames.CalendarEvent.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___PlannedEventIntervalView GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___PlannedEventIntervalView GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new V___PlannedEventIntervalView(conn.Fetch(PlannedEventIntervalView__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static V___PlannedEventIntervalView GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new V___PlannedEventIntervalView( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public V___PlannedEventIntervalView GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PlannedEventIntervalView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
