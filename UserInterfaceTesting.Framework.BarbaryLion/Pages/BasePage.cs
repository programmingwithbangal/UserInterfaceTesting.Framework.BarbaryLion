using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UserInterfaceTesting.Framework.BarbaryLion.Constants;

namespace UserInterfaceTesting.Framework.BarbaryLion.Pages
{
    internal class BasePage
    {
        internal IWebDriver Driver { get; set; }

        internal BasePage(ScenarioContext scenarioContext)
        {
            Driver = scenarioContext.Get<IWebDriver>(ScenarioContextConstants.Driver); ;
        }

        internal bool IsLoaded(string expected)
        {
            try
            {
                return Driver.Title.Contains(expected);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal void GoTo(string uri)
        {
            Driver.Navigate().GoToUrl(uri);
        }
    }
}