using System;
using System.Collections.Generic;
using System.Text;

namespace _1335
{
    class Program
    {
        static void Main(string[] args)
        {
            UnionFind uf = new UnionFind();
            int count = int.Parse(Console.ReadLine());
            Dictionary<int, string> indexes = new Dictionary<int, string>();
            for(int i = 0; i< count; i++)
            {
                string[] information = Console.ReadLine().Split();
                string username = information[0];
                int emailCount = int.Parse(information[1]);
                indexes.Add(i, username);
                for(int j = 0; j<emailCount; j++)
                {
                    uf.Add(information[2+j], information[2], i);
                }

            }
            //uf.Print();
            var result = uf.GetList();
            foreach(var key in result.Keys)
            {
                List<int> index = new List<int>(result[key]);
                index.Sort();
                StringBuilder sb = new StringBuilder();
                foreach(var number in index)
                {
                    if(sb.Length!=0) sb.Append(" ");
                    sb.Append(indexes[number]);
                    //System.Console.Write(indexes[number]);
                }
                System.Console.WriteLine(sb.ToString());
            }
        }
    }

    class UnionFind
    {
        Dictionary<string, string> parents = new Dictionary<string, string>();
        Dictionary<string, HashSet<int>> indexes = new Dictionary<string, HashSet<int>>();

        public void Add(string child, string parent, int index)
        {
            if(!parents.ContainsKey(child)) parents.Add(child, parent);
            else 
            {
                if(parents.ContainsKey(parent)) parents[parent]=parents[child];
                else parents.Add(parent, parent);
            }
            if(!indexes.ContainsKey(child)) indexes.Add(child, new HashSet<int>{index});
            else{
                indexes[child].Add(index);
            }
        }

        public string GetParent(string child)
        {
            while(parents[child]!=child)
            {
                child = parents[child];
            }
            return child;
        }

        public void Print()
        {
            foreach(string key in parents.Keys)
            {
                System.Console.WriteLine(key+" "+GetParent(key));
            }
        }

        public Dictionary<string, HashSet<int>> GetList()
        {
            Dictionary<string, HashSet<int>> result = new Dictionary<string, HashSet<int>>(); 
            foreach(string key in parents.Keys)
            {
                string parent = GetParent(key);
                if(result.ContainsKey(parent))
                {
                    foreach(var index in indexes[key])
                    {
                        result[parent].Add(index);
                    }
                } 
                else result.Add(parent, new HashSet<int>(indexes[key]));
            }
            return result;
        }
    }
}
