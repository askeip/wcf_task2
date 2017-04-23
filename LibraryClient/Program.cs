using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClient.ServiceReference1;

namespace LibraryClient
{
    class Program
    {
        #region
        static readonly List<Book> Books = new List<Book>
            {
                new Book
                {
                    Name = "name",
                    Author = "author",
                    PublishingYear = 2017,
                    BookType = BookType.FictionBook
                },
                new Book
                {
                    Name = "name2",
                    Author = "author2",
                    PublishingYear = 2017,
                    BookType = BookType.Magazine
                },
                new Book
                {
                    Name = "name2",
                    Author = "author2",
                    PublishingYear = 2017,
                    BookType = BookType.Magazine
                },
                new Book
                {
                    Name = "name3",
                    Author = "author3",
                    PublishingYear = 2017,
                    BookType = BookType.Other
                },
                new Book
                {
                    Name = "name3",
                    Author = "author3",
                    PublishingYear = 2017,
                    BookType = BookType.Other
                },
            };
#endregion
        static void Main(string[] args)
        {
            var client = new LibraryServiceClient();
            client.LogIn("user2");
            //AddSomeBooks(client);
            var books = new List<Book>();
            for (int i = 0; i < 6; i++)
            {
                books.Add(client.TakeBook(client.GetBook(i)));
                PrintBook(books[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                client.ReturnBook(books[i]);
                books.Add(client.TakeBook(client.GetBook(i)));
                PrintBook(books[i]);
                client.ReturnBook(books[i]);
            }
            var authorBooks = client.GetAllBooks("author");
            foreach (var e in authorBooks)
            {
                PrintBook(e);
            }
            client.LeaveLibrary();
        }

        static void AddSomeBooks(LibraryServiceClient client)
        {
            foreach (var book in Books)
            {
                client.AddBook(book);
            }
        }

        static void PrintBook(Book book)
        {
            if (book == null)
                Console.WriteLine("It is null");
            else
                Console.WriteLine(book.Id + ", author: " + book.Author);
        }
    }
}
