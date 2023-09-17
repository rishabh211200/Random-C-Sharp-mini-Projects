using System;
class Qs
{
    static void smallestNumber(int N)
    {
        Console.WriteLine((N % 9 + 1) *
                 Math.Pow(10, (N / 9)) - 1);
    }


    public static void Main()
    {
        int N = 31;

        smallestNumber(N);
        Console.ReadLine();
    }
}