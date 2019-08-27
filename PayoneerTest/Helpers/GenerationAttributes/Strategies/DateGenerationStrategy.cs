using System;
using System.Reflection;

namespace PayoneerTest.Helpers.GenerationAttributes.Strategies
{
    internal class DateGenerationStrategy : IGenerationStrategy
    {
        public bool IsValid(PropertyInfo property) => property.HasDateGeneratorAttribute();

        public string GetValue(PropertyInfo property) =>
            DateTime.Today.AddYears(-25).ToString(property.GetDatePattern());
    }
}