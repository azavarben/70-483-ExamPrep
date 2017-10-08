using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing17
    {
        public static void ThreadPoolDemo()
        {
            //threadpool provies a more managed enviroment to deal with threads
            //cant return anything form the theadppool nor can we tell when the thread has finished
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread form the threadpool");
                Thread.Sleep(2000);


            });

            Console.ReadKey();
        }
    }
}
