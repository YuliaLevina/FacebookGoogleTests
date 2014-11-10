using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageAutomation
{
    [TestClass]
    public class FacebookHomePageTests : FacebookLoginPageTests
    {
        private FacebookHomePage homePage;

        [TestInitialize]
        public override void TearUp()
        {
            base.TearUp();
            homePage = new FacebookHomePage(Driver);
            homePage = Page.LoginTo("ilearnautomation@gmail.com", "ilearnautomationpassword");
        }

       [TestMethod]
        public void LoginPossitiveTest()
        {
            Assert.IsTrue(homePage.IsAtHomePage(), "Couldn't navigate to Facebook home page!");
        }

        [TestCleanup]
        public override void TearDown()
        {
            homePage.Logout();
            base.TearDown();
        }
    }
}
