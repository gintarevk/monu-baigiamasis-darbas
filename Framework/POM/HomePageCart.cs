using System;

namespace Framework.POM
{
    public class HomePageCart
    {
        private static string url = "https://monu.lt/";
        private static string firstProductLocator = "//*[@id='slick-slide10']/div/div/div[1]/h2/a";
        private static string addProductToCartLocator = "//*[@type = 'submit'][1]";
        private static string showToCartLocator = "//span[@class='item-counter minicart-counter'][1]";
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