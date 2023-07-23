using extensible_csharp_selenium_4_automation_framework.Base;
using OpenQA.Selenium;

namespace extensible_csharp_selenium_4_automation_framework.SystemUnderTest.Wikipedia.Pages
{
    internal class EnglishLanding
    {
        public IWebDriver driverInstance;

        public EnglishLanding(TestSession testSession)
        {
            driverInstance = testSession.DriverInstance;
        }

        public string GetPageTitle()
        {
            return driverInstance.Title;
        }

        public string GetUrl()
        {
            return driverInstance.Url;
        }
    }
}