using System;
using System.Globalization;


namespace JulianDateConvertor
{
    public class JdConvertor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter julian date of length 3 : ");
            string datestr = Console.ReadLine();
            DateTime dObj = JulianConvertor.ConvertStringToJulianDate(datestr, DateTime.Today);
            Console.WriteLine("julian date is : " + dObj);
        }
    }
}
