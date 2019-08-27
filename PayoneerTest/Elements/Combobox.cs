using OpenQA.Selenium.Support.UI;
using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Element;

namespace PayoneerTest.Elements
{
    public class Combobox : HtmlElement, ISelect
    {
        public void Select(string value)
        {
            var selectElement = new SelectElement(NativeElement);
            selectElement.SelectByText(value);
        }

        public string GetSelected()
        {
            var selectElement = new SelectElement(NativeElement);
            return selectElement.SelectedOption.Text;
        }
    }
}