using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Pages;

namespace UserInterfaceTesting.Framework.BarbaryLion.PageActions
{
    internal class Sprint1PageActions
    {
        internal Sprint1Page Sprint1Page { get; set; }

        internal Sprint1PageActions(ScenarioContext scenarioContext)
        {
            Sprint1Page = new Sprint1Page(scenarioContext);
        }

        internal void FillOutFormAndSubmit(string firstname)
        {
            Sprint1Page.FirstNameField.SendKeys(firstname);
            Sprint1Page.SubmitButton.Submit();
        }
    }
}