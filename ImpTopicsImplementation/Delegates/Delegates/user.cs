using System;
namespace Delegates
{
    class user
    {
        static void Main (string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            //we will be adding another filter
            filterHandler += filters.ApplyContrast;
            //Using newly created filter
            filterHandler += RemoveBackground;
            processor.Process("photo.jpg", filterHandler);
        }
        // we can create a new filter here if needed.
        static void RemoveBackground(Photo photo) //It should confirm the signature defined while declaring delegate
        {
            System.Console.WriteLine("Removing Background");
        }

    }
}
