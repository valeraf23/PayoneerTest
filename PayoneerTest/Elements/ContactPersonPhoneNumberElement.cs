using VF.Serenity.AutomationFramework.Controls;
using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Element;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;

namespace PayoneerTest.Elements
{
    public class ContactPersonPhoneNumberElement : HtmlElement
    {
        [FindBy(How.Id, "ContactPersonPhoneNumber_num")]
        public TextBox PhoneNumber { get; set; }

        [FindBy(How.Id, "ContactPersonPhoneNumber_iso2")]
        public Combobox Iso { get; set; }
    }
}