using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class HomePageSendingTheMessageTests
    {
        [SetUp]

        public void SetUp()
        {
            Driver.Initialize();
            HomePageSendingTheMessage.Open();
        }
        [Test]

        public void HomePageCheckSendingTheMessage()
        {
            HomePageSendingTheMessage.ScrollDown();
            HomePageSendingTheMessage.ClickOnElementKontaktai();
            HomePageSendingTheMessage.EnterTextToFieldName("gi");
            HomePageSendingTheMessage.EnterTextToFieldEmail("g8star@gmail.com");
            HomePageSendingTheMessage.EnterTextToFieldTheme("Klausimas");
            HomePageSendingTheMessage.EnterTextToFieldMessage("Ar galiu atvažiuoti?");
            string actualResult = HomePageSendingTheMessage.SkaitytiGautaZinute();

            string expectedResult = "Dėkojame už pranešimą. Jis buvo išsiųstas.";

            Assert.IsTrue(expectedResult.Equals(actualResult));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}