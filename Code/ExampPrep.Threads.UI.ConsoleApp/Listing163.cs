using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing163
    {
        internal static void GotoInSwitch()
        {
            int x = 14;

            switch (x)
            {
                case 14:
                    {
                        Console.WriteLine("in case 14");
                        goto case 15;
                    }
                case 15:
                    {
                        Console.WriteLine("x is 14");
                        goto default;
                    }

                default:
                    Console.WriteLine("in default case");
                    break;
            }

            Console.ReadKey();
        }
    }
}
