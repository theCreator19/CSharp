using CSharpTraining.Ex5Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise5 : Inventory
    {
        public void Execute()
        {
            int option;
            var inventory = new Inventory();
            do
            {
                Console.WriteLine("Enter your Choice\n" +
                    "Press 1 to Create an Duck\n" +
                    "Press 2 to Show details of the Duck\n" +
                    "Press 0 to exit");
                string userInput = Console.ReadLine();
                option = Convert.ToInt32(userInput);
                switch (option)
                {
                    case 1:
                        inventory.CreateDuck();
                        break;
                    case 2:
                        inventory.ShowDuck();
                        break;
                    default:
                        Console.WriteLine("Enter Correct value");
                        break;
                }
            }
            while (option != 0);
        }
    }
}
