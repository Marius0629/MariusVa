using HUMMEL.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static HUMMEL.PAGE.SearchResultPage;

namespace HUMMEL.Test
{
    class CheckIfSortingTheMostExpensiveItem
    {
        private static HummelHomePage _homePage;
        private static SearchResultsPage _searchPage;

        internal static HummelHomePage HomePage { get => _homePage; set => _homePage = value; }

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Url = "https://www.e-hummel.lt/";
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _homePage = new HummelHomePage(_driver);
            _searchPage = new SearchResultsPage(_driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _homePage.CloseBrowser();
        }

        [Test]
        public static void TestMostExcepsiveItem()
        {
           
            _homePage.SearchByText("Batai");
            _searchPage.OrderByHighestPrice();
            Thread.Sleep(10000);
           
        }
    }
}
