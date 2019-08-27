using System.Reflection;

namespace PayoneerTest.Helpers.GenerationAttributes.Strategies
{
    internal interface IGenerationStrategy
    {
        bool IsValid(PropertyInfo property);
        string GetValue(PropertyInfo property);
    }
}