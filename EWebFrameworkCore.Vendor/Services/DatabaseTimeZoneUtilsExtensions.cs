using EWebFrameworkCore.Vendor.Utils.DateTimeHelper;

namespace EWebFrameworkCore.Vendor.Services
{
    public static class DatabaseTimeZoneUtilsExtensions
    {
        public class DatabaseTimeZoneUtils
        {

            /// <summary>
            /// This is the time zone of dates and Time received from Clients Input
            /// </summary>
            public readonly TimeZoneManager ClientTimeZone;
            /// <summary>
            /// This is the TimeZone of the Server This application is running On
            /// </summary>
            public readonly TimeZoneManager ServerTimeZone;

            /// <summary>
            /// This is the TimeZone Set to save Date Values
            /// </summary>
            public readonly TimeZoneManager DatabaseTimeZone;

            /// <summary>
            /// It uses UTC "+00:00" by default
            /// </summary>
            /// <param name="DATABASE_TIMEZONE"></param>
            public DatabaseTimeZoneUtils(string? DATABASE_TIMEZONE)
            {
                DatabaseTimeZone = new TimeZoneManager(DATABASE_TIMEZONE ?? "+00:00");

                // TODO: FIX Deprecation
                // https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo?view=net-6.0
                //
                ServerTimeZone = new TimeZoneManager(TimeZoneInfo.Local.GetUtcOffset(DateTime.Now).ToString());

                //SET this on request call
                // Make this same as database timezone
                // This is because there is no frontend or middleware conversion of time between
                // database and clientTimeZone
                // So, time in ClientTimeZone is save exactly like that to database
                //ClientTimeZone = new TimeZoneManager("+01:00");

                ClientTimeZone = DatabaseTimeZone;

                //var p = from v in request.Headers.AllKeys
                //        where v.ToLower() == "client-time-zone"
                //        select v;

                //if (p.Count()>0)
                //{
                //    ClientTimeZone = new TimeZoneManager(request.Headers[p.First()]);
                //}

            }

        }

        /// <summary>
        /// This converts from Client TimeZone to Database TimeZone.
        /// Please Note that this will throw exception if you didn't send the Client Time Zone in the request
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime FromClientTimeZone(this DateTime dateTime, DatabaseTimeZoneUtils utils)
        {
            if (utils.ClientTimeZone == null) throw new InvalidTimeZoneException("Please, set the ClientTimeZone in the HTTPRequestHeader!");
            return dateTime.ToTimezone(utils.ClientTimeZone, utils.DatabaseTimeZone);
        }

        /// <summary>
        /// Indicates you are converting from this current Servers Time to Database Set TimeZone
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime FromServerTimeZone(this DateTime dateTime, DatabaseTimeZoneUtils utils)
        {
            if (utils.ServerTimeZone == null) throw new InvalidOperationException("ServerTimeZone Null");
            if (utils.DatabaseTimeZone == null) throw new InvalidOperationException("DatabaseTimeZone Null");

            return dateTime.ToTimezone(utils.ServerTimeZone, utils.DatabaseTimeZone);
        }


        /// <summary>
        /// Indicate conversion from database set time zone to client timezone
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime ToClientTimeZone(this DateTime dateTime, DatabaseTimeZoneUtils utils)
        {
            if (utils.ClientTimeZone == null) throw new InvalidTimeZoneException("Please, set the ClientTimeZone in the HTTPRequestHeader!");
            return dateTime.ToTimezone(utils.DatabaseTimeZone, utils.ClientTimeZone);
        }


        /// <summary>
        /// Conversion from database saved date time to Server TimeZone
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime ToServerTimeZone(this DateTime dateTime, DatabaseTimeZoneUtils utils)
        {
            return dateTime.ToTimezone(utils.DatabaseTimeZone, utils.ServerTimeZone);
        }


    }

}