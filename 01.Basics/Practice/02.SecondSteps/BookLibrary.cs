using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnBasics
{
    public class Book
    {
        private int _pages;
        
        public Book(string title, int pages)
        {
            this.Title = title;
            this.Pages = pages;
        }

        public bool IsRented { get; set; }
        public string Title { get; set; }

        public int Pages
        {
            get
            {
                return this._pages;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of pages should be 1 or more");
                }
                this._pages = value;
            }
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "End")
                {
                    DisplaySorted(books);
                    break;
                }
                else if (command[0] == "Add")
                {
                    AddBook(books, input);
                }
                else if (command[0] == "Remove")
                {
                    RemoveBook(books, input);
                }
                else if (command[0] == "Rent")
                {
                    BookStatus(books, input, true);
                }
                else if (command[0] == "Return")
                {
                    BookStatus(books, input, false);
                }
                else if (command[0] == "Display")
                {
                    if (command[1] == "All")
                    {
                        DisplayAll(books);
                    }
                    else if (command[1] == "Available")
                    {
                        DisplayAvailable(books);
                    }
                    else if (command[1] == "Unavailable")
                    {
                        DisplayUnavailable(books);
                    }
                }
            }
        }

        private static void AddBook(List<Book> books, string commandArgs)
        {
            int startIndex = commandArgs.IndexOf(' ');
            int endIndex = commandArgs.LastIndexOf(' ');
            string bookName = commandArgs.Substring(startIndex + 1, endIndex - startIndex - 1);
            int pages = int.Parse(commandArgs.Substring(endIndex + 1));
            books.Add(new Book(bookName, pages));
        }

        private static void RemoveBook(List<Book> books, string commandArgs)
        {
            int index = commandArgs.IndexOf(' ');
            string bookName = commandArgs.Substring(index + 1);
            books.RemoveAll(x => x.Title == bookName);
        }

        private static void BookStatus(List<Book> books, string commandArgs, bool isRented)
        {
            int index = commandArgs.IndexOf(' ');
            string bookName = commandArgs.Substring(index + 1);

            foreach (var book in books)
            {
                if (book.Title == bookName)
                {
                    book.IsRented = isRented;
                }
            } 
        }

        private static void DisplayAll(List<Book> books)
        {
            DisplayList(books);
        }

        private static void DisplayAvailable(List<Book> books)
        {
            var availableBooks = new List<Book>(books).Where(x => !x.IsRented).ToList();
            DisplayList(availableBooks);
        }

        private static void DisplayUnavailable(List<Book> books)
        {
            var rentedBooks = new List<Book>(books).Where(x => x.IsRented).ToList();
            DisplayList(rentedBooks);
        }

        private static void DisplaySorted(List<Book> books)
        {
            books = books.OrderBy(x => x.IsRented ? 0 : 1).ToList();
            DisplayList(books);
        }

        private static void DisplayList(List<Book> books)
        {
            Console.WriteLine("*** Books List ***");
            foreach (var book in books)
            {
                Console.WriteLine($"Book Title: {book.Title}");
            }
            Console.WriteLine();
        }
    }
}
