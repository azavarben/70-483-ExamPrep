using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing210B
    {
        internal static void SaticDemo()
        {
            Console.WriteLine(MyOtherClass.TheMeaningOfLife);

            MyOtherClass.TheMeaningOfLife = 43;

            Console.WriteLine(MyOtherClass.TheMeaningOfLife);            
        }
    }

    public class MyOtherClass
    {
        public static int TheMeaningOfLife = 42;
    }
}
