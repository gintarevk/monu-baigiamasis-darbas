using System;

namespace Framework.POM
{
    public class HomePageCart
    {
        private static string url = "https://monu.lt/";
        private static string firstProductLocator = "//*[@id='slick-slide10']/div/div/div[1]/h2/a";
        private static string addProductToCartLocator = "//*[@type = 'submit'][1]";
        private static string addProductToCartLoadingLocator = "//*[@type = 'submit' and contains(@class, 'et-loader')][1]";
        private static string showToCartLocator = "//*[contains(@class, 'header-mobile')]//*[@data-target='open-cart']";
        private static string minusOneLocator = "//*[@class = 'minus']";
        private static string productinCartLocator = "//div[@class='col-md-6 col-sm-12 product-name']";
        private static string atnaujintiKrepseliLocator = "//button[@name][1]";
        private static string cartIsEmptyLocator = "//div[@class='woocommerce-notices-wrapper']";
        private static string testiAtsiskaitymaLocator = "//*[@class='checkout-button button alt wc-forward']";
        private static string pirkejoDuomenysLocator = "//*[@id='ship-to-different-address']/label/span";
        
        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickOnProduct()
        {
            Common.WaitForElementToBeClickableIgnoreNotInteractable(firstProductLocator);
            Common.ScrollToElement(firstProductLocator);
            Common.ClickElement(firstProductLocator);
        }

        public static void ClickAddProductToCart()
        {
            Common.ClickElement(addProductToCartLocator);
            // Palaukiame, kol prekė bus pridėta prie krepšelio
            // Paspaudus mygtuką pridėti, jis pasikeičia ir būna pasikeitęs tol, kol prekė tampa pridėta
            // Taigi galima palaukti, kol toks pasikeitęs mygtukas nustos egzistuoti
            Common.WaitForElementToBeInvisible(addProductToCartLoadingLocator);
            // Palaukiame, kol pasikeis prekių skaičiaus krepšelyje atvaizdavimas
            // Kai prekės pridėjimo mygtukas pasikeičia, tuomet iššaukiamas žemiau esantis pasikeitimas
            // Nepalaukus šio veiksmo ir paspaudus per anksti, būna rodomas tuščias krepšelis
            Common.WaitForElementToBeVisible($"{showToCartLocator}/span[contains(@class,'do-animation')]");
        }

        public static void ClickShowToCart()
        {
            Common.WaitForElementToBeClickableIgnoreNotInteractable(showToCartLocator);
            Common.ClickElement(showToCartLocator);
        }

        public static string ProductIsInTheCart()
        {
            return Common.GetElementText(productinCartLocator);
        }

        public static void ClickonMinusOne()
        {
            Common.ClickElement(minusOneLocator);
        }

        public static void ClickOnAtnaujintiKrepseli()
        {
            Common.ClickElement(atnaujintiKrepseliLocator);
        }

        public static string TheCartIsEmpty()
        {
           return Common.GetElementText(cartIsEmptyLocator);
        }

        public static void ClickOnElementTestiAtsiskaityma()
        {
            Common.ClickElement(testiAtsiskaitymaLocator); 
        }
        
        public static string PirkejoDuomenys()
        {
            return Common.GetElementText(pirkejoDuomenysLocator);
        }

        public static void WaitForTestiAtsiskaityma()
        {
            Common.WaitForElementToBeVisible(testiAtsiskaitymaLocator);
        }
    }
}       