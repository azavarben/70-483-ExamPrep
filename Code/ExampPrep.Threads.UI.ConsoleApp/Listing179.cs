using System;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing179
    {
        public delegate int Calculate(int x, int y); 

        public static void LambdaToCreateDelegate()
        {
            Calculate calc = (x, y) => x + y;
            //vs
            calc = (int x, int y) => { return x + y; };
            //vs
            calc = (int x, int y) => x + y;

            //int test = (x, y) => x + y;

            Console.WriteLine(calc(3, 4));

            calc = (x, y) => x * y;

            Console.WriteLine(calc(3, 4));

            Console.ReadLine();
        }
    }
}