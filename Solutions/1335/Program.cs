using System;
using System.Collections.Generic;

namespace _1335
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            UnionFind uf = new UnionFind();
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                names.Add(name);
                int count = Int32.Parse(info[1]);
                uf.Add(name, name);
                for (int j = 2; j < info.Length; j++)
                {
                    uf.Add(info[j], name);
                }
            }
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach(string name in names)
            {
                string parent = uf.Find(name);
                if(dict.ContainsKey(parent)) dict[parent].Add(name);
                else dict[parent] = new List<string>() { name };
            }
            Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
            foreach(string parent in dict.Keys)
            {
                dict2[dict[parent][0]] = dict[parent];
            }
            foreach(string name in names)
            {
                if(dict2.ContainsKey(name))
                {
                    System.Console.WriteLine(string.Join(" ", dict2[name]));
                }
            }
        }
    }

    public class UnionFind
    {
        Dictionary<string, string> parent = new Dictionary<string, string>();
        public int Count => parent.Count;
        public UnionFind()
        {

        }

        public void Add(string s, string parent)
        {
            if(!this.parent.ContainsKey(parent)) this.parent[parent] = parent;
            if(this.parent.ContainsKey(s))
            {
                Union(this.parent[s], parent);
            }
            else{
                this.parent[s] = parent;
            }
        }

        public string Find(string s)
        {
            while(parent[s]!=s)
            {
                parent[s] = Find(parent[s]);
                s = parent[s];
            }
            return parent[s];
        }

        public void Union(string s, string t)
        {
            if(s==t) return;
            string sparent = Find(s);
            string tparent = Find(t);
            parent[sparent] = tparent;
        }
    }
}
