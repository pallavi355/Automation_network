using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace turnuppp.Customthd
{
    public class seleniumGetMethod
    {

        public static string GetText(IWebDriver driver,string element,string elementtype)
        {

            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");

            if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;

        }
        public static string Click(IWebDriver driver, string element, string elementtype)
        {

            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).Text;

            if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).Text;
            else return String.Empty;

        }


    }



}
