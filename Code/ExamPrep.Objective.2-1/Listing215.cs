using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing215
    {
        public static void GenericMethodDefaultValueDemo()
        {
            MyGenericMethod<int>();
            //MyGenericMethod<string>();
            MyGenericMethod<decimal>();

        }

        public static void MyGenericMethod<T>() where T : struct
        {
            T defaultValue = default(T);

            Console.WriteLine(defaultValue);
        }
    }
}
