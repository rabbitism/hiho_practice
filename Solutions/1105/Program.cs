using System;
using System.Collections.Generic;

namespace _1105
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>((a, b) => (b - a));
            int count = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] events = Console.ReadLine().Split();
                if(events[0]=="A")
                {
                    queue.Enqueue(Int32.Parse(events[1]));
                }
                else{
                    System.Console.WriteLine(queue.Dequeue());
                }
            }
        }
    }

    public class PriorityQueue<T>
    {
        Func<T,T,int> comparer;
        List<T> data;

        public int Count => data.Count;
        public PriorityQueue(Func<T,T,int> func)
        {
            this.comparer = func;
            this.data = new List<T>();
        }

        public void Enqueue(T t)
        {
            data.Add(t);
            ShiftUp(Count - 1);
        }

        public T Dequeue()
        {
            if(Count==0) {
                throw new InvalidOperationException("Empty Queue");
            }
            T result = data[0];
            data[0] = data[Count - 1];
            data.RemoveAt(Count - 1);
            ShiftDown(0);
            return result;
        }

        public T Peek()
        {
            if(data.Count==0)
                throw new InvalidOperationException("Empty Queue");
            return data[0];
        }

        private int GetParent(int i)
        {
            if(i>=Count)
            {
                throw new IndexOutOfRangeException("index ot of range");
            }
            return (i - 1) / 2;
        }

        private int GetLeftChild(int i)
        {
            return 2 * i + 1;
        }
        
        private int GetRightChild(int i)
        {
            return 2 * i + 2;
        } 

        private void Swap(int i , int j)
        {
            if(i==j) return;
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }

        private void ShiftUp(int i)
        {
            if(i==0) return;
            int parent = GetParent(i);
            if(comparer(data[i], data[parent])>=0) return;
            Swap(i, parent);
            ShiftUp(parent);

        }

        private void ShiftDown(int i)
        {
            if(GetLeftChild(i)>=Count) return;
            int child = GetLeftChild(i);
            int rightChild = GetRightChild(i);
            if(rightChild<Count && comparer(data[child], data[rightChild])>0)
            {
                child = rightChild;
            }
            if(comparer(data[i], data[child])<0) return;
            Swap(i, child);
            ShiftDown(child);
        }
    }
}
