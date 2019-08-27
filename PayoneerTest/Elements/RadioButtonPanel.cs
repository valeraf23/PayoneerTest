using System.Linq;
using OpenQA.Selenium;
using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Element;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;

namespace PayoneerTest.Elements
{
    public class RadioButtonPanel : HtmlElement
    {

        public RadioButtonPanel SetValue(string value)
        {
            foreach (var element in FindAll<HtmlElement>(How.CssSelector, "label"))
            {
                var expectedValue = element.GetText();
                if (value != expectedValue) continue;
                if (element.GetAttribute("checked") != "true")
                {
                    element.Click();
                }

                return this;
            }

            throw new NotFoundException(value + " RadioButton was not found");
        }

        public string GetValue()
        {
            var checkedElement = FindAll<HtmlElement>(How.CssSelector, "input")
                .First(i => "true".Equals(i.GetAttribute("checked")));
            var checkedId = checkedElement.GetAttribute("id");
            var checkedLabel = checkedElement.Find<HtmlElement>(How.XPath,
                $"following-sibling::label[@for='{checkedId}']");
            return checkedLabel.GetText();
        }
    }
}