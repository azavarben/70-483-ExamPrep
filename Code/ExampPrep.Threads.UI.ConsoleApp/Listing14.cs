using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing14
    {
        public static void StopAThreadDemo()
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Thread is about to close");
            }));

            t.Start();

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();

            stopped = true;

            t.Join();
        }
    }
}
