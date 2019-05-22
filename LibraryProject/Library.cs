using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LibraryProject
{
    class Library
    {
        private List<User> users;
        private List<Book> books;
        private readonly string jBookFile;
        private readonly string jUserFile;

        // Constructor
        public Library()
        {
            users = new List<User>();
            books = new List<Book>();
            jBookFile = null;
            jUserFile = null;
        }
        public Library(string jBookFile,string jUserFile)
        {
            users = JsonUserLoad(jUserFile);
            books = JsonBookLoad(jBookFile);
            this.jBookFile = jBookFile;
            this.jUserFile = jUserFile;
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

        //Json Functions
        public List<Book> JsonBookLoad(string filename)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                var jBooks = JsonConvert.DeserializeObject<List<Book>>(json);
                return jBooks;
            }
        }
        public List<User> JsonUserLoad(string filename)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                var jUsers = JsonConvert.DeserializeObject<List<User>>(json);
                return jUsers;
            }
        }
        public void JsonBookSave()
        {
            using (StreamWriter file = File.CreateText(jBookFile))
            {
                JsonSerializer ser = new JsonSerializer();
                ser.Serialize(file, books);
            }
        }
        public void JsonBookSave(string filename)
        {
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer ser = new JsonSerializer();
                ser.Serialize(file, books);
            }
        }
        public void JsonUserSave()
        {
            using (StreamWriter file = File.CreateText(jUserFile))
            {
                JsonSerializer ser = new JsonSerializer();
                ser.Serialize(file, books);
            }
        }
        public void JsonUserSave(string filename)
        {
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer ser = new JsonSerializer();
                ser.Serialize(file, books);
            }
        }
    }
}
