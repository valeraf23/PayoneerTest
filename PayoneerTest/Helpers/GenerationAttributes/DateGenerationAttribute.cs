namespace PayoneerTest.Helpers.GenerationAttributes
{
    public class DateGenerationAttribute : GenerationAttribute
    {
        public string Pattern;
        public DateGenerationAttribute()
        {
            Pattern = "MM/dd/yyyy";
        }
        public DateGenerationAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}