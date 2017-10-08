using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    public class Listing15
    {
        [ThreadStatic] //each thread will get its own copy of this field
        public static int _field;

        public static void ThreadStaticAttributeDemo()
        {
            Thread t1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }));

            t1.Start();

            Thread t2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }));

            t2.Start();

            Console.ReadKey();

        }
    }
}
