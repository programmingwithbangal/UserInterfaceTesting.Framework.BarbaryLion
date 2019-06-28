using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Constants;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.PageActions;

namespace RestApiTesting.Framework.Cheetah.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Sprint1Steps")]
    public sealed class Sprint1Steps : Steps
    {
        private readonly Sprint1PageActions m_sprint1PageActions;

        public Sprint1Steps(ScenarioContext scenarioContext)
        {
            m_sprint1PageActions = new Sprint1PageActions(scenarioContext);
        }

        [Given(@"I go to the sample application page")]
        public void GivenIGoToSprint1SampleApplicationPage()
        {
            PageHelper.GotoSampleApplicationPage(m_sprint1PageActions.Sprint1Page, PageConstants.Sprint1Url, PageConstants.Sprint1Title);
        }

        [When(@"I fill out the form and submit it")]
        public void WhenIFillOutTheFormAndSubmitIt()
        {
            m_sprint1PageActions.FillOutFormAndSubmit(UserConstants.DefaultFirstName);
        }

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            PageHelper.ValidatePageTitle(m_sprint1PageActions.Sprint1Page, PageConstants.UltimateQaHomePageTitle);
        }
    }
}