using System;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom (new BadPupil(), new GoodPupil(), new ExcelentPupil(), new ExcelentPupil());

            classRoom.ShowAction();
        }
    }
}
