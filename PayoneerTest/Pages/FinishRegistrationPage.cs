using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Element;
using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Page;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;

namespace PayoneerTest.Pages
{
    public class FinishRegistrationPage : WebPage
    {
        [FindBy(How.CssSelector,"")]
        public HtmlElement SuccessNotification { get; set; }
    }
}