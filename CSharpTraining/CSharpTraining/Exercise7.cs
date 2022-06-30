using CSharpTraining.Ex5Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise7
    {
        public void Operations()
        {
            int choice;
            var inventory = new Inventory();
            do
            {
                //Instruction
                Console.WriteLine("Enter your choice from the below option\n" +
                    "Press 1 to Create a Duck\n" +
                    "Press 2 to Remove a Duck\n" +
                    "Press 3 to Remove all Ducks\n" +
                    "Press 4 to List Duck collection in increasing order of their weights.\n" +
                    "Press 5 to List Duck collection in increasing order of number of wings.\n" +
                    "Press 6 to Show All Ducks\n" +
                    "Press 0 to exit");
                Console.Write("Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        inventory.CreateDuck();
                        break;
                    case 2:
                        Console.Write("Enter the Name of Duck to Remove \n" +
                            "Press 1 to remove Rubber Duck\n" +
                            "Press 2 to remove Mallard Duck\n" +
                            "Press 3 to remove Redhead Duck\n" +
                            "Your Input : ");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        inventory.RemoveDuck(choose);
                        break;
                    case 3:
                        inventory.RemoveAllDuck();
                        break;
                    case 4:
                        inventory.ListAllDuckIncreasingWeight();
                        break;
                    case 5:
                        inventory.ListAllDuckIncreasingWing();
                        break;
                    case 6:
                        inventory.ShowDuck();
                        break;
                    case 0:
                        break;

                }
            }
            while (choice != 0);
        }
    }
}
