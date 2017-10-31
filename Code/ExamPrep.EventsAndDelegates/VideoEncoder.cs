using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExamPrep.EventsAndDelegates
{
    public class VideoEncoder
    {
        //1 - define a delegate
        //2 - define an event based of the delegate
        //3 - raise the event

        #region Old School Way
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        #endregion

        #region New Way
        public EventHandler<VideoEventArgs> VideoEncoded;
        #endregion

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) //are there any subscribers?
            {
                VideoEncoded(this, new VideoEventArgs {
                    Video = video
                });
            }
        }
    }
}
