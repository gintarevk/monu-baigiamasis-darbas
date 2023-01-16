using Framework;
using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class HomePageCartTests
    {
        [SetUp]

        public void SetUp()
        {
            Driver.Initialize();
            HomePageCart.Open();
        }

        [Test]

        public void AddingProductToCart()
        {
            string expectedResult = "Žalioji arbata Teministeriet – 262, braškės ir avietės, 100 g";
            HomePageCart.ClickOnProduct();
            HomePageCart.ClickAddProductToCart();
            HomePageCart.ClickShowToCart();
            string actualResult = HomePageCart.ProductIsInTheCart();

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
            HomePageCart.ClickOnProduct();
            HomePageCart.ClickAddProductToCart();
            HomePageCart.ClickShowToCart();
            HomePageCart.ClickOnElementTestiAtsiskaityma();
            HomePageCart.GetElement();

            string actualResult = HomePageCart.ProductIsInTheCart();

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    Driver.CloseDriver();
        //}
    }
}