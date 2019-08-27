using System;
using System.Collections.Generic;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Int32.TryParse(Console.ReadLine(), out count);
            UnionFind uf = new UnionFind();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                if(input[0]=="0")
                {
                    uf.Union(input[1], input[2]);
                }
                else{
                    if(uf.IsConnected(input[1], input[2]))
                    {
                        System.Console.WriteLine("yes");
                    }
                    else
                    {
                        System.Console.WriteLine("no");
                    }
                }

            }
        }
    }

    public class UnionFind
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        Dictionary<int, int> parent = new Dictionary<int, int>();
        int count;

        public UnionFind()
        {
            count = 0;
        }

        private void Add(string a)
        {
            if(dict.ContainsKey(a)) return;
            count++;
            dict[a] = count;
            parent[dict[a]] = dict[a];
        }

        private int GetParent(string a)
        {
            if(!dict.ContainsKey(a))
            {
                throw new KeyNotFoundException("a is not registered");
            }
            return GetParent(dict[a]);
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

        public void Union(string a, string b)
        {
            Add(a);
            Add(b);
            int pa = GetParent(a);
            int pb = GetParent(b);
            if(pa==pb) return;
            parent[pa] = pb;
        }

        public int Find(string a)
        {
            return GetParent(a);
        }

        public bool IsConnected(string a , string b)
        {
            Add(a);
            Add(b);
            return GetParent(a) == GetParent(b);
        }
    }
}
