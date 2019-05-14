using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Book
    {
        private string ISBN13;
        private string ISBN10;
        private string title;
        private string author;

        // Constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.ISBN13 = "";
            this.ISBN10 = "";
        }
        public Book(string ISBN13, string ISBN10, string title, string author)
        {
            this.ISBN13 = ISBN13;
            this.ISBN10 = ISBN10;
            this.title = title;
            this.author = author;
        }

        //Accessors
        public string TitleGetSet
        {
            get { return title; }
            set { title = value; }
        }
        public string AuthorGetSet
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN13GetSet
        {
            get { return ISBN13; }
            set { ISBN13 = value; }
        }
        public string ISBN10GetSet
        {
            get { return ISBN10; }
            set { ISBN10 = value; }
        }
    }

}
