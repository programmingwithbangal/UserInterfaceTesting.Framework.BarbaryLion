using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UserInterfaceTesting.Framework.BarbaryLion.Pages
{
    internal class Sprint5Page2 : BasePage
    {
        internal Sprint5Page2(ScenarioContext scenarioContext) : base(scenarioContext) {}

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));

        internal IWebElement CrocodilesRadioButton => Driver.FindElement(By.XPath("//input[@value='crocodiles']"));

        internal IWebElement BunniesRadioButton => Driver.FindElement(By.XPath("//input[@value='bunnies']"));
    }
}