using System;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing175
    {
        internal static void Delegate()
        {
            var test = new UseDelegate();

            Console.ReadLine();
        }
    }

    public class UseDelegate
    {

        public delegate int Calculate(int x, int y);

        public UseDelegate()
        {
            Calculate calc = Add;

            Console.WriteLine(calc(3, 4));

            calc = Multiply;

            Console.WriteLine(calc(3, 4));
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }


}