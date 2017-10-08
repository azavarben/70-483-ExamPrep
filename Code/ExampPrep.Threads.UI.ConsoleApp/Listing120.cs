using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    public class Listing120
    {
        internal static async void ConfigureAwait()
        {
            HttpClient client = new HttpClient();

            var result = await client.GetStringAsync("https://www.microsoft.com").ConfigureAwait(false);

            Console.ReadKey();
        }
    }
}
