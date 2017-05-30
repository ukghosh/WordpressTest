using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UITestFrameWork.WebObjects;

namespace UITestFrameWork
{
    public class CheckBox : WebObject
    {


        public CheckBox(By by, string name = "", string comment = "") : base(by, name, comment)
        {

        }

        public void Clear()
        {
            if (this.Checked)
            {
                this.Click();
                this.JS.ExecuteScript("arguments[0].checked=flase;", this.FindElement());
            }
        }

        public void Set()
        {
            if (!this.Checked)
            {
                this.Click();
                this.JS.ExecuteScript("arguments[0].checked=true;", this.FindElement());
            }
        }
    }
}
