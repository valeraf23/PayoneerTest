using PayoneerTest.Elements;
using VF.Serenity.AutomationFramework.Controls;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;

namespace PayoneerTest.Pages
{
    public class LastPage : RegistrationPageBase
    {
        [FindBy(How.Id, "role='combobox'")]
        public Combobox combobox { get; set; }
        [FindBy(How.Id, "iachfield2")]
        public TextBox iachfield2 { get; set; }
        [FindBy(How.Id, "iachfield3")]
        public TextBox Iachfield { get; set; }

        [FindBy(How.Id, "SignDocument_13_2")]
        public TextBox SignDocument { get; set; }
        [FindBy(How.Id, "SignDocument_7")]
        public TextBox SignDocument2 { get; set; }

    }
}