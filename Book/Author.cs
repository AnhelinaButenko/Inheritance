using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Author
    {
        readonly string _author;

        public Author(string author)
        {
            _author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Author: {_author}");
        }
    }
}
