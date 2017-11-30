using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTests
{
    class LoginPage
    {
            private static string url = "https://autotestdotnet.wordpress.com/wp-admin/";
            private static string user = "autotestdotnet@gmail.com";
            private static string pass = "P@ssw0rd1";

            internal static void Open()
            {
                Browser.NavigateTo(url);
            }

            internal static void LogIn()
            {
                var logInField = Browser.FindByXpath("//*[@name='usernameOrEmail']").First();
                logInField.Click();
                logInField.SendKeys(user);
                var passField = Browser.FindByXpath("//*[@name='password']").First();
                passField.Click();
                passField.SendKeys(pass);
                var LogInButon = Browser.FindByXpath("//button[contains(text(),'Log In')]").First();
                LogInButon.Click();
            }
        
    }
}
