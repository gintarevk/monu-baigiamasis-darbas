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
    public class BaseTest
    {
        [OneTimeSetUp]

        public void SetUp()
        {
            Driver.Initialize();
        }

        //[OneTimeTearDown]
        public void TearDown()
        {
            //Driver.TakeScreenShot();
            //Driver.CloseDriver();
        }
    }
}
