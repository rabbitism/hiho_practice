using System;
using System.Collections.Generic;

namespace _1485
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int length = s.Length;
            int[] dict = new int[26];
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while(i>=1 && start<i && Check(dict)>=0)
                {
                    dict[s[start] - 'a']--;
                    start++;
                    length = Math.Min(length, i - start+1);
                }
                //length = Math.Min(length, i - start+1);
                dict[s[i]-'a']++;
            }
            System.Console.WriteLine(length);

        }

        public static int Check(int[] dict)
        {
            if(dict[7] == 2 && dict[8] == 1 && dict[14] == 1) return 0;
            return (dict[7] - 2 + dict[8] - 1 + dict[14] - 1);
        }
    }
}
