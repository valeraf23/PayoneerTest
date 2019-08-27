using System.Reflection;
using VF.Serenity.AutomationFramework.Extensions.StringExtensions;

namespace PayoneerTest.Helpers.GenerationAttributes.Strategies
{
    internal class GenerationStrategy : IGenerationStrategy
    {
        public bool IsValid(PropertyInfo property) => property.HasGeneratorAttribute();
        public string GetValue(PropertyInfo property) => StringExtensions.GenerateString(property.GetLength());
    }
}