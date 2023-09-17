using System;
namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args) //Event Handler
        {

            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}
