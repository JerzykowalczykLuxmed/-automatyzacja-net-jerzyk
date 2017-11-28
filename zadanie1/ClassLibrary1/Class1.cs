﻿using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace SeleniumTests
{
    public class Example : IDisposable
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool AcceptNextAlert = true;

        public Example()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseURL = "https://www.google.pl/";
            verificationErrors = new StringBuilder();
                     
        }



        [Fact]
        public void TheExampleTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("lst-ib")).Clear();
            driver.FindElement(By.Id("lst-ib")).SendKeys("code sprinters");
            driver.FindElement(By.Id("lst-ib")).Submit();
            driver.FindElement(By.LinkText("Code Sprinters -")).Click();
            var element = driver.FindElement(By.LinkText("Poznaj nasze podejście"));
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=@color | ]]
            //Assert.AreEqual("Code Sprinters -", driver.Title);
            Assert.NotNull(element);
            driver.FindElement(By.LinkText("Szkolenia")).Click();
            Console.ReadKey();
        }
        //private bool IsElementPresent(By by)
        //{
        //    try
        //    {
        //        driver.FindElement(by);
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //}

        //private bool IsAlertPresent()
        //{
        //    try
        //    {
        //        driver.SwitchTo().Alert();
        //        return true;
        //    }
        //    catch (NoAlertPresentException)
        //    {
        //        return false;
        //    }
        //}

        //private string CloseAlertAndGetItsText()
        //{
        //    try
        //    {
        //        IAlert alert = driver.SwitchTo().Alert();
        //        string alertText = alert.Text;
        //        if (acceptNextAlert)
        //        {
        //            alert.Accept();
        //        }
        //        else
        //        {
        //            alert.Dismiss();
        //        }
        //        return alertText;
        //    }
        //    finally
        //    {
        //        acceptNextAlert = true;
        //    }
        //}

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.Equal("", verificationErrors.ToString());
        }
    }
}