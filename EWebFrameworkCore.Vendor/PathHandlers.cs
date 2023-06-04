using CODERiT.Logger.Standard.VB;
using EWebFrameworkCore.Vendor.Utils;
using System;
using System.Linq;

namespace EWebFrameworkCore.Vendor
{
    /// <summary>
    /// Use for handling application paths
    /// </summary>
    public static class PathHandlers
    {

        ///// <summary>
        ///// It is created once as static in this class and it is used within this module
        ///// EWebFramework.Vendor
        ///// </summary>
        //public static Log1 Logger { get; private set; }

        //static PathHandlers()
        //{
        //    var logFile = StoragePath(string.Format("{0}__EPWebFrameworkCore.Vendor.log", DateTime.Now.ToString("yyyy_MM_dd")));

        //    Logger = new Log1(logFile, Log1.Modes.FILE, false);
        //}



        /// <summary>
        /// Used to create instance of a class specified as string to Object
        /// </summary>
        /// <param name="strFullyQualifiedName">like EWebFramework.Vendor.PathHandlers</param>
        /// <returns></returns>
        public static object? GetInstance(this string strFullyQualifiedName)
        {
            Type? type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }


        /// <summary>
        /// Refers to the App Running Directory
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string RootPath(this string pPath)
        {
            return AppDomain.CurrentDomain.BaseDirectory + "/" + pPath;
        }


        /// <summary>
        /// Refers to App_Resources folder. Use to store files that are not publicly accessible. Like templates during and so on.
        /// These files are added during development.
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string ResourcesPath(this string pPath)
        {
            return AppDomain.CurrentDomain.BaseDirectory + "/App_Resources/" + pPath;
        }


        /// <summary>
        /// Refers to wwwroot folder. Use to store files that are publicly accessible. 
        /// These files are added during development.
        /// 
        /// Returns path /wwwroot/{Path Specified}
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string PublicPath(this string pPath)
        {
            return AppDomain.CurrentDomain.BaseDirectory + "/wwwroot/" + pPath;
        }

        /// <summary>
        /// Returns path /Storage/{Path Specified}
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string StoragePath(this string pPath)
        {
            // if(Logger != null) Logger.Print(pPath);
            return AppDomain.CurrentDomain.BaseDirectory + "/Storage/" + pPath;
            //return HttpContext.Current.Server.MapPath("~/App_Data/" + pPath);
        }

        /// <summary>
        /// Returns path /Storage/App/{Path Specified}
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string AppFileStore(this string pPath)
        {
            return StoragePath( "/App/" + pPath );
        }


        /// <summary>
        /// Returns path /Storage/Logs/{Path Specified}
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string AppLogStore(this string pPath)
        {
            return StoragePath("/Logs/" + pPath);
        }

        /// <summary>
        /// Highly volatile folder
        /// Returns path /Storage/Temp/{Path Specified}
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string AppTempStore(this string pPath)
        {
            return StoragePath("/Temp/" + pPath);
        }


        /// <summary>
        /// Create a random file name for this session to temporary store file and delete
        /// </summary>
        /// <param name="pExtWithDot">Just additional string to append</param>
        /// <param name="appendRandom">If you want to generate the randomString Part with it</param>
        /// <param name="randomStringLength">The length of the random string if needed</param>
        /// <returns></returns>
        public static string GetRandomTempFileName(string pExtWithDot = "", bool appendRandom = true, uint randomStringLength = 6)
        {
            string s = appendRandom ? AlphaNumericCodeGenerator.RandomString((int)randomStringLength) : string.Empty;
            return String.Format(@"{0}_{1}{2}", AlphaNumericCodeGenerator.RandomString(16), s, pExtWithDot).AppTempStore();
        }
    }
}
