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
            Common.WaitForElementToBeInvisible(iframeLocator);
            // Pridėti papildomi palaukimai:
            // Palaukimas, kol visas body taps redaguojamas, po to, kai dingsta reklama
            // Trumpas papildomas palaukimas, nes greituoju būdu nesugalvoju kaip sutvarkyti tai, kad paieškos mygtukas nėra paspaudžiamas
            Common.WaitForElementToBeInvisible("//body[@style='overflow: hidden;']");
            System.Threading.Thread.Sleep(500);
            Driver.GetDriver().SwitchTo().DefaultContent();
        }
    }
}