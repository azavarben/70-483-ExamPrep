using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video
            {
                Title = "My Video"
            };

            var videoEncoder = new VideoEncoder(); //event publisher

            var mailService = new MailService(); //event subscriber
            var messageService = new MessageService(); //event subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
