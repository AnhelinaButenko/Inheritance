using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car : Vehicle
    {
        public Car(double price, double speed, DateTime releaseDate): base(price, speed, releaseDate)
        {

        }

        public override void Show()
        {
            Console.WriteLine("Car: ");
            base.Show();
        }
    }
}
