using System;
using System.Collections.Generic;

namespace _1888
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parameters_strings = Console.ReadLine().Split();
            int N = int.Parse(parameters_strings[0]);
            int M = int.Parse(parameters_strings[1]);
            int W = int.Parse(parameters_strings[2]);
            int[,] graph = new int[N+1,N+1];
            for(int i = 0; i< M; i++)
            {
                string[] graphInfo = Console.ReadLine().Split();
                int start = int.Parse(graphInfo[0]);
                int end = int.Parse(graphInfo[1]);
                int limit = int.Parse(graphInfo[2]);
                graph[start, end] = limit;
                graph[end, start] = limit;
            }
            int[] cost = new int[N+1];
            for(int i = 2; i<N+1; i++)
            {
                cost[i]=-1;
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            while(stack.Count>0)
            {
                int start = stack.Pop();
                for(int i = 0; i<= N; i++)
                {
                    if(graph[start, i]>=W)
                    {
                        if(cost[i]==-1)
                        {
                            cost[i] = cost[start]+1;
                            stack.Push(i);
                        }
                        else
                        {
                            if(cost[i]>cost[start]+1)
                            {
                                cost[i] = cost[start]+1;
                                stack.Push(i);
                            }
                        }
                    }
                }
            }
            System.Console.WriteLine(cost[N]);

        }
    }
}
