using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class HomePageCart
    {
        private static string url = "https://monu.lt/";
        private static string firstProductLocator = "//*[@title= 'Žalioji arbata Teministeriet – 262, braškės ir avietės, 100 g']";
        private static string addProductToCartLocator = "//*[@type = 'submit'][1]";
        private static string showToCartLocator = "//span[@class='item-counter minicart-counter'][1]";
        private static string minusOneLocator = "//*[@class = 'minus']";
        private static string productinCartLocator = "//*[@title = 'Cart'][1]";
        private static string atnaujintiKrepseliLocator = "//button[@name][1]";
        private static string cartIsEmptyLocator = "//div[@class='woocommerce-notices-wrapper']";
        private static string closeLocator = "//*[@id='ml-webforms-popup-4991222']";
        private static string testiAtsiskaitymaLocator = "//*[@class='checkout-button button alt wc-forward']";
        private static string pirkejoDuomenysLocator = "//*[@class='col-1']";
        ////*[@id="header"]/div[1]/div/div[3]/a[1]/svg
        public static void Open()
        {
            Driver.OpenPage(url);
            Common.MoveMouse();
            Common.WaitForElementToBeVisible(closeLocator);
            Common.CloseAdd();
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
            Common.GetElement(productinCartLocator);
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
            Common.GetElement(cartIsEmptyLocator);
            return Common.GetElementText(cartIsEmptyLocator);
        }

        public static void ClickOnElementTestiAtsiskaityma()
        {
            Common.ClickElement(testiAtsiskaitymaLocator); 
        }
        
        public static string GetElement()
        {
            Common.GetElement(pirkejoDuomenysLocator);
            return Common.GetElementText(pirkejoDuomenysLocator);
        }
    }
}       