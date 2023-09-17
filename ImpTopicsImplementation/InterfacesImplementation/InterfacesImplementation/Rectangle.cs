using System;
using static InterfacesImplementation.InterfacesImplementation;

public class Rectangle : IDrawable
{
    public void draw()
    {
        Console.WriteLine("drawing rectangle...");
    }
}
