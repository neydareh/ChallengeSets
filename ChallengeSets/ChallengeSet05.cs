using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            // if startNumber is divisible by n, then multiply startNumber by n
            // if startNumber is not divisible by n, then divide startNumber by n, multiply the result by n, then add it to n to get the next term
            return (startNumber % n ==0) ? (startNumber + n) : ((startNumber / n) * n) + n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            // Check to see if business has Revenue, if it has revenue, skip
            // else change business name with no revenue to CLOSED.
            foreach (var business in businesses)
            {
                if(business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            // Check for null values Edge Case
            if (numbers == null) return false;
            // Check for ascending order
            var orderByAscending = numbers.OrderBy(x => x);
            if (numbers.SequenceEqual(orderByAscending) && numbers.Length > 0)
            {
                return true;
            }
            else return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
