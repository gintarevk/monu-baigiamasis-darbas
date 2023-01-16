using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class CommonMonu
    {
        private static string addCloseButtonLocator = "(//*[@aria-label='Close'])[1]";
        private static string iframeLocator = "//*[@id='ml-webforms-popup-4991222']";

        public static void CloseAdd()
        {
            Common.MoveMouse();
            Common.WaitForElementToBeVisible(iframeLocator);
            Common.SwitchToIframeByLocator(iframeLocator);
            Common.ClickElement(addCloseButtonLocator);
            Driver.GetDriver().SwitchTo().DefaultContent();
        }
    }
}