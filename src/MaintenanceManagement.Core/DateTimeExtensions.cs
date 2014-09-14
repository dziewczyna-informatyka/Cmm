namespace MaintenanceManagement.Core
{
    using System;
    using System.Globalization;

    public static class DateTimeExtensions
    {
        public static string ToCmmDate(this DateTime dateTime)
        {
            return (dateTime as DateTime?).ToCmmDate();
        }

        public static string ToCmmDate(this DateTime? dateTime)
        {
            return dateTime == null ? string.Empty : dateTime.Value.ToString("dd-MM-yyyy");
        }

        public static DateTime? ParseDateTime(this string s)
        {
            DateTime v;
            return string.IsNullOrWhiteSpace(s)
                       ? null
                       : DateTime.TryParseExact(
                           s,
                           "dd-MM-yyyy",
                           CultureInfo.InvariantCulture,
                           DateTimeStyles.None,
                           out v)
                             ? v as DateTime?
                             : null;
        }
    }
}