using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class PLINQ
    {
        public static void For()
        {
            var digits = Enumerable.Range(1, 20);

            Parallel.For(0, 100, i =>
            {
                Console.WriteLine(i);
            });
        }

        public static void ForEach()
        {
            var digits = Enumerable.Range(1, 20);

            //Parallel.Foreach is thread blocking, meaning it will process everything in parellel but block the current thread
            Parallel.ForEach(digits, i =>
            {
                Console.WriteLine(i);
            });
        }

        public static void AsParallel()
        {
            var digits = Enumerable.Range(1, 10);

            var parallelResult = digits.AsParallel().Where(i => i % 2 == 0).ToArray();

            foreach (var num in parallelResult)
            {
                Console.WriteLine(num);
            }
        }

        public static void AsOrdered()
        {
            var digits = Enumerable.Range(1, 10);

            var result = digits.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
