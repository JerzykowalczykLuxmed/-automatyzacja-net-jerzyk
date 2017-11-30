using System;

namespace PageObjectTests
{
    internal class NotePage
    {
        internal static void AddComment(Comment testdata)
        {
            var commentBox = Browser.FindElementById("comment");
            commentBox.Click();
            commentBox.SendKeys(testdata.Text);

            var email = Browser.FindElementById("email");
            email.Click();
            email.SendKeys(testdata.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']");
            var name = Browser.FindElementById("author");
            name.Click();
            name.SendKeys(testdata.User);

            var submit = Browser.FindElementById("Comment-submit");
            submit.Click();
        }
    }
}