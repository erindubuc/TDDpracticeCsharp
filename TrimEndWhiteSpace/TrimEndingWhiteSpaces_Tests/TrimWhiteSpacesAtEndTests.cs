using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrimEndingWhiteSpaces;

namespace TrimEndingWhiteSpaces_Tests
{
    [TestFixture]
    public class TrimWhiteSpacesAtEndTests
    {
        [Test]

        public void CheckIfAStringIsNull_ReturnException()
        {
            string input = null;
            Assert.Throws<System.NullReferenceException>(() => TrimWhiteSpacesAtEnd.CheckForWhiteSpace(input));
        }

        [Test]

        public void CheckIfAStringIsEmpty_ReturnException()
        {
            string input = "";
            Assert.Throws<System.ArgumentException>(() => TrimWhiteSpacesAtEnd.CheckForWhiteSpace(input));
        }

        [Test]

        public void CheckForNoWhitespace_InAString()
        {
            string input = "abc";
            string expected = "abc";
            var actual = TrimWhiteSpacesAtEnd.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void KeepsWhitespaceAtBeginningOfString()
        {
            string input = "   abc";
            string expected = "   abc";
            var actual = TrimWhiteSpacesAtEnd.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]

        public void RemoveWhiteSpacesAtEndOfString()
        {
            string input = "abc    ";
            string expected = "abc";
            var actual = TrimWhiteSpacesAtEnd.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void RemoveWhiteSpaceInMiddleOfString()
        {
            string input = "abc\r\n cd \r\n ";
            string expected = "abc\r\ncd\r\n";
            var actual = TrimWhiteSpacesAtEnd.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }
        
       

        [Test]
        public void CheckForTabsAndRemoveThemFromString()
        {
            string input = "abc\t ";
            string expected = "abc";
            var actual = TrimWhiteSpacesAtEnd.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }
        
        

    }
}
