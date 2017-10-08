using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing118
    {
        internal static void AsyncAwaitDemo()
        {
            string result = DownloadContent().Result;

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");

                return result;
            }
        }
    }
}