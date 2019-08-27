using System.Reflection;
using VF.Serenity.AutomationFramework.Extensions.StringExtensions;

namespace PayoneerTest.Helpers.GenerationAttributes.Strategies
{
    internal class NumberGenerationStrategy : IGenerationStrategy
    {
        public bool IsValid(PropertyInfo property) => property.HasNumberGeneratorAttribute();

        public string GetValue(PropertyInfo property) =>
            StringExtensions.GenerateString(property.GetLength(), "0123456789");
    }
}