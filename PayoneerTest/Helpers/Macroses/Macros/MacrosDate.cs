using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using PayoneerTest.Helpers.Macroses.Macros.DateAppender;

namespace PayoneerTest.Helpers.Macroses.Macros
{
    public class MacrosDate : IMacros
    {
        public string Process(string value)
        {
            // %%date%%
            value = value.Replace("%%date%%", DateTime.Now.ToString("g", CultureInfo.DefaultThreadCurrentCulture));
            value = value.Replace("%%today%%", DateTime.Now.ToString("g", CultureInfo.DefaultThreadCurrentCulture));
            // %%date+Xyears+Ymonths+Zdays+Nhours+Qminutes%%
            string datePattern = MacroDateAppender.GetPattern("dayCount");
            DateTime date = DateTime.Now;
            foreach (Match match in Regex.Matches(value, datePattern))
            {
                date = DateTime.Now.Update(
                    match.Groups["dayCount"].Captures
                        .Select(c => c.Value)
                        .ToArray());
            }

            return Regex.Replace(value, datePattern, date.ToString("g", CultureInfo.InvariantCulture));
        }
    }
}