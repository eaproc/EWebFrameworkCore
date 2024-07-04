using System.Globalization;

namespace EWebFrameworkCore.Vendor.Utils
{
    public static class DateOutputExtension
    {
        public static string ToGridDateString(this DateTime date) {
            return date.ToString("dd-MM-yyyy");
        }

        public static string ToServerDateString(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static string To24HrTimeString(this DateTime date)
        {
            return date.ToString("HH:mm");
        }
    }
}
