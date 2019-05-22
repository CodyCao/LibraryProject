using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryProject
{
    class Book
    {
        private string title;
        private string author;
        private string isbn13;
        private string isbn10;

        // Constructor
        [JsonConstructor]
        public Book(string title, string author, string ISBN13, string ISBN10)
        {
            this.title = title;
            this.author = author;
            this.isbn13 = ISBN13;
            this.isbn10 = ISBN10;
        }
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isbn13 = "";
            this.isbn10 = "";
        }
        
        //Accessors
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN13
        {
            get { return isbn13; }
            set { isbn13 = value; }
        }
        public string ISBN10GetSet
        {
            get { return isbn10; }
            set { isbn10 = value; }
        }

        //Functions
        public override string ToString()
        {
            return "Title: " + this.title +
                        "\tAuthor: " + this.author +
                        "\tISBN-13: " + this.isbn13 +
                        "\tISBN-10: " + this.isbn10;
        }
    }

}
