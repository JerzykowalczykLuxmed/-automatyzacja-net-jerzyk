﻿using System;
using System.Linq;
using Xunit;

namespace PageObjectTests
{
    internal class NotePage
    {
        internal static void AddComment(Comment testdata)
        {
            var commentBox = Browser.FindElementById("comment");
            commentBox.Click();
            commentBox.SendKeys(testdata.Text);

            var emailLabel = Browser.FindByXpath("//label[@for='email']").First();
            emailLabel.Click();


            var email = Browser.FindElementById("email");
            email.Click();
            email.SendKeys(testdata.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']").First();
            nameLabel.Click();

            var name = Browser.FindElementById("author");
            name.SendKeys(testdata.User);

            var submit = Browser.FindElementById("comment-submit");
            submit.Click();
        }

                public static void AssertCommentText(Comment comment)
        {
            Assert.Contains(comment.Text, Browser.ReturnPageSource());
        }
        internal static void AddCommentToExist(object comment2)
        {
            throw new NotImplementedException();
        }
    }
}