using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HUMMEL.Page
{

    class HummelHomePage : basePage
    {
        private IWebElement searchInput => Driver.FindElement(By.Id("main-search-input"));
        private IWebElement searchIcon => Driver.FindElement(By.Id("main-search-submit"));

        private IWebElement LoginButton => Driver.FindElement(By.Id("login_fly_on"));

        private IWebElement EmailInPutField => Driver.FindElement(By.Id("input-small.input_11.mt5"));

        private IWebElement PasswordInPutField => Driver.FindElement(By.Id("input-small.input_11.mt5.login_passwd_real"));

        private IWebElement RussianLanguage => Driver.FindElement(By.CssSelector("#languages > ul > li.lang-link.bn > a"));

        private IWebElement EnglishLanguage => Driver.FindElement(By.CssSelector("#languages > ul > li:nth-child(1) > a"));




        public HummelHomePage(IWebDriver webDriver) : base(webDriver) { }

        public void SearchByText(string searchText)
        {
            searchInput.Clear();
            searchInput.SendKeys(searchText);
            searchIcon.Click();
        }

        public void PressOnSearchIcon()
        {
            searchIcon.Click();
        }

        internal void CloseCookie()
        {
            throw new NotImplementedException();
        }

        public void EnterPassword(string email)
        {
            PasswordInPutField.Clear();
            PasswordInPutField.SendKeys(email);

        }

        public void EnterEmail(string email)
        {
            EmailInPutField.Clear();
            EmailInPutField.SendKeys(email);
        }

        internal static void ClickSubmitButton()
        {
            throw new NotImplementedException();
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();

        }

        public void Russian()
        {
            RussianLanguage.Click();
            Thread.Sleep(10000);
            EnglishLanguage.Click();
            Thread.Sleep(10000);

        }


    }

}












