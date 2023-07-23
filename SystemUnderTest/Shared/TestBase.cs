using extensible_csharp_selenium_4_automation_framework.Base;
using NUnit.Framework;

namespace extensible_csharp_selenium_4_automation_framework.SystemUnderTest.Shared
{
    internal class TestBase
    {
        public required TestSession testSession;

        [SetUp]
        public void Init()
        {
            testSession = new TestSessionSetup().SetupTestSession();
        }

        [TearDown]
        public void Cleanup()
        {
            testSession.DriverInstance.Quit();
        }
    }
}