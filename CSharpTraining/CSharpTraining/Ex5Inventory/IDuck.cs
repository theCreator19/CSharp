using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Ex5Inventory
{
    public interface IDuck
    {
        public int Weight { get;}
        public int NumberOfWing { get; }

        public TypeOfDuck TypeOfDuck { get; }


        void ShowDetails();
        

    }
}
