using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Library lib = new Library("../../BookArchive.json", "../../Users.json");
            lib.AddBook(new Book("ABC TITLE", "Cody Coa","0123456789123", ""));
            lib.PrintBooks();
            lib.PrintUsers();
            lib.JsonBookSave("../../BookArchiveSave.json");
            lib.JsonUserSave("../../UsersSave.json");

            Console.ReadKey();
        }
    }
}
