using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Fawry
{
    internal class PaperBook : Book
    {
        public int Stock { get; set; }
        public override void Buy(string email, string address)
        {
            if (Stock <= 0)
                Console.WriteLine("Out Of Stock");

            Stock--;
            Console.WriteLine("Quantum book store: Shipping paper book to " + address);

        }
    }
}
