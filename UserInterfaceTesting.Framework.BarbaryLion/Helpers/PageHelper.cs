using UserInterfaceTesting.Framework.BarbaryLion.Constants;
using UserInterfaceTesting.Framework.BarbaryLion.Pages;
using Xunit;

namespace UserInterfaceTesting.Framework.BarbaryLion.Models
{
    class PageHelper
    {
        public static void GotoSampleApplicationPage(BasePage basePage, string url, string title)
        {
            basePage.GoTo(url);
            Assert.True(basePage.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {basePage.Driver.Title}");
        }

        public static void ValidatePageTitle(BasePage basePage, string ultimateQaHomePageTitle)
        {
            Assert.True(basePage.IsLoaded(ultimateQaHomePageTitle), $"{ErrorConstants.UltimateQaHomePageError} Expected: {ultimateQaHomePageTitle} Actual: {basePage.Driver.Title}");
        }
    }
}
