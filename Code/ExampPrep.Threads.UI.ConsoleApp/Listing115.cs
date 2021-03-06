﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing115
    {
        internal static void WaitAnyDemo()
        {
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (tasks.Length > 0)
            {
                var taskIndex = Task.WaitAny(tasks);

                Task<int> completed = tasks[taskIndex];

                Console.WriteLine("Completed {0}", completed.Result);

                var temp = tasks.ToList();

                temp.RemoveAt(taskIndex);

                tasks = temp.ToArray();
            }

            Console.ReadKey();
        }


    }
}