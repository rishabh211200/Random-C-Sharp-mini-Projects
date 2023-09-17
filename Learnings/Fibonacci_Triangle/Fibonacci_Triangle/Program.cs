using System;

namespace Fibonacci_Triangle
{
    class Program
    {
        static void Main()
        {
            int a, b, c, i, n, j;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++) //Loop for number of rows
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");
                for (j = 1; j < i; j++) // for getting fibonacci series according to row
                {
                    c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;
                }
                Console.WriteLine();
            }

        }
    }
}


