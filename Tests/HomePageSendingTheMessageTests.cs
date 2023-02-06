using Framework.POM;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests
{
    internal class HomePageSendingTheMessageTests : BaseTest
    {
        [SetUp]

        public void Open()
        {
            HomePageSendingTheMessage.Open();
            CommonMonu.CloseAdd();
        }

        [Test]

        public void HomePageCheckSendingTheMessage()
        {
            string expectedResult = "Dėkojame už pranešimą. Jis buvo išsiųstas.";

            HomePageSendingTheMessage.ClickOnElementKontaktai();
            HomePageSendingTheMessage.EnterTextToFieldName("gi");
            HomePageSendingTheMessage.EnterTextToFieldEmail("g8star@gmail.com");
            HomePageSendingTheMessage.EnterTextToFieldTheme("Klausimas");
            HomePageSendingTheMessage.EnterTextToFieldMessage("Ar galiu atvažiuoti?");

            string actualResult = HomePageSendingTheMessage.TextOfConfirmingSendingMessage();

            Assert.IsTrue(actualResult.Equals(expectedResult));
        }
    }
}