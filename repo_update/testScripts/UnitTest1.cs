using System;
using System.Resources;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using turnuppp.baseclass;

namespace TurnupNunitMay20
{
    public class Tests :BaseClass
    {
        
      
        [Test]
        [TestCaseSource(typeof(TestDataClass), "TestCases")]
        

        public void CreateAndValidate(string code, string Description)
        {
            // Creating an instance of home page
            var homePage = new Home(driver);
            homePage.clickAdminstration();
            homePage.clickTimenMaterials();

            
            TimeMaterial timeMaterial = new TimeMaterial(driver);
            timeMaterial.clickCreateNew();
            
            timeMaterial.CreateNewRecord(code,Description);
            //Thread.Sleep(3000);
           
           
            timeMaterial.validateRecord();

        }

        [Test]
        public void EditnValidate(string code, string Description)
        {
            // Creating an instance of home page
            var homePage = new Home(driver);
            homePage.clickAdminstration();
            homePage.clickTimenMaterials();

            TimeMaterial timeMaterial = new TimeMaterial(driver);
            timeMaterial.EditNewRecord();
           // timeMaterial.ValidateRecord();

        }
        [Test]
        public void deleteRecord()
        {
            var homePage = new Home(driver);
            homePage.clickAdminstration();
            homePage.clickTimenMaterials();
            TimeMaterial timeMaterial = new TimeMaterial(driver);

            timeMaterial.DeleteNewRecord();

        }
    }
}