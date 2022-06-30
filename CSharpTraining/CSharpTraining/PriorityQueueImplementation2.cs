using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    
    public class PriorityQueueImplementation2<T> : IPriority where T : IEquatable<T>
    {
        public IDictionary<int, T> idict;

        public int Priority { get; set; } = int.MinValue;

        public PriorityQueueImplementation2()
        {

            idict = new Dictionary<int, T>();
        }

        public PriorityQueueImplementation2(IDictionary<int, T> idict1)
        {

            idict = idict1;
        }



        public bool Contains(int key)
        {
            return idict.ContainsKey(key);
        }

        public T DeQueue()
        {

            // idict.TryGetValue(1);

            if (idict.TryGetValue(Priority, out T value))
            {
                idict.Remove(Priority);
                Priority = int.MinValue;
                foreach (var item in idict)
                {
                    if (item.Key > Priority)
                    {
                        Priority = item.Key;
                    }
                }
            }

            return value;
        }


        public void Enqueue(T item)
        {
            Console.WriteLine("ENTER PRIORITY");
            int p = Convert.ToInt32(Console.ReadLine());
            Priority = p;
            idict[Priority] = item;
            if (Priority < p)
            {
                Priority = p;
            }

            Console.WriteLine("  Enqueue Elemets ... ", idict.TryGetValue(Priority, out T value));
            Console.WriteLine(value);


        }
        public int Count()
        {

            return idict.Count;
        }
        public T Peek()
        {
            if (!idict.TryGetValue(Priority, out T value))
            {
                Console.WriteLine("Queue Is Empty ");
            }

            return value;

        }
        public int GetHighestPriority()
        {
            return Priority;
        }
    }
}
