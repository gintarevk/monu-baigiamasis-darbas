namespace Framework.POM
{
    public class CommonMonu
    {
        private static string addCloseButtonLocator = "/html/body/div[1]/div/div[1]/div/div[1]/button";
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