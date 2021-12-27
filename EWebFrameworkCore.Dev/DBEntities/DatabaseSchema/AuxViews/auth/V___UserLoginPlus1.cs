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

    public class V___UserLoginPlus1 : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___UserLoginPlus1()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defUsername = new DataColumnDefinition(TableColumnNames.Username.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastLoginTime = new DataColumnDefinition(TableColumnNames.LastLoginTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLoggedOutTime = new DataColumnDefinition(TableColumnNames.LoggedOutTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionID = new DataColumnDefinition(TableColumnNames.SessionID.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionIDCreatedTime = new DataColumnDefinition(TableColumnNames.SessionIDCreatedTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionTimeoutMins = new DataColumnDefinition(TableColumnNames.SessionTimeoutMins.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastActive = new DataColumnDefinition(TableColumnNames.LastActive.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpiryDate = new DataColumnDefinition(TableColumnNames.ExpiryDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSecondsLeft = new DataColumnDefinition(TableColumnNames.SecondsLeft.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defActiveSessions = new DataColumnDefinition(TableColumnNames.ActiveSessions.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defLastLoginTime.ColumnName, defLastLoginTime); 
          ColumnDefns.Add(defLoggedOutTime.ColumnName, defLoggedOutTime); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defSessionID.ColumnName, defSessionID); 
          ColumnDefns.Add(defSessionIDCreatedTime.ColumnName, defSessionIDCreatedTime); 
          ColumnDefns.Add(defSessionTimeoutMins.ColumnName, defSessionTimeoutMins); 
          ColumnDefns.Add(defLastActive.ColumnName, defLastActive); 
          ColumnDefns.Add(defExpiryDate.ColumnName, defExpiryDate); 
          ColumnDefns.Add(defSecondsLeft.ColumnName, defSecondsLeft); 
          ColumnDefns.Add(defActiveSessions.ColumnName, defActiveSessions); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("auth.Session");                  
            ReferencedTableNames.Add("auth.UserLoginHistory");                  
            ReferencedTableNames.Add("auth.Users");                  

          }


                  
       public V___UserLoginPlus1() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___UserLoginPlus1(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(DataTable FullTable) : base(FullTable)                                    
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
        public V___UserLoginPlus1(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.UserLoginPlus1";
       public const string UserLoginPlus1__NO__BINARY___SQL_FILL_QUERY = "SELECT [Username], [LastLoginTime], [LoggedOutTime], [IPAddress], [SessionID], [SessionIDCreatedTime], [SessionTimeoutMins], [LastActive], [ExpiryDate], [SecondsLeft], [ActiveSessions], [UserID], [PersonID], [IsActive] FROM auth.UserLoginPlus1";
       public const string UserLoginPlus1__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [Username], [LastLoginTime], [LoggedOutTime], [IPAddress], [SessionID], [SessionIDCreatedTime], [SessionTimeoutMins], [LastActive], [ExpiryDate], [SecondsLeft], [ActiveSessions], [UserID], [PersonID], [IsActive] FROM auth.UserLoginPlus1";


       public enum TableColumnNames
       {

           Username,
           LastLoginTime,
           LoggedOutTime,
           IPAddress,
           SessionID,
           SessionIDCreatedTime,
           SessionTimeoutMins,
           LastActive,
           ExpiryDate,
           SecondsLeft,
           ActiveSessions,
           UserID,
           PersonID,
           IsActive
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defLastLoginTime;
       public static readonly DataColumnDefinition defLoggedOutTime;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defSessionID;
       public static readonly DataColumnDefinition defSessionIDCreatedTime;
       public static readonly DataColumnDefinition defSessionTimeoutMins;
       public static readonly DataColumnDefinition defLastActive;
       public static readonly DataColumnDefinition defExpiryDate;
       public static readonly DataColumnDefinition defSecondsLeft;
       public static readonly DataColumnDefinition defActiveSessions;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defIsActive;

       public string Username { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Username.ToString());  set => TargettedRow[TableColumnNames.Username.ToString()] = value; }


       public DateTime? LastLoginTime { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.LastLoginTime.ToString());  set => TargettedRow[TableColumnNames.LastLoginTime.ToString()] = value; }


       public DateTime? LoggedOutTime { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.LoggedOutTime.ToString());  set => TargettedRow[TableColumnNames.LoggedOutTime.ToString()] = value; }


       public string IPAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IPAddress.ToString());  set => TargettedRow[TableColumnNames.IPAddress.ToString()] = value; }


       public string SessionID { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.SessionID.ToString());  set => TargettedRow[TableColumnNames.SessionID.ToString()] = value; }


       public DateTime? SessionIDCreatedTime { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.SessionIDCreatedTime.ToString());  set => TargettedRow[TableColumnNames.SessionIDCreatedTime.ToString()] = value; }


       public int? SessionTimeoutMins { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.SessionTimeoutMins.ToString());  set => TargettedRow[TableColumnNames.SessionTimeoutMins.ToString()] = value; }


       public DateTime? LastActive { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.LastActive.ToString());  set => TargettedRow[TableColumnNames.LastActive.ToString()] = value; }


       public DateTime? ExpiryDate { get => (DateTime?)TargettedRow.GetDBValueConverted<DateTime?>(TableColumnNames.ExpiryDate.ToString());  set => TargettedRow[TableColumnNames.ExpiryDate.ToString()] = value; }


       public int? SecondsLeft { get => (int?)TargettedRow.GetDBValueConverted<int?>(TableColumnNames.SecondsLeft.ToString());  set => TargettedRow[TableColumnNames.SecondsLeft.ToString()] = value; }


       public string ActiveSessions { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ActiveSessions.ToString());  set => TargettedRow[TableColumnNames.ActiveSessions.ToString()] = value; }


       public int UserID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.UserID.ToString());  set => TargettedRow[TableColumnNames.UserID.ToString()] = value; }


       public int PersonID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PersonID.ToString());  set => TargettedRow[TableColumnNames.PersonID.ToString()] = value; }


       public bool IsActive { get => (bool)TargettedRow.GetDBValueConverted<bool>(TableColumnNames.IsActive.ToString());  set => TargettedRow[TableColumnNames.IsActive.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___UserLoginPlus1 GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___UserLoginPlus1 GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new V___UserLoginPlus1(conn.Fetch(UserLoginPlus1__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static V___UserLoginPlus1 GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new V___UserLoginPlus1( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public V___UserLoginPlus1 GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => UserLoginPlus1__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
