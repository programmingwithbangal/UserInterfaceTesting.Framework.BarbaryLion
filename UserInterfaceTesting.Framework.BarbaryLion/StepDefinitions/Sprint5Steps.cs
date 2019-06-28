using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Constants;
using UserInterfaceTesting.Framework.BarbaryLion.Enums;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTesting.Framework.BarbaryLion.PageActions;
using UserInterfaceTesting.Framework.Lion.Tests;
using Xunit;

namespace RestApiTesting.Framework.Cheetah.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Sprint5Steps")]
    public sealed class Sprint5Steps : Steps
    {
        private readonly Sprint5PageActions m_sprint5PageActions;

        private readonly Sprint5Page2Actions m_sprint5Page2Actions;

        public Sprint5Steps(ScenarioContext scenarioContext)
        {
            m_sprint5PageActions = new Sprint5PageActions(scenarioContext);
            m_sprint5Page2Actions = new Sprint5Page2Actions(scenarioContext);
        }

        [Given(@"I go to the sample application page")]
        public void GivenIGoToSprint1SampleApplicationPage()
        {
            PageHelper.GotoSampleApplicationPage(m_sprint5PageActions.Sprint5Page, PageConstants.Sprint5Url, PageConstants.Sprint5Title);
        }

        [When(@"I fill out the first form and submit it")]
        public void WhenIFillOutTheFirstFormAndSubmitIt()
        {
            Settings.DefaultUser.GenderType = Gender.Other;
            m_sprint5PageActions.FillOutPrimaryContactForm(Settings.DefaultUser);
            User TestEmergencyContactUser = BaseTests.SetUser(UserConstants.EmergencyContactFirstName, UserConstants.EmergencyContactLastName);
            TestEmergencyContactUser.GenderType = Gender.Female;
            m_sprint5PageActions.FillOutEmergencyContactFormAndSubmit(TestEmergencyContactUser);
        }

        [Then(@"I should be redirected to the second form")]
        public void ThenIShouldBeRedirectedToTheSecondForm()
        {
            Assert.True(m_sprint5PageActions.Sprint5Page.IsLoaded(PageConstants.FormPage2Title),
                $"{ErrorConstants.SampleApplicationPage2Error} Expected: {PageConstants.FormPage2Title} Actual: {m_sprint5PageActions.Sprint5Page.Driver.Title}");
        }

        [When(@"I fill out the second form and submit it")]
        public void WhenIFillOutTheSecondFormAndSubmitIt()
        {
            m_sprint5Page2Actions.FillOutRadioButtonAndSubmit(Animal.Crocodiles);
        }

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            PageHelper.ValidatePageTitle(m_sprint5Page2Actions.Sprint5Page2, PageConstants.UltimateQaHomePageTitle);
        }
    }
}