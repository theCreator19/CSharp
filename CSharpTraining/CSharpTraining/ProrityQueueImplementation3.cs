using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class ProrityQueueImplementation3<T> where T : IEquatable<T>
    {
        private class PriorityNode
        {
            public int Property { get; set; }
            public T Item { get; set; }
            public IEnumerable<PriorityNode> Select { get; internal set; }

            public PriorityNode(int p, T i)
            {
                Property = p;
                Item = i;
            }
        }

        public int count { get; set; }

        private IList<PriorityNode> elements;
        public int max { get; set; }

        public ProrityQueueImplementation3()
        {
            elements = new List<PriorityNode>();
        }

        public void Enqueue(int prior, T item)
        {

            PriorityNode p = new PriorityNode(prior, item);
            p.Property = prior;
            p.Item = item;
            max = prior;


            // List<PriorityNode> p1 = new List<PriorityNode>(collection: p.Select( => );


            elements.Add(p);
            Console.WriteLine("Added Element index{0} , item {1}", prior, item);

            //   IList<PriorityNode>  e = elements.GetEnumerator();

        }
        public bool Contains(T item)
        {

            foreach (var v in elements)
            {
                if (v.Item.Equals(item))
                {
                    return true;
                }


            }
            return false;
        }

        public int Count()
        {


            return elements.Count;

        }
        
        public int GetHighestPriorityQueue()
        {
            int max1 = 0;
            foreach (var v in elements)
            {
                if (max >= v.Property)
                {
                    max1 = max;
                }
            }
            return max1;

        }
        public T type { get; set; }
        public T Peek()
        {
            foreach (var v in elements)
            {
                if (v.Property == max)
                {
                    type = v.Item;
                }
            }
            return type;
        }
    }
}
