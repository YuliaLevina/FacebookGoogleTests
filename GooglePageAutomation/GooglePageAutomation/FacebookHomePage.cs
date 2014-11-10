using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageAutomation
{
    public class FacebookHomePage
    {
        private IWebDriver _driver;
        private const string FacebarTypeaheadNavigationFieldId = "_586i";
        private const string UserNavigationMenuId = "userNavigationLabel";
        private const string LogoutFormId = "logout_form";


        public FacebookHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsAtHomePage()
        {
            return _driver.FindElements(By.Id(FacebarTypeaheadNavigationFieldId)).Count > 0;
        }

        public FacebookHomePage Logout()
        {
            _driver.FindElement(By.Id(UserNavigationMenuId)).Click();
            _driver.FindElement(By.Id(LogoutFormId)).Submit();
            return this;
        }

    }
}
