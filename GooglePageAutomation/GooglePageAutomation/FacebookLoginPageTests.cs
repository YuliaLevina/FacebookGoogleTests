using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageAutomation
{
    public class FacebookLoginPageTests : TestBase
    {
        protected FacebookLoginPage Page;

        [TestInitialize]
        public override void TearUp()
        {
            base.TearUp();
            Page = new FacebookLoginPage(Driver);
            Page.GoTo();
        }

        [TestMethod]
        public void IsAtLoginPage()
        {
            Assert.IsTrue(Page.IsAtLoginPage(), "Couldn't navigate to Facebook login pagelocation!");
        }

        [TestCleanup]
        public override void TearDown()
        {
            base.TearDown();
        }
    }
}
