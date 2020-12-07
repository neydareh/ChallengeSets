using System;
using System.Collections.Generic;
using System.Linq;

namespace NewChallengeSet
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers != null && numbers.Any()) ? numbers.Max() + numbers.Min() : 0.0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                }
                return sum;

            }
            else
            {
                return 0;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null)
            {
                return (numbers.Sum() % 2 != 0) ? true : false;
            }
            else
            {
                return false;
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
