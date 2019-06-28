using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Constants;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.PageActions;

namespace RestApiTesting.Framework.Cheetah.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Sprint2Steps")]
    public sealed class Sprint2Steps : Steps
    {
        private readonly Sprint2PageActions m_sprint2PageActions;

        public Sprint2Steps(ScenarioContext scenarioContext)
        {
            m_sprint2PageActions = new Sprint2PageActions(scenarioContext);
        }

        [Given(@"I go to the sample application page")]
        public void GivenIGoToSprint1SampleApplicationPage()
        {
            PageHelper.GotoSampleApplicationPage(m_sprint2PageActions.Sprint2Page, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
        }

        [When(@"I fill out the form and submit it")]
        public void WhenIFillOutTheFormAndSubmitIt()
        {
            m_sprint2PageActions.FillOutFormAndSubmitAlternate(Settings.DefaultUser);
        }

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            PageHelper.ValidatePageTitle(m_sprint2PageActions.Sprint2Page, PageConstants.UltimateQaHomePageTitle);
        }
    }
}