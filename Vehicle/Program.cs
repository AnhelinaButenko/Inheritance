using System;
using System.Collections.Generic;

namespace Vehicle
{
    class Program
    {
        private static readonly List<Vehicle> _vehicles = new List<Vehicle>()
        {
         new Car(30000,80,DateTime.Now),
         new Plane(500000,120,DateTime.Today,69,90),
         new Ship(600000,90,DateTime.Now,40,"fghjk")
        };

        static void Main(string[] args)
        {
            foreach (var veh in _vehicles)
            {
                veh.Show();
            }
        }
    }
}
