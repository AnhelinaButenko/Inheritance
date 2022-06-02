using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Vehicle
    {
        protected double _price;  
        protected double _speed;
        protected DateTime _releaseDate;

        public Vehicle(double price, double speed, DateTime releaseDate)
        {
            _price = price;
            _speed = speed;
            _releaseDate = releaseDate;
        }

        public virtual void Show()
        {
                Console.WriteLine($"Price: { _price },Speed: { _speed},ReleaseDate: { _releaseDate}");           
        }
    }
}
