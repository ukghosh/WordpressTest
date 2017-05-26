using OpenQA.Selenium;
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
        public IWebDriver Driver => DriverContext.Driver;
        private By by;
        private string name;
        private string comment;
        private readonly IWebElement Element;

        public WebObject(By by, string name = "", string comment ="" ) 
        {
            this.by = by;
            this.name = name;
            this.comment = comment;
        }

        public IWebElement FindElement()
        {
            return this.Driver.FindElement(this.by);
        }
        public ReadOnlyCollection<IWebElement> FindElements()
        {
            return this.Driver.FindElements(by) == null
                       ? this.Driver.FindElements(this.by)
                       : new ReadOnlyCollection<IWebElement>(this.ElementAsList());
        }

        private IList<IWebElement> ElementAsList()
        {
            var list = new List<IWebElement> { this.Element };
            return list;
        }

        private bool FieldExists()
        {
            try
            {
                ReadOnlyCollection<IWebElement> list = this.FindElements();
                return list.Count == 1;
            }
            catch (Exception)
            {

                throw new Exception("Element may not be unique??!!");
            }
            
        }
    }
}
