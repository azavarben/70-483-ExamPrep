using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing187
    {
        public static void EventExceptionHandlingDemo()
        {
            var pub = new Pub();

            pub.OnChange += (sender, e) => { Console.WriteLine("Subscriber 1 called."); };
            pub.OnChange += (sender, e) => { throw new Exception();};
            pub.OnChange += (sender, e) => { Console.WriteLine("Subscriber 3 called."); };

            try
            {
                pub.Raise();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions.Count);                
            }

            Console.ReadLine();
        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                var exceptions = new List<Exception>();

                foreach (Delegate del in OnChange.GetInvocationList())
                {
                    try
                    {
                        del.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception e)
                    {
                        exceptions.Add(e);                        
                    }
                }

                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
        }
    }
}
