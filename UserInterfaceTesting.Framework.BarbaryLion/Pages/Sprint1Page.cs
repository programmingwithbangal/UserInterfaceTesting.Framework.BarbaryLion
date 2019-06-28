using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UserInterfaceTesting.Framework.BarbaryLion.Pages
{
    internal class Sprint1Page : BasePage
    {
        internal Sprint1Page(ScenarioContext scenarioContext) : base(scenarioContext) {}

        internal IWebElement FirstNameField => Driver.FindElement(By.XPath("//*[@name='firstname']"));

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));
    }
}