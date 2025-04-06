using System;
using System.Collections.Generic;

namespace Generic_Collections___Dictionaries

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionaries store key-value pairs
             * Keys are unique identifiers of the values stored adjacent to it
             * Dictionaries allow fast searches or look-ups */

            //A dictionary with product names as keys 
            Dictionary<string, string> books = new Dictionary<string, string>();

            books.Add("978-01", "Clean Code by Robert C. Martin");
            books.Add("978-02", "The Pragmatic Programmer by Andrew Hunt");
            books.Add("978-03", "The Pragmatic Programmer");


            //Display the dictionary with keys and values
            foreach (var book in books)
            {
                Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
            }

            //Adding a book to the dictionary
            Console.WriteLine("Enter ISBN");
            string isbn = Console.ReadLine();
            Console.WriteLine("Enter book title");
            string title = Console.ReadLine();

            if (!books.ContainsKey(isbn)) //prevents duplicate keys 
            { 
                books.Add(isbn, title);
                Console.WriteLine("Book added successfully");

                //display after adding the new book (we can also make a method that does the display)
                foreach (var book in books)
                {
                    Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
                }
            }
            else
            {
                Console.WriteLine("This ISBN already exists.");
            }

            Console.Write("Enter ISBN to search for a book: ");
            string isbnSearch = Console.ReadLine();

            if (books.TryGetValue(isbnSearch, out string bookTitle))
            {
                Console.WriteLine($"Book found: {bookTitle}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            Console.Write("Enter ISBN to remove: ");
            string removeISBN = Console.ReadLine();

            if (books.Remove(removeISBN))
                Console.WriteLine("Book removed successfully!");
            else
                Console.WriteLine("ISBN not found.");
        }
    }
}
