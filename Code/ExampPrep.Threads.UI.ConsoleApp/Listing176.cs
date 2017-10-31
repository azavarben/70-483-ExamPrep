using System;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing176
    {
        internal static void Multicast()
        {
            var multicast = new MultiCast();

            multicast.Multicast();

            Console.ReadLine();
        }
    }

    public class MultiCast
    {
        public delegate void Del();

        public void MethodOne()
        {
            Console.WriteLine("Method One");
        }

        public void MethodTwo()
        {
            Console.WriteLine("Method Two");
        }

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }
    }
}