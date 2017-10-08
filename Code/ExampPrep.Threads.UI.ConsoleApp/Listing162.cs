using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing162
    {
        internal static void SwitchStatement()
        {
            int x = 14;

            switch (x)
            {
                case 14:
                    {
                        Console.WriteLine("x is 14");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("x is 15");
                        break;
                    }
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
