namespace Bookstore_Fawry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

        
            PaperBook paperBook = new PaperBook
            {
                ISBN = "111",
                Title = "C# Basics",
                AuthorName = "Omar",
                YearPublished = 2020,
                Price = 150,
                Stock = 3
            };

            EBook eBook = new EBook
            {
                ISBN = "222",
                Title = "Learn ASP.NET",
                AuthorName = "Aliaa",
                YearPublished = 2023,
                Price = 100,
                FileType = "PDF"
            };

            ShowcaseBook demoBook = new ShowcaseBook
            {
                ISBN = "333",
                Title = "Linq Book",
                AuthorName = "Ahmed",
                YearPublished = 2018,
                Price = 0
            };

          
            inventory.AddBook(paperBook);
            inventory.AddBook(eBook);
            inventory.AddBook(demoBook);

            var removed = inventory.RemovOutDateBook(5);
            foreach (var book in removed)
            {
                Console.WriteLine("Quantum book store: Removed outdated book - " + book.Title);
            }

            
            inventory.BuyBook("111", 2, "omar@email.com", "Cairo");

           
            inventory.BuyBook("222", 1, "alfarouk@email.com", "");
            try
            {
                inventory.BuyBook("333", 1, "Aliaa@email.com", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Quantum book store: " + ex.Message);
            }
        }
    }
}
