using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Wordpress.steps
{
    public class FirefoxProvider : IDriverProvider
    {
        public IWebDriver GetDriver()
        {
            var driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
