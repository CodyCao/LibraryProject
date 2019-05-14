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
            Library lib = new Library();

            lib.AddBook(new Book("0123456789123", " ", "ABC TITLE", "Cody Coa"));
            lib.PrintBooks();
            Console.ReadKey();
        }
    }
}
