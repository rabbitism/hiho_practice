using System;
using System.Collections.Generic;
using System.Linq;

namespace _1820
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            string[] numbers_string = Console.ReadLine().Split();
            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
            Int64 sum = 0;
            foreach(string s in numbers_string)
            {
                int number = Convert.ToInt32(s);
                if(dictionary.ContainsKey(number)) dictionary[number]++;
                else dictionary.Add(number, 1);
                sum+= number;
            }
            int last = 0;
            while(dictionary.Keys.Count>0)
            {
                int key = dictionary.First().Key;
                sum-=(key-last)*count;
                last = key;
                count-=dictionary[key];
                System.Console.WriteLine(sum);
                dictionary.Remove(key);
            }
        }
    }
}
