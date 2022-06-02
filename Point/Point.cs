using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Point
    {
        protected int _x;
        protected int _y;
        protected string _name;

        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        
    }
}
