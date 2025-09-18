using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_
{
    internal class DVD : LibraryItem 
    {
        public int Runtime { get; set; } // Duration in minutes
        public DVD(String title, String author, DateTime publicationDate, int duration)
            : base(title, author, publicationDate)
        {
            Runtime = duration;
        }
        public override void CheckOut()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"You have checked out the DVD '{Title}' by {Author}.");
            }
            else
            {
                Console.WriteLine($"Sorry, the DVD '{Title}' is currently not available.");
            }
        }
        public override void ReturnItem()
        {
            if (!Available)
            {
                Available = true;
                Console.WriteLine($"You have returned the DVD '{Title}'.");
            }
            else
            {
                Console.WriteLine($"The DVD '{Title}' was not checked out.");
            }
        }
    }
}
