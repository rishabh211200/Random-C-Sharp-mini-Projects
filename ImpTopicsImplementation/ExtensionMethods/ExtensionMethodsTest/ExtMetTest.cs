using System;
using Xunit;
using ExtensionMethods;



namespace ExtensionMethodsTest
{
    public class ExtMetTest
    {

        string str = "one two three four five six seven eight nine ten eleven twelve thirteeen fourteen fifteen";
        int n;
        [Fact]
        public void Normal()
        {

            n = 5;

            string expectedValue = "one two three four five";
            Assert.Equal(expectedValue, StringExtensions.Shorten(str, n));
        }
        [Fact]
        public void Zero()
        {

            n = 0;
            string expectedValue = "";
            Assert.Equal(expectedValue, StringExtensions.Shorten(str, n));
        }


        /*************   Testing Throwed Exception  *************/
        [Fact]
        public void Negative()
        {
            n = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => StringExtensions.Shorten(str, n));

        }
        [Fact]
        public void Full_Length()
        {
            n = 15;
            string expectedValue = "one two three four five six seven eight nine ten eleven twelve thirteeen fourteen fifteen";
            Assert.Equal(expectedValue, StringExtensions.Shorten(str, n));
        }
        [Fact]
        public void More_Than_Length()
        {
            n = 17;
            string expectedValue = "one two three four five six seven eight nine ten eleven twelve thirteeen fourteen fifteen";
            Assert.Equal(expectedValue, StringExtensions.Shorten(str, n));
        }

    }
}
