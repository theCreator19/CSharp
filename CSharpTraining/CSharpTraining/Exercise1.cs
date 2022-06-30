using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise1
    {
        
        //to convert entered input to integer
        public void ConvertUserInputToInteger()
        {
            Console.WriteLine("Enter User input");
            string userInput = Console.ReadLine();
            Console.WriteLine("Converted User Input {0} to Integer", userInput);
            Console.WriteLine("Using 'int.Parse' ");
            Console.WriteLine(int.Parse(userInput));
            Console.WriteLine("Using 'ToInt32' method ");
            Console.WriteLine(Convert.ToInt32(userInput));
            Console.WriteLine("Using 'int.TryParse' method");
            Console.WriteLine(int.TryParse(userInput,out int res));
        }
        //to convert entered input to float
        public void ConvertUserInputToFloat()
        {
            Console.WriteLine("Enter User input");
            string userInput = Console.ReadLine();
            Console.WriteLine("Converted User Input {0} to  Float", userInput);
            Console.WriteLine("Using 'float.Parse' ");
            Console.WriteLine(float.Parse(userInput));
            Console.WriteLine("Using 'ToDouble' method ");
            Console.WriteLine(Convert.ToDouble(userInput));
        }
        //to convert entered input to Boolean
        public void ConvertUserInputToBool()
        {
            Console.WriteLine("Enter User input");
            string userInput = Console.ReadLine();
            Console.WriteLine("Converted User Input {0} to  Bool", userInput);
            Console.WriteLine("Using 'bool.Parse' ");
            Console.WriteLine(bool.Parse(userInput));
            Console.WriteLine("Using 'Convert.ToBoolean' method ");
            Console.WriteLine(Convert.ToBoolean(userInput));
        }
        public void ExecuteConversion()
        {
            Console.WriteLine("Enter your choice to convert into:-\n" +
                "press 1 for Integer\n" +
                "press 2 for Float\n" +
                "press 3 for Bool");
            string userInput = Console.ReadLine();
            int choice = Convert.ToInt32(userInput);
            switch (choice)
            {
                case 1:
                    ConvertUserInputToInteger();
                    break;
                case 2:
                    ConvertUserInputToFloat();
                    break;
                case 3:
                    ConvertUserInputToBool();
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;
            }
        }
    }
}
