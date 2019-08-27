using PayoneerTest.Elements;
using VF.Serenity.AutomationFramework.Controls;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;

namespace PayoneerTest.Pages
{
    public class ContactDataPage : RegistrationPageBase
    {
        [FindBy(How.Id, "txtAddress3")]
        public TextBox Address { get; set; }

        [FindBy(How.Id, "txtCity")]
        public TextBox City { get; set; }

        [FindBy(How.Id, "txtZip")]
        public TextBox Zip { get; set; }

        [FindBy(How.Id, "ContactPersonPhoneNumber")]
        public ContactPersonPhoneNumberElement ContactPersonPhoneNumber { get; set; }
    }
}