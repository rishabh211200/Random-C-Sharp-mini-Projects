/*
 In C# value types can't be null like a bool can either hold true or false.
 and sometimes we have to cater for null values for that we use nullable types.
*/

using System;

namespace NullableTypes
{
    public class NullableClass
    {
        //Like if we have to use datetime as null we can do so by
        // Nullable<DateTime> date = null; ******We can replace this line using nullable Short Hand******
        //We can use "?" like this for depicting nullable type
        // Convention is to type DataType follwed by question mark
        private readonly DateTime? date = null;


        // some properties and methods of nullable types
        /*Preferred way for getting value is by using GetvalueOrDefault*/
        public DateTime GetValueOrDefault1()
        {
            Console.WriteLine("GetValueOrDefault : " + date.GetValueOrDefault()); //It will return default value as our datetime is null
            return date.GetValueOrDefault();
        }
        public bool HasValue1()
        {
            Console.WriteLine("Hasvalue : " + date.HasValue); // It will return in form of bool as true or false(check whether it is carrying any value or not)
            return date.HasValue;
        }
        public DateTime Value1()
        {
            Console.WriteLine("Value : " + date.Value); // we have  to make sure it is having some value otherwise this method will throw exception.
            return date.Value;
        }
        


        

    }
}
