using CSharpTraining.Ex4Inventory;
using System;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Instruction for Different Exercises
                Console.WriteLine("Read the Instructions below\n" +
                    "Press 1 for Exercise 1\n" +
                    "Press 2 for Exercise 2\n" +
                    "Press 3 for Exercise 3\n" +
                    "Press 4 for Exercise 4\n" +
                    "Press 5 for Exercise 5\n" +
                    "Press 6 for Exercise 6\n" +
                    "Press 7 for Exercise 7\n" +
                    "Press 8 for Exercise 8\n" +
                    "Press 9 for Exercise 9\n" +
                    "Press 10 for Exercise 10\n" +
                    "Press 11 for Exercise 11\n" +
                    "Press 12 for Exercise 12\n" +
                    "Press 13 for Exercise 13\n" +
                    "Press 14 for Exercise 14\n" +
                    "Press 15 for Exercise 15\n" +
                    "Press 16 for Exercise 16\n" +
                    "Press 17 for Exercise 17");
                //Enter your Choice
                Console.Write("Your Choice : ");
                //Read UserInput for different exercises
                int userInput = Convert.ToInt32(Console.ReadLine());
                int intInput;
                //using switch case we will move to different cases.
                switch (userInput)
                {
                    case 1:
                        //Take you in Exercise 1
                        Console.WriteLine("Welcome To Exercise 1");
                        //Creating Instance
                        var exercise1 = new Exercise1();
                        int convertToInt;
                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            string loop;
                            Console.WriteLine("Press 1 to continue in Exercise 1 and 0 to exit from Exercise 1 : ");
                            loop = Console.ReadLine();
                            convertToInt = Convert.ToInt32(loop);
                            if (convertToInt == 1)
                            {
                                exercise1.ExecuteConversion();
                            }
                        }
                        while (convertToInt != 0);
                        break;
                    case 2:
                        //Take you in Exercise 2
                        Console.WriteLine("Welcome To Exercise 2");
                        //Creating Instance
                        var exercise2 = new Exercise2();
                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            string loop;
                            Console.WriteLine("Press 1 to continue in Exercise 2 and 0 to exit from Exercise 2 : ");
                            loop = Console.ReadLine();
                            convertToInt = Convert.ToInt32(loop);
                            if (convertToInt == 1)
                            {
                                exercise2.Execute();
                            }
                        }
                        while (convertToInt != 0);

                        break;
                    case 3:
                        //Take you in Exercise 3
                        Console.WriteLine("Welcome To Exercise 3");
                        //Creating Instance
                        var exercise3 = new Exercise3();
                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            string loop;
                            Console.WriteLine("Press 1 to continue in Exercise 3 and 0 to exit from Exercise 3 : ");
                            loop = Console.ReadLine();
                            convertToInt = Convert.ToInt32(loop);
                            if (convertToInt == 1)
                            {
                                exercise3.PrimeNumberFind();
                            }
                        }
                        while (convertToInt != 0);
                        break;
                    case 4:
                        //Take you in Exercise 4
                        Console.WriteLine("Welcome To Exercise 4");
                        //Creating Instance
                        var exercise4 = new Exercise4();
                        exercise4.ExecuteCode();
                        break;
                    case 5:
                        //Take you in Exercise 5
                        Console.WriteLine("Welcome To Exercise 5");
                        //Creating Instance
                        var exercise5 = new Exercise5();
                        exercise5.Execute();
                        break;
                    case 6:
                        //Take you in Exercise 6
                        Console.WriteLine("Welcome To Exercise 6");
                        //Creating Instance
                        var exercise6 = new Exercise6();
                        exercise6.Operations();
                        break;
                    case 7:
                        //Take you in Exercise 7
                        Console.WriteLine("Welcome To Exercise 7");
                        //Creating Instance
                        var exercise7 = new Exercise7();
                        exercise7.Operations();
                        break;
                    case 8:
                        //Take you in Exercise 8
                        Console.WriteLine("Welcome To Exercise 8");

                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            Console.WriteLine("Press 1 to continue in Exercise 8 and 0 to exit ");
                            intInput = Convert.ToInt32(Console.ReadLine());
                            if (intInput == 1)
                            {
                                //Creating Instance
                                var exercise8 = new Exercise8();
                                exercise8.Execute();
                            }
                        }
                        while (intInput != 0);
                        break;
                    case 9:
                        //Take you in Exercise 9
                        Console.WriteLine("Welcome To Exercise 9");
                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            Console.WriteLine("Press 1 to continue in Exercise 9 and 0 to exit ");
                            intInput = Convert.ToInt32(Console.ReadLine());
                            if (intInput == 1)
                            {
                                //Creating Instance
                                var exercise9 = new Exercise9();
                                exercise9.Execute();
                            }
                        }
                        while (intInput != 0);
                        break;
                    case 10:
                        //Take you in Exercise 10
                        Console.WriteLine("Welcome To Exercise 10");
                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            Console.WriteLine("Press 1 to continue in Exercise 10 and 0 to exit ");
                            intInput = Convert.ToInt32(Console.ReadLine());
                            if (intInput == 1)
                            {
                                //Creating Instance
                                var exercise10 = new Exercise10();
                                exercise10.Execute();
                            }
                        }
                        while (intInput != 0);
                        break;
                    case 11:
                        //Take you in Exercise 11
                        Console.WriteLine("Welcome To Exercise 11");
                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            Console.WriteLine("Press 1 to continue in Exercise 11 and 0 to exit ");
                            intInput = Convert.ToInt32(Console.ReadLine());
                            if (intInput == 1)
                            {
                                //Creating Instance
                                var exercise11 = new Exercise11();
                                exercise11.ExtensionOnInt();
                            }
                        }
                        while (intInput != 0);
                        break;
                    case 12:
                        //Take you in Exercise 12
                        Console.WriteLine("Welcome To Exercise 12");
                        //Creating Instance
                        var exercise12 = new Exercise12();
                        exercise12.LambdaAndDeligate();
                        break;
                    case 13:
                        //Take you in Exercise 13
                        Console.WriteLine("Welcome To Exercise 13");
                        //Creating Instance
                        var exercise13 = new Exercise13();
                        exercise13.MainMethod();
                        break;
                    case 14:
                        //Take you in Exercise 14
                        Console.WriteLine("Welcome To Exercise 14");
                        //Creating Instance
                        var exercise14 = new Ex15Inventory.Inventory();
                        exercise14.ProductDictionary();
                        break;
                    case 15:
                        //Take you in Exercise 15
                        Console.WriteLine("Welcome To Exercise 15");
                        //Creating Instance
                        var exercise15 = new Exercise15();
                        exercise15.Runnable();
                        break;
                    case 16:
                        //Take you in Exercise 16
                        Console.WriteLine("Welcome To Exercise 16");
                        //Creating Instance
                        var exercise16 = new Exercise16();
                        exercise16.FileOperation();
                        break;
                    case 17:
                        //Take you in Exercise 17
                        Console.WriteLine("Welcome To Exercise 17");
                        //It is loop if user wish to run this Exerercise again
                        do
                        {
                            Console.WriteLine("Press 1 to continue in Exercise 17 and 0 to exit  ");
                            intInput = Convert.ToInt32(Console.ReadLine());
                            if (intInput == 1)
                            {
                                int inputNumber;
                                int count = 0;
                                while(count<5)
                                
                                {
                                    Console.WriteLine("Enter any number from 1-5");
                                    inputNumber = Convert.ToInt32(Console.ReadLine());
                                    //Creating Instance
                                    var exercise17 = new Exercise17();
                                    exercise17.Validate(inputNumber);
                                    count++;

                                }
                                Console.WriteLine("You have played the Game for 5 times");
                                
                            }
                        }
                        while (intInput != 0);
                        break;
                    default:
                        Console.WriteLine("You have Entered wrong Input");
                        break;
                }
            }
            catch (Exception ) 
            {
                Console.WriteLine("You have Entered the Wrong Input from the instruction Given ");
            }

        }
    }
}
