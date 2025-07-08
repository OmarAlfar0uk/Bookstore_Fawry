using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Fawry
{
    internal class ShowcaseBook : Book
    {
        public override void Buy(string email, string address)
        {
            Console.WriteLine("Quantum book store: This book is for showcase only and cannot be purchased.");
        }
    }
}
