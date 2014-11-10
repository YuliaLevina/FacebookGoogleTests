using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageAutomation
{
    public class GoogleSearchResultPage
    {
        private const string ResultItemClassName = "g";
        private IWebDriver _driver;

        public GoogleSearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public int GetResultsNumber()
        {
            return _driver.FindElements(By.ClassName(ResultItemClassName)).Count;
        }

    }
}
