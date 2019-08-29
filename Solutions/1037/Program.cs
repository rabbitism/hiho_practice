using System;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            
            if(count==0) 
            {
                System.Console.WriteLine(0);
                return;
            }
             
            int[][] dp = new int[count][];
            for (int i = 0; i < count; i++)
            {
                dp[i] = new int[count];
            }
            
            for (int i = 0; i < count; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                if(numbers==null || numbers.Length==0) continue;
                for (int j = 0; j < Math.Min(numbers.Length, count); j++)
                {
                    dp[i][j] = Convert.ToInt32(numbers[j]);
                }
            }
            
            int max = 0;
            
            for (int i = 1; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (j == 0) dp[i][ j] += dp[i - 1][ j];
                    else
                    {
                        dp[i][ j] += Math.Max(dp[i - 1][ j - 1], dp[i - 1][ j]);
                    }
                    max = Math.Max(max, dp[i][ j]);
                }
            }
            
            System.Console.WriteLine(max);
        }

    }
}
