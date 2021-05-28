using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using HUMMEL.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMMEL.PAGE
{
    class SearchResultPage
    {
        public class SearchResultsPage : basePage
        {
            private const string highestPriceOptionText = "Brangiausios viršuje";

            private IReadOnlyCollection<IWebElement> resultList => Driver.FindElements(By.CssSelector("item_hover_wrap_link vv a2 fs2 fwb db mt5 c2 item-title"));

            private SelectElement orderByDropdown => new SelectElement(Driver.FindElement(By.Id("sortGoodsBy")));

            public SearchResultsPage(IWebDriver webdriver) : base(webdriver) { }

            public void OrderByHighestPrice()
            {
                orderByDropdown.SelectByText(highestPriceOptionText);
            }

            internal void VerifyPrice(string v)
            {
                throw new NotImplementedException();
            }
        }




    }
}


