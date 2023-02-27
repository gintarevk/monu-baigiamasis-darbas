using Framework.POM;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests
{
    internal class HomePageCartTests : BaseTest 
    {
        [SetUp]

        public void Open()
        {
            HomePageCart.Open();
            CommonMonu.CloseAdd();
        }

        [Test]

        public void AddingProductToCart()
        {
            //string expectedResult = "Natūralūs smilkalai Purnama Rituals - GROUNDING PRESENCE (vyšnių žiedai, sandalmedis)\r\n13.00 €";
            string expectedResult = "Namų kvapas FYG - Frankinsense & Myrrh, 125 ml\r\n28.00 €";

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

            Assert.IsTrue(expectedResult.Contains(actualResult));
        }

        [Test]

        public void HomePageCartContinueToBye()
        {
            string expectedResult = "Siųsti kitu adresu?";
            
            HomePageCart.ClickOnProduct();
            HomePageCart.ClickAddProductToCart();
            HomePageCart.ClickShowToCart();
            HomePageCart.WaitForTestiAtsiskaityma();
            HomePageCart.ClickOnElementTestiAtsiskaityma();
            
            string actualResult = HomePageCart.PirkejoDuomenys();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}