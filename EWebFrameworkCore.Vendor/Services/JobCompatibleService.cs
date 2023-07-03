using EEntityCore.DB.Abstracts;
using EEntityCore.DB.MSSQL;
using ELibrary.Standard.VB.Objects;
using EWebFrameworkCore.Vendor.CloudFileSystem;
using EWebFrameworkCore.Vendor.ConfigurationTypedClasses;
using EWebFrameworkCore.Vendor.Services.DataTablesNET;
using EWebFrameworkCore.Vendor.Utils;
using Microsoft.Extensions.Configuration;
using Serilog.Core;
using System.Data;
using System.Text;

namespace EWebFrameworkCore.Vendor.Services
{
    /// <summary>
    /// Extend for Client Service
    /// </summary>
    public class JobCompatibleService
    {
        /// <summary>
        /// Not working with SQL Server yet
        /// </summary>
        public const string SQL_DB_GMT_TIMEZONED_DATE_TIME_STRING = "yyyy-MM-dd HH:mm:ss \"GMT\"zzz";
        /// <summary>
        /// Works with SQL Server
        /// </summary>
        public const string SQL_DB_DATE_TIME_STRING = "yyyy-MM-dd HH:mm:ss";
        /// <summary>
        /// Works with SQL Server
        /// </summary>
        public const string SQL_DB_DATE_STRING = "yyyy-MM-dd";

        public const string SQL_DB_HOUR_MINUTE_STRING = "HH:mm";

        public MSSQLConnectionOption ConnectionOption { get; protected set; }

        public string MINIO_BUCKET { get; set; } = string.Empty;

        public IServiceProvider Provider { get; }
        public IConfiguration Configurations { get; private set; }

        public readonly ConfigurationOptions EWebFrameworkCoreConfigurations;

        public Logger Log { get; }
        public DatabaseTimeZoneUtilsExtensions.DatabaseTimeZoneUtils DBTimeZoneUtils { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionOption"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public JobCompatibleService(IServiceProvider provider, MSSQLConnectionOption connectionOption)
        {
            this.Provider = provider;

            this.Configurations = provider.GetConfigurations();

            this.EWebFrameworkCoreConfigurations = Provider.GetEWebFrameworkCoreOptions();
            this.Log = Bootstrap.GetLogger();

            this.DBTimeZoneUtils = new DatabaseTimeZoneUtilsExtensions.DatabaseTimeZoneUtils(EWebFrameworkCoreConfigurations.GENERAL.DATABASE_TIMEZONE);

            this.ConnectionOption = connectionOption;
        }

        public JobCompatibleService(IServiceProvider provider) : this(provider, new MSSQLConnectionOption())
        { }

        protected void SetConnection(MSSQLConnectionOption connectionOption)
        {
            this.ConnectionOption = connectionOption;
        }

        private DBTransaction CreateTransaction()
        {
            return new DBTransaction(this.GetDBConn().GetSQLConnection());
        }

        /// <summary>
        /// For more than one run call, set immediateDisposal to false or atleast set AllowDispose to false
        /// Differrence is, you will have to call ForceDispose if you set AllowDispose to false.
        /// 
        /// Be careful to make sure the tables don't depend on each other in a transaction else you will have Deadlock
        /// </summary>
        /// <param name="allowDispose">If true, Dispose method will work fine on Garbage Collection and on normal call else you will need to call ForceDispose()</param>
        /// <param name="immediateDisposal">If true and allowDispose is true, it will dispose immediately on the first call of Run</param>
        /// <returns></returns>
        public TransactionRunner CreateTransactionRunner(bool allowDispose = true, bool immediateDisposal = true)
        {
            // LEARN DEALING WITH TRANSACTION RUNNER
            // ------------------------------------
            //int ClassID, TermID;

            // AllowDispose to false, immediateDisposal can't work since AllowDispose is false.

            ////var runner = CreateTransactionRunner(false);
            //// T___PRTermTopic topic = T___PRTermTopic.GetRowWhereIDUsingSQL(ID, runner);
            ////    ClassID = topic.ClassID;
            ////    TermID = topic.TermID;
            ////    T___PRTermTopic.DeleteItemRow(runner, pID: ID);

            ////runner.ForceDispose();

            // AllowDispose = true, immediateDisposal = false. This is perfect when using "using" command
            // as it will auto dispose once you are totally done

            //using (var runner = CreateTransactionRunner(true, immediateDisposal: false)) {
            //    T___PRTermTopic topic = T___PRTermTopic.GetRowWhereIDUsingSQL(ID, runner);
            //    ClassID = topic.ClassID;
            //    TermID = topic.TermID;
            //    T___PRTermTopic.DeleteItemRow(runner, pID: ID);
            //}


            // Also, you can use this 2 approaches when using the keyword "using"

            //using (var runner = CreateTransactionRunner(true, immediateDisposal: false))
            //{
            //    // This is only best if immediateDisposal is true and allowDispose is true
            //    runner.Run((trans) => trans.ExecuteTransactionQuery(string.Format("delete from academic.StudentCBTExam where EvaluationCBTExamID={0}", ID)));
            //    runner.Run((trans) => trans.ExecuteTransactionQuery(string.Format("delete from  academic.EvaluationCBTExam where ID={0}", ID)));

            //    OR THIS because in our case, Run doesn't do anything different since immediateDisposal is false.

            //    runner.Transaction.ExecuteTransactionQuery(string.Format("delete from academic.StudentCBTExam where EvaluationCBTExamID={0}", ID));
            //    runner.Transaction.ExecuteTransactionQuery(string.Format("delete from  academic.EvaluationCBTExam where ID={0}", ID));
            //}

            return new TransactionRunner(CreateTransaction(), allowDispose: allowDispose, immediateDisposal: immediateDisposal);
        }

        public MsSQLDB GetDBConn()
        {
            return new MsSQLDB(ConnectionOption.HOST, ConnectionOption.PORT, ConnectionOption.DATABASE_USER_NAME, ConnectionOption.DATABASE_USER_PASSWORD, ConnectionOption.DATABASE_NAME);
        }

        /// <summary>
        /// The current time on the system. Server
        /// </summary>
        public static DateTime ServerNowDateTime
        {
            get
            {
                return DateTime.Now;
            }
        }

        /// <summary>
        /// Turn this on if you want to trace sql query
        /// </summary>
        protected bool TRACE_DEBUG_SQL { get; set; } = false;

        /// <summary>
        /// Addressing apostrophe means you will pass string value with this \'{0}\'
        /// </summary>
        /// <param name="pSQL"></param>
        /// <param name="AddressApostrophe"></param>
        /// <returns>DataTable or throws exception</returns>
        public virtual DataTable GetSQLTable(String pSQL, bool AddressApostrophe = false)
        {
            if (TRACE_DEBUG_SQL) Log.Information (pSQL);
            // I don't expect table to be null if sql executes successfully
            var db = (All__DBs)GetDBConn();
            DataSet p = db.getRS(pSQL, AddressApostrophe);
            return p.Tables[0];
        }


        /// <summary>
        /// Addressing apostrophe means you will pass string value with this \'{0}\'
        /// </summary>
        /// <param name="pSQL"></param>
        /// <param name="AddressApostrophe"></param>
        /// <returns>boolean</returns>
        public virtual int ExecuteQuery(String pSQL, bool AddressApostrophe = false)
        {
            if (TRACE_DEBUG_SQL) Log.Information(pSQL);
            return GetDBConn().DbExec(SQL: pSQL, Address_Apostrophe_Issue: AddressApostrophe);
        }



        #region "Utilities"

        /// <summary>
        /// Checks if table is not null and has rows
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static bool HasRows(DataTable dataTable)
        {
            return dataTable != null && dataTable.Rows.Count > 0;
        }

        #endregion


        #region Pagination

        /// <summary>
        /// For pagination
        /// </summary>
        /// <param name="pStart"></param>
        /// <param name="pLength"></param>
        /// <param name="pSQL"></param>
        /// <param name="pPreSQL"></param>
        /// <param name="OverrideOrderBy"></param>
        /// <param name="pOrderByColumn"></param>
        /// <param name="pOrderByColumnDirection"></param>
        /// <param name="pWhereClauseFilter"></param>
        /// <returns>DataTable or throws exception</returns>
        protected DataTable Paginate(int pStart, int pLength, string pSQL,
             string pPreSQL = "", String? OverrideOrderBy = null,
            String pOrderByColumn = "1", String pOrderByColumnDirection = "asc", string pWhereClauseFilter = "")
        {
            // Injected filtered_record_count
            //
            string bSQL;
            if (OverrideOrderBy == null || OverrideOrderBy == String.Empty)
            {
                bSQL = String.Format(
                                        pPreSQL + Environment.NewLine +
                                        "SELECT TOP {2} * FROM (                  " + Environment.NewLine +
                                        "     SELECT *                                                                                " + Environment.NewLine +
                                        "         FROM (                                                                                  " + Environment.NewLine +
                                        "                   SELECT *,                                                                     " + Environment.NewLine +
                                        "                       (                                                                         " + Environment.NewLine +
                                        "                          SELECT count(*) as filtered_record_count                               " + Environment.NewLine +
                                        "                          FROM (                                                                 " + Environment.NewLine +
                                        "                                   {0}                                                           " + Environment.NewLine +
                                        "                               ) as rows_fetched                                                 " + Environment.NewLine +
                                        "                          {3}                                                                    " + Environment.NewLine +
                                        "                       ) AS filtered_record_count                                                " + Environment.NewLine +
                                        "                   FROM (                                                                        " + Environment.NewLine +
                                        "                           {0}                                                                   " + Environment.NewLine +
                                        "                         ) as rows_fetched                                                       " + Environment.NewLine +
                                        "                   {3}                                                                           " + Environment.NewLine +
                                        "            ) as rows_fetched_with_count                                                         " + Environment.NewLine +
                                        "         ORDER BY {4} {5}                                                                        " + Environment.NewLine +
                                        "         OFFSET {1} ROWS                                                                         " + Environment.NewLine +
                                        "                      ) finalFetch                  " + Environment.NewLine +
                                        "                  ", pSQL, pStart, pLength, pWhereClauseFilter, pOrderByColumn, pOrderByColumnDirection
                                        );
            }
            else
            {
                bSQL = String.Format(
                                pPreSQL + Environment.NewLine +
                                        "SELECT TOP {2} * FROM (                  " + Environment.NewLine +
                                        "     SELECT *                                                                                " + Environment.NewLine +
                                        "         FROM (                                                                                  " + Environment.NewLine +
                                        "                   SELECT *,                                                                     " + Environment.NewLine +
                                        "                       (                                                                         " + Environment.NewLine +
                                        "                          SELECT count(*) as filtered_record_count                               " + Environment.NewLine +
                                        "                          FROM (                                                                 " + Environment.NewLine +
                                        "                                   {0}                                                           " + Environment.NewLine +
                                        "                               ) as rows_fetched                                                 " + Environment.NewLine +
                                        "                          {3}                                                                    " + Environment.NewLine +
                                        "                       ) AS filtered_record_count                                                " + Environment.NewLine +
                                        "                   FROM (                                                                        " + Environment.NewLine +
                                        "                           {0}                                                                   " + Environment.NewLine +
                                        "                         ) as rows_fetched                                                       " + Environment.NewLine +
                                        "                   {3}                                                                           " + Environment.NewLine +
                                        "            ) as rows_fetched_with_count                                                         " + Environment.NewLine +
                                        "         ORDER BY {4}                                                                        " + Environment.NewLine +
                                        "         OFFSET {1} ROWS                                                                         " + Environment.NewLine +
                                        "                      ) finalFetch                  " + Environment.NewLine +
                                        "                  ", pSQL, pStart, pLength, pWhereClauseFilter, OverrideOrderBy
                               );
            }

            return GetSQLTable(pSQL: bSQL);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSQL"></param>
        /// <param name="pOrderByColumnIndex"></param>
        /// <param name="pOrderByColumnDirection"></param>
        /// <param name="pWhereClauseFilter"></param>
        /// <returns></returns>
        protected DataTable ProcessForExport(string pSQL, int pOrderByColumnIndex = 1, String pOrderByColumnDirection = "asc", string pWhereClauseFilter = "")
        {
            // Injected filtered_record_count
            //

            return GetSQLTable(pSQL:
                String.Format("     SELECT *                                                              " + Environment.NewLine +
                                "     FROM (                                                                " + Environment.NewLine +
                                "               SELECT *                                                   " + Environment.NewLine +
                                "               FROM (                                                      " + Environment.NewLine +
                                "                       {0}                                                 " + Environment.NewLine +
                                "                     ) as rows_fetched                                     " + Environment.NewLine +
                                "               {1}                                                         " + Environment.NewLine +
                                "        ) as rows_fetched_with_count                                       " + Environment.NewLine +
                                "     ORDER BY {2} {3}                                                      " + Environment.NewLine +
                                "  ", pSQL, pWhereClauseFilter, pOrderByColumnIndex, pOrderByColumnDirection
                                )
                        );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSQL"></param>
        /// <param name="dTR"></param>
        /// <param name="pWhereClauseFilter"></param>
        /// <param name="OverrideOrderBy"></param>
        /// <param name="pSummarizeColumnNames"></param>
        /// <returns></returns>
        protected DataTableReturnFormat ProcessPaginate(String pSQL,
                                               DataTableRequestFields dTR,
                                               string pWhereClauseFilter = "",
                                               string? OverrideOrderBy = null,
                                               params string[] pSummarizeColumnNames
            )
        {
            var dtrf = ProcessPaginate(pSQL: pSQL, pWhereClauseFilter: pWhereClauseFilter,
                pStart: dTR.Start, pLength: dTR.Length,
                pOrderByColumn: dTR.SortUsingColumnName ? EStrings.ValueOf(dTR.OrderByColumnName) : (dTR.OrderByColumnIndex+1).ToString(),
                pOrderByColumnDirection: EStrings.ValueOf(dTR.OrderByColumnDirection),
                pSummarizeColumnNames: pSummarizeColumnNames, OverrideOrderBy: OverrideOrderBy
                );

            dtrf.draw = dTR.Draw;

            return dtrf;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPreSQL"></param>
        /// <param name="pSQL"></param>
        /// <param name="dTR"></param>
        /// <param name="pWhereClauseFilter"></param>
        /// <param name="pSummarizeColumnNames"></param>
        /// <returns></returns>
        protected DataTableReturnFormat ProcessPaginate(
            string pPreSQL,
            string pSQL,
                                            DataTableRequestFields dTR,
                                            string pWhereClauseFilter = "",
                                            params string[] pSummarizeColumnNames
         )
        {
            var dtrf = ProcessPaginate(pSQL: pSQL, pPreSQL: pPreSQL,
                pWhereClauseFilter: pWhereClauseFilter,
                pStart: dTR.Start, pLength: dTR.Length,
                pOrderByColumn: dTR.SortUsingColumnName ? EStrings.ValueOf(dTR.OrderByColumnName) : dTR.OrderByColumnIndex.ToString(),
                pOrderByColumnDirection: EStrings.ValueOf(dTR.OrderByColumnDirection),
                pSummarizeColumnNames: pSummarizeColumnNames
                );

            dtrf.draw = dTR.Draw;

            return dtrf;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSQL"></param>
        /// <param name="pWhereClauseFilter"></param>
        /// <param name="pPreSQL"></param>
        /// <param name="pStart"></param>
        /// <param name="pLength"></param>
        /// <param name="pOrderByColumn"></param>
        /// <param name="pOrderByColumnDirection"></param>
        /// <param name="OverrideOrderBy"></param>
        /// <param name="pSummarizeColumnNames"></param>
        /// <returns></returns>
        protected DataTableReturnFormat ProcessPaginate(string pSQL,
            string pWhereClauseFilter = "",
            string pPreSQL = "",
            int pStart = 0, int pLength = 20, string pOrderByColumn = "1", string pOrderByColumnDirection = "asc",
             string? OverrideOrderBy = null,
            params string[] pSummarizeColumnNames)
        {

            DataTable dCompleteTable = GetSQLTable(pSQL: pPreSQL + Environment.NewLine + pSQL);

            DataTable? dCompleteTableWithFilterSummary = null;

            if (pSummarizeColumnNames.Length > 0)
            {
                string columns = string.Join(", ", pSummarizeColumnNames.Select(x => string.Format("SUM({0}) as SUM_{0}", x)));
                dCompleteTableWithFilterSummary = GetSQLTable(pSQL:
               string.Format("     {3}       " + Environment.NewLine +
                                "     SELECT  {2}       " + Environment.NewLine +
                               "               FROM (                                                      " + Environment.NewLine +
                               "                       {0}                                                 " + Environment.NewLine +
                               "                     ) as rows_fetched                                     " + Environment.NewLine +
                               "               {1}                                                         " + Environment.NewLine,
                                           pSQL, pWhereClauseFilter, columns, pPreSQL
                               )
                       );
            }

            int pTotalCountWithoutPagination = 0;
            if (dCompleteTable != null) pTotalCountWithoutPagination = dCompleteTable.Rows.Count;

            DataTable paginated = Paginate(pStart: pStart, pLength: pLength, pSQL: pSQL, pPreSQL: pPreSQL,
                pOrderByColumn: pOrderByColumn, pOrderByColumnDirection: pOrderByColumnDirection,
                pWhereClauseFilter: pWhereClauseFilter, OverrideOrderBy: OverrideOrderBy
                );

            DataTableReturnFormat dtrf = new()
            {
                recordsFiltered = paginated.Rows.Count > 0 ? EInt.ValueOf(paginated.Rows[0]["filtered_record_count"]) : 0,
                recordsTotal = pTotalCountWithoutPagination,
                totalPagesSummary = dCompleteTableWithFilterSummary?.ToDictionary().First(),
                data = paginated.ToDictionary()
            };

            return dtrf;
        }



        #endregion


        //#region FileStorages

        //
        // Summary:
        //     Create a random file name for this session to temporary store file and delete
        //
        // Parameters:
        //   pExtWithDot:
        //     Just additional string to append
        //
        //   appendRandom:
        //     If you want to generate the randomString Part with it
        //
        //   randomStringLength:
        //     The length of the random string if needed
        public static string GetSessionTempFileName(string pExtWithDot = "")
        {
            string arg = AlphaNumericCodeGenerator.RandomString(8);
            return $"{arg}{pExtWithDot}".AppTempStore();
        }

        /// <summary>
        /// Help remove wrong characters from file name
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string GetArbitraryValidFileName(string filename)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                filename = filename.Replace(c, '_');
            }

            return filename;
        }

        public FileSystemCompatible CloudStore
        {
            get
            {
                return new MinioStorage(
                     EWebFrameworkCoreConfigurations.Minio.Endpoint,
                     EWebFrameworkCoreConfigurations.Minio.AccessKey,
                     EWebFrameworkCoreConfigurations.Minio.SecretKey,
                     MINIO_BUCKET,
                     EWebFrameworkCoreConfigurations.Minio.UseSsl
                     );
            }
        }

        /// <summary>
        /// // This may not be compatible with my app because the pacakge is written in .NET 4.6.2
        /// Get Resized Image
        /// </summary>
        /// <param name="Contents"></param>
        /// <param name="pResizeWidth"></param>
        /// <param name="pResizeHeight"></param>
        /// <returns></returns>
        public static byte[] GetResizedImage(byte[] Contents, uint pResizeWidth = 0, uint pResizeHeight = 0)
        {
            Console.WriteLine($"Parameters [ pResizeWidth: {pResizeWidth}, pResizeHeight: {pResizeHeight} ]are unused because Simple.ImageResizer 2.1.0 was not installed because of its version depends on .NETFramework instead of .NET Core ");
            return Contents;

            // Severity	Code	Description	Project	File	Line	Suppression State
            // Warning NU1701  Package 'Simple.ImageResizer 2.1.0' was restored using '.NETFramework,Version=v4.6.1, .NETFramework,Version=v4.6.2, .NETFramework,Version=v4.7, .NETFramework,Version=v4.7.1, .NETFramework,Version=v4.7.2, .NETFramework,Version=v4.8, .NETFramework,Version=v4.8.1' instead of the project target framework 'net6.0'.This package may not be fully compatible with your project


            //if (pResizeWidth != 0 || pResizeHeight != 0) return Contents;
            //using TemporaryFile tf = new();

            //File.WriteAllBytes(tf.FileFullPath, Contents);

            ////Resize
            ////
            //using (Simple.ImageResizer.ImageResizer resizer = new(Contents))
            //{
            //    resizer.Resize(width: (int)pResizeWidth, height: (int)pResizeHeight, encoding: Simple.ImageResizer.ImageEncoding.Jpg100);
            //    resizer.SaveToFile(tf.FileFullPath);
            //}

            //return File.ReadAllBytes(tf.FileFullPath);
        }

        public void StoreImageOnCloud(string destinationRelativePath, TemporaryFile pUploadedFile, uint pResizeWidth = 0, uint pResizeHeight = 0)
        {
            CloudStore.SaveFileContent(ObjectPath: destinationRelativePath, Contents: GetResizedImage(File.ReadAllBytes(pUploadedFile.FileFullPath), pResizeHeight: pResizeHeight, pResizeWidth: pResizeWidth));
        }

        public void StoreFileOnCloud(string destinationRelativePath, TemporaryFile pUploadedFile)
        {
            CloudStore.SaveFile(ObjectPath: destinationRelativePath, FileFullPath: pUploadedFile.FileFullPath);
        }

        /// <summary>
        /// Checks if the query returns any row. It just checks the count(), no record is fetched
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public bool DoesQueryExists(string SQL)
        {
            return GetSQLTable($"select count(*) as ExistCount from ({SQL}) as A")
                .AsEnumerable()
                .First().Field<int>("ExistCount") > 0;
        }

        /// <inheritdoc cref="BaseClientService.CreateTransactionRunner(bool, bool)"/>
        public TransactionRunner CTR(bool allowDispose = true, bool immediateDisposal = true) => CreateTransactionRunner(allowDispose, immediateDisposal);

        public string GenerateIdentificationNo(string TableName = "common.Person", string precede = "PE", int maxValue = 99999)
        {

            return GenerateUniqueColumnValue(TableName, "IdentificationNo", precede: precede, maxValue: maxValue);

        }

        public string GenerateUniqueColumnValue(string TableName = "academic.Student", string TargetColumn = "StudentNumber", string precede = "", int maxValue = 999)
        {
            //First create random short letters
            //pick anyone that is available in database
            // quicker because it is guaranteed one query
            StringBuilder stringBuilder = new(string.Format("SELECT '{0}{1}' as ID ", precede, EStrings.WrapUp(new Random(DateTime.Now.Millisecond).Next(maxValue).ToString(), maxValue.ToString().Length)));
            for (int i = 0; i < 50; i++)
                stringBuilder.AppendLine(string.Format("UNION ALL SELECT '{0}{1}'", precede, EStrings.WrapUp(new Random().Next(maxValue).ToString(), maxValue.ToString().Length)));


            string SQL =
"select                  " + Environment.NewLine +
"    G.ID                  " + Environment.NewLine +
"  from ({0}) as G                  " + Environment.NewLine +
"WHERE G.ID NOT IN (select DISTINCT {2}                  " + Environment.NewLine +
"                   from {1})                  " + Environment.NewLine +
"                  ";
            SQL = string.Format(SQL, stringBuilder.ToString(), TableName, TargetColumn);

            DataTable result = GetSQLTable(SQL);

            return (result != null && result.Rows.Count > 0) ? EStrings.ValueOf(result.Rows[0][0]) : string.Empty;
        }


    }
}