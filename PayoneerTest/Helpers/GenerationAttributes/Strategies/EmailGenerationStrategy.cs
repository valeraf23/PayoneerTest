using System.Reflection;
using VF.Serenity.AutomationFramework.Extensions.StringExtensions;

namespace PayoneerTest.Helpers.GenerationAttributes.Strategies
{
    internal class EmailGenerationStrategy : IGenerationStrategy
    {
        public bool IsValid(PropertyInfo property) => property.HasEmailGeneratorAttribute();

        public string GetValue(PropertyInfo property) => $"Name_{StringExtensions.GenerateString(4)}@lang.com";
    }
}