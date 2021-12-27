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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___Center : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Center()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiariesAvailableOnRegistration = new DataColumnDefinition(TableColumnNames.BeneficiariesAvailableOnRegistration.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatusID = new DataColumnDefinition(TableColumnNames.CenterStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defYearFounded = new DataColumnDefinition(TableColumnNames.YearFounded.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChurchCapacity = new DataColumnDefinition(TableColumnNames.ChurchCapacity.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureStoredPath = new DataColumnDefinition(TableColumnNames.PictureStoredPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defBeneficiariesAvailableOnRegistration.ColumnName, defBeneficiariesAvailableOnRegistration); 
          ColumnDefns.Add(defCenterStatusID.ColumnName, defCenterStatusID); 
          ColumnDefns.Add(defYearFounded.ColumnName, defYearFounded); 
          ColumnDefns.Add(defChurchCapacity.ColumnName, defChurchCapacity); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defPictureStoredPath.ColumnName, defPictureStoredPath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_CenterStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "charity.CenterStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "auth.Users"                  
                            ));                  

          }


                  
       public T___Center() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Center(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(DataTable FullTable) : base(FullTable)                                    
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
        public T___Center(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.Center";
       public const string Center__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Name], [Address], [BeneficiariesAvailableOnRegistration], [CenterStatusID], [YearFounded], [ChurchCapacity], [Comments], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.Center";
       public const string Center__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Name], [Address], [BeneficiariesAvailableOnRegistration], [CenterStatusID], [YearFounded], [ChurchCapacity], [Comments], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.Center";


       public enum TableColumnNames
       {

           ID,
           Name,
           Address,
           BeneficiariesAvailableOnRegistration,
           CenterStatusID,
           YearFounded,
           ChurchCapacity,
           Comments,
           PictureStoredPath,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_Center, 
           fk_charity_Center_CenterStatusID, 
           fk_charity_Center_CreatedByID, 
           fk_charity_Center_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defBeneficiariesAvailableOnRegistration;
       public static readonly DataColumnDefinition defCenterStatusID;
       public static readonly DataColumnDefinition defYearFounded;
       public static readonly DataColumnDefinition defChurchCapacity;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defPictureStoredPath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public string Name { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Name.ToString());  set => TargettedRow[TableColumnNames.Name.ToString()] = value; }


       public string Address { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Address.ToString());  set => TargettedRow[TableColumnNames.Address.ToString()] = value; }


       public int BeneficiariesAvailableOnRegistration { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.BeneficiariesAvailableOnRegistration.ToString());  set => TargettedRow[TableColumnNames.BeneficiariesAvailableOnRegistration.ToString()] = value; }


       public int CenterStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CenterStatusID.ToString());  set => TargettedRow[TableColumnNames.CenterStatusID.ToString()] = value; }


       public int YearFounded { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.YearFounded.ToString());  set => TargettedRow[TableColumnNames.YearFounded.ToString()] = value; }


       public int ChurchCapacity { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ChurchCapacity.ToString());  set => TargettedRow[TableColumnNames.ChurchCapacity.ToString()] = value; }


       public string Comments { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Comments.ToString());  set => TargettedRow[TableColumnNames.Comments.ToString()] = value; }


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
        public T___Center GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Center GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Center(conn.Fetch(Center__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Center GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Center( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Center GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Center__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamName;
            private DataColumnParameter ParamAddress;
            private DataColumnParameter ParamBeneficiariesAvailableOnRegistration;
            private DataColumnParameter ParamCenterStatusID;
            private DataColumnParameter ParamYearFounded;
            private DataColumnParameter ParamChurchCapacity;
            private DataColumnParameter ParamComments;
            private DataColumnParameter ParamPictureStoredPath;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Center v):this(v.ID)                  
            {                  

                ParamName = new(defName, v.Name);                  
                ParamAddress = new(defAddress, v.Address);                  
                ParamBeneficiariesAvailableOnRegistration = new(defBeneficiariesAvailableOnRegistration, v.BeneficiariesAvailableOnRegistration);                  
                ParamCenterStatusID = new(defCenterStatusID, v.CenterStatusID);                  
                ParamYearFounded = new(defYearFounded, v.YearFounded);                  
                ParamChurchCapacity = new(defChurchCapacity, v.ChurchCapacity);                  
                ParamComments = new(defComments, v.Comments);                  
                ParamPictureStoredPath = new(defPictureStoredPath, v.PictureStoredPath);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
            }                  
                  
            public UpdateQueryBuilder SetName(string v)                  
            {                  
                ParamName = new(defName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAddress(string v)                  
            {                  
                ParamAddress = new(defAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBeneficiariesAvailableOnRegistration(int v)                  
            {                  
                ParamBeneficiariesAvailableOnRegistration = new(defBeneficiariesAvailableOnRegistration, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCenterStatusID(int v)                  
            {                  
                ParamCenterStatusID = new(defCenterStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetYearFounded(int v)                  
            {                  
                ParamYearFounded = new(defYearFounded, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetChurchCapacity(int v)                  
            {                  
                ParamChurchCapacity = new(defChurchCapacity, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetComments(string v)                  
            {                  
                ParamComments = new(defComments, v);                  
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
            int BeneficiariesAvailableOnRegistration,
            int CenterStatusID,
            int YearFounded,
            int ChurchCapacity,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string Name = null,
            string Address = null,
            string Comments = null,
            string PictureStoredPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramName = new (defName, Name);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramBeneficiariesAvailableOnRegistration = new (defBeneficiariesAvailableOnRegistration, BeneficiariesAvailableOnRegistration);
                DataColumnParameter paramCenterStatusID = new (defCenterStatusID, CenterStatusID);
                DataColumnParameter paramYearFounded = new (defYearFounded, YearFounded);
                DataColumnParameter paramChurchCapacity = new (defChurchCapacity, ChurchCapacity);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramName.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramBeneficiariesAvailableOnRegistration.GetSQLValue(),
                        paramCenterStatusID.GetSQLValue(),
                        paramYearFounded.GetSQLValue(),
                        paramChurchCapacity.GetSQLValue(),
                        paramComments.GetSQLValue(),
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
        public static bool AddWithID(
            int ID,
            int BeneficiariesAvailableOnRegistration,
            int CenterStatusID,
            int YearFounded,
            int ChurchCapacity,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string Name = null,
            string Address = null,
            string Comments = null,
            string PictureStoredPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramName = new (defName, Name);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramBeneficiariesAvailableOnRegistration = new (defBeneficiariesAvailableOnRegistration, BeneficiariesAvailableOnRegistration);
                DataColumnParameter paramCenterStatusID = new (defCenterStatusID, CenterStatusID);
                DataColumnParameter paramYearFounded = new (defYearFounded, YearFounded);
                DataColumnParameter paramChurchCapacity = new (defChurchCapacity, ChurchCapacity);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramName.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramBeneficiariesAvailableOnRegistration.GetSQLValue(),
                        paramCenterStatusID.GetSQLValue(),
                        paramYearFounded.GetSQLValue(),
                        paramChurchCapacity.GetSQLValue(),
                        paramComments.GetSQLValue(),
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
        public static bool Add(
            int BeneficiariesAvailableOnRegistration,
            int CenterStatusID,
            int YearFounded,
            int ChurchCapacity,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string Name = null,
            string Address = null,
            string Comments = null,
            string PictureStoredPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramName = new (defName, Name);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramBeneficiariesAvailableOnRegistration = new (defBeneficiariesAvailableOnRegistration, BeneficiariesAvailableOnRegistration);
                DataColumnParameter paramCenterStatusID = new (defCenterStatusID, CenterStatusID);
                DataColumnParameter paramYearFounded = new (defYearFounded, YearFounded);
                DataColumnParameter paramChurchCapacity = new (defChurchCapacity, ChurchCapacity);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramName.GetSQLValue(),
                        paramAddress.GetSQLValue(),
                        paramBeneficiariesAvailableOnRegistration.GetSQLValue(),
                        paramCenterStatusID.GetSQLValue(),
                        paramYearFounded.GetSQLValue(),
                        paramChurchCapacity.GetSQLValue(),
                        paramComments.GetSQLValue(),
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
