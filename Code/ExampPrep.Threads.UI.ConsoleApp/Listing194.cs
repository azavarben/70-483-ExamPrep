using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing194
    {
        internal static void ThrowingExceptionsDemo()
        {
            try
            {
                var contents = OpenAndParse(null);
            } 
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Argument Null Exception: {0}", e.Message);
            }
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("fileName", "File name is required.");

            return File.ReadAllText(fileName);
        }
    }
}
