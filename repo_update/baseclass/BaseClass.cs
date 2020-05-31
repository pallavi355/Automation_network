using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TurnupNunitMay20;
using TurnupNunitMay20.Helpers;

namespace turnuppp.baseclass
{
    public class BaseClass
    {


        public IWebDriver driver = new ChromeDriver();
       // [OneTimeSetUp]
        [SetUp]

        public void openBrowser()
        {
            // open a browser
            driver = new ChromeDriver();
            var loginpage = new Login(driver);
            loginpage.LoginSuccess();



        }
       // [OneTimeTearDown]
        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
