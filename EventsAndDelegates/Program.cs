namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video { Title = "video1" };
            VideoEncoder videoencoder = new VideoEncoder(video);
            MailService mailservice = new MailService();

            videoencoder.VideoEncoded += mailservice.OnVideoEncoded;

            videoencoder.Encode(video);
        }
    }



}
