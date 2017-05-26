using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Wordpress.steps
{
    public class WordPressHome :BaseWordpressPage
    {
        IWebElement LoginLink;
        IWebElement PageHeader;
        public WordPressHome(Dependencies test) : base(test)
        {
            

        }

        //public WordPressHome(Dependencies test)
        //{
        //    this.Test = test;
        //}

        public WordPressHome OpenPage()
        {
            //Test.Driver.Navigate().GoToUrl(new Uri("https://wordpress.com/"));
            Test.Driver.Navigate().GoToUrl("https://wordpress.com/");
            return this;
        }

        public override bool IsLoaded()
        {
            LoginLink = Test.Driver.FindElement(By.Id("navbar-login-link"));
            PageHeader = Test.Driver.FindElement(By.ClassName("wpcom-logo"));
            return LoginLink.Displayed && PageHeader.Displayed;
        }

       
        public void OpenLoginForm()
        {
            LoginLink = Test.Driver.FindElement(By.Id("navbar-login-link"));
            PageHeader = Test.Driver.FindElement(By.ClassName("wpcom-logo"));
            LoginLink.Click();
            Test.LoginForm.GoLive();
        }
    }
}
