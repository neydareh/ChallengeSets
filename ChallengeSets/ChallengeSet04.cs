using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var even = numbers.Where(num => num % 2 == 0).ToList();
            var odd = numbers.Where(num => num % 2 != 0).ToList();
            return even.Sum() - odd.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>();
            list.Add(str1.Length);
            list.Add(str2.Length);
            list.Add(str3.Length);
            list.Add(str4.Length);

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>();
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);

            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
