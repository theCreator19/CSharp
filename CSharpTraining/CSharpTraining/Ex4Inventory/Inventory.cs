using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTraining.Ex4Inventory
{
    public class Inventory
    {
        public List<Equipment> Equipments = new List<Equipment>();


        public void CreateEquipment()
        {
            Console.WriteLine("Enter Your choice\n" +
                "Press 1 for Mobile \n" +
                "Press 2 for ImMobile");
            string input = Console.ReadLine();
            int option = Convert.ToInt32(input);
            
            if(option == 1 || option ==2)
            {
                CreateAllEquipment((TypeOfEquipment)option);
            }
            else
            {
                Console.WriteLine("Enter Correct Choice");
            }

        }
        public void CreateAllEquipment(TypeOfEquipment type)
        {

            Equipment equipment = null;//=new MobileEquipment();


            string name, description;
            Console.WriteLine("Enter Equipment Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Description");
            description = Console.ReadLine();
            if (type == TypeOfEquipment.Mobile)
            {
                Console.WriteLine("Enter Number Of Wheels");
                int numWheel = Convert.ToInt32(Console.ReadLine());
                equipment = new MobileEquipment
                {
                    Name = name,
                    Description = description,
                    NumberOfWheel = numWheel
                };
            }
            else if (type == TypeOfEquipment.ImMobile)
            {
                Console.WriteLine("Enter Weight of Equipment");
                int weight = Convert.ToInt32(Console.ReadLine());
                equipment = new ImMobileEquipment()
                {
                    Name = name,
                    Description = description,
                    Weight = weight
                };
            }
            else
            {
                Console.WriteLine("Enter correct Type Of Equipment");
            }

            Equipments.Add(equipment);
        }

        public void MoveEquip(string name, int di)
        {
            Equipments.First(e => e.Name == name).MoveBy(di);

        }

        public void DeleteEquipment(string name)
        {
            Equipments.RemoveAll(e => e.Name == name);
        }

        public void ShowEquipment()
        {
            Equipments.ForEach(r => r.ShowDetails());
        }
        public void ListAllEquipment()
        {
            Equipments.ForEach(r => r.ShowAllDetails());
        }
        public void ListMobileEquipment()
        {
            Equipments.FindAll(e => e.TypeOfEquipment == TypeOfEquipment.Mobile ).ForEach(r=>r.ShowDetails());
        }
        public void ListImMobileEquipment()
        {
            Equipments.FindAll(e => e.TypeOfEquipment == TypeOfEquipment.ImMobile).ForEach(r => r.ShowDetails());
        }
        public void ListUnMovedEquipment()
        {
            Equipments.FindAll(e => e.DistanceMovedTill == 0).ForEach(r => r.ShowDetails());
        }
        public void DeleteAllEquipment()
        {
            Equipments.Clear();
        }
        public void DeleteImMobileEquipment()
        {
            Equipments.RemoveAll(e => e.TypeOfEquipment == TypeOfEquipment.ImMobile);
        }
        public void DeleteMobileEquipment()
        {
            Equipments.RemoveAll(e => e.TypeOfEquipment == TypeOfEquipment.Mobile);
        }

    }
}
