using EEntityCore.DB.Abstracts;
using EEntityCore.DB.MSSQL;
using ELibrary.Standard.VB.Objects;
using EWebFrameworkCore.Vendor.Configurations;
using EWebFrameworkCore.Vendor.Requests;
using EWebFrameworkCore.Vendor.Services.DataTablesNET;
using EWebFrameworkCore.Vendor.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Core;
using System.Data;

namespace EWebFrameworkCore.Vendor.Services
{
    /// <summary>
    /// Extend for Client Service
    /// </summary>
    public class BaseClientService
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

        protected MSSQLConnectionOption ConnectionOption;

        public IServiceProvider Provider { get; }
        public HttpContext HttpContext { get; }
        public IConfiguration Configurations { get; private set; }

        public readonly ConfigurationOptions EWebFrameworkCoreConfigurations;

        protected readonly RequestHelper RequestInputs;
        public Logger Log { get; }
        public DatabaseTimeZoneUtilsExtensions.DatabaseTimeZoneUtils DBTimeZoneUtils { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionOption"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public BaseClientService(IServiceProvider provider, MSSQLConnectionOption connectionOption)
        {
            this.Provider = provider;
            RequestInputs = provider.GetRequestHelper();

            HttpContext = provider.GetHttpContext();

            this.Configurations = provider.GetConfigurations();

            this.EWebFrameworkCoreConfigurations = Provider.GetEWebFrameworkCoreOptions();
            this.Log = HttpContext.Logger();

            this.DBTimeZoneUtils = new DatabaseTimeZoneUtilsExtensions.DatabaseTimeZoneUtils(EWebFrameworkCoreConfigurations.GENERAL.DATABASE_TIMEZONE);

            this.ConnectionOption = connectionOption;
        }

        public BaseClientService(IServiceProvider provider) : this(provider, new MSSQLConnectionOption())
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
        public virtual System.Data.DataTable GetSQLTable(String pSQL, bool AddressApostrophe = false)
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
                pOrderByColumn: dTR.SortUsingColumnName ? dTR.OrderByColumnName : (dTR.OrderByColumnIndex+1).ToString(),
                pOrderByColumnDirection: dTR.OrderByColumnDirection,
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
                pOrderByColumn: dTR.SortUsingColumnName ? dTR.OrderByColumnName : dTR.OrderByColumnIndex.ToString(),
                pOrderByColumnDirection: dTR.OrderByColumnDirection,
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


        ///// <summary>
        ///// Get Resized Image
        ///// </summary>
        ///// <param name="Contents"></param>
        ///// <param name="pResizeWidth"></param>
        ///// <param name="pResizeHeight"></param>
        ///// <returns></returns>
        //public byte[] GetResizedImage(byte[] Contents, uint pResizeWidth = 0, uint pResizeHeight = 0)
        //{
        //    using (TemporaryFile tf = new TemporaryFile(".jpg"))
        //    {

        //        File.WriteAllBytes(tf.FileFullPath, Contents);


        //        //Resize
        //        //
        //        if (pResizeWidth != 0 && pResizeHeight != 0)
        //        {
        //            using (Simple.ImageResizer.ImageResizer resizer = new Simple.ImageResizer.ImageResizer(Contents))
        //            {
        //                resizer.Resize(width: (int)pResizeWidth, height: (int)pResizeHeight, encoding: Simple.ImageResizer.ImageEncoding.Jpg100);
        //                resizer.SaveToFile(tf.FileFullPath);
        //            }
        //        }


        //        return File.ReadAllBytes(tf.FileFullPath);
        //    }

        //}


        ///// <summary>
        ///// Get Resized Image
        ///// </summary>
        ///// <param name="Contents"></param>
        ///// <param name="pResizeWidth"></param>
        ///// <param name="pResizeHeight"></param>
        ///// <returns></returns>
        //public byte[] GetResizedImage(Stream Contents, uint pResizeWidth = 0, uint pResizeHeight = 0)
        //{

        //    Contents.Seek(0, System.IO.SeekOrigin.Begin);
        //    // Read it without closing the stream. Because once the stream is closed, it is gone.
        //    // 
        //    return GetResizedImage(new BinaryReader(Contents, Encoding.UTF8, leaveOpen: true).ReadBytes((int)Contents.Length), pResizeWidth, pResizeHeight);

        //}



        ///// <summary>
        ///// Store image in directory given
        ///// </summary>
        ///// <param name="pDstFileFullPath"></param>
        ///// <param name="pUploadedFile"></param>
        ///// <param name="pResizeWidth"></param>
        ///// <param name="pResizeHeight"></param>
        ///// <returns></returns>
        //public bool StoreImage(String pDstFileFullPath, HttpPostedFile pUploadedFile, uint pResizeWidth = 0, uint pResizeHeight = 0)
        //{
        //    try
        //    {

        //        if (!Directory.Exists(EIO.getDirectoryFullPath(pDstFileFullPath))) EIO.DeleteAndRecreateDirectory(EIO.getDirectoryFullPath(pDstFileFullPath));

        //        File.WriteAllBytes(pDstFileFullPath, this.GetResizedImage(pUploadedFile.InputStream, pResizeHeight: pResizeHeight, pResizeWidth: pResizeWidth));



        //        //using (TemporaryFile tf = new TemporaryFile(".jpg"))
        //        //{

        //        //    pUploadedFile.SaveAs(tf.FileFullPath);


        //        //    //Resize
        //        //    //
        //        //    if (pResizeWidth != 0 && pResizeHeight != 0)
        //        //    {
        //        //        using (Simple.ImageResizer.ImageResizer resizer = new Simple.ImageResizer.ImageResizer(tf.FileFullPath ))
        //        //        {
        //        //            resizer.Resize(width: (int)pResizeWidth, height: (int)pResizeHeight, encoding: Simple.ImageResizer.ImageEncoding.Jpg100);
        //        //            resizer.SaveToFile(pDstFileFullPath);

        //        //        }
        //        //    }
        //        //    else
        //        //    {
        //        //        // Just save the original file as it is
        //        //        EIO.CopyFile(tf.FileFullPath , pDstFileFullPath);
        //        //    }

        //        //}

        //            //// Create destination Path if it doesn't exist
        //            //if (!System.IO.Directory.Exists(EIO.getDirectoryFullPath(pDstFileFullPath))) EIO.DeleteAndRecreateDirectory(EIO.getDirectoryFullPath(pDstFileFullPath));

        //        //// 
        //        //// Save File in Temp Location
        //        //// Use it and delete it
        //        ////
        //        //var pDstTemp = GetSessionTempFileName(".jpg");
        //        //if (!System.IO.Directory.Exists(EIO.getDirectoryFullPath(pDstTemp))) EIO.DeleteAndRecreateDirectory(EIO.getDirectoryFullPath(pDstTemp));
        //        //pUploadedFile.SaveAs(pDstTemp);

        //        ////Resize
        //        ////
        //        //if (pResizeWidth != 0 && pResizeHeight != 0)
        //        //{
        //        //    using (Simple.ImageResizer.ImageResizer resizer = new Simple.ImageResizer.ImageResizer(pDstTemp))
        //        //    {
        //        //        resizer.Resize(width: (int)pResizeWidth, height: (int)pResizeHeight, encoding: Simple.ImageResizer.ImageEncoding.Jpg100);
        //        //        resizer.SaveToFile(pDstFileFullPath);

        //        //    }
        //        //}
        //        //else
        //        //{
        //        //    // Just save the original file as it is
        //        //    EIO.CopyFile(pDstTemp, pDstFileFullPath);
        //        //}


        //        ////Clean Up
        //        //// delete the temp file
        //        //EIO.DeleteFileIfExists(pDstTemp);


        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        PathHandlers.Logger.Print(ex);
        //        return false;
        //    }

        //}


        ///// <summary>
        ///// Store file in directory given
        ///// </summary>
        ///// <param name="pDstFileFullPath"></param>
        ///// <param name="pUploadedFile"></param>
        ///// <returns></returns>
        //public bool StoreFile(String pDstFileFullPath, HttpPostedFile pUploadedFile)
        //{
        //    try
        //    {

        //        // Create destination Path if it doesn't exist
        //        if (!System.IO.Directory.Exists(EIO.getDirectoryFullPath(pDstFileFullPath))) EIO.DeleteAndRecreateDirectory(EIO.getDirectoryFullPath(pDstFileFullPath));

        //        // 
        //        // Save File in Location
        //        //
        //        pUploadedFile.SaveAs(pDstFileFullPath);


        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        PathHandlers.Logger.Print(ex);
        //        return false;
        //    }

        //}


        //#endregion









    }
}