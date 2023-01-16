using Framework;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Security.AccessControl;

namespace Tests
{
    public class HomePageSearchButtonTest
    {
        [SetUp]

        public void SetUp()
        {
            Driver.Initialize();
            HomePageSearchButton.Open();
        }

        [Test]
        public void CheckingSearchButtonFunctionality()
        {
            string expectedResult = "Juodi degtukai";
            HomePageSearchButton.ClickSearchButton();
            HomePageSearchButton.EnterTextToSearchField(expectedResult);
            HomePageSearchButton.ClickSearchButtonWithText();
            string actualResult = HomePageSearchButton.GetSearchResultMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    Driver.CloseDriver();
        //}
    }
}