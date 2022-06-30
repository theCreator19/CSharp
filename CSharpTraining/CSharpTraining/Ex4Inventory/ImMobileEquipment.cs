using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Ex4Inventory
{
    public class ImMobileEquipment : Equipment
    {
        public int Weight { get; set; }

        public ImMobileEquipment()
        {
            TypeOfEquipment = TypeOfEquipment.ImMobile;
        }
        public override void MoveBy(int distanceInKm)
        {
            MaintenanceCost += Weight * distanceInKm;
            DistanceMovedTill += distanceInKm;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Weight = {0}",Weight);
        }
    }
}
