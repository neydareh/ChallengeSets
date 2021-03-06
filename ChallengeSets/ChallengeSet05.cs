﻿using System;
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
            // Variables
            int sum = 0;
            int nextNumber;

            // Check to see if numbers is null
            if (numbers == null) return 0;
            // Check for even number
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    // record index of even number 
                    // add one to the index of even number and add the number at that index the sum
                    nextNumber = i + 1;
                    sum = numbers[nextNumber] + sum;
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //Variables
            string output = "";

            if(words == null) return "";

            // Iterate through the words
            // Concatenate all word in words to form a sentence
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "" || words[i] == " " || words[i] == "  ")
                {
                    output += "";
                }
                else
                {
                    string temp = words[i].Trim();
                    output = output + temp + " ";
                    if (words[i] == words[words.Length - 1])
                    {
                        output = output.Trim();
                        output += ".";
                    }
                }
            }
            return output.Trim();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var newList = new List<double>();
            if (elements == null)
            {
                return newList.ToArray();
            }
            newList = elements.Where(elements => elements % 4 == 0).ToList();
            return newList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        { 
            HashSet<int> values = new HashSet<int>();
            foreach (int number in nums)
            {
                if (values.Contains(targetNumber - number)) return true;
                values.Add(number);
            }
            return false;
        }
    }
}
