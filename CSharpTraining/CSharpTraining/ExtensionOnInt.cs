using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public static class ExtensionOnInt
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool IsPrime(this int number)
        {

            if (number == 1)
            {
                return true;
            }
            else
            {
                int count = 0;
                int i = 2;
                while (i <= number / 2)
                {
                    if (number % i == 0)
                    {
                        count++;
                        break;
                    }
                    i++;
                }
                return count == 0;
            }
        }
        public static bool IsDivisibleBy(this int number, int diviser)
        {
            if(number % diviser == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
