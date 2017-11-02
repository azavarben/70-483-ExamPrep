using System;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing184
    {
        public static void EventHandlerDemo()
        {
            var printer = new Printer();

            printer.OnPrinted += (sender, args) =>
            {
                Console.WriteLine("Printing my doc:");
                Console.WriteLine(args.DocTitle);
            };

            printer.Print("My Doc");

            Console.ReadLine();
        }

        public class Printer
        {
            public event EventHandler<PrintedEventArgs> OnPrinted;

            public void Print(string title)
            {
                if (OnPrinted != null)
                {
                    OnPrinted(this, new PrintedEventArgs(title));
                }
            }
        }

        public class PrintedEventArgs : EventArgs
        {
            public string DocTitle { get; set; }

            public PrintedEventArgs(string docTitle)
            {
                DocTitle = docTitle;
            }

        }
    }
}