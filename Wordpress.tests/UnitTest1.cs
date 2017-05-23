using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Wordpress.tests
{
    [TestClass]
    public class UnitTest1
    {
        private Dependencies Test;
        private IWebDriver Driver;
        [TestInitialize]
        public void TestInit()
        {
            DriverContext.New();
            //Driver = DriverContext.Driver;
            Test = new Dependencies();
          //  Test.Driver = this.Driver;
        }
        [TestMethod]
        public void TestMethod1()
        {
            WordPressHome c = new WordPressHome(Test);
            c.OpenPage();
        }

        [TestCleanup]
        public void TestClean()
        {
            DriverContext.Release();
        }
    }
}
