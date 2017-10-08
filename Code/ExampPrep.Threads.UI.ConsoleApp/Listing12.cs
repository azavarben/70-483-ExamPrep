using System;
using System.Threading;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing12
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Proc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void BackgroundThreadDemo()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            //foregroundnd thread is default, program wont terminate until foreground thread is done
            //Background threads are threads which will get terminated when all foreground threads are closed. 
            t.IsBackground = false; 
            t.Start();

            //t.Join(); //using this the app will wait for the background thread now
        }
    }
}