using OpenQA.Selenium;

namespace extensible_csharp_selenium_4_automation_framework.Base
{
    internal class TestSession
    {
        public required IWebDriver DriverInstance { get; set; }
        public string UrlUnderTest { get; set; } = string.Empty;
    }
}