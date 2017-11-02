using System;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing181
    {


        public static void UseActionDelegate()
        {
            Action<int, int> callculate = (x, y) =>
            {
                Console.WriteLine(x + y);
            };

            callculate(5, 5);

            Console.ReadLine();
        }

        public static void UseFuncDelegate()
        {
            Func<int, int, int> calculate = (x, y) =>
            {
                return x + y;
            };

            Console.WriteLine(calculate(1, 2));

            Console.ReadLine();
        }
    }
}