using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingMaker
{
    public class Greeting
    {
        public string GreetPerson(string name)
        {
            if (name == null)
                name = "my friend";
            foreach (char letter in name)
            {
                if (Char.IsLower(letter))
                    return "Hello, " + name;
            }
            return "HELLO, " + name;
        }

        public string GreetPerson(string[] names)
        {
            string startingString = "Hello, ";
            string allCaps = "AND HELLO ";
            bool hasCaps = false;
            StringBuilder newString = new StringBuilder(startingString);
            StringBuilder capString = new StringBuilder(allCaps);

            if (names.Length > 2)
            {
                if (names[0] == names[0].ToUpper() || names[1] == names[1].ToUpper() || names[2] == names[2].ToUpper())
                {
                    hasCaps = true;
                }

                int lastName = names.Length - 1;
                for (var i = 0; i < names.Length - 1; i++)
                {
                    Console.WriteLine(i);
                    if (hasCaps)
                    {
                        if (names[i] == names[i].ToUpper())
                        {
                            capString.Append(names[i] + "!");
                        }

                        else
                        {
                            newString.Append(names[i] + " and ");
                        }

                        hasCaps = true;
                    }

                    else if (names[i] != names[i].ToUpper() || names[i + 1] != names[i + 1].ToUpper() || names[i + 2] != names[i + 2].ToUpper())
                    {
                        newString.Append(names[i] + ", " + names[i + 1] + ", ");
                    }
                }

                if (hasCaps)
                {
                    newString.Append(names[lastName] + ". ");
                    return newString.ToString() + capString.ToString();
                }

                else
                {
                    newString.Append("and " + names[lastName] + ".");
                    return newString.ToString();
                }

            }

            return "Hello, " + names[0] + " and " + names[1];
        }
    }
}
