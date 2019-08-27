using System;
using System.Collections.Generic;

namespace _1675
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = System.Console.ReadLine().Split();
            int N = Int32.Parse(dimensions[0]);
            int P = Int32.Parse(dimensions[1]);
            int Q = Int32.Parse(dimensions[2]);
            int[,] matrix = new int[N,N];
            Dictionary<int, HashSet<Tuple<int, int>>> dictA = new Dictionary<int, HashSet<Tuple<int, int>>>();
            Dictionary<int, HashSet<Tuple<int, int>>> dictB = new Dictionary<int, HashSet<Tuple<int, int>>>();
            for(int i = 0; i< P; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int x = Int32.Parse(numbers[0]);
                int y = Int32.Parse(numbers[1]);
                int v = Int32.Parse(numbers[2]);
                if(dictA.ContainsKey(y))
                {
                    dictA[y].Add(new Tuple<int,int>(x, v));
                }
                else
                {
                    dictA[y] = new HashSet<Tuple<int, int>>{new Tuple<int,int>(x,v)};
                }
            }

            for(int i = 0; i< Q; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int x = Int32.Parse(numbers[0]);
                int y = Int32.Parse(numbers[1]);
                int v = Int32.Parse(numbers[2]);
                if(dictB.ContainsKey(x))
                {
                    dictB[x].Add(new Tuple<int,int>(y, v));
                }
                else
                {
                    dictB[x] = new HashSet<Tuple<int, int>>{new Tuple<int,int>(y,v)};
                }
            }

            foreach(int key in dictA.Keys)
            {
                if(dictB.ContainsKey(key))
                {
                    foreach(var termA in dictA[key])
                    {
                        foreach(var termB in dictB[key])
                        {
                            matrix[termA.Item1-1, termB.Item1-1]+=termA.Item2*termB.Item2;
                        }
                    }
                }
            }
            for(int i = 0; i< N; i++)
            {
                for(int j = 0; j< N; j++)
                {
                    if(matrix[i,j]!=0)
                    {
                        System.Console.WriteLine((i+1)+" "+(j+1)+" "+matrix[i,j]);
                    }
                }
            }



        }
    }
}
