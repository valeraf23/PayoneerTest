using PayoneerTest.Elements;
using VF.Serenity.AutomationFramework.Controls;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;

namespace PayoneerTest.Pages
{
    public class BeginRegistrationPage : RegistrationPageBase
    {
        [FindBy(How.Id, "tbPassword")]
        public TextBox Password { get; set; }


        [FindBy(How.Id, "tbRetypePassword")]
        public TextBox RetypePassword { get; set; }

        [FindBy(How.Id, "ddlSecurityQuestions")]
        public Combobox SecurityQuestions { get; set; }


        [FindBy(How.Id, "tbSecurityAnswer")]
        public TextBox SecurityAnswer { get; set; }

        [FindBy(How.Id, "txtCollectCompanyRegistrationNumber")]
        public TextBox CompanyRegistrationNumber { get; set; }

        [FindBy(How.Id, "txtAccountDetailsCaptcha")]
        public TextBox LAccountDetailsCaptcha { get; set; }
    }
}