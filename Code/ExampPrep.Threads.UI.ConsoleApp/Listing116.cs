using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing116
    {
        internal static void ParallelForAndForEachDemo()
        {
            Console.WriteLine("Parallel.For");
            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            Console.WriteLine("Parallel.ForEach");

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Parallel.ForEach(ints, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            Console.ReadKey();
        }
    }
}