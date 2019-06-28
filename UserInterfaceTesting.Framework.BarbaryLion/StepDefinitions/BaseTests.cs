using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Constants;
using UserInterfaceTesting.Framework.BarbaryLion.Models;
using UserInterfaceTestingResources;

namespace UserInterfaceTesting.Framework.Lion.Tests
{
    [Binding]
    public class BaseTests
    {
        internal IWebDriver Driver { get; set; }

        internal User TestUser { get; set; }

        public ScenarioContext ScenarioContext;

        public BaseTests(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetupBeforeEveryTest()
        {
            Driver = GetChromeDriver();
            ScenarioContext.Add(ScenarioContextConstants.Driver, Driver);
            Settings.DefaultUser = SetUser(UserConstants.DefaultFirstName, UserConstants.DefaultLastName);
        }

        internal static User SetUser(string firstName, string lastName)
        {
            return new User
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        private static IWebDriver GetChromeDriver()
        {
            var factory = new WebDriverFactory();
            var driver = factory.Create(BrowserType.Chrome);
            return driver;
        }

        [AfterScenario]
        public void CleanupAfterEveryTest()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}