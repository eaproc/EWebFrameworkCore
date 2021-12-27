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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___PlannedEvent : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PlannedEvent()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCalendarEventID = new DataColumnDefinition(TableColumnNames.CalendarEventID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartDate = new DataColumnDefinition(TableColumnNames.StartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(TableColumnNames.EndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTrackID = new DataColumnDefinition(TableColumnNames.TrackID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAcademicSessionID = new DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCalendarEventID.ColumnName, defCalendarEventID); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defTrackID.ColumnName, defTrackID); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_CalendarEventID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "common.CalendarEvent"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_AcademicSessionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "academic.AcademicSession"                  
                            ));                  

          }


                  
       public T___PlannedEvent() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PlannedEvent(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(DataTable FullTable) : base(FullTable)                                    
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
        public T___PlannedEvent(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.PlannedEvent";
       public const string PlannedEvent__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CalendarEventID], [Title], [StartDate], [EndDate], [Comments], [CreatedAt], [CreatedByID], [TrackID], [AcademicSessionID] FROM common.PlannedEvent";
       public const string PlannedEvent__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CalendarEventID], [Title], [StartDate], [EndDate], [Comments], [CreatedAt], [CreatedByID], [TrackID], [AcademicSessionID] FROM common.PlannedEvent";


       public enum TableColumnNames
       {

           ID,
           CalendarEventID,
           Title,
           StartDate,
           EndDate,
           Comments,
           CreatedAt,
           CreatedByID,
           TrackID,
           AcademicSessionID
       } 



       public enum TableConstraints{

           pk_common_PlannedEvent, 
           fk_common_PlannedEvent_CalendarEventID, 
           fk_common_PlannedEvent_CreatedByID, 
           fk_common_PlannedEvent_AcademicSessionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCalendarEventID;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defTrackID;
       public static readonly DataColumnDefinition defAcademicSessionID;

       public int CalendarEventID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CalendarEventID.ToString());  set => TargettedRow[TableColumnNames.CalendarEventID.ToString()] = value; }


       public string Title { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Title.ToString());  set => TargettedRow[TableColumnNames.Title.ToString()] = value; }


       public DateTime StartDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.StartDate.ToString());  set => TargettedRow[TableColumnNames.StartDate.ToString()] = value; }


       public DateTime EndDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.EndDate.ToString());  set => TargettedRow[TableColumnNames.EndDate.ToString()] = value; }


       public string Comments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Comments.ToString());  set => TargettedRow[TableColumnNames.Comments.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int? TrackID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.TrackID.ToString());  set => TargettedRow[TableColumnNames.TrackID.ToString()] = value; }


       public int AcademicSessionID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AcademicSessionID.ToString());  set => TargettedRow[TableColumnNames.AcademicSessionID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PlannedEvent GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PlannedEvent GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___PlannedEvent(conn.Fetch(PlannedEvent__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___PlannedEvent GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___PlannedEvent( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___PlannedEvent GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PlannedEvent__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamCalendarEventID;
            private DataColumnParameter ParamTitle;
            private DataColumnParameter ParamStartDate;
            private DataColumnParameter ParamEndDate;
            private DataColumnParameter ParamComments;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamTrackID;
            private DataColumnParameter ParamAcademicSessionID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PlannedEvent v):this(v.ID)                  
            {                  

                ParamCalendarEventID = new(defCalendarEventID, v.CalendarEventID);                  
                ParamTitle = new(defTitle, v.Title);                  
                ParamStartDate = new(defStartDate, v.StartDate);                  
                ParamEndDate = new(defEndDate, v.EndDate);                  
                ParamComments = new(defComments, v.Comments);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamTrackID = new(defTrackID, v.TrackID);                  
                ParamAcademicSessionID = new(defAcademicSessionID, v.AcademicSessionID);                  
            }                  
                  
            public UpdateQueryBuilder SetCalendarEventID(int v)                  
            {                  
                ParamCalendarEventID = new(defCalendarEventID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTitle(string v)                  
            {                  
                ParamTitle = new(defTitle, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetStartDate(DateTime v)                  
            {                  
                ParamStartDate = new(defStartDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEndDate(DateTime v)                  
            {                  
                ParamEndDate = new(defEndDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetComments(string v)                  
            {                  
                ParamComments = new(defComments, v);                  
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
                  
            public UpdateQueryBuilder SetTrackID(int? v)                  
            {                  
                ParamTrackID = new(defTrackID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAcademicSessionID(int v)                  
            {                  
                ParamAcademicSessionID = new(defAcademicSessionID, v);                  
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
            int CalendarEventID,
            string Title,
            DateTime StartDate,
            DateTime EndDate,
            DateTime CreatedAt,
            int CreatedByID,
            int AcademicSessionID,
            string Comments = null,
            int? TrackID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCalendarEventID = new (defCalendarEventID, CalendarEventID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramTrackID = new (defTrackID, TrackID);
                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramCalendarEventID.GetSQLValue(),
                        paramTitle.GetSQLValue(),
                        paramStartDate.GetSQLValue(),
                        paramEndDate.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramTrackID.GetSQLValue(),
                        paramAcademicSessionID.GetSQLValue()                        )
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
            int CalendarEventID,
            string Title,
            DateTime StartDate,
            DateTime EndDate,
            DateTime CreatedAt,
            int CreatedByID,
            int AcademicSessionID,
            string Comments = null,
            int? TrackID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCalendarEventID = new (defCalendarEventID, CalendarEventID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramTrackID = new (defTrackID, TrackID);
                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramCalendarEventID.GetSQLValue(),
                        paramTitle.GetSQLValue(),
                        paramStartDate.GetSQLValue(),
                        paramEndDate.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramTrackID.GetSQLValue(),
                        paramAcademicSessionID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int CalendarEventID,
            string Title,
            DateTime StartDate,
            DateTime EndDate,
            DateTime CreatedAt,
            int CreatedByID,
            int AcademicSessionID,
            string Comments = null,
            int? TrackID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCalendarEventID = new (defCalendarEventID, CalendarEventID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramTrackID = new (defTrackID, TrackID);
                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramCalendarEventID.GetSQLValue(),
                        paramTitle.GetSQLValue(),
                        paramStartDate.GetSQLValue(),
                        paramEndDate.GetSQLValue(),
                        paramComments.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramTrackID.GetSQLValue(),
                        paramAcademicSessionID.GetSQLValue()                            
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
