using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    internal class Common
    {
        private static string addCloseButtonLocator = "(//*[@aria-label='Close'])[1]";
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

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(120));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
        }

        internal static void SwitchToIframeByLocator(string iframeElementLocator)
        {
            IWebElement iframe = GetElement(iframeElementLocator);
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

            actions.MoveByOffset(20, 20);
            actions.Perform();
            actions.MoveByOffset(-20, -20);
            actions.Perform();
        }

        internal static void WaitForElementToBeVisible(object iframeLocator)
        {
            throw new NotImplementedException();
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

        internal static void ClickElement(object elementKontaktaiLocator)
        {
            throw new NotImplementedException();
        }
    }
}