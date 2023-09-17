using System;

namespace EventsAndDelegates
{
    // Version 3:- We are not sending anything to subscriber till now and in this version
    // I will be sending reference to the object which is encoded through EventArgs. Earlier we were  sending it as empty
    /*
     * For implementation a custom class will be required which should derive from EventArgs and
     * It will be carrying information to be deliver to subscriber
    */

    public class VideoEventArgs : EventArgs
    {
        // now we need to create a property which determines the video that was encoded
        public Video Video { get; set; }
    }
}
