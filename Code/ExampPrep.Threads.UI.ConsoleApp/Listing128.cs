using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing128
    {
        internal static void BlockingCollection()
        {
            var blockingCollection = new BlockingCollection<string>();

            Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(blockingCollection.Take());
                }
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    blockingCollection.Add(s);
                }
            });

            write.Wait();
        }
    }
}
