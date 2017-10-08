using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing111
    {
        internal static void SchedulingContinuationTasks()
        {
            Task<int> t = Task.Run(() =>
            {
                //throw new Exception();

                return 42;
            });

            t.ContinueWith((i) => {
                Console.WriteLine("FAULTED");
            }, TaskContinuationOptions.OnlyOnFaulted);

            t.ContinueWith((i) => {
                Console.WriteLine("COMPLETED");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            Console.WriteLine(t.Result);

            Console.ReadKey();
        }
    }
}
