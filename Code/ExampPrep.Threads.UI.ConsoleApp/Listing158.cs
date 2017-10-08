using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing158
    {
        internal static void NullCoalescingOperator()
        {
            int? x = null;
            int? z = null;

            int y = x ?? z ?? -1;

            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
