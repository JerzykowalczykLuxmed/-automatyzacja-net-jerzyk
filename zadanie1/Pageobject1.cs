using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PageObjectTests
{
    public class AddingBlogCommentTest: IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            var comment = new Comment
            {
                Text = Guid.NewGuid().ToString(),
                Mail = "test@mail.pl",
                User = "Jerzy Testowy"
            };
            MainPage.Open();
            MainPage.OpenFirsNote();
            NotePage.AddComment(comment);
            NotePage.AssertCommentText(comment);
            //NotePage.AddCommentToExist(comment2);
            

            // + wejdz na stronę bloga
            // + otwórz pierwszą notkę
            // + dodaj komentarz
            // + sprawdź, że komentarz się dodał
            // dodaj komentarz do komentarza
        }
        [Fact]
        public void AddPostToAdminPanel()
        {
            var post = new Post
            {
                Title = "Testowy tytuł",
                Text = "Kilka słów od administratora"
             };
            LoginPage.Open();
            LoginPage.LogIn();
            AddPostToAdm.AddPost();

        }
        public void Dispose()
        {
            Browser.Close();
        }
    }
    
      
}
