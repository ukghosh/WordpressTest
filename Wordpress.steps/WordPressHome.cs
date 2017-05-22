using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Wordpress.steps
{
    public class WordPressHome
    {
        private Dependencies Test;
        public WordPressHome(Dependencies test)
        {
            this.Test = test;
        }
        
        public void OpenPage()
        {           
            Test.Driver.Navigate().GoToUrl(new Uri("https://wordpress.com/"));

        }
    }
}
