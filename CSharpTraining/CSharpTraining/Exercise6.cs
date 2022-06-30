using CSharpTraining.Ex4Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise6
    {
        public void Operations()
        {
            int choice;
            var inventory = new Inventory();
            do
            {
                Console.WriteLine("Enter your choice from the below option\n" +
                    "Press 1 to Create an equipment – mobile and immobile\n" +
                    "Press 2 to Delete an equipment\n" +
                    "Press 3 to Move an equipment – mobile and immobile\n" +
                    "Press 4 to List all equipment\n" +
                    "Press 5 to Show details of all equipment\n" +
                    "Press 6 to List all Mobile equipment\n" +
                    "Press 7 to List all ImMobile equipment\n" +
                    "Press 8 to List all equipment that have not been moved till now\n" +
                    "Press 9 to Delete all equipment\n" +
                    "Press 10 to Delete all ImMobile equipment\n" +
                    "Press 11 to Delete all Mobile equipment\n" +
                    "Press 0 to exit");
                Console.Write("Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        inventory.CreateEquipment();
                        break;
                    case 2:
                        Console.Write("Enter the Name of Equipment to delete : ");
                        string name = Console.ReadLine();
                        inventory.DeleteEquipment(name);
                        break;
                    case 3:
                        Console.WriteLine("Enter Name of Equipment");
                        string _name = Console.ReadLine();
                        Console.WriteLine("Enter distance");
                        int distance = Convert.ToInt32(Console.ReadLine());
                        inventory.MoveEquip(_name, distance);
                        break;
                    case 4:
                        inventory.ListAllEquipment();
                        break;
                    case 5:
                        inventory.ShowEquipment();
                        break;
                    case 6:
                        inventory.ListMobileEquipment();
                        break;
                    case 7:
                        inventory.ListImMobileEquipment();
                        break;
                    case 8:
                        inventory.ListUnMovedEquipment();
                        break;
                    case 9:
                        inventory.DeleteAllEquipment();
                        break;
                    case 10:
                        inventory.DeleteImMobileEquipment();
                        break;
                    case 11:
                        inventory.DeleteMobileEquipment();
                        break;
                    case 0:
                        break;

                }
            }
            while (choice != 0);
        }
    }
}
