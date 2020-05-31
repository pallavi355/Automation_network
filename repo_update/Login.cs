using System;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using OpenQA.Selenium;
using TurnupNunitMay20.Helpers;

namespace TurnupNunitMay20
{
    internal class Login
    {
        private IWebDriver driver;

        IWebElement UserName => driver.FindElement(By.Id("UserName"));
        IWebElement Password => driver.FindElement(By.Name("Password"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//input[@type='submit']"));

        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void LoginSuccess()
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
//to check title of the page
            try
            {

                Assert.AreEqual("Log In - Dispatching System", driver.Title);
                Console.WriteLine("assertion pass");

            }
            catch (Exception e)
            {

                Console.Write(e);
            }

            Console.WriteLine("the title is" + driver.Title);
           // WaitHelper.ForElement(By.Id("UserName"), driver, TimeSpan.FromSeconds(10));

            // enter hari as username
            UserName.SendKeys("hari");
            
            //clicked login btn
           
            LoginBtn.Click();

           // to check without entering password and press login it shows the password is required field
            Assert.AreEqual(driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[2]/div/span")).Text, "The Password field is required.");
            Console.WriteLine("test completed");
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

