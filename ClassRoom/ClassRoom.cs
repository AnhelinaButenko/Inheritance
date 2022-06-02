using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        private readonly List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(Pupil pupil1)
        {
            pupils.Add(pupil1);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
            : this (pupil1)
        {
            pupils.Add(pupil2);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
            : this (pupil2, pupil1)
        {
            pupils.Add(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
            : this (pupil1, pupil2, pupil3)
        {
            pupils.Add(pupil4);
        }

        public void ShowAction()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }
}
