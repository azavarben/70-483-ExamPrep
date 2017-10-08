using ConsoleApplication5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Tasks.UI.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=gfkuD_eWM5Y
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource(); //alllows us to halt tasks if anything goes wrong


            try
            {
                var t1 = Task.Factory.StartNew(() => DoStuff(1, 3500, source.Token)).ContinueWith((previous) => DoMoreStuff(1, 1000));
                source.Cancel();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType());
            }

            //var t1 = Task.Factory.StartNew(() => DoStuff(1, 1500)).ContinueWith((previous) => DoMoreStuff(1, 1000));
            //var t2 = Task.Factory.StartNew(() => DoStuff(2, 3000)); //.ContinueWith((previous) => DoMoreStuff(2, 2000));
            //var t3 = Task.Factory.StartNew(() => DoStuff(3, 1000)); //.ContinueWith((previous) => DoMoreStuff(3, 500));

            //PLINQ.ForEach();

            //PLINQ.For();

            //use the task factory yo
            //var t1 = new Task(() => DoStuff(1, 1500));
            //t1.Start();
            //var t2 = new Task(() => DoStuff(2, 3000));
            //t2.Start();
            //var t3 = new Task(() => DoStuff(3, 1000));
            //t3.Start();

            //var taskList = new List<Task> { t1, t2, t3 };
            //Task.WaitAll(taskList.ToArray()); //blocks and will wait for all tasks in the list to finish

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Doing some other work");
            //    Thread.Sleep(250);
            //    Console.WriteLine("i = {0}", i);
            //}

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void DoStuff(int id, int sleepTime, CancellationToken token = new CancellationToken())
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation Requested");

                token.ThrowIfCancellationRequested();
            }

            Console.WriteLine("task {0} is begining", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} is ending", id);
        }

        static void DoMoreStuff(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is begining more work", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} is ending more work", id);
        }
    }
}
