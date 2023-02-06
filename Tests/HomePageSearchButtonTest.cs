using Framework.POM;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests
{
    internal class HomePageSearchButtonTest : BaseTest
    {
        [SetUp]

        public void Open()
        {
            HomePageSearchButton.Open();
            CommonMonu.CloseAdd();
        }

        [Test]
        public void CheckingSearchButtonFunctionality()
        {
            string expectedResult = "Juodi degtukai";
            HomePageSearchButton.ClickOnSearchButton();
            HomePageSearchButton.EnterTextToSearchField(expectedResult);
            HomePageSearchButton.ClickOnSearchFieldWithText();
            string actualResult = HomePageSearchButton.GetSearchResultMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}