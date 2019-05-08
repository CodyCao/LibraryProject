using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaLibrary
{
    class Collection
    {
        private string name;
        private List<Book> collection;

        // Constructors
        public Collection(string name)
        {
            this.name = name;
        }
        public Collection(string name, List<Book> collection)
        {
            this.name = name;
            this.collection = collection;
        }

        // Accessors
        public string nameGetSet
        {
            get { return name; }
            set { name = value; }
        }
        public List<Book> collectionGetSet
        {
            get { return collection; }
            set { collection = value; }
        }
    }
}
