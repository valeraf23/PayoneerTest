using System;
using System.Linq;
using System.Reflection;
using PayoneerTest.Helpers.GenerationAttributes.Strategies;
using PayoneerTest.Models;

namespace PayoneerTest.Helpers
{
    public static class GeneratorModelFactory
    {
        public static CompanyUserModel GetCompanyUserModel()
        {
            var model = new CompanyUserModel();
            model = Get(model);
            model.DetailsSecurityInfo.BusinessOrganization = "Private Corporation";
            model.ContactDataInfo.City = "New York";
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
                var text = new IGenerationStrategy[]
                    {
                        new DateGenerationStrategy(),
                        new EmailGenerationStrategy(),
                        new NumberGenerationStrategy(),
                        new GenerationStrategy()
                    }.FirstOrDefault(x => x.IsValid(property))
                    ?.GetValue(property);

                property.SetValue(model, text);

                if (!property.PropertyType.IsClass || property.PropertyType == typeof(string)) continue;
                var inst = Activator.CreateInstance(property.PropertyType);
                Get(inst);
                property.SetValue(model, inst);

            }
        }

    }
}