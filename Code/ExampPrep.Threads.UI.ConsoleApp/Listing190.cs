using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing190
    {
        internal static void CatchingDifferentExceptionTypesDemo()
        {
            string s = "5555555555555555555555555555555555555555555555555555555555555";

            try
            {
                int.Parse(s);
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
        }
    }
}
