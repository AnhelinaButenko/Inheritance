using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("EXCELENT all studies");
        }
        public override void Read ()
        {
            Console.WriteLine("EXCELENT all reads");
        }
        public override void Write()
        {
            Console.WriteLine("EXCELENT all writes");
        }
        public override void Relax()
        {
            Console.WriteLine("EXCELENT normaly is relaxing, when he is tired");
        }
    }
}
