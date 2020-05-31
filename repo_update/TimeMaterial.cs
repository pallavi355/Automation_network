using System;
using System.Data;
using System.Security.Cryptography;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TurnupNunitMay20
{
    internal class TimeMaterial
    {
        IWebDriver driver;
        public TimeMaterial(IWebDriver driver)
        {
            this.driver = driver;
        }



        internal void clickCreateNew()
        {
            //checking the text of  drag a column header and drop it here to group bt that column  
            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[1]")).Text, Is.EqualTo(" "));
            //click create and new button
            try
            {
                IWebElement createNew = driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
                createNew.Click();
            }
            catch (Exception message)
            {

                Console.WriteLine(message.ToString());
                Assert.Fail();

            }
        }


        internal void CreateNewRecord(string code, string Description)
        {
            //check the text of element back to list means we are on Time and material page 

            Assert.That(driver.FindElement(By.XPath("//*[@id='container']/div/a")).Text, Is.EqualTo("Back to List"));
            NewRecord(code, Description);

        }

        internal void EditNewRecord()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

            IWebElement code = driver.FindElement(By.Id("Code"));
            code.Clear();
            code.SendKeys("777");


            Thread.Sleep(1000);
            //find Description textbox and write description
            string descriptionInput = "hello";

            IWebElement description = driver.FindElement(By.Id("Description"));
            description.Clear();
            description.SendKeys(descriptionInput);
            IWebElement price = driver.FindElement(By.CssSelector("input.k-formatted-value.k-input"));
            price.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string script = "return document.getElementById(\"Price\").value = 2020;";
            js.ExecuteScript(script);

        }

        internal void DeleteNewRecord()
        {
            Thread.Sleep(2000);
            // //*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[5]/a[2]
            driver.FindElement(By.LinkText("Delete")).Click();
            IAlert alert = driver.SwitchTo().Alert();

            String alertmessage = alert.Text;


            if (alertmessage.Equals("Are you sure you want to delete this record ? "))
            {

                Console.WriteLine("correct msg");
            }
            else
            {
                Console.WriteLine("incorrect msg");
            }
            alert.Accept();


        }
        public void GoToLastPage()
        {
            
            IWebElement lastPageBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(1500);
            lastPageBtn.Click();
            
        }
        public void GoToPreviousPage()
        {
            IWebElement lastPageBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[2]/span"));
            Thread.Sleep(1500);
            lastPageBtn.Click();

        }

        private void NewRecord(string code, string Description)
        {
            //Find Code button
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys(code);
            //Find description button and entering value//
            //IWebElement saveButton = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            //saveButton.Click();
            //// the description field is required
            //try
            //{
            //    Assert.AreEqual("", driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[3]/div/span")).Text);

            //    Console.WriteLine("assertion pass");

            //}
            //catch (Exception e)
            //{

            //    Console.Write(e);
            //}
            Thread.Sleep(1500);
            IWebElement Description1 = driver.FindElement(By.XPath("//input[contains(@id,'Description')]"));
           
            Description1.SendKeys(Description);
            //IWebElement price = driver.FindElement(By.CssSelector("input.k-formatted-value.k-input"));
            //price.Click();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //string script = "return document.getelementbyid(\"price\").value = 2020;";
            //_ = js.ExecuteScript(script);

            IWebElement saveButton1 = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            saveButton1.Click();
        }
        //this method validates rows of a page

        //this method validates newly added row starting from last page and then going to previous pages
        //internal void validatenewrecord(string code, string description)
        //{
        //    Thread.Sleep(1000);
            
            
        //    GoToLastPage();
        //    // wait for 1 second
        //    //thread.sleep(1000);

        //    try
        //    {
        //        while (true)
        //        {
        //            validaterows(code, description);
        //            break;
        //        }
        //        //click previous page

        //        GoToPreviousPage();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("test failed");
        //    }

        //}

        //this method validates rows of a page
        //internal void validateRecord()
        //{
        //    Thread.Sleep(1500);
        //    //IWebElement lastbtn = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']")).Click();
           
        //    //iterate through rows
        //    for (var i = 1; i <= 10; i++)
        //    {
        //        //driver.SwitchTo.("stylesheet");
        //        var testcode = driver.FindElement(By.XPath("//td[@role='gridcell'][contains(.,'jjj')]")).Text;
        //                                                   // var testcode = driver.FindElement(By.XPath("//*[@id=\"tmsgrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
        //                                                   // Console.WriteLine(testcode.Text);
        //                                                   // driver.SwitchTo.frame("stylesheet");

        //          var testDescription = driver.FindElement(By.XPath("//td[@role='gridcell'][contains(.,'777')]")).Text;
        //       // var testdescription = driver.FindElement(By.XPath("//*[@id=\"tmsgrid\"]/div[3]/table/tbody/tr[" + i + "]/td[3]")).Text;

        //        // logic to compare the one we wanted
        //        if (testcode == "jjj" && testDescription == "777")
        //        {
        //            Console.WriteLine("test passed");
        //            break;
        //        }
        //    }
        //}
        ////This method validates the edited record
        //internal void ValidateEditRecord(string code, string Description)
        //{
        //    // Wait for 1 second
        //    Thread.Sleep(1000);

        //    try
        //    {
        //        while (true)
        //        {
        //            validateRows(code, Description);
        //            break;
        //        }
        //        //GoToNextPage();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Test Failed");
        //    }
        //}

       // internal void ValidateRecord()
        //{
        //    // Wait for 1 second
        //    Thread.Sleep(1000);
        //    try
        //    {
        //        while (true)
        //        {
        //            // what;t the count
        //            for (var i = 1; i <= 10; i++)
        //            {
        //                var code1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
        //                //Console.WriteLine(code.Text);

        //                var testDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[3]")).Text;

        //                // logic to compare the one we wanted
        //                // Assert.That(code1, Is.EqualTo("code"));
        //                // Assert.That(testDescription, Is.EqualTo("Description"));

        //                if (code1== "ck" && testDescription == "doc1")
        //                {
        //                    Console.WriteLine("test passed");
        //                    return;
        //                }
        //            }
        //            //click next page
        //            driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Test Failed");
        //    }


    }
}
