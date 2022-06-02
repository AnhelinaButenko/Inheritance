using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Plane : Vehicle
    {
        private double _height;
        private int _passangersAmount;

        public Plane(double price, 
            double speed, 
            DateTime releaseDate, 
            double height, 
            int passangersAmount): base(price, speed, releaseDate)
        {
            _height = height;
            _passangersAmount = passangersAmount;
        }

        public override void Show()
        {
            Console.WriteLine("Plane: ");
            base.Show();
            Console.WriteLine($"Height: { _height },PassangersAmount: { _passangersAmount}");
        }
    }
}
