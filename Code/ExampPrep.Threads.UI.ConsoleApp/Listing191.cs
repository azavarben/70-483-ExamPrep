using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing191
    {
        internal static void FinallyBlockDemo()
        {
            string s = Console.ReadLine();

            try
            {
                var i = int.Parse(s);

                if (i == 42)
                {
                    Environment.FailFast("Finally will not be called");
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Null Exception: {0}", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid format: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            finally //gets called whether or not an exception is thrown with a few "exceptions" to the rule.
            {
                Console.WriteLine("Finally called");
            }
        }
    }
}
