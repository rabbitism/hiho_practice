using System;

namespace _1322
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseCount = Int32.Parse(Console.ReadLine());
            for (int cCount = 0; cCount < caseCount; cCount++)
            {
                string[] counts = Console.ReadLine().Split();
                int N = Int32.Parse(counts[0]);
                int M = Int32.Parse(counts[1]);
                if(N-M!=1)
                {
                    for (int i = 0; i < M; i++)
                    {
                        System.Console.ReadLine();
                    }
                    System.Console.WriteLine("NO");
                }
                else
                {
                    UnionFind uf = new UnionFind(N);
                    bool flag = true;
                    for (int i = 0; i < M; i++)
                    {
                        string[] points = Console.ReadLine().Split();
                        int start = Int32.Parse(points[0]) - 1;
                        int end = Int32.Parse(points[1]) - 1;
                        if(uf.IsConnected(start, end))
                        {
                            flag = false;
                            break;
                        }
                        else{
                            uf.Union(start, end);
                        }
                        
                    }
                    if(flag) System.Console.WriteLine("YES");
                    else System.Console.WriteLine("NO");
                }
            }
        }
    }

    public class UnionFind
    {
        int[] parent;
        public int count;
        public UnionFind(int i)
        {
            parent = new int[i];
            for (int j = 0; j<i; j++)
            {
                parent[j] = j;
            }
            count = i;
        }

        public int Find(int i)
        {
            while(i!=parent[i])
            {
                parent[i] = Find(parent[i]);
                i = parent[i];
            }
            return parent[i];
        }

        public void Union(int i, int j)
        {
            int pi = Find(i);
            int pj = Find(j);
            if(pi==pj) return;
            else
            {
                count--;
                parent[pi] = pj;
            }
        }

        public bool IsConnected(int i, int j)
        {
            return Find(i) == Find(j);
        }

    }
}
