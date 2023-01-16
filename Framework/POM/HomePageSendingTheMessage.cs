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

        public static void ClickOnElementKontaktai()
        {
            throw new NotImplementedException();
        }

        public static void ClickOnElement()
        {
            throw new NotImplementedException();
        }

        public static void EnterTextToFieldEmail()
        {
            throw new NotImplementedException();
        }

        public static void EnterTextToFieldMessage()
        {
            throw new NotImplementedException();
        }

        public static void EnterTextToFieldName(string value)
        {
            Common.SendKeysToElement("lokatorius", value);
        }

        public static void EnterTextToFieldTheme()
        {
            throw new NotImplementedException();
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
