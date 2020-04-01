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

    // with IEnumerable we can create both GetEnumerator methods
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
            return new BookIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // this one is only used to called the above one, because this one is here for legacy reasons
            return this.GetEnumerator();
        }

        private class BookIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;
            public BookIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            public Book Current {
                get { return this.books[this.index]; }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                // will check if we have next item with which we can continue itterating
                return ++this.index < this.books.Count;
            }

            public void Reset()
            {
                // here we will start from the beggining
                this.index = -1;
            }
        }
    }
    class CustomUsage 
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
