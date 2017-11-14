using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing188
    {
        internal static void ExceptionDemo()
        {
            string s = "NaN";

            try
            {
                int.Parse(s);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid value: {0}", e.Message);
            }

        }
    }
}
