using Framework;
using NUnit.Framework;

namespace Tests.BaseClasses
{
    internal class BaseTest
    {
        [SetUp]

        public void SetUp()
        {
            Driver.Initialize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
            Driver.CloseDriver();
        }
    }
}
