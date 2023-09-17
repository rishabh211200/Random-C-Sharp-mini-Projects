namespace EventsAndDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  // Publisher
            var mailService = new MailService();    // 1st Subscriber
            var messageService = new MessageService(); // 2nd Subscriber

            // We need to do subscription
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // "+=" operator to register an event handler.
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
