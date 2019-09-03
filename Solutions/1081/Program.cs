using System;
using System.Collections.Generic;

namespace _1081
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int N = Convert.ToInt32(numbers[0]);
            int M = Convert.ToInt32(numbers[1]);
            int S = Convert.ToInt32(numbers[2]);
            int T = Convert.ToInt32(numbers[3]);
            int[] shortest = new int[N + 1];
            for (int i = 0; i < shortest.Length; i++)
            {
                shortest[i] = 2000;
            }
            

            int[,] matrix = new int[N + 1, N + 1];
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    matrix[i, j] = 2000;
                }
            }
            for (int i = 0; i < M; i++)
            {
                string[] edge = Console.ReadLine().Split();
                int start = Convert.ToInt32(edge[0]);
                int end = Convert.ToInt32(edge[1]);
                int length = Convert.ToInt32(edge[2]);
                matrix[start, end] = Math.Min(length, matrix[start, end]);
                matrix[end, start] = Math.Min(length, matrix[end, start]);
            }

            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(S);
            shortest[S] = 0;

            while (queue.Count != 0)
            {
                int top = queue.Dequeue();
                for (int i = 1; i <= N; i++)
                {
                    if(top==i) continue;
                    if (shortest[i]>(shortest[top]+matrix[top, i]))
                    {
                        shortest[i] = shortest[top] + matrix[top, i];
                        queue.Enqueue(i);
                    }
                }
            }
            Console.WriteLine(shortest[T]);
            return;
        }
    }

}
