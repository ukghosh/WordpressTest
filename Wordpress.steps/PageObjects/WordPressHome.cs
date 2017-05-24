using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Wordpress.steps
{
    public class WordPressHome :BaseWordpressPage
    {
        public WordPressHome(Dependencies test) : base(test)
        {
        }

        //public WordPressHome(Dependencies test)
        //{
        //    this.Test = test;
        //}

        public WordPressHome OpenPage()
        {           
            Test.Driver.Navigate().GoToUrl(new Uri("https://wordpress.com/"));
            return this;
        }

        public override bool IsLoaded()
        {
            return false;
        }

        public void OpenLoginForm()
        {
            var LoginLink = Test.Driver.FindElement(By.Id("navbar-login-link"));
            LoginLink.Click();
            Test.LoginForm.GoLive();
        }
    }
}
