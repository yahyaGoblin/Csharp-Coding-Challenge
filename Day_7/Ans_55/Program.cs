namespace Ans_55
{
    public class BookProperties
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public long ISBN { get; set; }

        public BookProperties(string title, string author, long isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookProperties book = new BookProperties("The Alchemist", "Paulo Coelho", 9780062315007);
            book.Display();
        }
    }
}
