using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    public class Listing13
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("Thread Proc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void ParamaterizedThreadDemo()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(15);

            t.Join();

            Console.ReadKey();
        }
    }
}
