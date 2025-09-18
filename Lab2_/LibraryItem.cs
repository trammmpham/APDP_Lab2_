using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_
{
    internal  abstract class LibraryItem
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public Boolean Available { get; set; }    
        public abstract void CheckOut();
        public abstract void ReturnItem();
        public LibraryItem(String title, String author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Available = true;
        }
    }
    
}
