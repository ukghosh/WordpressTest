using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UITestFrameWork.WebObjects
{
    public class RadioButton : WebObject
    {
        public RadioButton(By by, string name = "", string comment = "") : base(by, name, comment)
        {
        }

        public bool Selected { get { return this.FindElement().Selected; } }

        public void Set()
        {
            this.Click();
            this.DriverContext.WaitUntil(isTrue => this.Selected);
        }
    }
}
