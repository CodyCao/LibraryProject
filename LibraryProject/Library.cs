using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryProject
{
    class Library
    {
        private List<User> users;
        private List<Book> books;
        /*
        // Constructor
        [JsonConstructor]
        public Library(List<User> u, List<Book> b)
        {
            users = u;
            books = b;
        }
        */

        // Accessors
        [JsonProperty("Users")]
        public List<User> User
        {
            get { return users; }
            set { users = value; }
        }
        [JsonProperty("Books")]
        public List<Book> Book
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
                Console.WriteLine(b.ToString());
            }
        }
        public void PrintUsers()
        {
            foreach (User u in users)
            {
                Console.WriteLine(u.ToString());
            }
        }
    }
}
