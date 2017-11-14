using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing197
    {
        internal static void ExceptionDispatchInfoDemo()
        {
            ExceptionDispatchInfo possibleException = null;

            string s = Console.ReadLine();

            try
            {
                int.Parse(s);
            }
            catch (FormatException e)
            {
                possibleException = ExceptionDispatchInfo.Capture(e);
            }

            if (possibleException != null)
            {
                possibleException.Throw(); //throwing can be used outside of a catch block
                //this is used when you want to catch an exception on one thread and throw it on another
                //used in async code, an exception thrown on an async thread will be captured and rethrown
                //on the executing thread
            }
        }
    }
}
