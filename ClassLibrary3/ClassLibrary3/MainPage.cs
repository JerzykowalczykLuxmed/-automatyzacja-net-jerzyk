using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace PageObjectTests
{
    internal class MainPage
    {
        private static string url = "https://autotestdotnet.wordpress.com/";

        internal static void Open()
        {
            Browser.NavigateTo(url);
        }

        internal static void OpenFirsNote()
        {
            var element = Browser.FindByXpath("//article/header");
            element.First().Click();
        }
        internal static void OpenNewPost()
        { 
            var element = Browser.FindByXpath("//div[text() = 'Posts']").First();
        element.Click();

        
        }
    }
}