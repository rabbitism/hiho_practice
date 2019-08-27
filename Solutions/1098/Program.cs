using System;
using System.Collections.Generic;

namespace _1098
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            int n = Int32.Parse(info[0]);
            int count = Int32.Parse(info[1]);

            UnionFind uf = new UnionFind(n+1);
            PriorityQueue<Edge> queue = new PriorityQueue<Edge>((a, b) => (a.distance - b.distance));
            for (int i = 0; i < count; i++)
            {
                string[] e = Console.ReadLine().Split();
                Edge edge = new Edge(Int32.Parse(e[0]), Int32.Parse(e[1]), Int32.Parse(e[2]));
                queue.Enqueue(edge);
            }
            int sum = 0;
            while(queue.Count!=0)
            {
                Edge peek = queue.Dequeue();
                if(uf.IsConnected(peek.start, peek.end)) continue;
                sum += peek.distance;
                uf.Union(peek.start, peek.end);
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

    public class UnionFind
    {
        int[] parent;
        int count;

        public UnionFind(int n)
        {
            parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }
            count = n;
        }

        private int GetParent(int i)
        {
            while(i!=parent[i])
            {
                parent[i] = GetParent(parent[i]);
                i = parent[i];
            }
            return parent[i];
        }

        public void Union(int i, int j)
        {
            int pa = GetParent(i);
            int pb = GetParent(j);
            if(pa==pb) return;
            parent[pa] = pb;
            count--;
        }

        public int Find(int a)
        {
            return GetParent(a);
        }

        public bool IsConnected(int i , int j)
        {
            return GetParent(i) == GetParent(j);
        }
    }
}
