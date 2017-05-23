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
       
        [TestInitialize]
        public void TestInit()
        {
            //DriverContext.New(new ChromeProvider());
            //DriverContext.New(new IEProvider());
            DriverContext.New(ProviderFactory.AppConfig());
            Test = new Dependencies();
          
        }
        [TestMethod]
        public void TestMethod1()
        {
            WordPressHome wordpressHome = new WordPressHome(Test);
            wordpressHome.OpenPage();
        }

        [TestCleanup]
        public void TestClean()
        {
            DriverContext.Release();
        }
    }
}
