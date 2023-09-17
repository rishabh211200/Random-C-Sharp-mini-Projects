//using NullableTypes;
using System;

namespace Nullabletypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //NullableClass calling = new();
            //calling.GetValueOrDefault1();
            //calling.HasValue1();
            //calling.Value1();

            /***********Version 2***************/
            DateTime? date = new DateTime(2014,1,1);
            DateTime date2 = date.GetValueOrDefault(); //We can't put nullable datetime to value datetime directly for doing the same we have to use GetValueOrDefault() method
            //whereas we can put value type to nullable types
            Console.WriteLine(date2);

            /***************   NULL COALESCING OPERATOR  *****************/


            // Suppose we have to do this 
            DateTime? date3 = null;
            DateTime date4 = date3 ?? DateTime.Today; // we replaced below section with "??" operator
            //We read the above as : If date3 has any value assign it to date4 or put Datetime.Today.

            //It's little bit similar to tertiary operator
            DateTime date5 = (date3 != null) ? date3.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine(date5);
            //We read the above as if date3 is not null then date3 will be assigned to date 5 otherwise dateTime.today will be assigned

            /*                   We can replace this whole part with null Coalescing Operator
            if (date3 != null)
                date4 = date.GetValueOrDefault();
            else
                date4 = DateTime.Today; //Setting any value in else condition as used today's date and time here
            */
            Console.WriteLine(date4);
        }
    }
}
