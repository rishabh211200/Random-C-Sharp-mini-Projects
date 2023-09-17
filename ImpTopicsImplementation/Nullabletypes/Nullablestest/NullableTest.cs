using System;
using Xunit;
using NullableTypes;
namespace Nullablestest
{
    public class NullableTest
    {
        [Fact]
        public void GetvalueOrDefault()
        {
            NullableClass NullableObj = new NullableClass();
            Assert.Equal(default(DateTime), NullableObj.GetValueOrDefault1());
        }
        [Fact]
        public void HasValue()
        {
            NullableClass NullableObj = new NullableClass();
            Assert.False(NullableObj.HasValue1());
        }
        [Fact]
        public void Value()
        {
            NullableClass NullableObj = new NullableClass();
            Assert.Throws<InvalidOperationException>(() => NullableObj.Value1());
        }
    }
}
