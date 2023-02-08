using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
