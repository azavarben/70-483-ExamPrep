using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing137
    {


        internal static void CreatingADeadlock()
        {
            object _lockA = new object();
            object _lockB = new object();

            Task myTask = Task.Run(() =>
            {
                lock (_lockA)
                {
                    lock (_lockB)
                    {
                        Console.WriteLine("Lock on both A and B");
                    }
                }
            });

            lock (_lockB)
            {
                Thread.Sleep(1000);

                lock (_lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }

            myTask.Wait();            
        }
    }
}
