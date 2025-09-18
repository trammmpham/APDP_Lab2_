namespace Lab2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LibraryItem book1 = new Book("1984", "George Orwell", new DateTime(1949, 6, 8), "Dystopian");
            //LibraryItem dvd1 = new DVD("Inception", "Christopher Nolan", new DateTime(2010, 7, 16), 148);
            //book1.CheckOut();
            //Console.WriteLine("The " +book1.Title+ " status: " +book1.Available);
            //dvd1.CheckOut();
            //Console.WriteLine("The " + dvd1.Title + " status: " + dvd1.Available);

            //Console.WriteLine("================================");
            //dvd1.ReturnItem();
            //book1.ReturnItem();
            //Console.WriteLine("The " + book1.Title + " status: " + book1.Available);
            //Console.WriteLine("The " + dvd1.Title + " status: " + dvd1.Available);
            LibraryCatalog catalog = new LibraryCatalog();
            catalog.AddItem(new Book ("1984", "George Orwell", new DateTime(1949, 6, 8), "Dystopian"));
            catalog.AddItem(new DVD("Inception", "Christopher Nolan", new DateTime(2010, 7, 16), 148));
            catalog.AddItem(new Book("To Kill a Mockingbird", "Harper Lee", new DateTime(1960, 7, 11), "Fiction"));
            catalog.ListItems();
            Console.WriteLine("================================");
            catalog.FindItem("George");
            Console.WriteLine("================================");
            catalog.FindItem("the");
            Console.WriteLine("================================");
            catalog.CheckOutItem("To Kill a Mockingbird");
            catalog.ListItems();
            Console.WriteLine("================================");
            catalog.ReturnItem("TO KILL A MOCKINGBIRD");
            catalog.ListItems();
            Console.WriteLine("================================");


        }
    }
}
