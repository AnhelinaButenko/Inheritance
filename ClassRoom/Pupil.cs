using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("People is studing");
        }

        public virtual void Read()
        {
            Console.WriteLine("People is reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("People is writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine("People is relaxing");
        }
    }
}
