using System;
using OpenQA.Selenium;

namespace UITestFrameWork
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

        public static void New (IDriverProvider provider)
        {
            if (Context != null)
            {
                throw new Exception("The Driver instance is not null!!");
            }

            Context = new DriverContext();
            Context._driver = provider.GetDriver();
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
