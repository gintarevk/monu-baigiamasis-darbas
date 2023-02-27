namespace Framework.POM
{
    public class HomePageSearchButton
    {
        private static string url = "https://monu.lt/";
        private static string searchFieldLocator = "//input[contains(@placeholder,'Ieškoti …')]";
        private static string searchButtonLocator = "(//*[contains(@class, 'quick_search')])[2]";
        private static string searchButtonWithTextLocator = "//button[@type='submit']";
        private static string searchFieldOutputLocator = "//*[@class='page-title']";
        
        public static void Open()
        {
            Driver.OpenPage(url);
        }
        
        public static void ClickOnSearchButton()
        {
            Common.ClickElement(searchButtonLocator);
        }

        public static void EnterTextToSearchField(string text)
        {
            Common.WaitForElementToBeVisible(searchFieldLocator);
            Common.SendKeysToElement(searchFieldLocator, text);
        }

        public static void ClickOnSearchFieldWithText()
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