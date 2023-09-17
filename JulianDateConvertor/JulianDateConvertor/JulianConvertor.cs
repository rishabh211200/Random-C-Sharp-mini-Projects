using System;
using System.Globalization;

namespace JulianDateConvertor
{
    public class JulianConvertor
    {
        public static DateTime ConvertStringToJulianDate(string jDateString, DateTime baseDate)
        {

            int jDate = int.Parse(jDateString);  // converting the string into int to get the julian date

            if (jDate > 0 && jDate < 366)
            {
                //Calculating first days of previous, current and next year.
                DateTime dt1FirstDay = new DateTime(baseDate.Year - 1, 1, 1);
                //Console.WriteLine("dt1FirstDay  "+dt1FirstDay);
                DateTime dt2FirstDay = new DateTime(baseDate.Year, 1, 1);
                //Console.WriteLine("dt2FirstDay  "+dt2FirstDay);
                DateTime dt3FirstDay = new DateTime(baseDate.Year + 1, 1, 1);
                //Console.WriteLine("dt3FirstDay  "+dt3FirstDay);

                //Adding Julian date days entered to the first day assigned above to get the corresponding date
                DateTime dt1 = dt1FirstDay.AddDays(jDate - 1);
                //Console.WriteLine("dt1  "+dt1);
                DateTime dt2 = dt2FirstDay.AddDays(jDate - 1);
                //Console.WriteLine("dt2  "+dt2);
                DateTime dt3 = dt3FirstDay.AddDays(jDate - 1);
                //Console.WriteLine("dt3  "+dt3);

                // Calculating the no. of days from today's date to our date  obtained 
                var ts1 = Math.Abs(dt1.Subtract(baseDate).Days);
                //Console.WriteLine("ts1  "+ts1);
                var ts2 = Math.Abs(dt2.Subtract(baseDate).Days);
                //Console.WriteLine("ts2  "+ts2);
                var ts3 = Math.Abs(dt3.Subtract(baseDate).Days);
                //Console.WriteLine("ts3  "+ts3);

                if (ts1 < ts2)  //checking if no. of days is closer to previous year or current year
                {
                    if (ts1 < ts3) return dt1; //if no. of days is closer to previous year, return previous year's calculated date
                    return dt3; //else return next year's calculated date
                }
                else
                {
                    if (ts2 < ts3) return dt2; //if no. of days is closer to current year, return current year's calculated date
                    return dt3; // else return next year's calculated date
                }
            }
            //else
                //try
                //{
                    return DateTime.ParseExact(jDateString, "yyMMdd", CultureInfo.InvariantCulture);
                //}
                //catch(Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //}
        }
    }
}
