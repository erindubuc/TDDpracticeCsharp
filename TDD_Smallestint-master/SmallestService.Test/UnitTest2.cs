using NUnit.Framework;
using SmallestService;
using System;

namespace Tests
{
    public class Tests2
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindClosestIntToZero(input));
        }

        [Test]
        public void FindClosestIntToZeroIfArrayLengthIsOneAndInputIsOneReturnOne()
        {
            var finder = new Finder();
            int[] input = { 1 };
            int output = finder.FindClosestIntToZero(input);
            int expectedOutput = 1;
            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var finder = new Finder();
            int[] input = { 3, 2 };
            int output = finder.FindClosestIntToZero(input);
            int expectedOutput = 2;
            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void IfInputLengthIsThreeReturnsClosestToZero()
        {
            var finder = new Finder();
            int[] input = { 3, 2, 1 };
            int output = finder.FindClosestIntToZero(input);
            int expectedOutput = 1;
            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void IfInputContainsNegativeNumberReturnClosestToZero()
        {
            var finder = new Finder();
            int[] input = { 3, 1, 5, 4, -5 };
            int output = finder.FindClosestIntToZero(input);
            int expectedOutput = 1;
            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void IfInputContainsNegativeNumberAndPostiveNumberBothAreSameClosestToZeroReturnNegativeNumber()
        {
            var finder = new Finder();
            int[] input = { 3, 2, 1, -5, -1 };
            int output = finder.FindClosestIntToZero(input);
            int expectedOutput = -1;
            Assert.AreEqual(output, expectedOutput);
        }
    }
}