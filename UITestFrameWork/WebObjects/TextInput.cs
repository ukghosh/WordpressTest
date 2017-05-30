using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UITestFrameWork.WebObjects
{
   public class TextInput : WebObject
    {
       
        public TextInput(By by, string name = "", string comment = "") : base(by, name, comment)
        {
        }

        public string GetValue()
        {
            return this.FindElement().GetAttribute("value");
        }

        public virtual void SetValue(string value)
        {
            this.DriverContext.WaitUntil(
                isTrue => (this.Displayed && this.Enabled),
                "TextInput should be Displayed and Enabled");

            

            IWebElement element = this.FindElement();
            element.Clear();
            element.SendKeys(value);
            element.SendKeys(Keys.Tab);
        }

    }
}
