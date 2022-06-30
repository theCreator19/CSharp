using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise3
    {
        public void PrimeNumberFind()
        {
            int smallNumber, largerNumber;
            Console.WriteLine("Enter 2 Positive non-equal Integer between 2 and 1000");
            do
            {
                Console.WriteLine("Enter Smaller Number :");
                string smallNo = Console.ReadLine();
                Console.WriteLine("Enter Larger Number :");
                string largerNo = Console.ReadLine();
                smallNumber = Convert.ToInt32(smallNo);
                largerNumber = Convert.ToInt32(largerNo);
                if (!(smallNumber >= 2 && smallNumber <= 1000 && largerNumber >= 2 && largerNumber <= 1000 && smallNumber != largerNumber && smallNumber < largerNumber))
                {
                    Console.WriteLine("Reenter both the Numbers");
                    continue;
                }
            }
            while (!(smallNumber >= 2 && smallNumber <= 1000 && largerNumber >= 2 && largerNumber <= 1000 && smallNumber != largerNumber && smallNumber < largerNumber));
            //Logic to get the Prime Numbers
            int i, count;
            while(smallNumber<largerNumber)
            {
                count = 0;
                i = 2;
                while(i<=smallNumber/2)
                {
                    if(smallNumber%i == 0)
                    {
                        count++;
                        break;
                    }
                    i++;

                }
                if(count ==0 && smallNumber!=1)
                {
                    Console.WriteLine(smallNumber);
                }
                smallNumber++;

            }
        }
    }
}
