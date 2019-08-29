using System;

namespace _1973
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] counts = Console.ReadLine().Split();
            int N = Convert.ToInt32(counts[0]);
            int M = Convert.ToInt32(counts[1]);
            char[][] c = new char[N][];
            for (int i = 0; i < N; i++)
            {
                c[i] = Console.ReadLine().ToCharArray();
            }
            int[] top = new int[M];
            int[] bottom = new int[M];
            int[] left = new int[N];
            int[] right = new int[N];
            for (int i = 0; i < N; i++)
            {
                left[i] = N;
                right[i] = -1;
            }
            for (int i = 0; i < M; i++)
            {
                top[i] = M;
                bottom[i] =-1;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if(c[i][j]=='B')
                    {
                        left[i] = Math.Min(left[i], j);
                        top[j] = Math.Min(top[j], i);
                        right[i] = Math.Max(right[i], j);
                        bottom[j] = Math.Max(right[j], i);
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M;j++)
                {
                    if(c[i][j]=='B') Console.Write('B');
                    else{
                        int sum = 0;
                        if(j>left[i]) sum++;
                        if(j<right[i]) sum++;
                        if(i>top[j]) sum++;
                        if(i<bottom[j]) sum++;
                        Console.Write(sum);
                    }
                    
                }
                System.Console.WriteLine();
            }

        }
    }
}
