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

        public LoginPage(Dependencies test) : base(test)
        {

        }

        public override bool IsLoaded()
        {
            return false;
        }

        public void Login()
        {
            EnterCredentials();
            clickLogin();
        }

        private void EnterCredentials()
        {
            var userName = Test.Driver.FindElement(By.Id("user_login"));
            var password = Test.Driver.FindElement(By.Id("user_pass"));
            userName.SendKeys("ujjwalsblogblog");
            password.SendKeys("Bruteforce71");
        }

        private void clickLogin()
        {
            if (IsStaySignedInChecked())
            {
                var loginButton = Test.Driver.FindElement(By.Id("wp-submit"));
                loginButton.Click();
            }  
            
        }

        private bool IsStaySignedInChecked()
        {
            var staySignedIn = Test.Driver.FindElement(By.Name("rememberme"));
            if (staySignedIn.Enabled)
            {
                staySignedIn.Click();
            }
            return !staySignedIn.Enabled;            
            
        }
    }
}
