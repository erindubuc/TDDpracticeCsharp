using NUnit.Framework;
using System;

namespace Tests
{
    /*
    *First line should print n - 1 spaces, and 1 hash
    * Each line should have 1 LESS space and 1 MORE hash
    * Last night should have 0 spaces, and n hashes
    */

    [TestFixture]
    public class Tests
    {
        [Test]
        public void CreateFirstLine_HeightMinusOneSpacesAndOneHash()
        {
            int height = 6;
            int spaces = 0;
            Staircase.CreateFirstLine(6);
            
            //int spaces = 0;
            Assert.AreEqual(spaces, height - 1);
        }
    }

    public static class Staircase
    {
        

        public static void CreateFirstLine(int height)
        {
            //int line = 0;
            //int spaces;
            for (int spaces = 0; spaces <= height - 1; ++spaces)
            {
                Console.Write(" ");
            }

            Console.Write("#");
        }

    }
}