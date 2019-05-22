using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryProject
{
    class User
    {
        private string name;
        private List<string> collection;

        // Constructor
        public User(string name)
        {
            this.name = name;
            this.collection = new List<string>();
        }
        [JsonConstructor]
        public User(string name, List<string> collection)
        {
            this.name = name;
            this.collection = collection;
        }

        // Accessors
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public List<string> Collection
        {
            get { return this.collection; }
            set { this.collection = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("User: " + name + "\nCollection: ");
            foreach (string s in collection)
            {
                sb.Append("\n" + s);
            }
            return sb.ToString();

        }
    }

   
}
