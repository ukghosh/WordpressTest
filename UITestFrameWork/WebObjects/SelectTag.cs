using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITestFrameWork.WebObjects
{
    public class SelectTag : WebObject
    {
        Object passedType;
        string text;
        string value;
        int index;
        public SelectTag(By by, string name = "", string comment = "") : base(by, name, comment)
        {
        }

        //public bool Select(Object passedType)
        //{          
        //        if (passedType.Equals(text))
        //        {
        //            new SelectElement(this.FindElement()).SelectByText(text);
        //        return true;
        //        }
                
        //        else if (passedType.Equals(value))
        //        {
        //            new SelectElement(this.FindElement()).SelectByValue(value);
                    
        //        }
        //       else if (passedType.Equals(index))
        //        {
        //            new SelectElement(this.FindElement()).SelectByIndex(index);
                    
        //        }
           
        //    return true;

        //}


        public void SelectByText(string text)
        {
            this.DriverContext.WaitUntil(delegate { return TrytoSelectByText(text); });
        }

        public void SelectByValue(string value)
        {
            this.DriverContext.WaitUntil(delegate { return TrytoSelectByValue(value); });
        }

        public bool TrytoSelectByText(string text)
        {
            try
            {
                new SelectElement(this.FindElement()).SelectByText(text);
                return true;
            }
            //catch (FieldAmbiguousException)
            //{
            //    throw;
            //}
            catch (Exception)
            {

                return false;
            }
        }

        public bool TrytoSelectByValue(string value)
        {
            try
            {
                new SelectElement(this.FindElement()).SelectByText(value);
                return true;
            }
            //catch (FieldAmbiguousException)
            //{
            //    throw;
            //}
            catch (Exception)
            {

                return false;
            }
        }
    }
}
