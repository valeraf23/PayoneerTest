using OpenQA.Selenium;
using PayoneerTest.Elements;
using VF.Serenity.AutomationFramework.Controls;
using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Element;
using VF.Serenity.AutomationFramework.Infrastructure.Driver;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;
using DriverService = VF.Serenity.AutomationFramework.Infrastructure.Driver.DriverService;

namespace PayoneerTest.Pages
{
    [Url("/")]
    public class DetailsSecurityPage : RegistrationPageBase
    {
        [FindBy(How.Id, "accountType")]
        public RadioButtonPanel AccountType { get; set; }

        [FindBy(How.Id, "txtCompanyName")]
        public TextBox CompanyName { get; set; }

        [FindBy(How.Id, "ddlBusinessOrganization")]
        public Combobox BusinessOrganization { get; set; }


        [FindBy(How.Id, "txtContactPersonFirstName")]
        public TextBox FirstName { get; set; }

        [FindBy(How.Id, "txtContactPersonLastName")]
        public TextBox LastName { get; set; }

        [FindBy(How.Id, "txtEmail")]
        public TextBox Email { get; set; }

        [FindBy(How.Id, "txtRetypeEmail")]
        public TextBox ConfirmEmail { get; set; }

        [FindBy(How.Id, "datepicker")]
        public DateTimePicker Birthday { get; set; }
    }

    public class DateTimePicker : HtmlElement
    {
        public void SetValue(string value)
        {
            DriverService.Driver.CastTo<IJSExecutor>().ExecuteScript($"jQuery(arguments[0]).val('{value}')",NativeElement);
        }
    }
}