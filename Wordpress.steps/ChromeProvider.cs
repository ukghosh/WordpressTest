using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Wordpress.steps
{
    public class ChromeProvider : IDriverProvider
    {
        
        public IWebDriver GetDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            //options.AddUserProfilePreference("download.default_directory", @"C:\\selenium");
            //options.AddUserProfilePreference("download.prompt_for_download", false);
            ChromeDriver driver = new ChromeDriver(options);
            return driver;
        }
    }
}
