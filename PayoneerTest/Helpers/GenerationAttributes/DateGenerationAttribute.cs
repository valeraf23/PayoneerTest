namespace PayoneerTest.Helpers.GenerationAttributes
{
    public class DateGenerationAttribute : GenerationAttribute
    {
        public string Pattern;
        public string Macros;

        public DateGenerationAttribute()
        {
            Pattern = "MM/dd/yyyy";
        }

        public DateGenerationAttribute(string pattern, string macros)
        {
            Macros = macros;
            Pattern = pattern;
        }

        public DateGenerationAttribute(string macros)
        {
            Macros = macros;
        }
    }
}