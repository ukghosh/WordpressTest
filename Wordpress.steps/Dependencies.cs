using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestFrameWork;
using UITestFrameWork.Logs;
using UITestFrameWork.Reports;
using Wordpress.steps.PageObjects;

namespace Wordpress.steps
{
    public class Dependencies
    {
        private static Dependencies _context;       
        


        // private keyword in the Constructor - Prevents creating a new instance of this class from outside of this class
        //Singleton Design pattern 
        private Dependencies()
        {
            this.WordpressHome = new WordPressHome(this);
            this.LoginForm = new LoginPage(this);
            this.Report = new TestReport();
            this.Logger = new Log4NetLogger();
        }

        //the created new instance is accessed by this property 
        public static Dependencies Inject { get { return _context; } }

        public WordPressHome WordpressHome { get; private set; }
        public LoginPage LoginForm { get; private set; }
        public TestReport Report { get; private set; }        
        public ITestLog Logger;

        public IWebDriver Driver
        {
            get
            {
                return DriverContext.Driver;
            }
        }

        //instance of the class is created here
        public static void New()
        {
           
            _context = new Dependencies();

        }

        public static void Release()
        {
            _context = null; 
        }

    }
}
