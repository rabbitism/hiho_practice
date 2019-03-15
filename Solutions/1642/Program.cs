using System;
using System.Collections.Generic;

namespace _1642
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i< count; i++)
            {
                string[] coordinates = Console.ReadLine().Split();
                int X = int.Parse(coordinates[0]);
                int Y = int.Parse(coordinates[1]);//Y>0
                for(int j = 0; j<=Y; j++)
                {
                    if(dict.ContainsKey(X-j)) dict[X-j] = Math.Max(Y-j, dict[X-j]);
                    else dict.Add(X-j, Y-j);
                    if(dict.ContainsKey(X+j)) dict[X+j] = Math.Max(Y-j, dict[X+j]);
                    else dict.Add(X+j, Y-j);
                }
            }
            double sum = 0;
            List<int> keys = new List<int>(dict.Keys);
            keys.Sort();
            for(int i = 0; i< keys.Count-1; i++)
            {
                sum+=(Math.Min(dict[i], dict[i+1])+0.5);
            }
            System.Console.WriteLine(sum);
        }
    }
}
