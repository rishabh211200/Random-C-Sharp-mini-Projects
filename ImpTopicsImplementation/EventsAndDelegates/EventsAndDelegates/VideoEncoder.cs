using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        /*
         Version 4 : Now we are going to replace the first step of defining a delegate
         there is a delegate type EventHandler pre defined, so that we do not have to 
         create a custom delegate each time while declaring an event.
         In dotNet they are having delegate type in 2 forms one is normal form and one is in generic form
         i.e 1. Eventhandler
            2. EventHandler<TEventArgs>
        */

        
        // ******public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);*******
        //above delegate is replaced by pre defined delegate eventhandler which is defined directly when publishing events
        // and if we don't have to send any additional data to subscriber we can use normal form EventHandler.
        
        public event EventHandler<VideoEventArgs> VideoEncoded;  // here we used the pre defined delegate eventhandler and passed VideoEventArgs.
        public void Encode(Video video)          //Event Handler
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000); //Delaying process by 3 seconds

            OnVideoEncoded(video); //In encode method we are having reference to video object so we are going to pass the same. 
        }

        // There is a convention that our event publisher method should be virtual protected and void
        // and in naming section the name should start from On
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) //Checking If we have some subscribers.
                VideoEncoded(this, new VideoEventArgs() { Video = video}); // Now it is going to some additional data. 
        }
    }
}
