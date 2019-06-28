using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Constants;
using UserInterfaceTesting.Framework.BarbaryLion.Enums;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.PageActions;
using UserInterfaceTesting.Framework.Lion.Tests;

namespace RestApiTesting.Framework.Cheetah.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Sprint4Steps")]
    public sealed class Sprint4Steps : Steps
    {
        private readonly Sprint4PageActions m_sprint4PageActions;

        public Sprint4Steps(ScenarioContext scenarioContext)
        {
            m_sprint4PageActions = new Sprint4PageActions(scenarioContext);
        }

        [Given(@"I go to the sample application page")]
        public void GivenIGoToSprint1SampleApplicationPage()
        {
            PageHelper.GotoSampleApplicationPage(m_sprint4PageActions.Sprint4Page, PageConstants.Sprint4Url, PageConstants.Sprint4Title);
        }

        [When(@"I fill out the form and submit it")]
        public void WhenIFillOutTheFormAndSubmitIt()
        {
            Settings.DefaultUser.GenderType = Gender.Other;
            m_sprint4PageActions.FillOutPrimaryContactForm(Settings.DefaultUser);
            User TestEmergencyContactUser = BaseTests.SetUser(UserConstants.EmergencyContactFirstName, UserConstants.EmergencyContactLastName);
            TestEmergencyContactUser.GenderType = Gender.Female;
            m_sprint4PageActions.FillOutEmergencyContactFormAndSubmit(TestEmergencyContactUser);
        }

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            PageHelper.ValidatePageTitle(m_sprint4PageActions.Sprint4Page, PageConstants.UltimateQaHomePageTitle);
        }
    }
}