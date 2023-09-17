using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) //Event handler
        {
            Console.WriteLine("MailService : Sending an email..." +e.Video.Title);
        }
    }
}
