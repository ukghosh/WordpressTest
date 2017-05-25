using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress.steps.PageObjects
{
   public class LoginPage : BaseWordpressPage
    {
        IWebElement userName;
        IWebElement password;
        IWebElement loginButton;
        public LoginPage(Dependencies test) : base(test)
        {
            
            

        }

        public override bool IsLoaded()
        {
            userName = Test.Driver.FindElement(By.Id("user_login"));
            password = Test.Driver.FindElement(By.Id("user_pass"));
            loginButton = Test.Driver.FindElement(By.Id("wp-submit"));
            return userName.Displayed && password.Displayed && loginButton.Displayed;
        }

        public void Login()
        {
            EnterCredentials();
            clickLogin();
        }

        private void EnterCredentials()
        {
            userName = Test.Driver.FindElement(By.Id("user_login"));
            password = Test.Driver.FindElement(By.Id("user_pass"));
            userName.SendKeys("ujjwalsblogblog");
            password.SendKeys("Bruteforce71");
        }

        private void clickLogin()
        {
          
                loginButton = Test.Driver.FindElement(By.Id("wp-submit"));
                loginButton.Click();           
            
        }

    
    }
}
