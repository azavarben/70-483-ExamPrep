using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    public class Listing11
    {
        public static void ThreadDemo()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread, do some work");
                Thread.Sleep(0);
            }

            //t.Join(); //lets the main thread wait until the other thread finishes.

            Console.WriteLine("AFTER");
            Console.ReadKey();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(0);
                //when using zero with this method, tells windows that this thread is finished 
                //instead of waiting for the whole time slice of the thread to finish, it will immediately
                //switch to another thread.
            }
        }
    }
}
