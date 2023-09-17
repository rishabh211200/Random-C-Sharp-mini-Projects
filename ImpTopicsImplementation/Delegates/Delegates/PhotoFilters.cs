﻿using System;


namespace Delegates
{
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying Brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying Contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing photo");
        }
    }
}
