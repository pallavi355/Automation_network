using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TurnupNunitMay20;
using turnuppp.Customthd;
using System.Linq;

namespace turnuppp.Customthd
{
   public class module1
    {
        IWebDriver driver = new ChromeDriver();


    

        
            [Test]


            public void Execute()
        {

            var loginpage = new Login(driver);
            loginpage.LoginSuccess();

            var homePage = new Home(driver);
            homePage.clickAdminstration();
            homePage.clickTimenMaterials();


            TimeMaterial timeMaterial = new TimeMaterial(driver);
            timeMaterial.clickCreateNew();


            Thread.Sleep(2000);
            
                seleniumsetmethod.EnterText(driver, "Code", "111", "Id");

            Console.WriteLine("the code is   " + seleniumGetMethod.GetText(driver, "Code", "Id"));

            seleniumsetmethod.EnterText(driver, "Description", "testing", "Id");

            Console.WriteLine("the description is   " + seleniumGetMethod.GetText(driver, "Description", "Id"));


            seleniumsetmethod.Click(driver, "SaveButton", "Id");

           
        }

    } 
}
