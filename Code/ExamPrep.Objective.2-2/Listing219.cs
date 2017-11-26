using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_2
{
    class Listing219
    {
        internal static void ConcatDemo()
        {
            //string s = string.Concat("string", 5, DayOfWeek.Friday);

            string s = "string" + 5 + DayOfWeek.Friday;

            Console.WriteLine(s);
        }

        internal static void BoxingDemo()
        {
            int i = 42;

            //boxing
            object o = i;

            //unboxing
            int x = (int)o;
        }
    }
}
