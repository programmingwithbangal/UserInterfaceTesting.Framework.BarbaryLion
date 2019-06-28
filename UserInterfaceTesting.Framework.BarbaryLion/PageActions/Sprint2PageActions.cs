using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.Pages;

namespace UserInterfaceTesting.Framework.BarbaryLion.PageActions
{
    internal class Sprint2PageActions
    {
        internal Sprint2Page Sprint2Page { get; set; }

        internal Sprint2PageActions(ScenarioContext scenarioContext)
        {
            Sprint2Page = new Sprint2Page(scenarioContext);
        }

        internal void FillOutFormAndSubmitAlternate(User user)
        {
            Sprint2Page.FirstNameFieldAlternate.SendKeys(user.FirstName);
            Sprint2Page.LastNameFieldAlternate.SendKeys(user.LastName);
            Sprint2Page.SubmitButton.Submit();
        }
    }
}