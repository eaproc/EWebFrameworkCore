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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___CenterVisitation : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CenterVisitation()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defVisitationDay = new DataColumnDefinition(TableColumnNames.VisitationDay.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defResidingPastorID = new DataColumnDefinition(TableColumnNames.ResidingPastorID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStatusID = new DataColumnDefinition(TableColumnNames.StatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAttendees = new DataColumnDefinition(TableColumnNames.Attendees.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureStoredPath = new DataColumnDefinition(TableColumnNames.PictureStoredPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defVisitationDay.ColumnName, defVisitationDay); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defResidingPastorID.ColumnName, defResidingPastorID); 
          ColumnDefns.Add(defStatusID.ColumnName, defStatusID); 
          ColumnDefns.Add(defAttendees.ColumnName, defAttendees); 
          ColumnDefns.Add(defPictureStoredPath.ColumnName, defPictureStoredPath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CenterVisitation_StatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CenterVisitation", "charity.VisitationStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CenterVisitation_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.CenterVisitation", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CenterVisitation_ResidingPastorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CenterVisitation", "charity.ResidingPastor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CenterVisitation_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CenterVisitation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CenterVisitation_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CenterVisitation", "auth.Users"                  
                            ));                  

          }


                  
       public T___CenterVisitation() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CenterVisitation(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CenterVisitation(DataTable FullTable) : base(FullTable)                                    
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
        public T___CenterVisitation(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.CenterVisitation";
       public const string CenterVisitation__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [VisitationDay], [CenterID], [ResidingPastorID], [StatusID], [Attendees], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.CenterVisitation";
       public const string CenterVisitation__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [VisitationDay], [CenterID], [ResidingPastorID], [StatusID], [Attendees], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.CenterVisitation";


       public enum TableColumnNames
       {

           ID,
           VisitationDay,
           CenterID,
           ResidingPastorID,
           StatusID,
           Attendees,
           PictureStoredPath,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_CenterVisitation, 
           fk_charity_CenterVisitation_StatusID, 
           fk_charity_CenterVisitation_CenterID, 
           fk_charity_CenterVisitation_ResidingPastorID, 
           fk_charity_CenterVisitation_CreatedByID, 
           fk_charity_CenterVisitation_UpdatedByID, 
           uq_charity_CenterVisitation_CenterID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defVisitationDay;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defResidingPastorID;
       public static readonly DataColumnDefinition defStatusID;
       public static readonly DataColumnDefinition defAttendees;
       public static readonly DataColumnDefinition defPictureStoredPath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public DateTime VisitationDay { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.VisitationDay.ToString());  set => TargettedRow[TableColumnNames.VisitationDay.ToString()] = value; }


       public int CenterID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CenterID.ToString());  set => TargettedRow[TableColumnNames.CenterID.ToString()] = value; }


       public int ResidingPastorID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ResidingPastorID.ToString());  set => TargettedRow[TableColumnNames.ResidingPastorID.ToString()] = value; }


       public int StatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.StatusID.ToString());  set => TargettedRow[TableColumnNames.StatusID.ToString()] = value; }


       public int Attendees { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.Attendees.ToString());  set => TargettedRow[TableColumnNames.Attendees.ToString()] = value; }


       public string PictureStoredPath { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PictureStoredPath.ToString());  set => TargettedRow[TableColumnNames.PictureStoredPath.ToString()] = value; }


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
        public T___CenterVisitation GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___CenterVisitation GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___CenterVisitation(conn.Fetch(CenterVisitation__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___CenterVisitation GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___CenterVisitation( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___CenterVisitation GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CenterVisitation__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamVisitationDay;
            private DataColumnParameter ParamCenterID;
            private DataColumnParameter ParamResidingPastorID;
            private DataColumnParameter ParamStatusID;
            private DataColumnParameter ParamAttendees;
            private DataColumnParameter ParamPictureStoredPath;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___CenterVisitation v):this(v.ID)                  
            {                  

                ParamVisitationDay = new(defVisitationDay, v.VisitationDay);                  
                ParamCenterID = new(defCenterID, v.CenterID);                  
                ParamResidingPastorID = new(defResidingPastorID, v.ResidingPastorID);                  
                ParamStatusID = new(defStatusID, v.StatusID);                  
                ParamAttendees = new(defAttendees, v.Attendees);                  
                ParamPictureStoredPath = new(defPictureStoredPath, v.PictureStoredPath);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetVisitationDay(DateTime v)                  
            {                  
                ParamVisitationDay = new(defVisitationDay, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCenterID(int v)                  
            {                  
                ParamCenterID = new(defCenterID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetResidingPastorID(int v)                  
            {                  
                ParamResidingPastorID = new(defResidingPastorID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetStatusID(int v)                  
            {                  
                ParamStatusID = new(defStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAttendees(int v)                  
            {                  
                ParamAttendees = new(defAttendees, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPictureStoredPath(string v)                  
            {                  
                ParamPictureStoredPath = new(defPictureStoredPath, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int v)                  
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
                  
            public int Execute(TransactionRunner runner)                  
            {                  
                return runner.Run((conn) => conn.ExecuteTransactionQuery(this.BuildSQL()));                  
            }                  
        }                  
                  
        #endregion                  
                  





        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID( TransactionRunner runner, 
            DateTime VisitationDay
,            int CenterID
,            int ResidingPastorID
,            int StatusID
,            int Attendees
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            string PictureStoredPath = null
          ){

                DataColumnParameter paramVisitationDay = new (defVisitationDay, VisitationDay);
                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramResidingPastorID = new (defResidingPastorID, ResidingPastorID);
                DataColumnParameter paramStatusID = new (defStatusID, StatusID);
                DataColumnParameter paramAttendees = new (defAttendees, Attendees);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([VisitationDay],[CenterID],[ResidingPastorID],[StatusID],[Attendees],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramVisitationDay.GetSQLValue(),
                        paramCenterID.GetSQLValue(),
                        paramResidingPastorID.GetSQLValue(),
                        paramStatusID.GetSQLValue(),
                        paramAttendees.GetSQLValue(),
                        paramPictureStoredPath.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
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
        public static bool AddWithID(TransactionRunner runner,
            int ID
,            DateTime VisitationDay
,            int CenterID
,            int ResidingPastorID
,            int StatusID
,            int Attendees
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            string PictureStoredPath = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramVisitationDay = new (defVisitationDay, VisitationDay);
                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramResidingPastorID = new (defResidingPastorID, ResidingPastorID);
                DataColumnParameter paramStatusID = new (defStatusID, StatusID);
                DataColumnParameter paramAttendees = new (defAttendees, Attendees);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[VisitationDay],[CenterID],[ResidingPastorID],[StatusID],[Attendees],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramVisitationDay.GetSQLValue(),
                        paramCenterID.GetSQLValue(),
                        paramResidingPastorID.GetSQLValue(),
                        paramStatusID.GetSQLValue(),
                        paramAttendees.GetSQLValue(),
                        paramPictureStoredPath.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            DateTime VisitationDay
,            int CenterID
,            int ResidingPastorID
,            int StatusID
,            int Attendees
,            DateTime CreatedAt
,            DateTime UpdatedAt
,            int CreatedByID
,            int UpdatedByID
,            string PictureStoredPath = null
          ){

                DataColumnParameter paramVisitationDay = new (defVisitationDay, VisitationDay);
                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramResidingPastorID = new (defResidingPastorID, ResidingPastorID);
                DataColumnParameter paramStatusID = new (defStatusID, StatusID);
                DataColumnParameter paramAttendees = new (defAttendees, Attendees);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([VisitationDay],[CenterID],[ResidingPastorID],[StatusID],[Attendees],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramVisitationDay.GetSQLValue(),
                        paramCenterID.GetSQLValue(),
                        paramResidingPastorID.GetSQLValue(),
                        paramStatusID.GetSQLValue(),
                        paramAttendees.GetSQLValue(),
                        paramPictureStoredPath.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
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
        public bool Update(TransactionRunner runner, bool reloadTable = false)                  
        {                  
            return runner.Run(                  
               (conn) => {                  
                   bool r = new UpdateQueryBuilder(this).Execute(new (conn, false)).ToBoolean();                  
                   if (reloadTable) this.LoadFromRows( GetRowWhereIDUsingSQL(this.ID, new (conn, false)).TargettedRow );                  
                   return r;                  
               }                  
               );                  
        }                  
                  



                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(TransactionRunner runner)                  
        {                  
            return DeleteItemRow(runner, ID);                  
        }                  
                  
        public static bool DeleteItemRow(TransactionRunner runner, long pID)                                                      
        {                  
            return runner.Run(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean()                  
               );                  
        }                  



   }


}
