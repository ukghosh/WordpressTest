using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UITestFrameWork.WebObjects
{
    public class WebObject
    {
        //public IWebDriver Driver
        //{
        //    get
        //    {
        //        return DriverContext.Driver;
        //    }
        //}
        public DriverContext DriverContext => DriverContext.Current;
        public IWebDriver Driver => DriverContext.Driver;
        private By by;
        private string name;
        private string comment;

        //public WebObject()
        //{

        //}

        public WebObject(By by, string name = "", string comment ="" ) 
        {
            this.by = by;
            this.name = name;
            this.comment = comment;
        }

        protected IJavaScriptExecutor JS
        {
            get
            {
                return this.Driver as IJavaScriptExecutor;
            }
        }

        public bool Checked
        {
            get
            {
                try
                {
                    return this.FieldExists()
                      && (bool)this.JS.ExecuteScript("return arguments[0].checked;", this.FindElement());
                }
                catch (FieldAmbiguousException)
                {
                    throw;
                }

                catch (Exception)
                {

                    return false;
                }
               
            }
        }


        public bool Displayed
        {
            get
            {
                try
                {
                    return this.FieldExists() && this.FindElement().Displayed;
                }
                catch (FieldAmbiguousException)
                {
                    throw;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Enabled
        {
            get
            {
                try
                {
                    return this.FieldExists() && this.FindElement().Enabled;
                }

                catch (FieldAmbiguousException)
                {
                    throw;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        public void Click(string message = "", int timeout = -1, int delay = 500)
        {
            this.DriverContext.WaitUntil(isTrue => (this.Displayed && this.Enabled), message, timeout);
            IWebElement element = this.FindElement();

            // Message need to be put before action, otherwise, object may be changed
            //this.DriverContext.ReportLowStep("Click on", element.Text);

            var builder = new Actions(this.Driver);
            builder.MoveToElement(element).Click().Perform();

            /*
            builder.Perform();
            Thread.Sleep(delay);
            el.Click();
             */
        }

        public IWebElement FindElement()
        {
            return this.Driver.FindElement(this.by);
        }

        public ReadOnlyCollection<IWebElement> FindElements()
        {
            return this.Driver.FindElements(by); 
        }


        // Should only contain an unique element
        private bool FieldExists()
        {
            ReadOnlyCollection<IWebElement> list = this.FindElements();
            if (list.Count > 1)
            {
                throw new FieldAmbiguousException();
            }

            return list.Count == 1;

        }

       

       
    }
}
