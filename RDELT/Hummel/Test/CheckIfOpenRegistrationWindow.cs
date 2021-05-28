using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HUMMEL.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HUMMEL.PAGE.SearchResultPage;

namespace HUMMEL
{
    public class Test1
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

        public void LogIn()
        {
            _homePage.ClickLoginButton();
            _homePage.EnterEmail("Marius");
           _homePage.EnterPassword("lietuva");
           //_homePage.ClickSubmitButton();    
        }

       


            


    }

}

