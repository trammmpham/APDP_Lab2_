using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_
{
    internal class LibraryCatalog
    {
        List<LibraryItem> items = new List<LibraryItem>();
        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }
        public void ListItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.GetType().Name} - {item.Title} by {item.Author}, Published on: {item.PublicationDate.ToShortDateString()}, Available: {item.Available}");
            }
        }
        public void FindItem(string keyword)
        {  var found = items.Where(i => i.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)
            || i.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach(var item in found)
            {
                if ( item.GetType()==typeof(Book))
                    Console.WriteLine($"{item.Title} by{item.Author}, Genre: {(item as Book).Genre}- Available: {item.Available}"); 
                else if (item.GetType() == typeof(DVD))
                    Console.WriteLine($"{item.Title} irected by {item.Author}, Runtime: {(item as DVD).Runtime} mins, Available: {item.Available}");
                else
                    Console.WriteLine($"{item.Title} by {item.Author}, Available: {item.Available}");
            }
        }
        public void CheckOutItem(string title)
        {
            var item = items.FirstOrDefault(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.CheckOut();
            }
            else
            {
                Console.WriteLine($"Item '{title}' not found in the catalog.");
            }
        }
        public void ReturnItem(string title)
        {
            var item = items.FirstOrDefault(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.ReturnItem();
            }
            else
            {
                Console.WriteLine($"Item '{title}' not found in the catalog.");
            }
        }

    }
} 
