using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing174
    {
        public static void JumpStatements()
        {
            int x = 3;

            if (x == 3)
            {
                goto customlabel;
            }

            Console.WriteLine("This will not show.");

            customlabel:
                Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
