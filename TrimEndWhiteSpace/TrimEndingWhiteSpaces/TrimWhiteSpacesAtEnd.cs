using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrimEndingWhiteSpaces
{
    public class TrimWhiteSpacesAtEnd
    {

        public static string CheckForWhiteSpace(string input)
        {
            if (input == null)
                throw new NullReferenceException();

            if (input == string.Empty)
                throw new ArgumentException();

            StringBuilder newString = new StringBuilder(input);
            bool firstLetterFound = false;

            for (int charIndex = 0; charIndex < newString.Length; charIndex++)
            {
                if (firstLetterFound == false && !Char.IsWhiteSpace(newString[charIndex]))
                    firstLetterFound = true;

                if (firstLetterFound && newString[charIndex] == ' ' || newString[charIndex] == '\t')
                    newString[charIndex] = 'x';
            }

            return newString.Replace("x", "").ToString();

        }
    }
}


