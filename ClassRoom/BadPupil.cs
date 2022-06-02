using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class BadPupil : Pupil 
    {
        public override void Study()
        {
            Console.WriteLine("BADDDD studies little");
        }

        public override void Read()
        {
            Console.WriteLine("BADDDD reads little");
        }

        public override void Write()
        {
            Console.WriteLine("BADDDD writes little");
        }
        public override void Relax()
        {
            Console.WriteLine("BADDDD a lot of relax");
        }
    }
}
