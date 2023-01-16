using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class HomePageSendingTheMessage
    {
        private static string url = "https://monu.lt/";
        private static string closeLocator = "//*[@id='ml-webforms-popup-4991222']";
        private static object elementKontaktaiLocator = "//*[@id='menu-item-349']";
        private static string emailLocator = "//*[@type='email']";
        private static string messageLocator = "//*[@name='your-message']";
        private static string nameLocator = "//input[@name='your-name']";
        private static string themeLocator = "//input[@name='your-subject']";
        private static string ConfirmingMessageLocator = "//div[@class='wpcf7-response-output']";

        public static void ClickOnElementKontaktai()
        {
            Common.ClickElement(elementKontaktaiLocator);
        }

        public static void EnterTextToFieldEmail(string value)
        {
            Common.SendKeysToElement(emailLocator, value);
        }

        public static void EnterTextToFieldMessage(string value)
        {
            Common.SendKeysToElement(messageLocator, value);
        }

        public static void EnterTextToFieldName(string value)
        {
            Common.SendKeysToElement(nameLocator, value);
        }

        public static void EnterTextToFieldTheme(string value)
        {
            Common.SendKeysToElement(themeLocator, value);
        }

        public static void Open()
        {
            Driver.OpenPage(url);
            Common.MoveMouse();
            Common.WaitForElementToBeVisible(closeLocator);
            Common.CloseAdd();
        }

        public static string TextOfConfirmingSendingMessage()
        {
            Common.GetElement(ConfirmingMessageLocator);
            return Common.GetElementText(ConfirmingMessageLocator);
        }
    }
}
