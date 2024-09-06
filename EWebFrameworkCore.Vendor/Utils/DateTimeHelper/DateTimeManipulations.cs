using System.Globalization;

namespace EWebFrameworkCore.Vendor.Utils.DateTimeHelper
{
    public static class DateTimeManipulations
    {
        public static int WeekDiff(this DateTime d1, DateTime d2, DayOfWeek startOfWeek = DayOfWeek.Sunday)
        {
            var diff = d2.Subtract(d1);

            var weeks = (int)diff.Days / 7;

            // need to check if there's an extra week to count
            var remainingDays = diff.Days % 7;
            var cal = CultureInfo.InvariantCulture.Calendar;
            var d1WeekNo = cal.GetWeekOfYear(d1, CalendarWeekRule.FirstFullWeek, startOfWeek);
            var d1PlusRemainingWeekNo = cal.GetWeekOfYear(d1.AddDays(remainingDays), CalendarWeekRule.FirstFullWeek, startOfWeek);

            if (d1WeekNo != d1PlusRemainingWeekNo)
                weeks++;

            return weeks;
        }

        public static DateTime GetDayOfWeekFromPointerDate(this DateTime pointerDate, DayOfWeek desiredDay, DayOfWeek weekStartDay = DayOfWeek.Sunday)
        {
            // Calculate the difference between the week start day and the pointer date's day of the week
            int diff = (int)pointerDate.DayOfWeek - (int)weekStartDay;
            if (diff < 0)
            {
                diff += 7;
            }

            // Get the start of the week
            DateTime startOfWeek = pointerDate.AddDays(-diff);

            // Calculate the desired day of the week
            int desiredDiff = (int)desiredDay - (int)weekStartDay;
            if (desiredDiff < 0)
            {
                desiredDiff += 7;
            }

            DateTime desiredDate = startOfWeek.AddDays(desiredDiff);

            return desiredDate;
        }

        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
