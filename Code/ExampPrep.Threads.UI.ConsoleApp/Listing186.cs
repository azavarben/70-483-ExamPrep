using System;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing186
    {
        public static void ExceptionWhenRaisingEventDemo()
        {
            var pub = new Pub();

            pub.OnChange += (sender, args) => { Console.WriteLine("Subscriber 1 called."); };
            pub.OnChange += (sender, args) => { throw new Exception();};
            pub.OnChange += (sender, args) => { Console.WriteLine("Subscriber 3 called."); };

            pub.Raise();

            Console.ReadLine();
        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, EventArgs.Empty);
            }
        }
    }
}