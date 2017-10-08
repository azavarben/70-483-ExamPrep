using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing149
    {
        internal static void ShortCircuiteTheAndOperator()
        {
            string input = null;
            bool result = (input != null) && GetY();

            Console.ReadLine();
        }

        private static bool GetY()
        {
            Console.WriteLine("OUTPUT");
            return true;
        }
    }
}
