using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing27
    {
        internal static void NamedAndOptionalParamsDemo()
        {
            MyMethod(1, thirdArgument: true);
        }

        public static void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {

        }
    }
}
