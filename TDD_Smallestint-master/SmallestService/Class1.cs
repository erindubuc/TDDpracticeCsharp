using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array can't be empty.");

            if (numbers.Length == 1)
                return numbers[0];

            if (numbers.Length == 2)
            {
                if (numbers[0] > numbers[1])
                    return numbers[1];
                else
                    return numbers[0];
            }

            int minValue = Int32.MaxValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] < minValue)
                    minValue = numbers[index];
            }

            return minValue;
        }

        public int FindClosestIntToZero(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
