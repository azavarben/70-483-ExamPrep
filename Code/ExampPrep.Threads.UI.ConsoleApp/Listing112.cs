﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing112
    {
        internal static void ParentChildTasksDemo()
        {
            Task<int[]> parent = Task.Run(() =>
            {
                var results = new int[3];

                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

                return results;

            });

            var finalTask = parent.ContinueWith(parentTask => {
                foreach (int i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();

            Console.ReadKey();
        }
    }
}
