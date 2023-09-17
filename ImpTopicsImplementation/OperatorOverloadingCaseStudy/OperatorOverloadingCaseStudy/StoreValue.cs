using System;

namespace OperatorOverloadingCaseStudy
{
    class StoreValue
    {
        private int num1;
        private int num2;
        public StoreValue()
        {

        }
        public StoreValue(int m, int n)
        {
            num1 = m + m;
            num2 = n + n;
        }
        public void DisplayWindow()
        {
            Console.WriteLine("The sum of numbers is {0}{1}", num1,num2);
        }
    }
}
