using System;
namespace Delegates
{
    public class PhotoProcessor
    {
        //Instead of making our custom delegate we can use delegates pre defined in .net
        //which are Action and func.

        // Action<> - It points to methods which return void.
        // Func<> - It points to a method which returns a value
        
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            //changes : After using delegate all functions from version 1 will be removed from here
            filterHandler(photo);
            
            photo.Save();
        }
    }
}
