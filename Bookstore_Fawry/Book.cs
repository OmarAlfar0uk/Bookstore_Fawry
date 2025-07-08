using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Fawry
{
    internal abstract class Book
    {
        public string ISBN;
        public string Title;
        public string AuthorName;
        public int YearPublished;
        public decimal Price;

        public abstract void Buy(string email, string address);
    }
}
