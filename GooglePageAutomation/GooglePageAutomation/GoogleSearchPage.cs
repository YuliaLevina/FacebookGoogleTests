using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace PageAutomation
{
    public class GoogleSearchPage
    {
        private IWebDriver _driver;
        private const string GoogleSearchButtonId = "gbqfb";
        private const string GoogleSearchInputFieldId = "gbqfq";
        private const string GoogleSearchUrl = "http://www.google.com";


        public GoogleSearchPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public GoogleSearchPage GoTo()
        {
            _driver.Navigate().GoToUrl(GoogleSearchUrl);
            return this;
        }

        public bool IsAt()
        {
            return _driver.FindElements(By.Id(GoogleSearchInputFieldId)).Count > 0;
        }

        public GoogleSearchResultPage SearchFor(string searchKeyword)
        {
            _driver.FindElement(By.Id(GoogleSearchInputFieldId)).SendKeys(searchKeyword);
            _driver.FindElement(By.Id(GoogleSearchButtonId)).Click();
            Thread.Sleep(3000);
            var resultPage = new GoogleSearchResultPage(_driver);

            return resultPage;
        }

    }
}
