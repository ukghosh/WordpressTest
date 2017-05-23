using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Wordpress.steps
{
    public class DriverContext 
    {
        private static DriverContext Context;
        private IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                return Context._driver;
            }
                
          }

        //to prevent instantiating from other classes
        private DriverContext()
        {
            
        }

        public static void New()
        {
            if (Context != null)
            {
                throw new Exception("The Driver instance is not null!!");
            }

            Context = new DriverContext();
            Context._driver = new ChromeDriver();
        }
        
        public static void Release()
        {
            if (Context != null && Context._driver != null)
            {
                Context._driver.Quit();
            }

            Context = null;
        }
    }
}
