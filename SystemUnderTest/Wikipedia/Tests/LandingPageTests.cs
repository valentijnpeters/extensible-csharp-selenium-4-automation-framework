using extensible_csharp_selenium_4_automation_framework.SystemUnderTest.Shared;
using extensible_csharp_selenium_4_automation_framework.SystemUnderTest.Wikipedia.Pages;
using NUnit.Framework;

namespace extensible_csharp_selenium_4_automation_framework.SystemUnderTest.Wikipedia.Tests
{
    [TestFixture]
    internal class LandingPageTests : TestBase
    {
        [Test, Description("The user should be able to navigate to the English Language landing page of Wikipedia.org successfully.")]
        public void NavigateToEnWikipedia()
        {
            // Navigate to the base URL of the website under test
            testSession.DriverInstance.Navigate().GoToUrl(testSession.UrlUnderTest);

            // Start a new instance of the page the URL navigates to and complete the first driver action
            new Landing(testSession).NavigateToEnglishLandingPage();

            EnglishLanding englishLanding = new(testSession);
            Assert.That(englishLanding.GetPageTitle(), Is.EqualTo("Wikipedia, the free encyclopedia"));
            Assert.That(englishLanding.GetUrl(), Is.EqualTo("https://en.wikipedia.org/wiki/Main_Page"));
        }
    }
}