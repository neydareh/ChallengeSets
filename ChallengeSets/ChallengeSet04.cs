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
            return ((sideLength1 + sideLength2 > sideLength3) && 
                (sideLength1 + sideLength3 > sideLength2) && 
                (sideLength2 + sideLength3 > sideLength1)) ? true : false;
        }

        public bool IsStringANumber(string input)
        {
            double num = 0;
            return double.TryParse(input, out num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var list = objs.Where(x => x == null).ToList();
            var non = objs.Where(x => x != null).ToList();

            return (list.Count() > non.Count()) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            if (numbers.All(x => x % 2 != 0)) return 0;
            if ((numbers.Length != 0)) return numbers.Where(x => x % 2 == 0).Average();
            else return 0;
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
            
        }
    }
}
