using extensible_csharp_selenium_4_automation_framework.Base;
using OpenQA.Selenium;

namespace extensible_csharp_selenium_4_automation_framework.SystemUnderTest.Wikipedia.Pages
{
    internal class Landing
    {
        public IWebDriver driverInstance;
        private readonly By enWikipediaLink = By.Id("js-link-box-en");

        public Landing(TestSession testSession)
        {
            driverInstance = testSession.DriverInstance;
        }

        public void NavigateToEnglishLandingPage()
        {
            driverInstance.FindElement(enWikipediaLink).Click();
        }
    }
}