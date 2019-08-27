using VF.Serenity.AutomationFramework.Controls;
using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Page;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;
using VF.Serenity.AutomationFramework.Infrastructure.Locators;

namespace PayoneerTest.Pages
{
  
    public class RegistrationPageBase : WebPage
    {

        [FindBy(How.Id, "PersonalDetailsButton")]
        public Button Next { get; set; }
    }
}
