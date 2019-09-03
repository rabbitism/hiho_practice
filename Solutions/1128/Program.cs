using System;
using System.Collections.Generic;

namespace _1128
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1();
        }

        private static void Solution1()
        {
            string[] info = Console.ReadLine().Split();
            int N = Int32.Parse(info[0]);
            int K = Int32.Parse(info[1]);
            List<int> list = new List<int>();
            string[] nums = Console.ReadLine().Split();
            foreach(string n in nums)
            {
                list.Add(Int32.Parse(n));
            }
            list.Sort();
            int l = 0;
            int r = list.Count - 1;
            while(l<=r)
            {
                int mid = l + (r - l) / 2;
                if(list[mid]==K) 
                {
                    Console.WriteLine(mid+1);
                    return;
                }
                else if(list[mid]<K)
                {
                    l++;
                }
                else{
                    r--;
                }
            }
            return;
        }
    }
}
