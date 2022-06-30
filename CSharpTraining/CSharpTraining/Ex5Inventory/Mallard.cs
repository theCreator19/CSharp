using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Ex5Inventory
{
    public class Mallard: IDuck
    {
        public int Weight { get; set; }
        public int NumberOfWing { get; set; }
        public TypeOfDuck TypeOfDuck { get; set; }
        public Mallard()
        {
            TypeOfDuck = TypeOfDuck.Mallard;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Weight of Duck {0}", Weight);
            Console.WriteLine("Number OF Wing {0}", NumberOfWing);
            Console.WriteLine("Rubber Duck Fly Fast and Queak Loud");
        }
    }
}
