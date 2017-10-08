using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing142
    {
        internal static void CancellationTokenDemo()
        {
            CancellationTokenSource source = new CancellationTokenSource();

            var token = source.Token;

            Task myTask = Task.Run(() => {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }
            }, token);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();

            source.Cancel();

            Console.WriteLine("Press enter to end the program");
            Console.ReadLine();
        }
    }
}
