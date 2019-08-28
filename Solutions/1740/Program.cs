using System;
using System.Collections.Generic;

namespace _1740
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string s = Console.ReadLine();
                string d = Console.ReadLine();
                Dictionary<char, char> dict = new Dictionary<char, char>();
                string result  = "YES";
                for (int j = 0; j < s.Length; j++)
                {
                    if(!dict.ContainsKey(s[j]))
                    {
                        dict[s[j]] = d[j];
                    }
                    else{
                        if(dict[s[j]]==d[j]) continue;
                        else
                        {
                            result = "NO";
                            break;
                        }
                    }
                }
                System.Console.WriteLine(result);
            }
        }
    }
}
