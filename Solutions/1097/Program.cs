using System;
using System.Collections.Generic;

namespace _1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Int32.TryParse(Console.ReadLine(), out n);
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Int32.Parse(numbers[j]);
                }
            }

            bool[] visited = new bool[n];
            PriorityQueue<Edge> queue = new PriorityQueue<Edge>((a, b)=>(a.distance - b.distance));
            visited[0] = true;
            for (int i = 1; i < n; i++)
            {
                queue.Enqueue(new Edge(0, i, matrix[0, i]));
            }
            int sum = 0;
            while(queue.Count!=0)
            {
                Edge peek = queue.Dequeue();
                //System.Console.WriteLine(peek.start+" "+peek.end+" "+peek.distance);
                if(visited[peek.start] && visited[peek.end]) continue;

                sum += peek.distance;
                if(!visited[peek.start])
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(i==peek.start || visited[i]) continue;
                        queue.Enqueue(new Edge(peek.start, i, matrix[peek.start, i]));
                    }
                }
                if(!visited[peek.end])
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(i==peek.end|| visited[i]) continue;
                        queue.Enqueue(new Edge(peek.end, i, matrix[peek.end, i]));
                    }
                }
                visited[peek.start] = true;
                visited[peek.end] = true;
            }
            System.Console.WriteLine(sum);
        }
    }

    public class Edge
    {
        public int start;
        public int end;
        public int distance;
        public Edge(int start, int end, int distance)
        {
            this.start = start;
            this.end = end;
            this.distance = distance;
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