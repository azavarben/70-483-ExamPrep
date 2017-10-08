using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing127
    {
        internal static void AggregateExceptions()
        {
            var numbers = Enumerable.Range(0, 10);

            try
            {
                var results = numbers.AsParallel().Where(i => i / 0 == 1);

                results.ForAll(i => Console.WriteLine(i));
            }
            catch (AggregateException ex)
            {               
                Console.WriteLine(ex.Flatten().InnerException);
            }

            Console.ReadKey();
        }
    }
}
