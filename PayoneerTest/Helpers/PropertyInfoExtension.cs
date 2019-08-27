using System;
using System.Linq;
using System.Reflection;
using PayoneerTest.Helpers.GenerationAttributes;

namespace PayoneerTest.Helpers
{
    public static class PropertyInfoExtension
    {
        public static bool HasGeneratorAttribute(this PropertyInfo propertyInfo)
        {
            var attributes = propertyInfo.CustomAttributes;
            return attributes.Any(attribute => attribute.AttributeType == typeof(GenerationAttribute));
        }

        public static bool HasNumberGeneratorAttribute(this PropertyInfo propertyInfo)
        {
            var attributes = propertyInfo.CustomAttributes;
            return attributes.Any(attribute => attribute.AttributeType == typeof(GenerationNumberAttribute));
        }

        public static bool HasEmailGeneratorAttribute(this PropertyInfo propertyInfo)
        {
            var attributes = propertyInfo.CustomAttributes;
            return attributes.Any(attribute => attribute.AttributeType == typeof(EmailGenerationAttribute));
        }

        public static bool HasDateGeneratorAttribute(this PropertyInfo propertyInfo)
        {
            var attributes = propertyInfo.CustomAttributes;
            return attributes.Any(attribute => attribute.AttributeType == typeof(DateGenerationAttribute));
        }

        public static int GetLength(this PropertyInfo propertyInfo)
        {
            var findByAttribute =
                (GenerationAttribute) Attribute.GetCustomAttribute(propertyInfo, typeof(GenerationAttribute));
            return findByAttribute.Length;
        }

        public static string GetDatePattern(this PropertyInfo propertyInfo)
        {
            var findByAttribute =
                (DateGenerationAttribute) Attribute.GetCustomAttribute(propertyInfo, typeof(DateGenerationAttribute));
            return findByAttribute.Pattern;
        }
    }
}