using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing126
    {
        internal static void ForAll()
        {
            var numbers = Enumerable.Range(0, 10);

            var result = numbers.AsParallel().Where(i => i % 2 == 0);

            result.ForAll(i => Console.WriteLine(i));

            Console.ReadKey();
                                              
        }
    }
}
