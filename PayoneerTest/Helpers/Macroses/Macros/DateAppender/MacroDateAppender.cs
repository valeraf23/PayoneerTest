using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PayoneerTest.Helpers.Macroses.Macros.DateAppender
{
    public static class MacroDateAppender
    {
        public static DateTime Update(this DateTime date, string[] values) => values.Aggregate(date, UpdateDate);

        // Following regular expression gathers into the named 'dayCount' group all the matches for the following conditions:
        // + or - sign, at least one number and 'minte/minutes' or hour/hours or 'day/days' or 'moth/months' or 'year/years'
        /// <summary>
        /// Returns formed RegEx pattern based on DateAppenderEnum object
        /// </summary>
        /// <param name="groupName">Named group vale</param>
        /// <returns>RegEx string pattern based on DateAppenderEnum object</returns>
        public static string GetPattern(string groupName) => $@"%%(date|today)(?<{groupName}>[+||-]\d+({
                string.Join("||",
                    Enum.GetNames(typeof(DateAppender)).Select(en => $"{en.ToLower()}(s)?").ToArray())
            }))*%%";

        private static DateTime UpdateDate(DateTime currentDate, string updatePattern)
        {
            const string pattern = @"(?<diffVal>[+||-]\d+)(?<diffArea>(\w+))";
            var match = Regex.Matches(updatePattern, pattern)[0];
            var value = match.Groups["diffArea"].Value;
            if (value.EndsWith("s")) value = value.Remove(value.Length - 1);
            return currentDate.AddValue((DateAppender) Enum.Parse(typeof(DateAppender), value, true),
                match.Groups["diffVal"].Value);
        }
    }

}
