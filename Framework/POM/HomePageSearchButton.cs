using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class HomePageSearchButton
    {
        private static string searchFieldLocator = "//input[contains(@placeholder,'Ieškoti …')]";
        private static string searchButtonLocator = "//*[@id='header']/div[1]/div/div[3]/a[2]";
        private static string searchButtonWithTextLocator = "/html/body/nav[3]/div/div/div/form/fieldset/div/button";
        private static string elementLocator = "//*[@id='search-form-63c3b2c43372a']";
        private static string searchFieldOutputLocator = "//*[@id='wrapper']/div[2]/div/div[2]/div[1]/div/div/header/h1";
        private static string url = "https://monu.lt/";
        private static string closeLocator = "//*[@id='ml-webforms-popup-4991222']";

        public static void Open()
        {
            Driver.OpenPage(url);
            Common.MoveMouse();
            Common.WaitForElementToBeVisible(closeLocator);
            Common.CloseAdd();
        }

        public static void ClickSearchButton()
        {
            Common.ClickElement(searchButtonLocator);
        }

        public static void EnterTextToSearchField(string text)
        {
            Common.WaitForElementToBeVisible(searchFieldLocator);
            Common.SendKeysToElement(searchFieldLocator, text);
        }

        public static void ClickSearchButtonWithText()
        {
            Common.ClickElement(searchButtonWithTextLocator);
        }

        public static void WaitForElementToBeVisible()
        {
            Common.WaitForElementToBeVisible(elementLocator);
        }

        public static string GetSearchResultMessage()
        {
            Common.WaitForElementToBeVisible(searchFieldOutputLocator);
            return Common.GetElementText(searchFieldOutputLocator);
        }
    }
}