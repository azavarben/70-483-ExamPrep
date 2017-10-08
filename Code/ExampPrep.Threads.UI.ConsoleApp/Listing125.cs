using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing125
    {
        internal static void AsSequential()
        {
            var numbers = Enumerable.Range(0, 10);

            var results = numbers.AsParallel().Where(i => i % 2 == 0).AsSequential().ToArray();

            foreach (var result in results.Take(5))
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
