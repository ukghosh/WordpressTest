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
        // Dependencies class is Injected here with the use of Dependencies.Inject(property)
        // private Dependencies Test { get { return Dependencies.Inject; } }    - or replaced with code below
        private Dependencies Test => Dependencies.Inject;
       
        [TestInitialize]
        public void TestInit()
        {            
            DriverContext.New(ProviderFactory.AppConfig());
            Dependencies.New();         
          
          
        }

        [TestMethod]
        public void TestMethod1()
        {           
           Test.WordpressHome.OpenPage();
           Test.WordpressHome.OpenLoginForm();
           Test.LoginForm.Login();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Test.WordpressHome.OpenPage();
            Test.WordpressHome.OpenLoginForm();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Test.WordpressHome
                .OpenPage()
                .OpenLoginForm();
        }



        [TestCleanup]
        public void TestClean()
        {
            DriverContext.Release();
        }
    }
}
