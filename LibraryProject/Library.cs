using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Library
    {
        private List<User> users;
        private List<Book> books;
        // Constructor
        public Library()
        {
            users = new List<User>();
            books = new List<Book>();
        }

        // Accessors
        public List<User> UserGetSet
        {
            get { return users; }
            set { users = value; }
        }
        public List<Book> BookGetSet
        {
            get { return books; }
            set { books = value; }
        }

        // Functions
        public void AddUser(User u)
        {
            // Duplicate Check here
            users.Add(u);
        // Incomplete
        }
        public void AddBook(Book b)
        {
            // Duplicate Check here
            books.Add(b);
        // Incomplete
        }
        public void RemoveUser(User u)
        {
            // Duplicate Check here
            users.Remove(u);
        // Incomplete
        }
        public void RemoveBook(Book b)
        {
            // Duplicate Check here
            books.Remove(b);
        }

        public void PrintBooks()
        {
            foreach(Book b in books)
            {
                Console.WriteLine("Title: " + b.TitleGetSet +
                        "\tAuthor: " + b.AuthorGetSet +
                        "\tISBN-13: " + b.ISBN13GetSet +
                        "\tISBN-10: " + b.ISBN10GetSet);
            }
        }
        public void PrintUsers()
        {
            foreach (User u in users)
            {
                Console.WriteLine(u.GetSetName);
            }
        }

    }
}
