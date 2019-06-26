using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = LibLoad("../../JsonLibraryLoad.json");
            lib.PrintBooks();
            lib.PrintUsers();

            Console.ReadKey();
            
            LibSave("../../JsonLibrarySave2.json",lib);

        }

        public static Library LibLoad(string filename)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                Library jLib = JsonConvert.DeserializeObject<Library>(json);
                return jLib;
            }
        }
        public static void LibSave(string fileName, Library lib)
        {
            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer ser = new JsonSerializer();
                ser.Serialize(file, lib);
            }
        }
    }
}
