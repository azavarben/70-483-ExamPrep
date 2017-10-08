using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing148
    {
        internal static void ShortCircuitTheOrOperator()
        {
            bool x = true;

            bool result = x || GetY();

            Console.WriteLine(result);
            Console.ReadKey();           
        }

        private static bool GetY()
        {
            Console.WriteLine("This method will never be called");
            return true;
        }
        
    }
}
