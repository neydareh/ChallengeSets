﻿using System;
namespace NewChallengeSet
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return (number1 > number2) ? number2 : number1;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return (nameOfPerson != "") ? $"Hello, {nameOfPerson}!" : "Hello!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
