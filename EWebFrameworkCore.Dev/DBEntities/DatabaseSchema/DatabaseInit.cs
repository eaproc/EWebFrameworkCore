using EEntityCore.DB.MSSQL;
using EEntityCore.DB.MSSQL.Schemas;
using System;

namespace EWebFrameworkCore.Dev.DBEntities.DatabaseSchema
{

    /// <summary>
    /// Make sure you initialize this in your app as DatabaseInit.DBConnectInterface = new DatabaseInit(mode). This class only points to your connection. You can override it
    /// DatabaseInit.DBConnectInterface = new DatabaseInit("SalesSCADWARE", "sa", "netEPRO@2017", 51391, @"localhost\SQLSERVER2016");
    /// </summary>
    /// <remarks></remarks>
    public class DatabaseInit : IDatabaseInit
    {

        public class TransactionRunner : IDisposable
        {
            private bool AllowDispose;
            private DBTransaction Transaction;

            public TransactionRunner(DBTransaction trans = null)
            {
                Transaction = trans ?? CreateTransaction();
                AllowDispose = trans == null;
            }

            public T Run<T>(Func<DBTransaction, T> action)
            {
                var r = action(this.Transaction);

                // Dispose immediately if no need to hold for long
                if (AllowDispose) this.Dispose();

                return r;
            }

            public static T InvokeRun<T>(Func<DBTransaction, T> action, DBTransaction trans = null)
            {
                using var r = new TransactionRunner(trans);
                return r.Run(action);
            }

            public void Dispose()
            {
                if (AllowDispose && Transaction != null)
                {
                    Transaction.Dispose();
                    Transaction = null;
                }
            }
        }



        #region Constructors

        /// <summary>
        /// Just for pointer access
        /// </summary>
        public DatabaseInit()
        {

        }

        /// <summary>
        /// Create Default. NOTE: Server name is not required for FULL_SERVER MODE.
        /// </summary>
        /// <param name="pServerName">with intance name if any like PC\sqlexpress for client modes but for server mode [ Just the SQL Server InstanceName like sqlserver2014 ]</param>
        /// <param name="pDatabaseName">This is very important. the name of the database you are connecting to like [Master]</param>
        /// <param name="pUserName">this is not needed for server mode if server is not allowing clients connection</param>
        /// <param name="pUserPassword">this is not needed for server mode if server is not allowing clients connection</param>
        /// <param name="pPort">this is not needed for server mode if server is not allowing clients connection</param>
        /// <remarks></remarks>
        public DatabaseInit(string pDatabaseName, string pUserName = "", string pUserPassword = "", int pPort = 1433, string pServerName = "")
        {
            ServerName = pServerName;
            UserName = pUserName;
            UserPassword = pUserPassword;
            DatabaseName = pDatabaseName;
            Port = pPort;
        }


        #endregion



        #region Properties

        //private DatabaseSchema.IDatabaseInit Parent;

        /// <summary>
        /// You are responsible for initializing this
        /// </summary>
        /// <remarks></remarks>
        public static DatabaseInit DBConnectInterface { get; set; }


        private readonly string ServerName;
        private readonly string DatabaseName;
        private readonly string UserName;
        private readonly string UserPassword;
        private readonly int Port;


        #endregion



        #region Methods

        public IDatabaseInit GetDatabaseInit()
        {
            return DBConnectInterface;
        }

        /// <summary>
        /// Returns new connection on each call
        /// </summary>
        /// <returns></returns>
        public MsSQLDB GetDBConn()
        {
            return new MsSQLDB(ServerIPAddressOrName(), ServerPort(), DBUserName(), DBUserPassword(), DBName());
        }

        //public int Execute(string Query, DBTransaction transaction = null)
        //{
        //    if (transaction != null) return transaction.ExecuteTransactionQuery(Query);
        //    return GetDBConn().DbExec(Query);
        //}

        public static DBTransaction CreateTransaction()
        {
            return new DBTransaction(DBConnectInterface.GetDBConn().GetSQLConnection());
        }

        //public DataSet Fetch(string Query, DBTransaction transaction = null)
        //{
        //    if (transaction != null) return transaction.Fetch(Query);
        //    return GetDBConn().GetRS(Query);
        //}

        public string DBName()
        {
            return DatabaseName;
        }

        public string DBUserName()
        {
            return UserName;
        }

        public string DBUserPassword()
        {
            return UserPassword;
        }

        public string ServerIPAddressOrName()
        {
            return ServerName;
        }

        public int ServerPort()
        {
            return Port;
        }




        #endregion


    }
}