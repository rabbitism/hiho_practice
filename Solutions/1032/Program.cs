using System;
using System.Collections.Generic;

namespace _1032
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            if (count == 0) return;
            List<string> list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string s = Console.ReadLine();
                if (s != null)
                {
                    list.Add(s);
                }

            }
            foreach (var s in list)
            {
                System.Console.WriteLine(Check(s));
            }
        }

        static int Check(string s)
        {
            if (s == null) return 0;
            int n = s.Length;
            if (n == 0) return 0;
            bool[][] dp = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new bool[n];
            }
            int max = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i; j < n; j++)
                {
                    if (i == j)
                    {
                        dp[i][j] = true;
                    }
                    else if (j - i == 1)
                    {
                        dp[i][j] = s[i] == s[j] ? true : false;
                    }
                    else
                    {
                        dp[i][j] = s[i] == s[j] && dp[i + 1][j - 1];
                    }
                    if (dp[i][j])
                    {
                        max = Math.Max(max, j - i + 1);
                    }
                }
            }
            return max;
        }
    }
}
