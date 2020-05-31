using System;
using OpenQA.Selenium;

namespace TurnupNunitMay20
{
    internal class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void clickAdminstration()
        {
            // click admin & click time and material
            driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Click();
        }

        internal void clickTimenMaterials()
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
        }
    }
}