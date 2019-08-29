using System;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Int32.Parse(Console.ReadLine());
            int[,] dp = new int[count, count];
            for (int i = 0; i < count; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                for (int j = 0; j < numbers.Length; j++)
                {
                    dp[i, j] = Int32.Parse(numbers[j]);
                }
            }
            int max = 0;
            for (int i = 1; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if(j==0) dp[i, j] += dp[i - 1, j];
                    else{
                        dp[i, j] += Math.Max(dp[i - 1, j - 1], dp[i - 1, j]);
                    }
                    max = Math.Max(max, dp[i, j]);
                }
            }
            System.Console.WriteLine(max);
        }

    }
}
