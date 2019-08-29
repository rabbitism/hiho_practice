using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            HashSet<char> hs = new HashSet<char>();
            string[] numbers = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            foreach(string number in numbers)
            {
                hs.Clear();
                foreach(char c in number)
                {
                    hs.Add(c);
                }
                foreach(char c in hs)
                {
                    if(dict.ContainsKey(c)) dict[c]++;
                    else dict[c] = 1;
                }
            }
            foreach(char key in dict.Keys)
            {
                System.Console.WriteLine( key+" "+dict[key]);
            }
        }
    }
}
