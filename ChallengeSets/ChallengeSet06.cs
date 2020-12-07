using System;
using System.Collections.Generic;
using System.Linq;

namespace NewChallengeSet
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, 
            string word, bool ignoreCase)
        {
            bool result = false;
            if (ignoreCase == true)
            {
                //Check for the null case
                if (words == null)
                    return false;
                else if ( words.Contains(null) ) 
                    return false;
                else
                {
                    //if ignore case is true
                    //O(N)
                    return words.Select(x => x.ToLower()).ToList().Contains(word.ToLower());
                }
            }
            if (ignoreCase == false)
            {
                //Check for the null case
                if (words == null)
                    return false;
                result = words.Contains(word);
            }

            return result;
        }

        public bool IsPrimeNumber(int num)
        {
            int i = 2;

            //Check for negative numbers and zero
            if (num == 1 || num == 0) return false;
            //Checking Prime
            if (num == i) return true;
            //Base Case
            if (num % i == 0) return false;
            i++;

            return IsPrimeNumber(num);
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            //if current == next, add one to the current count,
            //else move unto next 
            int max = 1;
            /*for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        max += 1;
                    }
                    break;
                }
            }*/
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n < 0 || elements == null)
            {
                return new double[] { };
            }
            var list = elements.Where(x => x % n == 0).ToArray();
            return list;
        }
    }
}
