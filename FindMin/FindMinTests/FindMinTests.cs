using NUnit.Framework;
using System;

namespace FindMinimum.FindMinTests
{
    public class FindMinTests
    {

        private FindMin _findMin { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _findMin = new FindMin();
        }
        //Now we have to do 3 things assign act & assert

        [Test]
        public void IsParameterInLowRange()
        {
            var _findMin = new FindMin();
            var N = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => _findMin.FindMinimum(N));
        }
        [Test]
        public void IsParameterInHighRange()
        {
            var _findMin = new FindMin();
            var N = 83;
            Assert.Throws<OverflowException>(() => _findMin.FindMinimum(N));
        }
        [TestCase(16, 79)]
        [TestCase(19, 199)]
        [TestCase(7, 7)]
        [TestCase(10, 19)]
        [TestCase(0, 0)]
        public void IsInRangeCorrect(int N, int expected)
        {
            var _findMin = new FindMin();
            var result = _findMin.FindMinimum(N);
            Assert.AreEqual(expected, result);
        }
    }
}