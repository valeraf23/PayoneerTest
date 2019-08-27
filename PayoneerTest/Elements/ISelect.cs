using VF.Serenity.AutomationFramework.Infrastructure.BaseTypes.Element;

namespace PayoneerTest.Elements
{
    public interface ISelect : IHtmlElement
    {
        void Select(string value);
        string GetSelected();
    }
}