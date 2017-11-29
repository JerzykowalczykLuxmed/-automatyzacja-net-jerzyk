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
            MainPage.Open();
            MainPage.OpenFirsNote();

            // + wejdz na stronę bloga
            // + otwórz pierwszą notkę
            //dodaj komentarz
            //sprawdź, że komentarz się dodał
        }
        public void Dispose()
        {
            Browser.Close();
        }
    }
}
