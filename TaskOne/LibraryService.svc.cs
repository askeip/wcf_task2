using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TaskOne
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LibraryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LibraryService.svc or LibraryService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class LibraryService : ILibraryService
    {
        private static readonly List<Book> AvailableBooks = new List<Book>();
        private static readonly Dictionary<int, Book> TakenBooks = new Dictionary<int, Book>();
        
        private static readonly Dictionary<string, List<Book>> UserActivity = new Dictionary<string, List<Book>>();

        private string userName;
        private List<Book> chosenBooks;

        public void LogIn(string userName)
        {
            this.userName = userName;
            chosenBooks = new List<Book>();
            if (!UserActivity.ContainsKey(userName))
                UserActivity.Add(userName, new List<Book>());
            Console.WriteLine(userName + " came to library");
        }

        public void AddBook(Book value)
        {
            value.Id = AvailableBooks.Count;
            AvailableBooks.Add(value);
        }

        public Book GetBook(int id)
        {
            if (AvailableBooks.Count > id)
            {
                return AvailableBooks[id];
            }
            return null;
        }

        public List<Book> GetAllBooks(string author)
        {
            return AvailableBooks.Where(z => z!= null && z.Author == author)
                .ToList();
        }

        public Book TakeBook(Book book)
        {
            var bookToTake = AvailableBooks.FirstOrDefault(z => z != null && z.Equals(book));
            if (bookToTake != null)
            {
                AvailableBooks[bookToTake.Id] = null;
                TakenBooks.Add(bookToTake.Id, bookToTake);
                UserActivity[userName].Add(bookToTake);
            }
            return bookToTake;
        }

        public void ReturnBook(Book book)
        {
            if (!UserActivity[userName].Any(z => z != null && z.Equals(book))) return;
            TakenBooks.Remove(book.Id);
            UserActivity[userName]
                .Remove(book);
            AvailableBooks[book.Id] = book;
        }

        public string ConfirmChoice()
        {
            if (UserActivity[userName].Count + chosenBooks.Count <= 5)
            {
                UserActivity[userName] = UserActivity[userName].Concat(chosenBooks)
                    .ToList();
                chosenBooks = new List<Book>();
                return "Books taken";
            }
            return "You cant take more than 5 books";
        }

        public void LeaveLibrary()
        {
            Console.WriteLine(userName + " left library");
        }
    }
}
