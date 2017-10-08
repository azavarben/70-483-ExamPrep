using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing122
    {
        internal static void AsParallel()
        {
            var numbas = Enumerable.Range(0, 10000);

            var results = numbas.AsParallel().Where(i => i % 2 == 0).ToArray();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
