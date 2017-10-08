using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing121
    {
        internal static async void ContinueOnThradPoolNotUI()
        {
            var client = new HttpClient();

            var result = await client.GetStringAsync("https://www.azavar.com").ConfigureAwait(false);

            using (var fileStream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(result);

                await fileStream.WriteAsync(encodedText, 0, encodedText.Length).ConfigureAwait(false);
            }

            Console.ReadKey();
        }
    }
}
