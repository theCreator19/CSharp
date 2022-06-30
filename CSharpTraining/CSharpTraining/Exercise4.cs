using CSharpTraining.Ex4Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise4 : Inventory
    {
        public void ExecuteCode()

        {
            int option;
            var inventory = new Inventory();
            do
            {
                Console.WriteLine("Enter your Choice from the options Below\n" +
                    "Press 1 to Create an equipment – mobile and immobile\n" +
                    "Press 2 to Move an equipment – mobile and immobile\n" +
                    "Press 3 to Show details of an equipment.\n" +
                    "Press 0 to exit");
                string userInput = Console.ReadLine();
                option = Convert.ToInt32(userInput);
                switch (option)
                {
                    case 1:
                        inventory.CreateEquipment();
                        break;
                    case 2:
                        Console.WriteLine("Enter Name of Equipment");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter distance");
                        int distance = Convert.ToInt32(Console.ReadLine());
                        inventory.MoveEquip(name, distance);
                        break;
                    case 3:                    
                        inventory.ShowEquipment();
                        break;
                    default:
                        Console.WriteLine("Enter Correct value");
                        break;
                }
            }
            while (option!=0);
        }
    }
}
