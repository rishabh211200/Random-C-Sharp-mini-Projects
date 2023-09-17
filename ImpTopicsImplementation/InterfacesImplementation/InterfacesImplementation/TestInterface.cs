using System;
using static InterfacesImplementation.InterfacesImplementation;

public class TestInterface
{
    public static void Main()
    {
        IDrawable d;
        d = new Rectangle();
        d.draw();
        d = new Circle();
        d.draw();
    }

}
