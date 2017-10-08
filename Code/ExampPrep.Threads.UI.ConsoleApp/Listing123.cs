using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing123
    {
        internal static void UnorderedParallelQuery()
        {
            var numbers = Enumerable.Range(0, 10);

            var results = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
