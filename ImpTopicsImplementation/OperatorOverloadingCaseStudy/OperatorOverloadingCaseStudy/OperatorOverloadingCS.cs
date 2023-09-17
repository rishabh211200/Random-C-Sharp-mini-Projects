using System;

namespace OperatorOverloadingCaseStudy
{
    class OperatorOverloadingCS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator Overloading with inheritance.");
            StoreValue Obj1 = new StoreValue(119, 280);
            Obj1.DisplayWindow();
            InheritValue Obj2 = new InheritValue(355, 455);
            Obj2.DisplayWindow();
            InheritMoreValue Obj3 = new InheritMoreValue(150, 250);
            Obj3.DisplayWindow();
        }
    }
}
