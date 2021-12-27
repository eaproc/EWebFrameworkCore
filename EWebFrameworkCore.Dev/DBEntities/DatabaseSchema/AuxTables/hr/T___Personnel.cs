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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___Personnel : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Personnel()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPersonnelNumber = new DataColumnDefinition(TableColumnNames.PersonnelNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmploymentDate = new DataColumnDefinition(TableColumnNames.EmploymentDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuperUser = new DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPositionID = new DataColumnDefinition(TableColumnNames.PositionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSalaryTypeID = new DataColumnDefinition(TableColumnNames.SalaryTypeID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSalaryAmount = new DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDuties = new DataColumnDefinition(TableColumnNames.Duties.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsWebVisible = new DataColumnDefinition(TableColumnNames.IsWebVisible.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPersonnelNumber.ColumnName, defPersonnelNumber); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defEmploymentDate.ColumnName, defEmploymentDate); 
          ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser); 
          ColumnDefns.Add(defPositionID.ColumnName, defPositionID); 
          ColumnDefns.Add(defSalaryTypeID.ColumnName, defSalaryTypeID); 
          ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defDuties.ColumnName, defDuties); 
          ColumnDefns.Add(defIsWebVisible.ColumnName, defIsWebVisible); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_PositionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "hr.Position"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_SalaryTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "hr.SalaryType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "auth.Users"                  
                            ));                  

          }


                  
       public T___Personnel() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Personnel(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(DataTable FullTable) : base(FullTable)                                    
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
        public T___Personnel(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.Personnel";
       public const string Personnel__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PersonnelNumber], [PersonID], [IsActive], [EmploymentDate], [IsSuperUser], [PositionID], [SalaryTypeID], [SalaryAmount], [CreatedByID], [UpdatedByID], [CreatedAt], [UpdatedAt], [Duties], [IsWebVisible] FROM hr.Personnel";
       public const string Personnel__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PersonnelNumber], [PersonID], [IsActive], [EmploymentDate], [IsSuperUser], [PositionID], [SalaryTypeID], [SalaryAmount], [CreatedByID], [UpdatedByID], [CreatedAt], [UpdatedAt], [Duties], [IsWebVisible] FROM hr.Personnel";


       public enum TableColumnNames
       {

           ID,
           PersonnelNumber,
           PersonID,
           IsActive,
           EmploymentDate,
           IsSuperUser,
           PositionID,
           SalaryTypeID,
           SalaryAmount,
           CreatedByID,
           UpdatedByID,
           CreatedAt,
           UpdatedAt,
           Duties,
           IsWebVisible
       } 



       public enum TableConstraints{

           pk_hr_Personnel, 
           fk_hr_Personnel_PersonID, 
           fk_hr_Personnel_PositionID, 
           fk_hr_Personnel_SalaryTypeID, 
           fk_hr_Personnel_CreatedByID, 
           fk_hr_Personnel_UpdatedByID, 
           uq_hr_Personnel_PersonnelNumber, 
           uq_hr_Personnel_PersonID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPersonnelNumber;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defEmploymentDate;
       public static readonly DataColumnDefinition defIsSuperUser;
       public static readonly DataColumnDefinition defPositionID;
       public static readonly DataColumnDefinition defSalaryTypeID;
       public static readonly DataColumnDefinition defSalaryAmount;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defDuties;
       public static readonly DataColumnDefinition defIsWebVisible;

       public string PersonnelNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PersonnelNumber.ToString());  set => TargettedRow[TableColumnNames.PersonnelNumber.ToString()] = value; }


       public int PersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonID.ToString());  set => TargettedRow[TableColumnNames.PersonID.ToString()] = value; }


       public bool IsActive { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


       public DateTime EmploymentDate { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.EmploymentDate.ToString());  set => TargettedRow[TableColumnNames.EmploymentDate.ToString()] = value; }


       public bool IsSuperUser { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsSuperUser.ToString());  set => TargettedRow[TableColumnNames.IsSuperUser.ToString()] = value; }


       public int PositionID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PositionID.ToString());  set => TargettedRow[TableColumnNames.PositionID.ToString()] = value; }


       public int? SalaryTypeID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.SalaryTypeID.ToString());  set => TargettedRow[TableColumnNames.SalaryTypeID.ToString()] = value; }


       public decimal? SalaryAmount { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.SalaryAmount.ToString());  set => TargettedRow[TableColumnNames.SalaryAmount.ToString()] = value; }


       public int CreatedByID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.CreatedByID.ToString());  set => TargettedRow[TableColumnNames.CreatedByID.ToString()] = value; }


       public int? UpdatedByID { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.UpdatedByID.ToString());  set => TargettedRow[TableColumnNames.UpdatedByID.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.UpdatedAt.ToString());  set => TargettedRow[TableColumnNames.UpdatedAt.ToString()] = value; }


       public string Duties { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Duties.ToString());  set => TargettedRow[TableColumnNames.Duties.ToString()] = value; }


       public bool? IsWebVisible { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.IsWebVisible.ToString());  set => TargettedRow[TableColumnNames.IsWebVisible.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Personnel GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Personnel GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___Personnel(conn.Fetch(Personnel__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___Personnel GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___Personnel( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___Personnel GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Personnel__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamPersonnelNumber;
            private DataColumnParameter ParamPersonID;
            private DataColumnParameter ParamIsActive;
            private DataColumnParameter ParamEmploymentDate;
            private DataColumnParameter ParamIsSuperUser;
            private DataColumnParameter ParamPositionID;
            private DataColumnParameter ParamSalaryTypeID;
            private DataColumnParameter ParamSalaryAmount;
            private DataColumnParameter ParamCreatedByID;
            private DataColumnParameter ParamUpdatedByID;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamUpdatedAt;
            private DataColumnParameter ParamDuties;
            private DataColumnParameter ParamIsWebVisible;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___Personnel v):this(v.ID)                  
            {                  

                ParamPersonnelNumber = new(defPersonnelNumber, v.PersonnelNumber);                  
                ParamPersonID = new(defPersonID, v.PersonID);                  
                ParamIsActive = new(defIsActive, v.IsActive);                  
                ParamEmploymentDate = new(defEmploymentDate, v.EmploymentDate);                  
                ParamIsSuperUser = new(defIsSuperUser, v.IsSuperUser);                  
                ParamPositionID = new(defPositionID, v.PositionID);                  
                ParamSalaryTypeID = new(defSalaryTypeID, v.SalaryTypeID);                  
                ParamSalaryAmount = new(defSalaryAmount, v.SalaryAmount);                  
                ParamCreatedByID = new(defCreatedByID, v.CreatedByID);                  
                ParamUpdatedByID = new(defUpdatedByID, v.UpdatedByID);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamUpdatedAt = new(defUpdatedAt, v.UpdatedAt);                  
                ParamDuties = new(defDuties, v.Duties);                  
                ParamIsWebVisible = new(defIsWebVisible, v.IsWebVisible);                  
            }                  
                  
            public UpdateQueryBuilder SetPersonnelNumber(string v)                  
            {                  
                ParamPersonnelNumber = new(defPersonnelNumber, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPersonID(int v)                  
            {                  
                ParamPersonID = new(defPersonID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsActive(bool v)                  
            {                  
                ParamIsActive = new(defIsActive, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEmploymentDate(DateTime v)                  
            {                  
                ParamEmploymentDate = new(defEmploymentDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsSuperUser(bool v)                  
            {                  
                ParamIsSuperUser = new(defIsSuperUser, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPositionID(int v)                  
            {                  
                ParamPositionID = new(defPositionID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSalaryTypeID(int? v)                  
            {                  
                ParamSalaryTypeID = new(defSalaryTypeID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSalaryAmount(decimal? v)                  
            {                  
                ParamSalaryAmount = new(defSalaryAmount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedByID(int v)                  
            {                  
                ParamCreatedByID = new(defCreatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedByID(int? v)                  
            {                  
                ParamUpdatedByID = new(defUpdatedByID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetUpdatedAt(DateTime? v)                  
            {                  
                ParamUpdatedAt = new(defUpdatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDuties(string v)                  
            {                  
                ParamDuties = new(defDuties, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIsWebVisible(bool? v)                  
            {                  
                ParamIsWebVisible = new(defIsWebVisible, v);                  
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
            string PersonnelNumber
,            int PersonID
,            bool IsActive
,            DateTime EmploymentDate
,            bool IsSuperUser
,            int PositionID
,            int CreatedByID
,            DateTime CreatedAt
,            int? SalaryTypeID = null
,            decimal? SalaryAmount = null
,            int? UpdatedByID = null
,            DateTime? UpdatedAt = null
,            string Duties = null
,            bool? IsWebVisible = null
          ){

                DataColumnParameter paramPersonnelNumber = new (defPersonnelNumber, PersonnelNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramEmploymentDate = new (defEmploymentDate, EmploymentDate);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramPositionID = new (defPositionID, PositionID);
                DataColumnParameter paramSalaryTypeID = new (defSalaryTypeID, SalaryTypeID);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDuties = new (defDuties, Duties);
                DataColumnParameter paramIsWebVisible = new (defIsWebVisible, IsWebVisible);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  ", TABLE_NAME,
                        paramPersonnelNumber.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramEmploymentDate.GetSQLValue(),
                        paramIsSuperUser.GetSQLValue(),
                        paramPositionID.GetSQLValue(),
                        paramSalaryTypeID.GetSQLValue(),
                        paramSalaryAmount.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramDuties.GetSQLValue(),
                        paramIsWebVisible.GetSQLValue()                        )
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
,            string PersonnelNumber
,            int PersonID
,            bool IsActive
,            DateTime EmploymentDate
,            bool IsSuperUser
,            int PositionID
,            int CreatedByID
,            DateTime CreatedAt
,            int? SalaryTypeID = null
,            decimal? SalaryAmount = null
,            int? UpdatedByID = null
,            DateTime? UpdatedAt = null
,            string Duties = null
,            bool? IsWebVisible = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPersonnelNumber = new (defPersonnelNumber, PersonnelNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramEmploymentDate = new (defEmploymentDate, EmploymentDate);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramPositionID = new (defPositionID, PositionID);
                DataColumnParameter paramSalaryTypeID = new (defSalaryTypeID, SalaryTypeID);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDuties = new (defDuties, Duties);
                DataColumnParameter paramIsWebVisible = new (defIsWebVisible, IsWebVisible);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramPersonnelNumber.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramEmploymentDate.GetSQLValue(),
                        paramIsSuperUser.GetSQLValue(),
                        paramPositionID.GetSQLValue(),
                        paramSalaryTypeID.GetSQLValue(),
                        paramSalaryAmount.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramDuties.GetSQLValue(),
                        paramIsWebVisible.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            string PersonnelNumber
,            int PersonID
,            bool IsActive
,            DateTime EmploymentDate
,            bool IsSuperUser
,            int PositionID
,            int CreatedByID
,            DateTime CreatedAt
,            int? SalaryTypeID = null
,            decimal? SalaryAmount = null
,            int? UpdatedByID = null
,            DateTime? UpdatedAt = null
,            string Duties = null
,            bool? IsWebVisible = null
          ){

                DataColumnParameter paramPersonnelNumber = new (defPersonnelNumber, PersonnelNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramEmploymentDate = new (defEmploymentDate, EmploymentDate);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramPositionID = new (defPositionID, PositionID);
                DataColumnParameter paramSalaryTypeID = new (defSalaryTypeID, SalaryTypeID);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDuties = new (defDuties, Duties);
                DataColumnParameter paramIsWebVisible = new (defIsWebVisible, IsWebVisible);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  ", TABLE_NAME,
                        paramPersonnelNumber.GetSQLValue(),
                        paramPersonID.GetSQLValue(),
                        paramIsActive.GetSQLValue(),
                        paramEmploymentDate.GetSQLValue(),
                        paramIsSuperUser.GetSQLValue(),
                        paramPositionID.GetSQLValue(),
                        paramSalaryTypeID.GetSQLValue(),
                        paramSalaryAmount.GetSQLValue(),
                        paramCreatedByID.GetSQLValue(),
                        paramUpdatedByID.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramUpdatedAt.GetSQLValue(),
                        paramDuties.GetSQLValue(),
                        paramIsWebVisible.GetSQLValue()                            
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
