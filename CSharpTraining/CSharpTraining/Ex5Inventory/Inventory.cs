using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTraining.Ex5Inventory
{
    public class Inventory
    {
        public List<IDuck> Ducks = new List<IDuck>();

        public void CreateDuck()
        {
            Console.WriteLine("Enter Your choice\n" +
                "Press 1 for Rubber Duck \n" +
                "Press 2 for Mallard Duck\n" +
                "Press 3 for Redhead Duck");
            string input = Console.ReadLine();
            int option = Convert.ToInt32(input);

            if (option == 1 || option == 2 || option == 3)
            {
                CreateAllDuck((TypeOfDuck)option);
            }
            else
            {
                Console.WriteLine("You have Entered Wrong Choice");
            }
        }
        public void CreateAllDuck(TypeOfDuck type)
        {
            IDuck duck = null;
            Console.Write("Enter Weight of the Duck : ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number Of Wings : ");
            int numberOfWing = Convert.ToInt32(Console.ReadLine());
            if (type == TypeOfDuck.Rubber)
            {
                duck = new Rubber()
                {
                    Weight = weight,
                    NumberOfWing = numberOfWing
                };
            }
            else if (type == TypeOfDuck.Mallard)
            {
                duck = new Mallard()
                {
                    Weight = weight,
                    NumberOfWing = numberOfWing
                };
            }
            else if (type == TypeOfDuck.Redhead)
            {
                duck = new Redhead()
                {
                    Weight = weight,
                    NumberOfWing = numberOfWing
                };
            }
            else
            {
                Console.WriteLine("Enter correct Type Of Duck");
            }
            Ducks.Add(duck);
        }
        public void ShowDuck()
        {
            Ducks.ForEach(r => r.ShowDetails());
        }
        public void RemoveDuck(int choose)
        {
            if (choose == 1)
            {
                Ducks.RemoveAll(e => e.TypeOfDuck == TypeOfDuck.Rubber);
            }
            else if (choose == 2)
            {
                Ducks.RemoveAll(e => e.TypeOfDuck == TypeOfDuck.Rubber);
            }
            else if (choose == 3)
            {
                Ducks.RemoveAll(e => e.TypeOfDuck == TypeOfDuck.Rubber);
            }
            else
            {
                Console.WriteLine("You have entered wrong Input");
            }
        }
        public void RemoveAllDuck()
        {
            Ducks.Clear();
        }
        public void ListAllDuckIncreasingWeight()
        {
            Ducks = Ducks.OrderBy(e => e.Weight).ToList();
            Ducks.ForEach(e => e.ShowDetails());
        }
        public void ListAllDuckIncreasingWing()
        {
            Ducks=Ducks.OrderBy(e => e.NumberOfWing).ToList();
            Ducks.ForEach(e => e.ShowDetails());
        }
    }
}
