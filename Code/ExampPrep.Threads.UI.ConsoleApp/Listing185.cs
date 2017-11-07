using System;


namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing185
    {
        public static void EventAccesorDemo()
        {
            var pub = new EventPublisher();

            pub.OnChange += (sender, args) =>
            {
                Console.WriteLine(args.Stuff);
            };

            pub.Raise();

            Console.ReadLine();
        }

        public class EventPublisher
        {
            private event EventHandler<MyArgs> _onChange = delegate { };

            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock (_onChange)
                    {
                        _onChange += value;
                    }

                }

                remove
                {
                    lock (_onChange)
                    {
                        _onChange -= value;
                    }
                }
            }

            public void Raise()
            {
                if (_onChange != null)
                {
                    _onChange(this, new MyArgs("Heya"));
                }
            }
        }
    }

    internal class MyArgs : EventArgs
    {
        public MyArgs(string stuff)
        {
            Stuff = stuff;
        }

        public string Stuff { get; set; }
    }
}