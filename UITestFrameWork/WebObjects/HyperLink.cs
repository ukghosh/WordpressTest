using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UITestFrameWork.WebObjects
{
    public class HyperLink : WebObject
    {
        public HyperLink(By by, string name = "", string comment = "") : base(by, name, comment)
        {

        }


    }
}
