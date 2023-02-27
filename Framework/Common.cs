using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework
{
    internal class Common
    {
        private static string addCloseButtonLocator = "/html/body/div[1]/div/div[1]/div/div[1]/button";
        private static string iframeLocator = "//*[@id='ml-webforms-popup-4991222']";
        
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
        }

        internal static void SwitchToIframeByLocator(string locator)
        {
            IWebElement iframe = GetElement(locator);
            Driver.GetDriver().SwitchTo().Frame(iframe);
        }

        internal static void CloseAdd()
        {
            Common.SwitchToIframeByLocator(iframeLocator);
            Common.ClickElement(addCloseButtonLocator);
            Driver.GetDriver().SwitchTo().DefaultContent();
        }

        internal static void MoveMouse()
        {
            Actions actions = new Actions(Driver.GetDriver());

            actions.MoveByOffset(50, 50);
            actions.Perform();
            actions.MoveByOffset(-50, -50);
            actions.Perform();
        }

        internal static void WaitForElementToBeClickableIgnoreNotInteractable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(20));
            wait.IgnoreExceptionTypes(typeof(ElementNotInteractableException), typeof(StaleElementReferenceException));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
        }

        internal static void ScrollToElement(string firstProductLocator)
        {
            Actions actions = new Actions(Driver.GetDriver());

            IWebElement element = Common.GetElement(firstProductLocator);
            actions.ScrollToElement(element);
            actions.MoveToElement(element);
            actions.Perform();
        }

        internal static void WaitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }
    }
}