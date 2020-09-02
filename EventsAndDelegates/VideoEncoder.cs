using System;
using System.Threading;
namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        private Video video;

        public VideoEncoder(Video video)
        {
            this.video = video;
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
            
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }

        }
    }
}
