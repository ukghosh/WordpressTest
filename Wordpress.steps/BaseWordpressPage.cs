using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using UITestFrameWork;

namespace Wordpress.steps
{
    public class BaseWordpressPage
    {
        protected Dependencies Test;
        public int TIMEOUT_SEC;

        public BaseWordpressPage(Dependencies test)
        {
            this.Test = test;
            this.TIMEOUT_SEC = 20;
        }


        public virtual bool IsLoaded()
        {
            return true;
        }

        public bool SafeIsLoaded()
        {
            try
            {
                return IsLoaded();
            }
            catch
            {
                throw new Exception("IsLoaded is successful!!??");
            }
        }

        public void GoLive(string message = "", int timeout = -1)
        {
           DriverContext.Current.WaitUntil(istrue => SafeIsLoaded(), message, timeout);

        }

      

        private bool SafeIsTrue(Func<IWebDriver, bool> isTrue)
        {
            try
            {
                return isTrue.Invoke(this.Test.Driver);
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
