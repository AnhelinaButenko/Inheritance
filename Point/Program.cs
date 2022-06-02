using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1,2,"A"), new Point(3,4,"B"), new Point(1,4,"C"), new Point(3,5,"D"));
            Console.WriteLine(figure.Type);
            figure.PerimeterCalculator();
        }
    }
}
