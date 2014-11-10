using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageAutomation
{
    public class FacebookLoginPage
    {
        private IWebDriver _driver;
        private const string FacebookEmailInputFieldId = "email";
        private const string FacebookPasswordInputFieldId = "pass";
        private const string FacebookLoginButtonId = "loginbutton";
        private const string FacebookUrl = "https://www.facebook.com/";

        public FacebookLoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public FacebookLoginPage GoTo()
        {
            _driver.Navigate().GoToUrl(FacebookUrl);
            return this;
        }

        public bool IsAtLoginPage()
        {
            return _driver.FindElements(By.Id(FacebookEmailInputFieldId)).Count > 0 &&
                   _driver.FindElements(By.Id(FacebookPasswordInputFieldId)).Count > 0;
        }

        public FacebookHomePage LoginTo(string email, string password)
        {
            _driver.FindElement(By.Id(FacebookEmailInputFieldId)).SendKeys("ilearnautomation@gmail.com");
            _driver.FindElement(By.Id(FacebookPasswordInputFieldId)).SendKeys("ilearnautomationpassword");
            _driver.FindElement(By.Id(FacebookLoginButtonId)).Click();

            var homePage = new FacebookHomePage(_driver);

            return homePage;
        }
        
    }
}
