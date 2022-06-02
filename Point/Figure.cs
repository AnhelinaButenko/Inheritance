using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Figure
    {
        protected string _type;
        protected Point _point1;
        protected Point _point2;
        protected Point _point3;
        protected Point _point4;
        protected Point _point5;

        public string Type
        {
            get { return _type; }
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _type = "triangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
            : this (point1, point2, point3)
        {
            _point4 = point4;
            _type = "rectangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
            : this (point1, point2, point3, point4)
        {
            _point5 = point5;
            _type = "5ngle";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.X - A.X, 2));
        }

        public void PerimeterCalculator()
        {
            if(_point1 != null && _point2 != null && _point3 != null && _point4 == null && _point5 == null)
            {
                Console.WriteLine("Triangle");
                double lenght1 = LengthSide(_point1, _point2);
                double lenght2 = LengthSide(_point2, _point3);
                double lenght3 = LengthSide(_point3, _point1);
                double sumTr = lenght1 + lenght2 + lenght3;
                Console.WriteLine(sumTr);
            }
            else if (_point1 != null && _point2 != null && _point3 != null && _point4 != null && _point5 == null)
            {
                Console.WriteLine("Rectangle");
                double lenght1 = LengthSide(_point1, _point2);
                double lenght2 = LengthSide(_point2, _point3);
                double lenght3 = LengthSide(_point3, _point4);
                double lenght4 = LengthSide(_point4, _point1);
                double sumRt = lenght1 + lenght2 + lenght3 + lenght4;
                Console.WriteLine(sumRt);
            }
            else if (_point1 != null && _point2 != null && _point3 != null && _point4 != null && _point5 != null)
            {
                Console.WriteLine("5ngle");
                double lenght1 = LengthSide(_point1, _point2);
                double lenght2 = LengthSide(_point2, _point3);
                double lenght3 = LengthSide(_point3, _point4);
                double lenght4 = LengthSide(_point4, _point5);
                double lenght5 = LengthSide(_point5, _point1);
                double sum5 = lenght1 + lenght2 + lenght3 + lenght4 + lenght5;
                Console.WriteLine(sum5);
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
