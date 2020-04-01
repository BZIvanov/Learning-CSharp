using System;
using System.Collections;
using System.Collections.Generic;

namespace IntermediateLevel
{
    public class Book
    {
        public Book()
        {
            this.Authors = new List<string>();
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; }
    }

    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return this.books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // this one is only used to called the above one, because this one is here for legacy reasons
            return this.GetEnumerator();
        }
    }
    class BasicUsage 
    {
        static void Main(string[] args)
        {
            var library = new Library
            {
                new Book { Title = "Some title", Year = 2017 },
                new Book { Title = "Some other", Year = 2019 }
            };

            foreach (var book in library)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
