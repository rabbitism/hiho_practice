using System;
using System.Collections.Generic;
using System.Text;

namespace _1361
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace('J','I');
            StringBuilder sb = new StringBuilder();
            HashSet<char> hs = new HashSet<char>();
            foreach(char c in input)
            {
                if(!hs.Contains(c))
                {
                    hs.Add(c);
                    sb.Append(c);
                }
            }
            for(int i = 0; i< 26; i++)
            {
                char c = (char)('A'+i);
                if(!hs.Contains(c) && c!='J')
                {
                    sb.Append(c);
                }
            }
            for(int i = 0; i< 5; i++)
            {
                for(int j = 0; j< 5; j++)
                {
                    System.Console.Write(sb[5*i+j]);
                }
                System.Console.WriteLine();
            }

        }
    }
}
