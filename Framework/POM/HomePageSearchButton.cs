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
        private static string url = "https://monu.lt/";
        private static string searchFieldLocator = "//input[contains(@placeholder,'Ieškoti …')]";
        private static string searchButtonLocator = "//*[@class='feather feather-search'][1]";
        private static string searchButtonWithTextLocator = "//button[@type='submit']";
        private static string searchFieldOutputLocator = "//*[@class='page-title']";
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

        public static string GetSearchResultMessage()
        {
            Common.WaitForElementToBeVisible(searchFieldOutputLocator);
            return Common.GetElementText(searchFieldOutputLocator);
        }
    }
}