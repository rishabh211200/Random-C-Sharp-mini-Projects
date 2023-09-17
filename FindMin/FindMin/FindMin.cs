using System;
using System.Collections.Generic;
using System.Linq;


namespace FindMinimum
{
    public class FindMin
    {
        public int FindMinimum(int N)
        {
            if (N < 0) throw new ArgumentOutOfRangeException("N");

            else if (N < 10) return N;

            else return (Convert.ToInt32((N % 9 + 1) *
             Math.Pow(10, (N / 9)) - 1));
        }
    }
}