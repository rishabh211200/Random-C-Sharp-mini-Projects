using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinimum
{
    internal class program
    {
        static void Main(string[] args)
        {
            var FindMin = new FindMin();
            Console.WriteLine("Enter Number: ");
            var N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindMin.FindMinimum(N));
        }
    }
}
