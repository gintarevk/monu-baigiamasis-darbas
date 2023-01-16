using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static void Initialize()
        {
            driver = new ChromeDriver();
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}



