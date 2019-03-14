using System;

namespace _1928
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizeString = Console.ReadLine().Split();
            int N = Convert.ToInt32(sizeString[0]);
            int M = Convert.ToInt32(sizeString[1]);
            string[] LString = Console.ReadLine().Split();
            int[] L = new int[N];
            for(int i = 0; i< N; i++)
            {
                L[i] = Convert.ToInt32(LString[i]);
            }
            string[] FString = Console.ReadLine().Split();
            int[] F = new int[M];
            for(int i = 0; i< M; i++)
            {
                F[i] = Convert.ToInt32(FString[i]);
            }
            int sum = 0;
            for(int i = 0; i< N; i++)
            {
                for(int j = 0; j< M; j++)
                {
                    sum+=Math.Min(L[i], F[j]);
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
