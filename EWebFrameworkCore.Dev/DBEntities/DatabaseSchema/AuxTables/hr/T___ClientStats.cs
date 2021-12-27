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

    public class T___ClientStats : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ClientStats()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRegisteredStudentCount = new DataColumnDefinition(TableColumnNames.RegisteredStudentCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAssignedStudentCount = new DataColumnDefinition(TableColumnNames.AssignedStudentCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessCount = new DataColumnDefinition(TableColumnNames.SCADWAREAccessCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessThreshold = new DataColumnDefinition(TableColumnNames.SCADWAREAccessThreshold.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAverageTermBill = new DataColumnDefinition(TableColumnNames.AverageTermBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerStudent = new DataColumnDefinition(TableColumnNames.RatePerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledPerStudent = new DataColumnDefinition(TableColumnNames.BilledPerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalReceivedOnSCADWAREBill = new DataColumnDefinition(TableColumnNames.TotalReceivedOnSCADWAREBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMinimumExpectedOnSCADWAREBill = new DataColumnDefinition(TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedOnSCADWAREBill = new DataColumnDefinition(TableColumnNames.ExpectedOnSCADWAREBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullScholarshipStudentCount = new DataColumnDefinition(TableColumnNames.FullScholarshipStudentCount.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defRegisteredStudentCount.ColumnName, defRegisteredStudentCount); 
          ColumnDefns.Add(defAssignedStudentCount.ColumnName, defAssignedStudentCount); 
          ColumnDefns.Add(defSCADWAREAccessCount.ColumnName, defSCADWAREAccessCount); 
          ColumnDefns.Add(defSCADWAREAccessThreshold.ColumnName, defSCADWAREAccessThreshold); 
          ColumnDefns.Add(defAverageTermBill.ColumnName, defAverageTermBill); 
          ColumnDefns.Add(defRatePerStudent.ColumnName, defRatePerStudent); 
          ColumnDefns.Add(defBilledPerStudent.ColumnName, defBilledPerStudent); 
          ColumnDefns.Add(defTotalReceivedOnSCADWAREBill.ColumnName, defTotalReceivedOnSCADWAREBill); 
          ColumnDefns.Add(defMinimumExpectedOnSCADWAREBill.ColumnName, defMinimumExpectedOnSCADWAREBill); 
          ColumnDefns.Add(defExpectedOnSCADWAREBill.ColumnName, defExpectedOnSCADWAREBill); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defFullScholarshipStudentCount.ColumnName, defFullScholarshipStudentCount); 
          ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate); 
          ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "hr.ClientStats", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.ClientStats", "academic.Term"                  
                            ));                  

          }


                  
       public T___ClientStats() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ClientStats(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(DataTable FullTable) : base(FullTable)                                    
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
        public T___ClientStats(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.ClientStats";
       public const string ClientStats__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM hr.ClientStats";
       public const string ClientStats__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM hr.ClientStats";


       public enum TableColumnNames
       {

           ID,
           ClientID,
           TermID,
           RegisteredStudentCount,
           AssignedStudentCount,
           SCADWAREAccessCount,
           SCADWAREAccessThreshold,
           AverageTermBill,
           RatePerStudent,
           BilledPerStudent,
           TotalReceivedOnSCADWAREBill,
           MinimumExpectedOnSCADWAREBill,
           ExpectedOnSCADWAREBill,
           IPAddress,
           CreatedAt,
           FullScholarshipStudentCount,
           TermStartDate,
           TermEndDate
       } 



       public enum TableConstraints{

           pk_hr_ClientStats, 
           fk_hr_ClientStats_ClientID, 
           fk_hr_ClientStats_TermID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defRegisteredStudentCount;
       public static readonly DataColumnDefinition defAssignedStudentCount;
       public static readonly DataColumnDefinition defSCADWAREAccessCount;
       public static readonly DataColumnDefinition defSCADWAREAccessThreshold;
       public static readonly DataColumnDefinition defAverageTermBill;
       public static readonly DataColumnDefinition defRatePerStudent;
       public static readonly DataColumnDefinition defBilledPerStudent;
       public static readonly DataColumnDefinition defTotalReceivedOnSCADWAREBill;
       public static readonly DataColumnDefinition defMinimumExpectedOnSCADWAREBill;
       public static readonly DataColumnDefinition defExpectedOnSCADWAREBill;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defFullScholarshipStudentCount;
       public static readonly DataColumnDefinition defTermStartDate;
       public static readonly DataColumnDefinition defTermEndDate;

       public int ClientID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ClientID.ToString());  set => TargettedRow[TableColumnNames.ClientID.ToString()] = value; }


       public int TermID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TermID.ToString());  set => TargettedRow[TableColumnNames.TermID.ToString()] = value; }


       public int RegisteredStudentCount { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.RegisteredStudentCount.ToString());  set => TargettedRow[TableColumnNames.RegisteredStudentCount.ToString()] = value; }


       public int AssignedStudentCount { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.AssignedStudentCount.ToString());  set => TargettedRow[TableColumnNames.AssignedStudentCount.ToString()] = value; }


       public int SCADWAREAccessCount { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.SCADWAREAccessCount.ToString());  set => TargettedRow[TableColumnNames.SCADWAREAccessCount.ToString()] = value; }


       public decimal SCADWAREAccessThreshold { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.SCADWAREAccessThreshold.ToString());  set => TargettedRow[TableColumnNames.SCADWAREAccessThreshold.ToString()] = value; }


       public decimal AverageTermBill { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.AverageTermBill.ToString());  set => TargettedRow[TableColumnNames.AverageTermBill.ToString()] = value; }


       public decimal RatePerStudent { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.RatePerStudent.ToString());  set => TargettedRow[TableColumnNames.RatePerStudent.ToString()] = value; }


       public decimal BilledPerStudent { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.BilledPerStudent.ToString());  set => TargettedRow[TableColumnNames.BilledPerStudent.ToString()] = value; }


       public decimal TotalReceivedOnSCADWAREBill { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.TotalReceivedOnSCADWAREBill.ToString());  set => TargettedRow[TableColumnNames.TotalReceivedOnSCADWAREBill.ToString()] = value; }


       public decimal MinimumExpectedOnSCADWAREBill { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString());  set => TargettedRow[TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString()] = value; }


       public decimal ExpectedOnSCADWAREBill { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.ExpectedOnSCADWAREBill.ToString());  set => TargettedRow[TableColumnNames.ExpectedOnSCADWAREBill.ToString()] = value; }


       public string IPAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IPAddress.ToString());  set => TargettedRow[TableColumnNames.IPAddress.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


       public int? FullScholarshipStudentCount { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.FullScholarshipStudentCount.ToString());  set => TargettedRow[TableColumnNames.FullScholarshipStudentCount.ToString()] = value; }


       public DateTime? TermStartDate { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.TermStartDate.ToString());  set => TargettedRow[TableColumnNames.TermStartDate.ToString()] = value; }


       public DateTime? TermEndDate { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.TermEndDate.ToString());  set => TargettedRow[TableColumnNames.TermEndDate.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___ClientStats GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___ClientStats GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___ClientStats(conn.Fetch(ClientStats__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___ClientStats GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___ClientStats( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___ClientStats GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ClientStats__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamClientID;
            private DataColumnParameter ParamTermID;
            private DataColumnParameter ParamRegisteredStudentCount;
            private DataColumnParameter ParamAssignedStudentCount;
            private DataColumnParameter ParamSCADWAREAccessCount;
            private DataColumnParameter ParamSCADWAREAccessThreshold;
            private DataColumnParameter ParamAverageTermBill;
            private DataColumnParameter ParamRatePerStudent;
            private DataColumnParameter ParamBilledPerStudent;
            private DataColumnParameter ParamTotalReceivedOnSCADWAREBill;
            private DataColumnParameter ParamMinimumExpectedOnSCADWAREBill;
            private DataColumnParameter ParamExpectedOnSCADWAREBill;
            private DataColumnParameter ParamIPAddress;
            private DataColumnParameter ParamCreatedAt;
            private DataColumnParameter ParamFullScholarshipStudentCount;
            private DataColumnParameter ParamTermStartDate;
            private DataColumnParameter ParamTermEndDate;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___ClientStats v):this(v.ID)                  
            {                  

                ParamClientID = new(defClientID, v.ClientID);                  
                ParamTermID = new(defTermID, v.TermID);                  
                ParamRegisteredStudentCount = new(defRegisteredStudentCount, v.RegisteredStudentCount);                  
                ParamAssignedStudentCount = new(defAssignedStudentCount, v.AssignedStudentCount);                  
                ParamSCADWAREAccessCount = new(defSCADWAREAccessCount, v.SCADWAREAccessCount);                  
                ParamSCADWAREAccessThreshold = new(defSCADWAREAccessThreshold, v.SCADWAREAccessThreshold);                  
                ParamAverageTermBill = new(defAverageTermBill, v.AverageTermBill);                  
                ParamRatePerStudent = new(defRatePerStudent, v.RatePerStudent);                  
                ParamBilledPerStudent = new(defBilledPerStudent, v.BilledPerStudent);                  
                ParamTotalReceivedOnSCADWAREBill = new(defTotalReceivedOnSCADWAREBill, v.TotalReceivedOnSCADWAREBill);                  
                ParamMinimumExpectedOnSCADWAREBill = new(defMinimumExpectedOnSCADWAREBill, v.MinimumExpectedOnSCADWAREBill);                  
                ParamExpectedOnSCADWAREBill = new(defExpectedOnSCADWAREBill, v.ExpectedOnSCADWAREBill);                  
                ParamIPAddress = new(defIPAddress, v.IPAddress);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
                ParamFullScholarshipStudentCount = new(defFullScholarshipStudentCount, v.FullScholarshipStudentCount);                  
                ParamTermStartDate = new(defTermStartDate, v.TermStartDate);                  
                ParamTermEndDate = new(defTermEndDate, v.TermEndDate);                  
            }                  
                  
            public UpdateQueryBuilder SetClientID(int v)                  
            {                  
                ParamClientID = new(defClientID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTermID(int v)                  
            {                  
                ParamTermID = new(defTermID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRegisteredStudentCount(int v)                  
            {                  
                ParamRegisteredStudentCount = new(defRegisteredStudentCount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAssignedStudentCount(int v)                  
            {                  
                ParamAssignedStudentCount = new(defAssignedStudentCount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSCADWAREAccessCount(int v)                  
            {                  
                ParamSCADWAREAccessCount = new(defSCADWAREAccessCount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetSCADWAREAccessThreshold(decimal v)                  
            {                  
                ParamSCADWAREAccessThreshold = new(defSCADWAREAccessThreshold, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetAverageTermBill(decimal v)                  
            {                  
                ParamAverageTermBill = new(defAverageTermBill, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetRatePerStudent(decimal v)                  
            {                  
                ParamRatePerStudent = new(defRatePerStudent, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBilledPerStudent(decimal v)                  
            {                  
                ParamBilledPerStudent = new(defBilledPerStudent, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTotalReceivedOnSCADWAREBill(decimal v)                  
            {                  
                ParamTotalReceivedOnSCADWAREBill = new(defTotalReceivedOnSCADWAREBill, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMinimumExpectedOnSCADWAREBill(decimal v)                  
            {                  
                ParamMinimumExpectedOnSCADWAREBill = new(defMinimumExpectedOnSCADWAREBill, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetExpectedOnSCADWAREBill(decimal v)                  
            {                  
                ParamExpectedOnSCADWAREBill = new(defExpectedOnSCADWAREBill, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIPAddress(string v)                  
            {                  
                ParamIPAddress = new(defIPAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFullScholarshipStudentCount(int? v)                  
            {                  
                ParamFullScholarshipStudentCount = new(defFullScholarshipStudentCount, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTermStartDate(DateTime? v)                  
            {                  
                ParamTermStartDate = new(defTermStartDate, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTermEndDate(DateTime? v)                  
            {                  
                ParamTermEndDate = new(defTermEndDate, v);                  
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
            int ClientID
,            int TermID
,            int RegisteredStudentCount
,            int AssignedStudentCount
,            int SCADWAREAccessCount
,            decimal SCADWAREAccessThreshold
,            decimal AverageTermBill
,            decimal RatePerStudent
,            decimal BilledPerStudent
,            decimal TotalReceivedOnSCADWAREBill
,            decimal MinimumExpectedOnSCADWAREBill
,            decimal ExpectedOnSCADWAREBill
,            string IPAddress
,            DateTime CreatedAt
,            int? FullScholarshipStudentCount = null
,            DateTime? TermStartDate = null
,            DateTime? TermEndDate = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramRegisteredStudentCount = new (defRegisteredStudentCount, RegisteredStudentCount);
                DataColumnParameter paramAssignedStudentCount = new (defAssignedStudentCount, AssignedStudentCount);
                DataColumnParameter paramSCADWAREAccessCount = new (defSCADWAREAccessCount, SCADWAREAccessCount);
                DataColumnParameter paramSCADWAREAccessThreshold = new (defSCADWAREAccessThreshold, SCADWAREAccessThreshold);
                DataColumnParameter paramAverageTermBill = new (defAverageTermBill, AverageTermBill);
                DataColumnParameter paramRatePerStudent = new (defRatePerStudent, RatePerStudent);
                DataColumnParameter paramBilledPerStudent = new (defBilledPerStudent, BilledPerStudent);
                DataColumnParameter paramTotalReceivedOnSCADWAREBill = new (defTotalReceivedOnSCADWAREBill, TotalReceivedOnSCADWAREBill);
                DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new (defMinimumExpectedOnSCADWAREBill, MinimumExpectedOnSCADWAREBill);
                DataColumnParameter paramExpectedOnSCADWAREBill = new (defExpectedOnSCADWAREBill, ExpectedOnSCADWAREBill);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramFullScholarshipStudentCount = new (defFullScholarshipStudentCount, FullScholarshipStudentCount);
                DataColumnParameter paramTermStartDate = new (defTermStartDate, TermStartDate);
                DataColumnParameter paramTermEndDate = new (defTermEndDate, TermEndDate);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  ", TABLE_NAME,
                        paramClientID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramRegisteredStudentCount.GetSQLValue(),
                        paramAssignedStudentCount.GetSQLValue(),
                        paramSCADWAREAccessCount.GetSQLValue(),
                        paramSCADWAREAccessThreshold.GetSQLValue(),
                        paramAverageTermBill.GetSQLValue(),
                        paramRatePerStudent.GetSQLValue(),
                        paramBilledPerStudent.GetSQLValue(),
                        paramTotalReceivedOnSCADWAREBill.GetSQLValue(),
                        paramMinimumExpectedOnSCADWAREBill.GetSQLValue(),
                        paramExpectedOnSCADWAREBill.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramFullScholarshipStudentCount.GetSQLValue(),
                        paramTermStartDate.GetSQLValue(),
                        paramTermEndDate.GetSQLValue()                        )
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
,            int ClientID
,            int TermID
,            int RegisteredStudentCount
,            int AssignedStudentCount
,            int SCADWAREAccessCount
,            decimal SCADWAREAccessThreshold
,            decimal AverageTermBill
,            decimal RatePerStudent
,            decimal BilledPerStudent
,            decimal TotalReceivedOnSCADWAREBill
,            decimal MinimumExpectedOnSCADWAREBill
,            decimal ExpectedOnSCADWAREBill
,            string IPAddress
,            DateTime CreatedAt
,            int? FullScholarshipStudentCount = null
,            DateTime? TermStartDate = null
,            DateTime? TermEndDate = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramRegisteredStudentCount = new (defRegisteredStudentCount, RegisteredStudentCount);
                DataColumnParameter paramAssignedStudentCount = new (defAssignedStudentCount, AssignedStudentCount);
                DataColumnParameter paramSCADWAREAccessCount = new (defSCADWAREAccessCount, SCADWAREAccessCount);
                DataColumnParameter paramSCADWAREAccessThreshold = new (defSCADWAREAccessThreshold, SCADWAREAccessThreshold);
                DataColumnParameter paramAverageTermBill = new (defAverageTermBill, AverageTermBill);
                DataColumnParameter paramRatePerStudent = new (defRatePerStudent, RatePerStudent);
                DataColumnParameter paramBilledPerStudent = new (defBilledPerStudent, BilledPerStudent);
                DataColumnParameter paramTotalReceivedOnSCADWAREBill = new (defTotalReceivedOnSCADWAREBill, TotalReceivedOnSCADWAREBill);
                DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new (defMinimumExpectedOnSCADWAREBill, MinimumExpectedOnSCADWAREBill);
                DataColumnParameter paramExpectedOnSCADWAREBill = new (defExpectedOnSCADWAREBill, ExpectedOnSCADWAREBill);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramFullScholarshipStudentCount = new (defFullScholarshipStudentCount, FullScholarshipStudentCount);
                DataColumnParameter paramTermStartDate = new (defTermStartDate, TermStartDate);
                DataColumnParameter paramTermEndDate = new (defTermEndDate, TermEndDate);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramClientID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramRegisteredStudentCount.GetSQLValue(),
                        paramAssignedStudentCount.GetSQLValue(),
                        paramSCADWAREAccessCount.GetSQLValue(),
                        paramSCADWAREAccessThreshold.GetSQLValue(),
                        paramAverageTermBill.GetSQLValue(),
                        paramRatePerStudent.GetSQLValue(),
                        paramBilledPerStudent.GetSQLValue(),
                        paramTotalReceivedOnSCADWAREBill.GetSQLValue(),
                        paramMinimumExpectedOnSCADWAREBill.GetSQLValue(),
                        paramExpectedOnSCADWAREBill.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramFullScholarshipStudentCount.GetSQLValue(),
                        paramTermStartDate.GetSQLValue(),
                        paramTermEndDate.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int ClientID
,            int TermID
,            int RegisteredStudentCount
,            int AssignedStudentCount
,            int SCADWAREAccessCount
,            decimal SCADWAREAccessThreshold
,            decimal AverageTermBill
,            decimal RatePerStudent
,            decimal BilledPerStudent
,            decimal TotalReceivedOnSCADWAREBill
,            decimal MinimumExpectedOnSCADWAREBill
,            decimal ExpectedOnSCADWAREBill
,            string IPAddress
,            DateTime CreatedAt
,            int? FullScholarshipStudentCount = null
,            DateTime? TermStartDate = null
,            DateTime? TermEndDate = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramRegisteredStudentCount = new (defRegisteredStudentCount, RegisteredStudentCount);
                DataColumnParameter paramAssignedStudentCount = new (defAssignedStudentCount, AssignedStudentCount);
                DataColumnParameter paramSCADWAREAccessCount = new (defSCADWAREAccessCount, SCADWAREAccessCount);
                DataColumnParameter paramSCADWAREAccessThreshold = new (defSCADWAREAccessThreshold, SCADWAREAccessThreshold);
                DataColumnParameter paramAverageTermBill = new (defAverageTermBill, AverageTermBill);
                DataColumnParameter paramRatePerStudent = new (defRatePerStudent, RatePerStudent);
                DataColumnParameter paramBilledPerStudent = new (defBilledPerStudent, BilledPerStudent);
                DataColumnParameter paramTotalReceivedOnSCADWAREBill = new (defTotalReceivedOnSCADWAREBill, TotalReceivedOnSCADWAREBill);
                DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new (defMinimumExpectedOnSCADWAREBill, MinimumExpectedOnSCADWAREBill);
                DataColumnParameter paramExpectedOnSCADWAREBill = new (defExpectedOnSCADWAREBill, ExpectedOnSCADWAREBill);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramFullScholarshipStudentCount = new (defFullScholarshipStudentCount, FullScholarshipStudentCount);
                DataColumnParameter paramTermStartDate = new (defTermStartDate, TermStartDate);
                DataColumnParameter paramTermEndDate = new (defTermEndDate, TermEndDate);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  ", TABLE_NAME,
                        paramClientID.GetSQLValue(),
                        paramTermID.GetSQLValue(),
                        paramRegisteredStudentCount.GetSQLValue(),
                        paramAssignedStudentCount.GetSQLValue(),
                        paramSCADWAREAccessCount.GetSQLValue(),
                        paramSCADWAREAccessThreshold.GetSQLValue(),
                        paramAverageTermBill.GetSQLValue(),
                        paramRatePerStudent.GetSQLValue(),
                        paramBilledPerStudent.GetSQLValue(),
                        paramTotalReceivedOnSCADWAREBill.GetSQLValue(),
                        paramMinimumExpectedOnSCADWAREBill.GetSQLValue(),
                        paramExpectedOnSCADWAREBill.GetSQLValue(),
                        paramIPAddress.GetSQLValue(),
                        paramCreatedAt.GetSQLValue(),
                        paramFullScholarshipStudentCount.GetSQLValue(),
                        paramTermStartDate.GetSQLValue(),
                        paramTermEndDate.GetSQLValue()                            
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
