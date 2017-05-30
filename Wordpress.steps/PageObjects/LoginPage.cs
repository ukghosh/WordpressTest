using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestFrameWork.WebObjects;

namespace Wordpress.steps.PageObjects
{
   public class LoginPage : BaseWordpressPage
    {
        TextInput userName;
        TextInput password;
        IWebElement loginButton;
        public LoginPage(Dependencies test) : base(test)
        {
            userName = new TextInput(By.Id("user_login"));
            password = new TextInput(By.Id("user_pass"));
            //loginButton = Test.Driver.FindElement(By.Id("wp-submit"));

        }

        public override bool IsLoaded()
        {           
            
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
           
            userName.SetValue("ujjwalsblogblog");
            password.SetValue("password@1");
        }

        private void clickLogin()
        {          
                loginButton = Test.Driver.FindElement(By.Id("wp-submit"));
                loginButton.Click();           
            
        }

    
    }
}
