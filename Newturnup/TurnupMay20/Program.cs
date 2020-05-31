using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TurnupMay20
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // open a browser
            IWebDriver driver = new ChromeDriver();

            //Creating instance of Login Page
            var loginPage = new Login(driver);
            loginPage.LoginSuccess();

            // Creating an instance of home page
            var homePage = new Home(driver);
            homePage.clickAdminstration();
            homePage.clickTimenMaterials();


            TimeMaterial timeMaterial = new TimeMaterial(driver);
            //timeMaterial.clickCreateNew();
            //timeMaterial.CreateNewRecord();
            //timeMaterial.EditNewRecord();
            timeMaterial.DeleteNewRecord();
            //timeMaterial.ValidateRecord();      

            driver.Quit();

        }
    }
}
