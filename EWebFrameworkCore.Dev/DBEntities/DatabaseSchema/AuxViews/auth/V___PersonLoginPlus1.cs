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

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxViews.auth                  
{                  

    public class V___PersonLoginPlus1 : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___PersonLoginPlus1()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defUsername = new DataColumnDefinition(TableColumnNames.Username.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIdentificationNo = new DataColumnDefinition(TableColumnNames.IdentificationNo.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastLoginTime = new DataColumnDefinition(TableColumnNames.LastLoginTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionTimeoutMins = new DataColumnDefinition(TableColumnNames.SessionTimeoutMins.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastActive = new DataColumnDefinition(TableColumnNames.LastActive.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTimeSpentSecs = new DataColumnDefinition(TableColumnNames.TimeSpentSecs.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSecondsLeft = new DataColumnDefinition(TableColumnNames.SecondsLeft.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStatus = new DataColumnDefinition(TableColumnNames.Status.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionID = new DataColumnDefinition(TableColumnNames.SessionID.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defActiveSessions = new DataColumnDefinition(TableColumnNames.ActiveSessions.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLoggedOutTime = new DataColumnDefinition(TableColumnNames.LoggedOutTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionIDCreatedTime = new DataColumnDefinition(TableColumnNames.SessionIDCreatedTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defLastLoginTime.ColumnName, defLastLoginTime); 
          ColumnDefns.Add(defSessionTimeoutMins.ColumnName, defSessionTimeoutMins); 
          ColumnDefns.Add(defLastActive.ColumnName, defLastActive); 
          ColumnDefns.Add(defTimeSpentSecs.ColumnName, defTimeSpentSecs); 
          ColumnDefns.Add(defSecondsLeft.ColumnName, defSecondsLeft); 
          ColumnDefns.Add(defStatus.ColumnName, defStatus); 
          ColumnDefns.Add(defSessionID.ColumnName, defSessionID); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defActiveSessions.ColumnName, defActiveSessions); 
          ColumnDefns.Add(defLoggedOutTime.ColumnName, defLoggedOutTime); 
          ColumnDefns.Add(defSessionIDCreatedTime.ColumnName, defSessionIDCreatedTime); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("auth.UserLoginPlus1");                  
            ReferencedTableNames.Add("common.Person");                  

          }


                  
       public V___PersonLoginPlus1() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___PersonLoginPlus1(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PersonLoginPlus1(DataTable FullTable) : base(FullTable)                                    
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
        public V___PersonLoginPlus1(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.PersonLoginPlus1";
       public const string PersonLoginPlus1__NO__BINARY___SQL_FILL_QUERY = "SELECT [Username], [IdentificationNo], [FirstName], [LastName], [LastLoginTime], [SessionTimeoutMins], [LastActive], [TimeSpentSecs], [SecondsLeft], [Status], [SessionID], [IPAddress], [IsActive], [ActiveSessions], [LoggedOutTime], [SessionIDCreatedTime], [PersonID], [UserID] FROM auth.PersonLoginPlus1";
       public const string PersonLoginPlus1__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [Username], [IdentificationNo], [FirstName], [LastName], [LastLoginTime], [SessionTimeoutMins], [LastActive], [TimeSpentSecs], [SecondsLeft], [Status], [SessionID], [IPAddress], [IsActive], [ActiveSessions], [LoggedOutTime], [SessionIDCreatedTime], [PersonID], [UserID] FROM auth.PersonLoginPlus1";


       public enum TableColumnNames
       {

           Username,
           IdentificationNo,
           FirstName,
           LastName,
           LastLoginTime,
           SessionTimeoutMins,
           LastActive,
           TimeSpentSecs,
           SecondsLeft,
           Status,
           SessionID,
           IPAddress,
           IsActive,
           ActiveSessions,
           LoggedOutTime,
           SessionIDCreatedTime,
           PersonID,
           UserID
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defIdentificationNo;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defLastLoginTime;
       public static readonly DataColumnDefinition defSessionTimeoutMins;
       public static readonly DataColumnDefinition defLastActive;
       public static readonly DataColumnDefinition defTimeSpentSecs;
       public static readonly DataColumnDefinition defSecondsLeft;
       public static readonly DataColumnDefinition defStatus;
       public static readonly DataColumnDefinition defSessionID;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defActiveSessions;
       public static readonly DataColumnDefinition defLoggedOutTime;
       public static readonly DataColumnDefinition defSessionIDCreatedTime;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defUserID;

       public string Username { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Username.ToString());  set => TargettedRow[TableColumnNames.Username.ToString()] = value; }


       public string IdentificationNo { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IdentificationNo.ToString());  set => TargettedRow[TableColumnNames.IdentificationNo.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public DateTime? LastLoginTime { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.LastLoginTime.ToString());  set => TargettedRow[TableColumnNames.LastLoginTime.ToString()] = value; }


       public int? SessionTimeoutMins { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.SessionTimeoutMins.ToString());  set => TargettedRow[TableColumnNames.SessionTimeoutMins.ToString()] = value; }


       public DateTime? LastActive { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.LastActive.ToString());  set => TargettedRow[TableColumnNames.LastActive.ToString()] = value; }


       public int? TimeSpentSecs { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.TimeSpentSecs.ToString());  set => TargettedRow[TableColumnNames.TimeSpentSecs.ToString()] = value; }


       public int? SecondsLeft { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.SecondsLeft.ToString());  set => TargettedRow[TableColumnNames.SecondsLeft.ToString()] = value; }


       public string Status { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Status.ToString());  set => TargettedRow[TableColumnNames.Status.ToString()] = value; }


       public string SessionID { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SessionID.ToString());  set => TargettedRow[TableColumnNames.SessionID.ToString()] = value; }


       public string IPAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IPAddress.ToString());  set => TargettedRow[TableColumnNames.IPAddress.ToString()] = value; }


       public bool IsActive { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


       public string ActiveSessions { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ActiveSessions.ToString());  set => TargettedRow[TableColumnNames.ActiveSessions.ToString()] = value; }


       public DateTime? LoggedOutTime { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.LoggedOutTime.ToString());  set => TargettedRow[TableColumnNames.LoggedOutTime.ToString()] = value; }


       public DateTime? SessionIDCreatedTime { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.SessionIDCreatedTime.ToString());  set => TargettedRow[TableColumnNames.SessionIDCreatedTime.ToString()] = value; }


       public int PersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonID.ToString());  set => TargettedRow[TableColumnNames.PersonID.ToString()] = value; }


       public int UserID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UserID.ToString());  set => TargettedRow[TableColumnNames.UserID.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___PersonLoginPlus1 GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___PersonLoginPlus1 GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new V___PersonLoginPlus1(conn.Fetch(PersonLoginPlus1__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static V___PersonLoginPlus1 GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new V___PersonLoginPlus1( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public V___PersonLoginPlus1 GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PersonLoginPlus1__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
