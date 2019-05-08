using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class User
    {
        private string name;
        private Collection collection;

        // Accessors
        public string GetSetName
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Collection GetSetCollection
        {
            get { return this.collection; }
            set { this.collection = value; }
        }
    }

   
}
