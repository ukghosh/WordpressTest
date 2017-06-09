using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITestFrameWork;

namespace Wordpress.tests
{
    [TestClass]
    public class UnitTest1
    {
        //TestContext is predefined in .Net TestFramework
       public TestContext TestContext { get; set; }
        // Dependencies class is Injected here with the use of Dependencies.Inject(property)
        // private Dependencies Test { get { return Dependencies.Inject; } }    - or replaced with code below
        private Dependencies Test => Dependencies.Inject;
       
        [TestInitialize]
        public void TestInit()
        {            
            DriverContext.New(ProviderFactory.AppConfig());
            Dependencies.New();
            Test.Report.SetTitle(TestContext.TestName);


        }

        [TestMethod]
        public void TestMethod1()
        {
            //Test.Report.SetTitle("TestMethod1");
            Test.Report.NewStep("Open Page");                 
           Test.WordpressHome.OpenPage();
            Test.Report.NewStep("Open Login form");
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
        public void FailedTest()
        {
            //Test.Report.SetTitle("Failed Test");
            Test.Driver.FindElement(By.Id("")).Click();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Test.WordpressHome
                .OpenPage()
                .OpenLoginForm();
        }

        [TestMethod]

        public void TestMethod4()
        {
            //Write a blog

            // Preview a blog
            //Publish a blog
            //Set date and time

            //Left Side menu
            //Blog posts

            //Edit a blog
            //view a blog

            //More
            //Trash a blog
            //copy a blog

        }

       

        [TestCleanup]
        public void TestClean()
        {
            if (this.TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                Test.Report.Passed();                
            }
            else
            {
                
                Test.Report.Failed();
            }

            Test.Report.Flush();
            DriverContext.Release();
        }
    }
}
