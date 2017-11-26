using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_2
{
    class Listing222
    {
        internal static void ExplicitConversionDemo()
        {
            double x = 1234.7;
            //int a = x; wont directly complile

            int a = (int)x; //its ok compiler, i know ill lose precision.

            Console.WriteLine(a);

        }
    }
}
