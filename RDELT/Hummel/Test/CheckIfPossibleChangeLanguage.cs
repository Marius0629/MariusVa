using HUMMEL.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HUMMEL.PAGE.SearchResultPage;

namespace HUMMEL.Test
{
    class Test2
    {
        
        
            private static HummelHomePage _homePage;
          

            internal static HummelHomePage HomePage { get => _homePage; set => _homePage = value; }

            [OneTimeSetUp]
            public static void OneTimeSetUp()
            {
                IWebDriver _driver = new ChromeDriver();
                _driver.Url = "https://www.e-hummel.lt/";
                _driver.Manage().Window.Maximize();
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                _homePage = new HummelHomePage(_driver);
           
            }

            [OneTimeTearDown]
            public static void OneTimeTearDown()
            {
                _homePage.CloseBrowser();
            }
        [Test]

        public void Russian()
        {
            _homePage.Russian();
           
        }
    }
    }










