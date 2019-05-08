using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Library
    {
        Archive a = new Archive();
        Dictionary<string, Collection> c = new Dictionary<string, Collection>();
        Dictionary<string, User> u = new Dictionary<string, User>();
    }
}
