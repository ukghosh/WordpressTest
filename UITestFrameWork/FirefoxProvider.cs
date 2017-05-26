using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UITestFrameWork
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
