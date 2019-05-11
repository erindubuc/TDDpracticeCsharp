using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }

        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            var finder = new Finder();
            var input = new int[1] { 3 };
            var expected = 3;
            Assert.AreEqual(expected, finder.FindSmallestInt(input));
        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[2] { 3, 5 };
            var expected = 3;
            Assert.AreEqual(expected, finder.FindSmallestInt(input));
        }


        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[3] { 3, 5, 9 };
            var expected = 3;
            Assert.AreEqual(expected, finder.FindSmallestInt(input));
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            var finder = new Finder();
            var input = new int[5] { 3, 5, 9, 1, 7 };
            var expected = 1;
            Assert.AreEqual(expected, finder.FindSmallestInt(input));
        }
    }
}