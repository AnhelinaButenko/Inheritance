using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{

    public class Content
    {
        readonly string _content;

        public Content (string content)
        {
            _content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Content: {_content}");
        }
    }
}
