using System;
using System.Collections.Generic;
using System.Text;
namespace CSharpTraining
{
    public class Exercise11
    {
        
        public void ExtensionOnInt()
        {
            //Instructions
            Console.WriteLine("Choose the below Option \n" +
                "Press 1 for IsOdd extension Method\n" +
                "Press 2 for IsEven extension Method\n" +
                "Press 3 for IsPrime extension Method\n" +
                "Press 4 for IsDivisibleBy extension Method\n" +
                "Press 0 to Exit");
            Console.Write("Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int intNumber;
            var exercise11 = new Exercise11();
            //cases as per choice 
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter an Integer Number");
                    intNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(intNumber.IsOdd());
                    break;
                case 2:
                    Console.WriteLine("Enter an Integer Number");
                    intNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(intNumber.IsEven());
                    break;
                case 3:
                    Console.WriteLine("Enter an Integer Number");
                    intNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(intNumber.IsPrime());
                    break;
                case 4:
                    Console.WriteLine("Enter the Integer number whose divisibility needs to be checked:");
                    intNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Integer number with which divisibility needs to be checked:");
                    int intdivNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(intNumber.IsDivisibleBy(intdivNumber));
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Enter Correct Choice");
                    break;
            }
        }
    }
}
