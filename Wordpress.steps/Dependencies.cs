using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordpress.steps.PageObjects;

namespace Wordpress.steps
{
    public class Dependencies
    {
        private static Dependencies _context;       
        

        // private keyword in the Constructor - Prevents creating a new instance of this class from outside of this class
        private Dependencies()
        {
            this.WordpressHome = new WordPressHome(this);
            this.LoginForm = new LoginPage(this);
        }

        //the created new instance is accessed by this property 
        public static Dependencies Inject { get { return _context; } }

        public WordPressHome WordpressHome { get; private set; }
        public LoginPage LoginForm { get; private set; }

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
            if (_context != null)
            {
                throw new Exception("The Dependencies instance is not null!!");
            }
            _context = new Dependencies();

        }

        public static void Release()
        {
            _context = null; 
        }

    }
}
