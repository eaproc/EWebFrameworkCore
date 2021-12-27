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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___PaymentTransactionTarget : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaymentTransactionTarget()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentTransactionID = new DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStudentNumber = new DataColumnDefinition(TableColumnNames.StudentNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID); 
          ColumnDefns.Add(defStudentNumber.ColumnName, defStudentNumber); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransactionTarget_PaymentTransactionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "pay_gateway.PaymentTransactionTarget", "pay_gateway.PaymentTransaction"                  
                            ));                  

          }


                  
       public T___PaymentTransactionTarget() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaymentTransactionTarget(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(DataTable FullTable) : base(FullTable)                                    
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
        public T___PaymentTransactionTarget(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.PaymentTransactionTarget";
       public const string PaymentTransactionTarget__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PaymentTransactionID], [StudentNumber], [FirstName], [LastName], [PaymentRequiredWithoutCharges] FROM pay_gateway.PaymentTransactionTarget";
       public const string PaymentTransactionTarget__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PaymentTransactionID], [StudentNumber], [FirstName], [LastName], [PaymentRequiredWithoutCharges] FROM pay_gateway.PaymentTransactionTarget";


       public enum TableColumnNames
       {

           ID,
           PaymentTransactionID,
           StudentNumber,
           FirstName,
           LastName,
           PaymentRequiredWithoutCharges
       } 



       public enum TableConstraints{

           pk_pay_gateway_PaymentTransactionTarget, 
           fk_PaymentTransactionTarget_PaymentTransactionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPaymentTransactionID;
       public static readonly DataColumnDefinition defStudentNumber;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defPaymentRequiredWithoutCharges;

       public int PaymentTransactionID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PaymentTransactionID.ToString());  set => TargettedRow[TableColumnNames.PaymentTransactionID.ToString()] = value; }


       public string StudentNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.StudentNumber.ToString());  set => TargettedRow[TableColumnNames.StudentNumber.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public decimal PaymentRequiredWithoutCharges { get => (decimal)TargettedRow.GetDBValueConverted<decimal>(TableColumnNames.PaymentRequiredWithoutCharges.ToString());  set => TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PaymentTransactionTarget GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PaymentTransactionTarget GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___PaymentTransactionTarget(conn.Fetch(PaymentTransactionTarget__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___PaymentTransactionTarget GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___PaymentTransactionTarget( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___PaymentTransactionTarget GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PaymentTransactionTarget__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamPaymentTransactionID;
            private DataColumnParameter ParamStudentNumber;
            private DataColumnParameter ParamFirstName;
            private DataColumnParameter ParamLastName;
            private DataColumnParameter ParamPaymentRequiredWithoutCharges;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PaymentTransactionTarget v):this(v.ID)                  
            {                  

                ParamPaymentTransactionID = new(defPaymentTransactionID, v.PaymentTransactionID);                  
                ParamStudentNumber = new(defStudentNumber, v.StudentNumber);                  
                ParamFirstName = new(defFirstName, v.FirstName);                  
                ParamLastName = new(defLastName, v.LastName);                  
                ParamPaymentRequiredWithoutCharges = new(defPaymentRequiredWithoutCharges, v.PaymentRequiredWithoutCharges);                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentTransactionID(int v)                  
            {                  
                ParamPaymentTransactionID = new(defPaymentTransactionID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetStudentNumber(string v)                  
            {                  
                ParamStudentNumber = new(defStudentNumber, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFirstName(string v)                  
            {                  
                ParamFirstName = new(defFirstName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLastName(string v)                  
            {                  
                ParamLastName = new(defLastName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPaymentRequiredWithoutCharges(decimal v)                  
            {                  
                ParamPaymentRequiredWithoutCharges = new(defPaymentRequiredWithoutCharges, v);                  
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
            int PaymentTransactionID
,            string StudentNumber
,            string FirstName
,            string LastName
,            decimal PaymentRequiredWithoutCharges
          ){

                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5})  ", TABLE_NAME,
                        paramPaymentTransactionID.GetSQLValue(),
                        paramStudentNumber.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue()                        )
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
,            int PaymentTransactionID
,            string StudentNumber
,            string FirstName
,            string LastName
,            decimal PaymentRequiredWithoutCharges
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramPaymentTransactionID.GetSQLValue(),
                        paramStudentNumber.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int PaymentTransactionID
,            string StudentNumber
,            string FirstName
,            string LastName
,            decimal PaymentRequiredWithoutCharges
          ){

                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5})  ", TABLE_NAME,
                        paramPaymentTransactionID.GetSQLValue(),
                        paramStudentNumber.GetSQLValue(),
                        paramFirstName.GetSQLValue(),
                        paramLastName.GetSQLValue(),
                        paramPaymentRequiredWithoutCharges.GetSQLValue()                            
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
