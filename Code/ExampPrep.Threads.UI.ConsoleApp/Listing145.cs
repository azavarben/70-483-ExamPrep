using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing145
    {
        internal static void TaskTimeout()
        {
            Task longTask = Task.Run(() => {
                Thread.Sleep(5000);
            });

            var indext = Task.WaitAny(new Task[] { longTask }, 1000);

            if (indext == -1)
            {
                Console.WriteLine("Task timed out");
            }


            Console.ReadKey();
        }
    }
}
