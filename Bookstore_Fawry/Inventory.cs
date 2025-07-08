using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Fawry
{
    internal class Inventory
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book) => books.Add(book);

        public List<Book> RemovOutDateBook(int Year)
        {
            int currntYear = DateTime.Now.Year;
            var outDate = books.Where(book => currntYear - book.YearPublished > Year).ToList();

            foreach (var book in outDate)
                 books.Remove(book);
            return outDate;
        }
        public void BuyBook(string isbn, int quantity, string email, string address)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);

            if (book == null)
            {
                throw new Exception("Quantum book store: Book not found");
            }

            for (int i = 0; i < quantity; i++)
            {
                book.Buy(email, address);
            }
        }
    }
}
