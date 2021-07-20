using IntroToWebAPIs.Models;
using System.Web.Http;

namespace IntroToWebAPIs.Controllers
{
    public class BooksController : ApiController
    {
        // GET Primitve Paremetrs (int, string, double....etc)
        // add coments
        public string GetBook(int numberOfPages, [FromBody]string title)
        {
            return string.Format("Title = {0}: Numder Of Page = {1}", title, numberOfPages);
        }

        // Post Primitve Paremetrs (int, string, double....etc)

        public string PostBook([FromUri]string title, int numberOfPages)
        {
            return string.Format("Title = {0}: Numder Of Page = {1}", title, numberOfPages);
        }

        // GET Complex Paremetrs 
        public string GetBook(Book book)
        {
            return string.Format("Title = {0}: Numder Of Page = {1}", book.Title, book.NumberOfPages);
        }

        //POST Complex Paremetrs 
        public string PostBook(Book book)
        {
            return string.Format("Title = {0}: Numder Of Page = {1}", book.Title, book.NumberOfPages);
        }

        // GET Complex and primitiv Paremetrs 
        public string GetBook(Book book, string author)
        {
            return string.Format("Title = {0}: Numder Of Page = {1}: Author={2}", book.Title, book.NumberOfPages,author);
        }

        // Post Complex and primitiv Paremetrs 
        public string PostBook(Book book, string author)
        {
            return string.Format("Title = {0}: Numder Of Page = {1}: Author={2}", book.Title, book.NumberOfPages, author);
        }


        // [FromBody]  [FromUri]
    }
}