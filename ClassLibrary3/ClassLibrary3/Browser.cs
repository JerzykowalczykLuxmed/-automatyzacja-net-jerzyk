using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Firefox;

namespace PageObjectTests
{
    internal class Browser
    {
        private static IWebDriver _driver;

        internal static IWebElement FindElementById(string id)
        {
            return _driver.FindElement(By.Id(id));
        }

        internal static object FindElement(object p)
        {
            throw new NotImplementedException();
        }

        static Browser()
        {

            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        internal static void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
        
        internal static void Close()
        {
            _driver.Quit();
        }
        internal static ReadOnlyCollection<IWebElement> FindByXpath(string xpath)
        {
            return _driver.FindElements(By.XPath(xpath));
        }
        internal static string ReturnPageSource()
        {
            string pagesource = _driver.PageSource;
            return pagesource;
        }

    }
}