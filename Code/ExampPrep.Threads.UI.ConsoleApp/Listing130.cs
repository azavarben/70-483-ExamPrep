using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing130
    {
        internal static void ConcurrentBag()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;

            if (bag.TryTake(out result))
            {
                Console.WriteLine("Removed {0}", result);
            }

            if (bag.TryPeek(out result))
            {
                Console.WriteLine("Next up {0}", result);
            }

            Console.ReadKey();
        }
    }
}
