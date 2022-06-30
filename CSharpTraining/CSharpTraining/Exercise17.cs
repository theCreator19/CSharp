using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise17
    {
        public void Validate(int inputNumber)
        {
            //using exceptions to avoid error when user gives wrong input
            try
            {

                if (inputNumber == 1)
                {
                    Console.Write("Enter Even Number : ");
                    int evenNo = Convert.ToInt32(Console.ReadLine());
                    if (evenNo % 2 == 0)
                    {
                        Console.WriteLine("True");

                    }
                    else
                    {
                        throw new CustomException("Error : Entered Number is not a Even No.");
                    }
                }
                if (inputNumber == 2)
                {
                    Console.WriteLine("Enter Odd Number");
                    int oddNo = Convert.ToInt32(Console.ReadLine());
                    if (oddNo % 2 != 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        throw new CustomException("Error : Entered Number is not a Odd No.");
                    }
                }
                if (inputNumber == 3)
                {
                    Console.WriteLine("Enter a Prime Number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        int count = 0;
                        int i = 2;
                        while (i <= number / 2)
                        {
                            if (number % i == 0)
                            {
                                //count++;
                                throw new CustomException("Error : Entered Number is not a Prime No.");
                            }
                            i++;
                        }
                        if (count == 0)
                        {
                            Console.WriteLine(true);
                        }

                    }
                }
                if (inputNumber == 4)
                {
                    Console.WriteLine("Enter a Negative Number");
                    int negativeNumber = Convert.ToInt32(Console.ReadLine());
                    if (negativeNumber < 0)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        throw new CustomException("Error : Entered Number is not a Negative No.");
                    }

                }
                if (inputNumber == 5)
                {
                    Console.WriteLine("Enter Zero");
                    int zeroNumber = Convert.ToInt32(Console.ReadLine());
                    if (zeroNumber == 0)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        throw new CustomException("Error : Entered Number is not Zero.");
                    }
                }
            }
            //this will catch the exception for any in valid Input
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }

        }
            
    }
}
