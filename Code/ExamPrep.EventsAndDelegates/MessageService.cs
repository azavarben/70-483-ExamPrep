using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: sending a text message..." + e.Video.Title);
        }
    }
}
