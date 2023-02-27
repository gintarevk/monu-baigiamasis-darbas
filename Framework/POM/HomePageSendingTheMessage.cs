namespace Framework.POM
{
    public class HomePageSendingTheMessage
    {
        private static string url = "https://monu.lt/";
        private static string elementKontaktaiLocator = "//*[@id='menu-item-349']/a";
        private static string emailLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/p[2]/label";
        private static string messageLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/p[4]/label";
        private static string nameLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/p[1]/label";
        private static string themeLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/p[3]/label";
        private static string confirmingMessageLocator = "//*[@id='wpcf7-f2066-p342-o1']/form/div[2]";
        
        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickOnElementKontaktai()
        {
            Common.ClickElement(elementKontaktaiLocator);
        }

        public static void EnterTextToFieldEmail(string text)
        {
            Common.SendKeysToElement(emailLocator, text);
        }

        public static void EnterTextToFieldMessage(string text)
        {
            Common.SendKeysToElement(messageLocator, text);
        }

        public static void EnterTextToFieldName(string text)
        {
            Common.WaitForElementToBeVisible(nameLocator);
            Common.SendKeysToElement(nameLocator, text);
        }

        public static void EnterTextToFieldTheme(string value)
        {
            Common.SendKeysToElement(themeLocator, value);
        }

        public static string TextOfConfirmingSendingMessage()
        {
            return Common.GetElementText(confirmingMessageLocator);
        }
    }
}