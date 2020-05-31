using System;
using OpenQA.Selenium;

namespace TurnupMay20
{
    public class Login
    {
        private IWebDriver driver; 
             
        public Login(IWebDriver driver)
        {
            this.driver = driver; 
        }
        
        IWebElement UserName => driver.FindElement(By.Id("UserName"));
        IWebElement Password => driver.FindElement(By.Name("Password"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//input[@type='submit']"));


        public void LoginSuccess()
        {            
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // enter hari as username
            UserName.SendKeys("hari");
            //identfying password & sending password
            Password.SendKeys("123123");
            //clicked login btn
            LoginBtn.Click();
        }

        public void LoginFailure()
        {
            //Identify username
            // enter hari as username
            UserName.SendKeys("hari");

            //identfying password & sending password
            Password.SendKeys("123123");
        }
    }
}
