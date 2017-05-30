using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITestFrameWork
{
    public class DriverContext 
    {
        private static DriverContext Context;
        private IWebDriver _driver;
        public int TIMEOUT_SEC;

        public static IWebDriver Driver
        {
            get
            {
                return Context._driver;
            }
                
          }

        public static DriverContext Current { get { return Context; } }

        //to prevent instantiating from other classes
        private DriverContext()
        {
            TIMEOUT_SEC = 20;
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

      

        public void WaitUntil(Func<IWebDriver, bool> isTrue, string message = "", int timeout = -1)
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(this.TimeOut(timeout)));
                wait.Until(delegate { return this.SafeIsTrue(isTrue); });
            }
            catch (Exception)
            {
                //this.Log(message);
                throw new Exception("The page is not loaded!!");
            }
        }

        private bool SafeIsTrue(Func<IWebDriver, bool> isTrue)
        {
            try
            {
                return isTrue.Invoke(Driver);
            }
            catch (Exception)
            {
                throw new Exception("Safe is not true!!??");
            }
        }
        private int TimeOut(int timeout)
        {
            return timeout != -1 ? timeout : this.TIMEOUT_SEC;
        }
    }
}
