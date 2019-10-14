using System;

namespace _1376
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            while( (s = Console.ReadLine())!="-1")
            {
                int count = Convert.ToInt32(s);
                string[] nums = Console.ReadLine().Split();
                System.Console.Write(nums[0]+" ");
                for (int i = 1; i < nums.Length; i++)
                {
                    if(nums[i]==nums[i-1]) continue;
                    else System.Console.Write(nums[i]+" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
