using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Fawry
{
    internal class EBook : Book
    {
        public string FileType { get; set; }
        public override void Buy(string email, string address)
        {
            Console.WriteLine("Quantum book store: Sending " + FileType + " ebook to " + email);
        }
        
    }
}
