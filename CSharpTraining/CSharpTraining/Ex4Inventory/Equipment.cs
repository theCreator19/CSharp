using System;
using System.Collections.Generic;

namespace CSharpTraining.Ex4Inventory
{
    public abstract class Equipment
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int MaintenanceCost { get; set; }

        public int DistanceMovedTill { get; set; }

        public TypeOfEquipment TypeOfEquipment { get; protected set; }



        public abstract void MoveBy(int distanceInKm);

        public virtual void ShowDetails()
        {
            Console.WriteLine("Name -  {0}", Name);
            Console.WriteLine("Destription - {0}",Description);
            Console.WriteLine("Maintenance Cost - {0}",MaintenanceCost);
            Console.WriteLine("Distance Moved Till Date - {0}",DistanceMovedTill);
            Console.WriteLine("Type of Equipment - {0}", TypeOfEquipment);
        }
        public virtual void ShowAllDetails()
        {
            Console.WriteLine("Name -  {0}", Name);
            Console.WriteLine("Destription - {0}", Description);
        }
    }
}
