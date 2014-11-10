using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageAutomation
{
    [TestClass]
    public class TestBase
    {
        protected IWebDriver Driver;

        [TestInitialize]
        public virtual void TearUp()
        {
            Driver = new FirefoxDriver();
        }

        [TestCleanup]
        public virtual void TearDown()
        {
            Driver.Close();
        }

    }
}
