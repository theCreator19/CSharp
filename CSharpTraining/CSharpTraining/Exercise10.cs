using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise10
    {
        public void Execute()
        {
            ProrityQueueImplementation3<string> queue1 = new ProrityQueueImplementation3<string>();
            int choice;
            do
            {
                //cases as per choice
                Console.WriteLine("Press 1 for Enqueue\n" +
                                "Press 2 to Count\n" +
                                "Press 3 to Get Highest Priority\n" +
                                "press 4 for Peek Value\n" +
                                "Press 5 to check for contains" +
                                "Press 0 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    queue1.Enqueue(1, "Aman");

                    queue1.Enqueue(2, "Ashutosh");
                    queue1.Enqueue(3, "Rahul");

                }

                if (choice == 2)
                {
                    Console.WriteLine("COUNT {0}", queue1.Count());
                }
                if (choice == 3)
                {
                    Console.WriteLine("HIGHEST PRIORITY {0} ", queue1.GetHighestPriorityQueue());
                }

                if (choice == 4)
                {
                    Console.WriteLine("PEEK VALUE {0}", queue1.Peek());
                }
                if (choice == 5)
                {
                    Console.WriteLine("PEEK VALUE {0}", queue1.Contains("Aman"));
                }



            }
            while (choice != 0);
        }
    }
}
