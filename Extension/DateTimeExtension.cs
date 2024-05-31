namespace Demo.Extension
{
    public static class DateTimeExtension
    {
        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }

        public static bool IsAfterDay(this DateTime dateTime1, DateTime dateTime2)
        {
            return (new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day, 0, 0, 0, 0, dateTime1.Kind) > (new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day, 0, 0, 0, 0, dateTime2.Kind)));
        }

        public static int CompareDateWithoutMilliseconds(this DateTime dateTime1, DateTime dateTime2)
        {
            var _dateTime1 = ChangeTime(dateTime1, dateTime1.Hour, dateTime1.Minute, dateTime1.Second, 0);
            var _dateTime2 = ChangeTime(dateTime2, dateTime2.Hour, dateTime2.Minute, dateTime2.Second, 0);
            return DateTime.Compare(_dateTime1, _dateTime2);
        }
    }
}
