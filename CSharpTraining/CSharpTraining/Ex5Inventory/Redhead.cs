using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Ex5Inventory
{
    public class Redhead : IDuck
    {
        public int Weight { get; set; }
        public int NumberOfWing { get; set; }
        public TypeOfDuck TypeOfDuck { get; set; }
        public Redhead()
        {
            TypeOfDuck = TypeOfDuck.Redhead;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Weight of Duck {0}", Weight);
            Console.WriteLine("Number OF Wing {0}", NumberOfWing);
            Console.WriteLine("Redhead Duck Fly Slow and Queak Mild");
        }
    }
}
