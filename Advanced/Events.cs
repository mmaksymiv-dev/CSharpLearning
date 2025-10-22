namespace Advanced;

public static class Events
{
    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event base on that delegate
        // 3 - Raise the event

        //public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        //public event VideoEncoderEventHandler VideoEncoded;

        //EventHandler
        //EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending am email..." + e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message..." + e.Video.Title);
        }
    }

    public static void Run()
    {
        Console.WriteLine("Start -> Events");

        var video = new Video() { Title = "Video 1" };
        var encoder = new VideoEncoder(); //publisher
        var mailService = new MailService(); //subscriber
        var messageService = new MessageService(); //subscriber

        encoder.VideoEncoded += mailService.OnVideoEncoded;
        encoder.VideoEncoded += messageService.OnVideoEncoded;

        encoder.Encode(video);

        Console.WriteLine("Finish -> Events");
    }
}
