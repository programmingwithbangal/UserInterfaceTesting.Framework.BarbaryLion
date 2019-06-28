using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Constants;
using UserInterfaceTesting.Framework.BarbaryLion.Enums;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.PageActions;

namespace RestApiTesting.Framework.Cheetah.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Sprint3Steps")]
    public sealed class Sprint3Steps : Steps
    {
        private readonly Sprint3PageActions m_sprint3PageActions;

        public Sprint3Steps(ScenarioContext scenarioContext)
        {
            m_sprint3PageActions = new Sprint3PageActions(scenarioContext);
        }

        [Given(@"I go to the sample application page")]
        public void GivenIGoToSprint1SampleApplicationPage()
        {
            PageHelper.GotoSampleApplicationPage(m_sprint3PageActions.Sprint3Page, PageConstants.Sprint3Url, PageConstants.Sprint3Title);
        }

        [When(@"I fill out the form and submit it")]
        public void WhenIFillOutTheFormAndSubmitIt()
        {
            Settings.DefaultUser.GenderType = Gender.Female;
            m_sprint3PageActions.FillOutFormWithRadioButtonAndSubmit(Settings.DefaultUser);
        }

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            PageHelper.ValidatePageTitle(m_sprint3PageActions.Sprint3Page, PageConstants.UltimateQaHomePageTitle);
        }
    }
}