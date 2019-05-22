using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
//using System.Json;
using System.IO;
using Newtonsoft.Json;

namespace LibraryProject
{
    class JsonEdit
    {
        public List<Book> JsonLoad(string filename)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                Console.WriteLine(json);
                var books = JsonConvert.DeserializeObject<List<Book>>(json);

                foreach (Book b in books)
                {
                    Console.WriteLine(b.ToString());
                }

                return books;
            }
            
        }
    }
}
