using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UserInterfaceTesting.Framework.BarbaryLion.Pages
{
    internal class Sprint2Page : BasePage
    {
        internal Sprint2Page(ScenarioContext scenarioContext) : base(scenarioContext) {}

        internal IWebElement FirstNameFieldAlternate => Driver.FindElement(By.Name("firstname"));

        internal IWebElement LastNameFieldAlternate => Driver.FindElement(By.Name("lastname"));

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));
    }
}