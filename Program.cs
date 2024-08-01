namespace ADV3
{
    internal class Program
    {
        public delegate string GetTitleDelegate(Book B);
        public delegate string GetAuthorsDelegate(Book B);
        public delegate string GetPriceDelegate(Book B);
        static void Main(string[] args)
        {
            #region Part 1 
        /*    // a   (Defin delegate)
            string[] data = { "nedal", "osama", "salah" };

            Book book = new Book("algo", "C#", data, DateTime.Now, 60m);

            GetTitleDelegate getTitleDelegate = BookFunctions.GetTitle;
            GetAuthorsDelegate getAuthorsDelegate = BookFunctions.GetAuthors;
            GetPriceDelegate getPriceDelegate = BookFunctions.GetPrice;

            Console.WriteLine(getTitleDelegate(book));
            Console.WriteLine(getAuthorsDelegate(book));
            Console.WriteLine(getPriceDelegate(book)); 

            Func<Book, string> func01 = BookFunctions.GetTitle;
            Func<Book, string> func02 = BookFunctions.GetAuthors;
            Func<Book, string> func03 = B => BookFunctions.GetPrice(B);

            // c (Anonymous Method)
            Func<Book, string> funcISBN = delegate (Book book)
            {
                return book.ISBN;
            };
            Console.WriteLine(funcISBN(book));

            // d (Lambda Expression)
            Func<Book, DateTime> funcPublicationDate = book => book.PublicationDate;
            Console.WriteLine(funcPublicationDate(book)); */
            #endregion



        }
    }
}
