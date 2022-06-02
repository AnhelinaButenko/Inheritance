using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        private double _area;
        private double _perimetr;

        public double AreaCalculator()
        {
            return _side1 * _side2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double PerimetrCalculator()
        {
            return (_side1 + _side2) * 2;
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }
    }
}
