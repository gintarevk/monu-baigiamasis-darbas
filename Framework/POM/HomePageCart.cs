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
        private static string firstProductLocator = "//*[@id='slick-slide10']/div//a";
        private static string addProductToCartLocator = "//*[@id='product-10878']/div[1]/div[2]/div/div[2]/div/div[3]/form/div/button";
        private static string showToCartLocator = "//*[@id='header']/div[2]/div/div[3]/a[1]/span[2]";
        private static string closeAdLocator = "//*[@id='ml-webforms-popup-4991222']";
        private static string minusOneLocator = "//*[@id='wrapper']/div[2]/div/div[3]/div/div/div[4]/div[1]/form/table/tbody/tr[1]/td[2]/div/div[2]/div/span[1]";
        private static string productinCartLocator = "//*[@id='header']/div[1]/div/div[3]/a[1]/span[2]";
        private static string atnaujintiKrepseliLocator = "//*[@id='wrapper']/div[2]/div/div[3]/div/div/div[4]/div[1]/form/table/tbody/tr[2]/td/button";
        private static string cartIsEmptyLocator = "//*[@id='wrapper']/div[2]/div/div[3]/div/div/div/div[2]";
        private static string closeLocator = "//*[@id='ml-webforms-popup-4991222']";
        private static string testiAtsiskaitymaLocator = "";
        private static string pirkejoDuomenysLocator = "//*[@id='customer_details']/div[1]/div[2]/h3/text()";

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