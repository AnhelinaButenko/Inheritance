using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itdvn
{
    public class BasePrinter
    {
        protected ConsoleColor color;

        public BasePrinter(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(string value) 
        {
            Console.ForegroundColor = color;           
            Console.WriteLine(value);
        }
    }
}
