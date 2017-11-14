using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing195
    {
        internal static void RethrowingExceptionsDemo()
        {
            try
            {
                SomeOperation();
            }
            catch (Exception ex)
            {
                Log(ex);
                throw; //rethrows the exception without modifying the call stack
                //throw new Exception("dont do this"); //rethrows and resets the call stack to the current location in the code
            }
        }

        private static void SomeOperation()
        {
            throw new NotImplementedException();
        }

        private static void Log(Exception ex)
        {
            
        }
    }
}
