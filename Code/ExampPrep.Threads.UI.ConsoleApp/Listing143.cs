
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing143
    {
        internal static void OperationCancelledDemo()
        {
            CancellationTokenSource source = new CancellationTokenSource();

            var token = source.Token;

            Task myTask = Task.Run(() => {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }

                token.ThrowIfCancellationRequested();
            }, token);


            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();

                source.Cancel();
                myTask.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions.First().Message);
            }

            Console.WriteLine("Press enter to end the program");
            Console.ReadLine();
        }
    }
}
