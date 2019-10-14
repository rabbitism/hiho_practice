using System;
using System.Collections.Generic;

namespace _1518
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            int[] nums = new int[n+1];
            for (int i = 0; i < numbers.Length; i++)
            {
                nums[i+1] = Convert.ToInt32(numbers[i]);
            }
            int[] count = new int[n + 1];
            int max = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if(count[i]>0) continue;
                HashSet<int> hs = new HashSet<int>();
                int start = nums[i];
                while(!hs.Contains(start))
                {
                    hs.Add(start);
                    start = nums[start];
                    count[start] = 1;
                }
                max = Math.Max(max, hs.Count);
            }
            System.Console.WriteLine(max);
        }
    }
}
