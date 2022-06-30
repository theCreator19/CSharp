using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{

    public class PriorityQueueImplementation1<T> where T : IEquatable<T>
    {
        
        private IDictionary<int, T> idict;

        public int Priority { get; set; } = int.MinValue;

        public PriorityQueueImplementation1()
        {
            idict = new Dictionary<int, T>();
        }

        public PriorityQueueImplementation1(IDictionary<int, T> idict1)
        {
            idict = idict1;
        }

        //public int count { get; set; }

        public int Count()
        {
            
            return idict.Count;
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
        public void Enqueue(int priority, T item)
        {
            idict[priority] = item;
            if (priority > Priority)
            {
                Priority = priority;
            }
            Console.WriteLine("  Enqueue Elemets ... ", idict.TryGetValue(priority, out T value));
            Console.WriteLine(value);
        }

        public T Peek()
        {
            if (!(idict.TryGetValue(Priority, out T value)))
            {
                // throw new Exception.CustomException("Queue is empty");
                Console.WriteLine("Queue is Empty");
            }
            return value;

        }
        public int GetHighestPriority()
        {
            return Priority;
        }
    }
}
