using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Select(value => value).Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                return (numbers.Sum() % 2 == 0) ? false : true;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return ( password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) ) ? true : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {

            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return ( divisor != 0 ) ? ( dividend / divisor ) : 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            var oddNumbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }
            return oddNumbers.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
