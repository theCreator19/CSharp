using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Ex4Inventory
{
    public class MobileEquipment : Equipment
    {
        public int NumberOfWheel { get; set; }

        public MobileEquipment()
        {
            TypeOfEquipment = TypeOfEquipment.Mobile;
        }

        public override void MoveBy(int distanceInKm)
        {
            MaintenanceCost += NumberOfWheel * distanceInKm;
            DistanceMovedTill += distanceInKm;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("NumberOfWheel -  {0} ", NumberOfWheel);
        }
    }
}
