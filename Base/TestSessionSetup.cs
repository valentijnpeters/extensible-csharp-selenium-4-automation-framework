using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System.Configuration;

namespace extensible_csharp_selenium_4_automation_framework.Base
{
    internal class TestSessionSetup
    {
        private const string Url = "UrlUnderTest", Headless = "RunHeadlessBrowser", Incognito = "EnableIncognito", Browser = "TargetBrowser";
        private string urlUnderTest = string.Empty;
        private bool runHeadlessBrowser, enableIncognito;
        private SupportedBrowsers targetBrowser;

        public TestSession SetupTestSession()
        {
            RetrieveEnvironmentConfiguration();

            var driver = SetupWebDriverInstance();

            return new TestSession
            {
                DriverInstance = driver,
                UrlUnderTest = urlUnderTest
            };
        }

        private void RetrieveEnvironmentConfiguration()
        {
            // 1. URL under test
            if (string.IsNullOrEmpty(TestContext.Parameters[Url]))
            {
                throw new ConfigurationErrorsException($"Unable to find a value for {Url} in config!");
            }
            else
            {
                urlUnderTest = TestContext.Parameters[Url];
            }

            // 2. Run browser heedlessly
            if (string.IsNullOrEmpty(TestContext.Parameters[Headless]))
            {
                throw new ConfigurationErrorsException($"Unable to find a value for {Headless} in config!");
            }
            if (!bool.TryParse(TestContext.Parameters[Headless], out runHeadlessBrowser))
            {
                throw new ConfigurationErrorsException(message: $"No boolean found for the configuration property: {Headless}");
            }

            // 3. Run browser in incognito
            if (string.IsNullOrEmpty(TestContext.Parameters[Incognito]))
            {
                throw new ConfigurationErrorsException($"Unable to find a value for {Incognito} in config!");
            }
            if (!bool.TryParse(TestContext.Parameters[Incognito], out enableIncognito))
            {
                throw new ConfigurationErrorsException(message: $"No boolean found for the configuration property: {Incognito}");
            }

            // 4. Which supported browser to use
            if (string.IsNullOrEmpty(TestContext.Parameters[Browser]))
            {
                throw new ConfigurationErrorsException($"Unable to find a value for {Browser} in config!");
            }
            if (!Enum.TryParse(TestContext.Parameters[Browser], out targetBrowser))
            {
                throw new ConfigurationErrorsException(message: $"The value specified for the target browser seems unsupported, please evaluate the configuration file.");
            }
        }

        private IWebDriver SetupWebDriverInstance()
        {
            return targetBrowser switch
            {
                SupportedBrowsers.Chrome => SetupChromeDriverInstance(),
                SupportedBrowsers.Firefox => SetupFireFoxDriverInstance(),
                SupportedBrowsers.Safari => SetupSafariDriverInstance(),
                SupportedBrowsers.Edge => SetupEdgeDriverInstance(),
                _ => throw new Exception($"No browser setup method defined for the selected browser!"),
            };
        }

        private IWebDriver SetupEdgeDriverInstance()
        {
            var options = new EdgeOptions();

            if (enableIncognito)
            {
                options.AddArgument("--incognito");
            }

            if (runHeadlessBrowser)
            {
                options.AddArgument("--headless=new");
            }

            return new EdgeDriver(options);
        }

        private IWebDriver SetupSafariDriverInstance()
        {
            var options = new SafariOptions();

            // No known options at the moment

            return new SafariDriver(options);
        }

        private IWebDriver SetupFireFoxDriverInstance()
        {
            var options = new FirefoxOptions();

            if (enableIncognito)
            {
                options.AddArgument("--incognito");
            }

            if (runHeadlessBrowser)
            {
                options.AddArgument("--headless");
            }

            return new FirefoxDriver(options);
        }

        private IWebDriver SetupChromeDriverInstance()
        {
            var options = new ChromeOptions();

            if (enableIncognito)
            {
                options.AddArgument("--incognito");
            }

            if (runHeadlessBrowser)
            {
                options.AddArgument("--headless=new");
            }

            return new ChromeDriver(options);
        }
    }
}