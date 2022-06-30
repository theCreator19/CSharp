using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Ex5Inventory
{
    public class Rubber : IDuck
    {
        public int Weight { get; set; }
        public int NumberOfWing { get; set; }

        public TypeOfDuck TypeOfDuck { get; set; }
        public Rubber()
        {
            TypeOfDuck = TypeOfDuck.Rubber;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Weight of Duck {0}", Weight);
            Console.WriteLine("Number OF Wing {0}", NumberOfWing);
            Console.WriteLine("Rubber Duck Don't Fly and Squeak");
        }

    }
}
