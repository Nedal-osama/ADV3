using ADV3.part1;
using ADV3.part2;

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


            #region part2
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Testing Exists
            Console.WriteLine(list.Exists(x => x == 3)); 
            Console.WriteLine(list.Exists(x => x == 6)); 

            // Testing Find
            Console.WriteLine(list.Find(x => x == 3)); 
            Console.WriteLine(list.Find(x => x == 6)); 

            // Testing FindAll
            var allGreaterThan2 = list.FindAll(x => x > 2);
            allGreaterThan2.ForEach(x => Console.WriteLine(x)); 

            // Testing FindIndex
            Console.WriteLine(list.FindIndex(x => x == 3)); 
            Console.WriteLine(list.FindIndex(1, x => x == 3)); 
            Console.WriteLine(list.FindIndex(1, 3, x => x == 3)); 

            // Testing FindLast
            Console.WriteLine(list.FindLast(x => x < 4));

            // Testing FindLastIndex
            Console.WriteLine(list.FindLastIndex(x => x < 4));
            Console.WriteLine(list.FindLastIndex(3, x => x < 4)); 
            Console.WriteLine(list.FindLastIndex(3, 3, x => x < 4)); 

            // Testing ForEach
            list.ForEach(x => Console.Write(x + " ")); 
            Console.WriteLine();

            // Testing TrueForAll
            Console.WriteLine(list.TrueForAll(x => x > 0)); 
            Console.WriteLine(list.TrueForAll(x => x < 4)); 
            #endregion
        }
    }
}
