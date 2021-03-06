﻿using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace UITestFrameWork
{
    public class IEProvider : IDriverProvider
    {
        public IWebDriver GetDriver()
        {
            // NOTE: Protected Mode must be set to the same value (enabled or disabled) for all zones.
            // GoTo Internet Options. Click Security Tab. Check or Uncheck "Enable Protected Mode" for all Internet, Local Intranet, Trusted Sites and Restricted Sites.
            var driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            return driver;
        }
    }
}
