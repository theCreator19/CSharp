using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTraining
{
    public class Exercise12
    {

        public void LambdaAndDeligate()
        {

            IEnumerable<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };
            bool NumberGreaterThanFive(int number)
            {
                if (number > 5)
                { return true; }
                else { return false; }
            }
            bool NumberLessThanFive(int number)
            {
                return number < 5;
            }
            Console.WriteLine("List Elements : " + string.Join(", ", list));

            IEnumerable<int> odd = list.Where(e => e % 2 == 1);
            Console.Write("Odd Numbers : ");
            Console.WriteLine(string.Join(", ", odd));

            IEnumerable<int> even = list.Where(e => { return e % 2 == 0; });
            Console.Write("Even Numbers : ");
            Console.WriteLine(string.Join(", ", even));

            IEnumerable<int> primeAnonymous = list.Where(delegate (int n)
            {
                if (n <= 1)
                {
                    return false;
                }
                for (int i = 2; i < n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            });
            Console.Write("Prime Numbers - Anonymous Method : ");
            Console.WriteLine(string.Join(", ", primeAnonymous));

            IEnumerable<int> primeLambda = list.Where(e =>
            {
                if (e <= 1)
                {
                    return false;
                }
                for (int i = 2; i < e / 2; i++)
                {
                    if (e % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            });
            Console.Write("Prime Numbers Another - Lambda Method : ");
            Console.WriteLine(string.Join(", ", primeLambda));

            Func<int, bool> methodConversion = NumberGreaterThanFive;
            IEnumerable<int> elementGreaterThanFive = list.Where(methodConversion);
            Console.Write("Elements Greater than 5 : ");
            Console.WriteLine(string.Join(", ", elementGreaterThanFive));

            Func<int, bool> methodConversionLessThanFive = new Func<int, bool>(NumberLessThanFive);
            IEnumerable<int> elementLessThanFive = list.Where(NumberLessThanFive);
            Console.Write("Elements Less than 5  : ");
            Console.WriteLine(string.Join(", ", elementLessThanFive));

            Func<int, bool> lambdaExpression = new Func<int, bool>(n => n % 3 == 0);
            IEnumerable<int> threeMultiple = list.Where(lambdaExpression);
            Console.Write("Elements 3K  : ");
            Console.WriteLine(string.Join(", ", threeMultiple));

            Func<int, bool> threeMultiplePlusOne = new Func<int, bool>(delegate (int number) { return number % 3 == 1; });
            IEnumerable<int> elementThreeMultiplePlusOne = list.Where(threeMultiplePlusOne);
            Console.Write("Elements 3K + 1  : ");
            Console.WriteLine(string.Join(", ", elementThreeMultiplePlusOne));

            Func<int, bool> threeMultiplePlusTwo = n => n % 3 == 2;
            IEnumerable<int> elementThreeMultiplePlusTwo = list.Where(threeMultiplePlusTwo);
            Console.Write("Elements 3K + 2  : ");
            Console.WriteLine(string.Join(", ", elementThreeMultiplePlusTwo));

            int anyNumber = 5;
            Func<int, bool> findAnything = delegate (int number) { return number == anyNumber; };
            IEnumerable<int> anyElement = list.Where(findAnything);
            Console.Write("Any Element  : ");
            Console.WriteLine(string.Join(", ", anyElement));

            
            bool AnythingMethod(int number)
            {
                return number == anyNumber;
            }
            Func<int, bool> elementAny = AnythingMethod;
            IEnumerable<int> elementAnything = list.Where(elementAny);
            Console.Write("Any Element  : ");
            Console.WriteLine(string.Join(", ", elementAnything));
        }
    }
}
