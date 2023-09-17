using System;

namespace OperatorOverloadingCaseStudy
{
    class InheritValue : StoreValue
    {
        private double num1;
        private double num2;
        public InheritValue(double a, double b)
        {
            num1 = a * a;
            num2 = b * b;
        }
        public InheritValue()
        {
        }
        public new void DisplayWindow()
        {
            Console.WriteLine("Now the square of number 355 and 455 are {0} {1}", num1,num2);
        }
    }
}
