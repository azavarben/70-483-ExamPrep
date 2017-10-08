using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing135
    {
        internal static void AccessingSharedDataInMultiThreadedApp()
        {
            int n = 0;

            Task myTask = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            myTask.Wait();


            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
