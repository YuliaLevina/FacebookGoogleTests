using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace PageAutomation
{
    [TestClass]
    public class GoogleTests : TestBase
    {
        [TestInitialize]
        public override void TearUp()
        {
           base.TearUp(); 
        }

        [TestMethod]
        public void CheckYouAreAtGooglePage()
        {
            var page = new GoogleSearchPage(Driver);
            Assert.IsTrue(page.GoTo().IsAt(), "Coudn't navigate to Google search page location!");
        }
        
        [TestMethod]
        public void FindResultsForKeyword()
        {
            var page = new GoogleSearchPage(Driver);
            Assert.IsTrue(page.GoTo().SearchFor("test").GetResultsNumber()> 0, "No results found for search keyword.");
        }

        [TestCleanup]
        public override void TearDown()
        {
            base.TearDown();
        }
    }
}