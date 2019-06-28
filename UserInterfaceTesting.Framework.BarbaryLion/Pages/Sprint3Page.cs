using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UserInterfaceTesting.Framework.BarbaryLion.Pages
{
    internal class Sprint3Page : BasePage
    {
        internal Sprint3Page(ScenarioContext scenarioContext) : base(scenarioContext) {}

        internal IWebElement FirstNameField => Driver.FindElement(By.XPath("//*[@name='firstname']"));

        internal IWebElement LastNameField => Driver.FindElement(By.XPath("//*[@name='lastname']"));

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));

        internal IWebElement FemaleGenderRadioButton => Driver.FindElement(By.XPath("//input[@value='female']"));

        internal IWebElement OtherGenderRadioButton => Driver.FindElement(By.XPath("//input[@value='other']"));
    }
}