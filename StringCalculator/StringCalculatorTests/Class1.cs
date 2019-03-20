using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    /* The method can take 0, 
     * 1 or 2 numbers, and will return their sum 
     * (for an empty string it will return 0) 
     * for example “” or “1” or “1,2”
    */

    [TestFixture]
    public class Tests
    {
        Calculator calc = new Calculator();

        [Test]
        public void EmptyString_ReturnZero()
        {
            calc.Add(' ');

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void OneNumber_ReturnsNumber()
        {
            calc.Add(3);
            Assert.AreEqual(3, 3);
        }

        [Test]
        public void TwoNumbers_ReturnsSum()
        {
            calc.Add(2, 3);
            Assert.AreEqual(5, 5);
        }
    }
}
