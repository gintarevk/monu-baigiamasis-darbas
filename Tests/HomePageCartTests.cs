using Framework;
using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.BaseClasses;

namespace Tests
{
    public class HomePageCartTests : BaseTest 
    {
        [SetUp]

        public void Open()
        {
            HomePageCart.Open();
        }

        [Test]

        public void AddingProductToCart()
        {
            string expectedResult = "Naturalūs smilkalai Purnama Rituals-GRPINDING PRESENCE (vyšnių žiedai, sandalmedis)";
            string actualResult = HomePageCart.ProductIsInTheCart();

            HomePageCart.ClickOnProduct();
            HomePageCart.ClickAddProductToCart();
            HomePageCart.ClickShowToCart();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void EmptyingTheCart()
        {
            string expectedResult = "Krepšelis dar tuščias";
            HomePageCart.ClickOnProduct();
            HomePageCart.ClickAddProductToCart();
            HomePageCart.ClickShowToCart();
            HomePageCart.ClickonMinusOne();
            HomePageCart.ClickOnAtnaujintiKrepseli();
            string actualResult = HomePageCart.TheCartIsEmpty();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void HomePageCartContinueToBye()
        {
            string expectedResult = "Krepšelis dar tuščias";
            string actualResult = HomePageCart.ProductIsInTheCart();

            HomePageCart.ClickOnProduct();
            HomePageCart.ClickAddProductToCart();
            HomePageCart.ClickShowToCart();
            HomePageCart.ClickOnElementTestiAtsiskaityma();
            HomePageCart.GetElement();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}