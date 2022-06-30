using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise2
    {
        

        public void Execute()
        {
            Console.WriteLine("For this exercise You have to enter 2 Inputs");
            Console.WriteLine("Enter Input 1 : ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Enter Input 2 : ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Using '==' Operator");
            // "==" operator will compare the 2 inputs whether they are equal or not.
            Console.WriteLine(userInput1 == userInput2);
            Console.WriteLine("Using 'Object.Equals' : ");
            // This compares userInput1 with userInput2 and check whether the contents are equal or not.
            Console.WriteLine("Input1 and Input 1 are same: {0}", userInput1.Equals(userInput2));
            Console.WriteLine("Using 'Object.ReferenceEquals' : ");
            //this compares inputs only By the References of the userInput1 and userInput2 and check whether they are equal or not
            Console.WriteLine("Input1 and Input 1 are same: {0}",object.ReferenceEquals(userInput1, userInput2));
            


        }
    }
}
