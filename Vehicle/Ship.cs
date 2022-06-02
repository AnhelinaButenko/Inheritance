using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Ship : Vehicle
    {
        private int _passangersAmount;
        protected string _port;

        public Ship(double price, double speed, DateTime releaseDate, int passangersAmount, string port) : base (price, speed, releaseDate)
        {
            _passangersAmount = passangersAmount;
            _port = port;
        }

        public override void Show()
        {
            Console.WriteLine("Ship: ");
            base.Show();
            Console.WriteLine($"passangersAmount: {_passangersAmount},passangersAmount: {_port}");
        }

    }
}
