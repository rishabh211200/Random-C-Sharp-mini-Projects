using System;

namespace OperatorOverloadingCaseStudy
{
    class InheritMoreValue : InheritValue
    {
        private double num1;
        private double num2;
        public InheritMoreValue(double a,  double b)
        {
            num1 = (a * b) / (a + b);
            num2 = (a * b) / (b - a);
        }
        public InheritMoreValue()
        {
        }
        public new void DisplayWindow()
        {
            Console.WriteLine("The value of numbers 48 and 62 are {0}{1}", num1,num2);
        }
    }
}
