using VF.Serenity.AutomationFramework.Extensions.StringExtensions;

namespace PayoneerTest.Helpers.Macroses
{
    public class MacrosString : IMacros
    {
        public string Process(string value)
        {
            var res = value.Replace("%%default%%", StringExtensions.GenerateString(7));
            return res;
        }
    }
}