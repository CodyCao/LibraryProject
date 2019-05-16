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
        private string ISBN13;
        private string ISBN10;


        // Constructor
        [JsonConstructor]
        public Book(string title, string author, string ISBN13, string ISBN10)
        {
            this.title = title;
            this.author = author;
            this.ISBN13 = ISBN13;
            this.ISBN10 = ISBN10;
        }
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.ISBN13 = "";
            this.ISBN10 = "";
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
