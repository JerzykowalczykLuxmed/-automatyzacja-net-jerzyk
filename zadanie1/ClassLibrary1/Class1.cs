using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit;
using OpenQA.Selenium.Chrome;
using System.Linq;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Collections.Generic;

namespace SeleniumTests
{
    public class SeleniumExample : IDisposable
    {
        private const string SearchTextBoxId = "lst-ib";
        private const string Google = "https://www.google.com";
        private const string   = "Code Sprinters -";
        private const string TextToSearch = "code sprinters";
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private const string LinkTextToFind = "Poznaj nasze podejście";
        private const string CookiePolicyButtonText = "Akceptuję";
        
        public SeleniumExample()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts()
                .ImplicitWait = TimeSpan.FromMilliseconds(100);
            verificationErrors = new StringBuilder();
        }

        [Fact]
        public void NavigatingToCodeSprintersSite()
        {
            GoToGoogle();
            Search(TextToSearch);
            GoToSearchResultByPageTitle(PageTitle);


            // var element = driver.FindElement(By.LinkText("Poznaj nasze podejście"));
            // Assert.NotNull(element);

            

            AcceptCookiePolicy();
            GoToNextPage(LinkTextToFind);

            // ver 1
            Assert.Contains("WIEDZA NA PIERWSZYM MIEJSCU", driver.PageSource);


            // ver 2
            Assert.Single(driver.FindElements(By.TagName("h2"))
                .Where(tag => tag.Text == "WIEDZA NA PIERWSZYM MIEJSCU"));


        }

        private void GoToNextPage(string nextpage)
        {
            Assert.Single(GetElements(nextpage));
            WaitForClickable(By.LinkText(nextpage), 5);
            driver.FindElement(By.LinkText(nextpage)).Click();
        }

        private void AcceptCookiePolicy()
        {
            By CookiePolicyButtonLocator = By.LinkText(CookiePolicyButtonText);
            driver.FindElement(CookiePolicyButtonLocator).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));
            wait.Until(ExpectedConditions.InvisibilityOfElementWithText(CookiePolicyButtonLocator, CookiePolicyButtonText));

        }

        private IReadOnlyCollection<IWebElement> GetElements(string text)
        {
            return driver.FindElements(By.LinkText(text));
        }

        private void Search(string query)
        {
            var searchBox = GetSearchBox();
            searchBox.Clear();
            searchBox.SendKeys(query);
            searchBox.Submit();
        }

        private void GoToSearchResultByPageTitle(string title)
        {
            driver.FindElement(By.LinkText(title)).Click();
        }

        private void GoToGoogle()
        {
            driver.Navigate().GoToUrl(Google);
        }

        private IWebElement GetSearchBox()
        {
            return driver.FindElement(By.Id(SearchTextBoxId));
        }

        protected void WaitForClickable(By by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected void waitForElementPresent(IWebElement by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }


        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
            }
            Assert.Equal("", verificationErrors.ToString());
        }
    }
}