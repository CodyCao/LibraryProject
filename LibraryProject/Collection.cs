using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject

{
    class Collection
    {
        private string name;
        private List<Book> collection;

        // Constructors
        public Collection(string name)
        {
            this.name = name;
            collection = new List<Book>();
        }
        public Collection(string name, List<Book> collection)
        {
            this.name = name;
            this.collection = collection;
        }

        // Accessors
        public string NameGetSet
        {
            get { return name; }
            set { name = value; }
        }
        public List<Book> CollectionGetSet
        {
            get { return collection; }
            set { collection = value; }
        }

        public void Print()
        {
            foreach(Book b in this.collection)
            {
                Console.WriteLine("Title: " + b.TitleGetSet +
                        "\tAuthor: " + b.AuthorGetSet +
                        "\tISBN-13: " + b.ISBN13GetSet +
                        "\tISBN-10: " + b.ISBN10GetSet);
            }
        }
        public void AddBook(Book b)
        {
            // Add duplicate check here
            collection.Add(b);
        }
        public void RemoveBook(Book b)
        {
            // Quantity check here
            collection.Remove(b);
        }
    }
}
