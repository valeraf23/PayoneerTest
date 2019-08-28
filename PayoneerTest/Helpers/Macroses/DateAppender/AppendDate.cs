using System;

namespace PayoneerTest.Helpers.Macroses.DateAppender
{
    public static class AppendDate
    {
        /// <summary>
        /// Adds/subtract value to the <paramref name="date"/> date
        /// </summary>
        /// <param name="date">DateTime object operated with</param>
        /// <param name="type">Enum value defining minute/hour/day/month/year to be appended to</param>
        /// <param name="value">Value to be appended</param>
        /// <returns>Updated DateTime object</returns>
        public static DateTime AddValue(this DateTime date, DateAppender type, string value)
        {
            switch (type)
            {
                case DateAppender.Minute:
                    date = date.AddMinutes(short.Parse(value));
                    break;
                case DateAppender.Hour:
                    date = date.AddHours(short.Parse(value));
                    break;
                case DateAppender.Day:
                    date = date.AddDays(short.Parse(value));
                    break;
                case DateAppender.Month:
                    date = date.AddMonths(short.Parse(value));
                    break;
                case DateAppender.Year:
                    date = date.AddYears(short.Parse(value));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return date;
        }
    }
}
