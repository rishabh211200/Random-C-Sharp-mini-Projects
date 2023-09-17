using System.Linq;
using System;

namespace ExtensionMethods
{
    // For Extension methods we need to use static class.
    public static class StringExtensions
    {
        

        public static string Shorten(string str, int numberOfWords)
        {
            if (numberOfWords  < 0)
                throw new ArgumentOutOfRangeException();

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');   //breaking each word

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));  //joining each extracted word.(used Take default extension method)
            
        }
    }
}
