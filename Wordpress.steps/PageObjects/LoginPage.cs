using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestFrameWork;
using UITestFrameWork.WebObjects;

namespace Wordpress.steps.PageObjects
{
   public class LoginPage : BaseWordpressPage
    {
        TextInput userName;
        TextInput password;
        CheckBox staySignedIn;
        IWebElement loginButton;
        public LoginPage(Dependencies test) : base(test)
        {
            userName = new TextInput(By.Id("user_login"));
            password = new TextInput(By.Id("user_pass"));
            staySignedIn = new CheckBox(By.Id("rememberme"));
            //loginButton = Test.Driver.FindElement(By.Id("wp-submit"));

        }

        public override bool IsLoaded()
        {           
            
            loginButton = Test.Driver.FindElement(By.Id("wp-submit"));
            return userName.Displayed && password.Displayed && loginButton.Displayed;
        }

        public void Login()
        {
            Test.Report.NewStep("Log in");
            EnterCredentials();
            clickLogin();
           
        }

        private void EnterCredentials()
        {
            var userNametoType = "ujjwalsblogblog";
            var passwordToType = "password@1";
            Test.Report.Log($"userName:  {userNametoType}");
            userName.SetValue(userNametoType);
            password.SetValue(passwordToType);
        }

        private void clickLogin()
        {
                UnCheckStaySignedIn(); 
                loginButton = Test.Driver.FindElement(By.Id("wp-submit"));
                loginButton.Click();           
            
        }

        public void UnCheckStaySignedIn()
        {
            if (IsStaySignedInChecked())
            {
                staySignedIn.Click();
            }
        }
         
        private bool IsStaySignedInChecked()
        {
            if (!staySignedIn.Checked)
            {
                return false;
            }
            return true;
        }
    
    }
}
