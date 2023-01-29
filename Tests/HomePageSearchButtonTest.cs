using Framework;
using Framework.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Security.AccessControl;
using Tests.BaseClasses;

namespace Tests
{
    public class HomePageSearchButtonTest : BaseTest
    {
        [SetUp]

        public void Open()
        {
            HomePageSearchButton.Open();
        }

        [Test]
        public void CheckingSearchButtonFunctionality()
        {
            string expectedResult = "Juodi degtukai";
            HomePageSearchButton.ClickOnSearchButton();
            HomePageSearchButton.EnterTextToSearchField(expectedResult);
            HomePageSearchButton.ClickOnSearchFieldWithText();
            string actualResult = HomePageSearchButton.GetSearchResultMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}