using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Exercise9
    {
        public void Execute()
        {
            PriorityQueueImplementation2<string> queue1 = new PriorityQueueImplementation2<string>();
            int choice;
            do
            {

                Console.WriteLine("Press 1 for Enqueue\n" +
                                "Press 2 for Dequeue\n" +
                                "Press 3 for Count\n" +
                                "Press 4 to Get Highest Priority\n" +
                                "press 5 for Peek Value\n" +
                                "Press 0 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    queue1.Enqueue( "Aman");

                    queue1.Enqueue( "Agarwal");
                    queue1.Enqueue( "Rahul");

                }
                if (choice == 2)
                {
                    Console.WriteLine(queue1.DeQueue());
                }
                if (choice == 3)
                {
                    Console.WriteLine("COUNT {0}", queue1.Count());
                }
                if (choice == 4)
                {
                    Console.WriteLine("HIGHEST PRIORITY {0} ", queue1.GetHighestPriority());
                }
                if (choice == 5)
                {
                    Console.WriteLine("PEEK VALUE {0}", queue1.Peek());
                }
                if (choice == 6)
                {
                    Console.WriteLine("PEEK VALUE {0}", queue1.Contains(2));
                }



            }
            while (choice != 0);
        }
    }
}
