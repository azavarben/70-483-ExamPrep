using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing140
    {
        internal static void InterlockedDemo()
        {
            int n = 0;

            Task myTask = Task.Run(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref n);
            }


            myTask.Wait();

            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
