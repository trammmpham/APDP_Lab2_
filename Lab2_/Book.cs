using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_
{
    internal class Book : LibraryItem 
    {
public String Genre { get; set; }
        public Book(String title, String author, DateTime publicationDate, String genre)
            : base(title, author, publicationDate)
        {
            Genre = genre;
        }
        public override void CheckOut()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"You have checked out '{Title}' by {Author}.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{Title}' is currently not available.");
            }
        }
        public override void ReturnItem()
        {
            if (!Available)
            {
                Available = true;
                Console.WriteLine($"You have returned '{Title}'.");
            }
            else
            {
                Console.WriteLine($"'{Title}' was not checked out.");
            }
        }
    }
}
