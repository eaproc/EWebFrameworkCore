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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.academic                  
{                  

    public class T___TestTable : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___TestTable()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTestString = new DataColumnDefinition(TableColumnNames.TestString.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestStringNull = new DataColumnDefinition(TableColumnNames.TestStringNull.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestInt32 = new DataColumnDefinition(TableColumnNames.TestInt32.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestInt32Null = new DataColumnDefinition(TableColumnNames.TestInt32Null.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestBool = new DataColumnDefinition(TableColumnNames.TestBool.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestBoolNull = new DataColumnDefinition(TableColumnNames.TestBoolNull.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDecimal = new DataColumnDefinition(TableColumnNames.TestDecimal.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDecimalNull = new DataColumnDefinition(TableColumnNames.TestDecimalNull.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDateTime = new DataColumnDefinition(TableColumnNames.TestDateTime.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDateTimeNull = new DataColumnDefinition(TableColumnNames.TestDateTimeNull.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTestString.ColumnName, defTestString); 
          ColumnDefns.Add(defTestStringNull.ColumnName, defTestStringNull); 
          ColumnDefns.Add(defTestInt32.ColumnName, defTestInt32); 
          ColumnDefns.Add(defTestInt32Null.ColumnName, defTestInt32Null); 
          ColumnDefns.Add(defTestBool.ColumnName, defTestBool); 
          ColumnDefns.Add(defTestBoolNull.ColumnName, defTestBoolNull); 
          ColumnDefns.Add(defTestDecimal.ColumnName, defTestDecimal); 
          ColumnDefns.Add(defTestDecimalNull.ColumnName, defTestDecimalNull); 
          ColumnDefns.Add(defTestDateTime.ColumnName, defTestDateTime); 
          ColumnDefns.Add(defTestDateTimeNull.ColumnName, defTestDateTimeNull); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  


          }


                  
       public T___TestTable() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___TestTable(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(DataTable FullTable) : base(FullTable)                                    
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
        public T___TestTable(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "academic.TestTable";
       public const string TestTable__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TestString], [TestStringNull], [TestInt32], [TestInt32Null], [TestBool], [TestBoolNull], [TestDecimal], [TestDecimalNull], [TestDateTime], [TestDateTimeNull] FROM academic.TestTable";
       public const string TestTable__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TestString], [TestStringNull], [TestInt32], [TestInt32Null], [TestBool], [TestBoolNull], [TestDecimal], [TestDecimalNull], [TestDateTime], [TestDateTimeNull] FROM academic.TestTable";


       public enum TableColumnNames
       {

           ID,
           TestString,
           TestStringNull,
           TestInt32,
           TestInt32Null,
           TestBool,
           TestBoolNull,
           TestDecimal,
           TestDecimalNull,
           TestDateTime,
           TestDateTimeNull
       } 



       public enum TableConstraints{

           pk_academic_TestTable, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTestString;
       public static readonly DataColumnDefinition defTestStringNull;
       public static readonly DataColumnDefinition defTestInt32;
       public static readonly DataColumnDefinition defTestInt32Null;
       public static readonly DataColumnDefinition defTestBool;
       public static readonly DataColumnDefinition defTestBoolNull;
       public static readonly DataColumnDefinition defTestDecimal;
       public static readonly DataColumnDefinition defTestDecimalNull;
       public static readonly DataColumnDefinition defTestDateTime;
       public static readonly DataColumnDefinition defTestDateTimeNull;

       public string TestString { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.TestString.ToString());  set => TargettedRow[TableColumnNames.TestString.ToString()] = value; }


       public string TestStringNull { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.TestStringNull.ToString());  set => TargettedRow[TableColumnNames.TestStringNull.ToString()] = value; }


       public int TestInt32 { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.TestInt32.ToString());  set => TargettedRow[TableColumnNames.TestInt32.ToString()] = value; }


       public int? TestInt32Null { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.TestInt32Null.ToString());  set => TargettedRow[TableColumnNames.TestInt32Null.ToString()] = value; }


       public bool TestBool { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.TestBool.ToString());  set => TargettedRow[TableColumnNames.TestBool.ToString()] = value; }


       public bool? TestBoolNull { get => (bool?)TargettedRow.GetDBValueConverted<bool?>(TableColumnNames.TestBoolNull.ToString());  set => TargettedRow[TableColumnNames.TestBoolNull.ToString()] = value; }


       public decimal TestDecimal { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.TestDecimal.ToString());  set => TargettedRow[TableColumnNames.TestDecimal.ToString()] = value; }


       public decimal? TestDecimalNull { get => (decimal?)TargettedRow.GetDBValueConverted<decimal?>(TableColumnNames.TestDecimalNull.ToString());  set => TargettedRow[TableColumnNames.TestDecimalNull.ToString()] = value; }


       public DateTime TestDateTime { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.TestDateTime.ToString());  set => TargettedRow[TableColumnNames.TestDateTime.ToString()] = value; }


       public DateTime? TestDateTimeNull { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.TestDateTimeNull.ToString());  set => TargettedRow[TableColumnNames.TestDateTimeNull.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___TestTable GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___TestTable GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___TestTable(conn.Fetch(TestTable__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___TestTable GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___TestTable( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___TestTable GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => TestTable__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamTestString;
            private DataColumnParameter ParamTestStringNull;
            private DataColumnParameter ParamTestInt32;
            private DataColumnParameter ParamTestInt32Null;
            private DataColumnParameter ParamTestBool;
            private DataColumnParameter ParamTestBoolNull;
            private DataColumnParameter ParamTestDecimal;
            private DataColumnParameter ParamTestDecimalNull;
            private DataColumnParameter ParamTestDateTime;
            private DataColumnParameter ParamTestDateTimeNull;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___TestTable v):this(v.ID)                  
            {                  

                ParamTestString = new(defTestString, v.TestString);                  
                ParamTestStringNull = new(defTestStringNull, v.TestStringNull);                  
                ParamTestInt32 = new(defTestInt32, v.TestInt32);                  
                ParamTestInt32Null = new(defTestInt32Null, v.TestInt32Null);                  
                ParamTestBool = new(defTestBool, v.TestBool);                  
                ParamTestBoolNull = new(defTestBoolNull, v.TestBoolNull);                  
                ParamTestDecimal = new(defTestDecimal, v.TestDecimal);                  
                ParamTestDecimalNull = new(defTestDecimalNull, v.TestDecimalNull);                  
                ParamTestDateTime = new(defTestDateTime, v.TestDateTime);                  
                ParamTestDateTimeNull = new(defTestDateTimeNull, v.TestDateTimeNull);                  
            }                  
                  
            public UpdateQueryBuilder SetTestString(string v)                  
            {                  
                ParamTestString = new(defTestString, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestStringNull(string v)                  
            {                  
                ParamTestStringNull = new(defTestStringNull, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestInt32(int v)                  
            {                  
                ParamTestInt32 = new(defTestInt32, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestInt32Null(int? v)                  
            {                  
                ParamTestInt32Null = new(defTestInt32Null, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestBool(bool v)                  
            {                  
                ParamTestBool = new(defTestBool, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestBoolNull(bool? v)                  
            {                  
                ParamTestBoolNull = new(defTestBoolNull, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestDecimal(decimal v)                  
            {                  
                ParamTestDecimal = new(defTestDecimal, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestDecimalNull(decimal? v)                  
            {                  
                ParamTestDecimalNull = new(defTestDecimalNull, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestDateTime(DateTime v)                  
            {                  
                ParamTestDateTime = new(defTestDateTime, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetTestDateTimeNull(DateTime? v)                  
            {                  
                ParamTestDateTimeNull = new(defTestDateTimeNull, v);                  
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
            string TestString
,            int TestInt32
,            bool TestBool
,            decimal TestDecimal
,            DateTime TestDateTime
,            string TestStringNull = null
,            int? TestInt32Null = null
,            bool? TestBoolNull = null
,            decimal? TestDecimalNull = null
,            DateTime? TestDateTimeNull = null
          ){

                DataColumnParameter paramTestString = new (defTestString, TestString);
                DataColumnParameter paramTestStringNull = new (defTestStringNull, TestStringNull);
                DataColumnParameter paramTestInt32 = new (defTestInt32, TestInt32);
                DataColumnParameter paramTestInt32Null = new (defTestInt32Null, TestInt32Null);
                DataColumnParameter paramTestBool = new (defTestBool, TestBool);
                DataColumnParameter paramTestBoolNull = new (defTestBoolNull, TestBoolNull);
                DataColumnParameter paramTestDecimal = new (defTestDecimal, TestDecimal);
                DataColumnParameter paramTestDecimalNull = new (defTestDecimalNull, TestDecimalNull);
                DataColumnParameter paramTestDateTime = new (defTestDateTime, TestDateTime);
                DataColumnParameter paramTestDateTimeNull = new (defTestDateTimeNull, TestDateTimeNull);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TestString],[TestStringNull],[TestInt32],[TestInt32Null],[TestBool],[TestBoolNull],[TestDecimal],[TestDecimalNull],[TestDateTime],[TestDateTimeNull]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramTestString.GetSQLValue(),
                        paramTestStringNull.GetSQLValue(),
                        paramTestInt32.GetSQLValue(),
                        paramTestInt32Null.GetSQLValue(),
                        paramTestBool.GetSQLValue(),
                        paramTestBoolNull.GetSQLValue(),
                        paramTestDecimal.GetSQLValue(),
                        paramTestDecimalNull.GetSQLValue(),
                        paramTestDateTime.GetSQLValue(),
                        paramTestDateTimeNull.GetSQLValue()                        )
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
,            string TestString
,            int TestInt32
,            bool TestBool
,            decimal TestDecimal
,            DateTime TestDateTime
,            string TestStringNull = null
,            int? TestInt32Null = null
,            bool? TestBoolNull = null
,            decimal? TestDecimalNull = null
,            DateTime? TestDateTimeNull = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTestString = new (defTestString, TestString);
                DataColumnParameter paramTestStringNull = new (defTestStringNull, TestStringNull);
                DataColumnParameter paramTestInt32 = new (defTestInt32, TestInt32);
                DataColumnParameter paramTestInt32Null = new (defTestInt32Null, TestInt32Null);
                DataColumnParameter paramTestBool = new (defTestBool, TestBool);
                DataColumnParameter paramTestBoolNull = new (defTestBoolNull, TestBoolNull);
                DataColumnParameter paramTestDecimal = new (defTestDecimal, TestDecimal);
                DataColumnParameter paramTestDecimalNull = new (defTestDecimalNull, TestDecimalNull);
                DataColumnParameter paramTestDateTime = new (defTestDateTime, TestDateTime);
                DataColumnParameter paramTestDateTimeNull = new (defTestDateTimeNull, TestDateTimeNull);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TestString],[TestStringNull],[TestInt32],[TestInt32Null],[TestBool],[TestBoolNull],[TestDecimal],[TestDecimalNull],[TestDateTime],[TestDateTimeNull]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramTestString.GetSQLValue(),
                        paramTestStringNull.GetSQLValue(),
                        paramTestInt32.GetSQLValue(),
                        paramTestInt32Null.GetSQLValue(),
                        paramTestBool.GetSQLValue(),
                        paramTestBoolNull.GetSQLValue(),
                        paramTestDecimal.GetSQLValue(),
                        paramTestDecimalNull.GetSQLValue(),
                        paramTestDateTime.GetSQLValue(),
                        paramTestDateTimeNull.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            string TestString
,            int TestInt32
,            bool TestBool
,            decimal TestDecimal
,            DateTime TestDateTime
,            string TestStringNull = null
,            int? TestInt32Null = null
,            bool? TestBoolNull = null
,            decimal? TestDecimalNull = null
,            DateTime? TestDateTimeNull = null
          ){

                DataColumnParameter paramTestString = new (defTestString, TestString);
                DataColumnParameter paramTestStringNull = new (defTestStringNull, TestStringNull);
                DataColumnParameter paramTestInt32 = new (defTestInt32, TestInt32);
                DataColumnParameter paramTestInt32Null = new (defTestInt32Null, TestInt32Null);
                DataColumnParameter paramTestBool = new (defTestBool, TestBool);
                DataColumnParameter paramTestBoolNull = new (defTestBoolNull, TestBoolNull);
                DataColumnParameter paramTestDecimal = new (defTestDecimal, TestDecimal);
                DataColumnParameter paramTestDecimalNull = new (defTestDecimalNull, TestDecimalNull);
                DataColumnParameter paramTestDateTime = new (defTestDateTime, TestDateTime);
                DataColumnParameter paramTestDateTimeNull = new (defTestDateTimeNull, TestDateTimeNull);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TestString],[TestStringNull],[TestInt32],[TestInt32Null],[TestBool],[TestBoolNull],[TestDecimal],[TestDecimalNull],[TestDateTime],[TestDateTimeNull]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramTestString.GetSQLValue(),
                        paramTestStringNull.GetSQLValue(),
                        paramTestInt32.GetSQLValue(),
                        paramTestInt32Null.GetSQLValue(),
                        paramTestBool.GetSQLValue(),
                        paramTestBoolNull.GetSQLValue(),
                        paramTestDecimal.GetSQLValue(),
                        paramTestDecimalNull.GetSQLValue(),
                        paramTestDateTime.GetSQLValue(),
                        paramTestDateTimeNull.GetSQLValue()                            
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
