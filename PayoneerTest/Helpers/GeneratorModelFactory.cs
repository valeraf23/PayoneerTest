using System;
using System.Linq;
using System.Reflection;
using PayoneerTest.Helpers.GenerationAttributes.Strategies;
using PayoneerTest.Models;

namespace PayoneerTest.Helpers
{
    public static class GeneratorModelFactory
    {
        public static CompanyUserModel GetCompanyUserModel(Action<CompanyUserModel> func)
        {
            var model = Get<CompanyUserModel>();
            func(model);
            Get(model);
            return model;
        }

        public static CompanyUserModel GetCompanyUserModel()
        {
            var model = Get<CompanyUserModel>();
            return model;
        }

        private static T Get<T>(T model) where T : class, new()
        {
            Init(model);
            return model;
        }

        public static T Get<T>() where T : class, new()
        {
            var model = new T();
            return Get(model);
        }

        private static void Init<T>(T model)
        {
            var properties = model.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var property in properties)
            {
                var valueByDefault = property.GetValue(model);
                if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                {
                    ForClasses(valueByDefault, property, model);
                }
                else
                {
                    ForPrimitive(valueByDefault, property, model);
                }
            }

        }

        private static void ForClasses<T>(object valueByDefault, PropertyInfo property, T model)
        {
            if (valueByDefault == null)
            {
                valueByDefault = Activator.CreateInstance(property.PropertyType);
            }

            Get(valueByDefault);
            property.SetValue(model, valueByDefault);
        }

        private static void ForPrimitive<T>(object valueByDefault, PropertyInfo property, T model)
        {
            var text = new IGenerationStrategy[]
                {
                    new DateGenerationStrategy(),
                    new EmailGenerationStrategy(),
                    new NumberGenerationStrategy(),
                    new GenerationStrategy()

                }.FirstOrDefault(x => x.IsValid(property))
                ?.GetValue(property);

            text = ProcessMacros(valueByDefault?.ToString(), text);

            if (text != null)
            {
                property.SetValue(model, text);
            }
        }

        private static string ProcessMacros(string valueByDefault, string text)
        {
            if (string.IsNullOrEmpty(text) && valueByDefault == null)
            {
                return text;
            }

            text = Macroses.Macros.Macros.Process(valueByDefault ?? text);

            return text;
        }
    }
}