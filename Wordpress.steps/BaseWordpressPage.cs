using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            WaitUntil(istrue => SafeIsLoaded(), message, timeout);
           
        }

        public void WaitUntil(Func<IWebDriver, bool> isTrue, string message = "", int timeout = -1)
        {
            try
            {
                var wait = new WebDriverWait(this.Test.Driver, TimeSpan.FromSeconds(this.TimeOut(timeout)));
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
