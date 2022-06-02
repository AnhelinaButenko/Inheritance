using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 сторону прямоугольника");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 2 сторону прямоугольника");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine(rectangle.AreaCalculator());
            Console.WriteLine(rectangle.PerimetrCalculator());
        }
    }
}
