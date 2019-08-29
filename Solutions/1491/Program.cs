using System;
using System.Collections.Generic;

namespace _1491
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int c = 0; c < count; c++)
            {
                string[] numbers = Console.ReadLine().Split();
                if(numbers==null || numbers.Length<=1) continue;
                int sum = 0;
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    sum += Convert.ToInt32(numbers[i]);
                    if(dictionary.ContainsKey(sum)) dictionary[sum]++;
                    else dictionary[sum] = 1;
                }
            }
            int max = 0;
            foreach(var key in dictionary.Keys)
            {
                max = Math.Max(max, dictionary[key]);
            }
            System.Console.WriteLine(count - max);
        }
    }
}
