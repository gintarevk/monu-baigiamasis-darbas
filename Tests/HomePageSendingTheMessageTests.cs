﻿using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.BaseClasses;

namespace Tests
{
    public class HomePageSendingTheMessageTests :BaseTest
    {
        [SetUp]

        public void Open()
        {
            HomePageSendingTheMessage.Open();
        }

        [Test]

        public void HomePageCheckSendingTheMessage()
        {
            HomePageSendingTheMessage.ClickOnElementKontaktai();
            HomePageSendingTheMessage.EnterTextToFieldName("gi");
            HomePageSendingTheMessage.EnterTextToFieldEmail("g8star@gmail.com");
            HomePageSendingTheMessage.EnterTextToFieldTheme("Klausimas");
            HomePageSendingTheMessage.EnterTextToFieldMessage("Ar galiu atvažiuoti?");
            string actualResult = HomePageSendingTheMessage.TextOfConfirmingSendingMessage();

            string expectedResult = "Dėkojame už pranešimą. Jis buvo išsiųstas.";

            Assert.IsTrue(expectedResult.Equals(actualResult));
        }
    }
}