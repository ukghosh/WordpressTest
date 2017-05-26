using OpenQA.Selenium;

namespace UITestFrameWork
{
  public interface IDriverProvider
    {
        IWebDriver GetDriver();
    }
}
