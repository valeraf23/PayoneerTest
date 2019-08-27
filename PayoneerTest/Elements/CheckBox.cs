using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Element;

namespace PayoneerTest.Elements
{
    public class CheckBox : HtmlElement
    {
        public void Check()
        {
            if (!Checked)
                Click();
        }

        public void Uncheck()
        {
            if (Checked)
                Click();
        }

        public bool Checked => bool.Parse(GetAttribute("checked"));
    }
}