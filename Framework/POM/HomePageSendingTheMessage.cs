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
        private static object elementKontaktaiLocator = "//*[@id='menu-item-349']/a";
        private static string emailLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/p[2]/label/span/input";
        private static string messageLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/p[4]/label/span/textarea";
        private static string nameLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/p[1]/label/span/input";
        private static string themeLocator = "//*[@id=\"wpcf7-f2066-p342-o1\"]/form/p[3]/label/span/input";

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

        public static void ScrollDown()
        {
            throw new NotImplementedException();
        }

        public static string SkaitytiGautaZinute()
        {
            throw new NotImplementedException();
        }
    }
}
