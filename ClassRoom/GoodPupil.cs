using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GOOD studies");
        }
        public override void Read()
        {
            Console.WriteLine("GOOD reads");
        }
        public override void Write()
        {
            Console.WriteLine("GOOD writes");
        }
        public override void Relax()
        {
            Console.WriteLine("GOOD normaly is relax, when he is tired");
        }
    }
}
