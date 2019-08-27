using System;
using System.Collections.Generic;

namespace _1152
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>(){1,2,3,5,8,13,21,34};
            string s = Console.ReadLine();
            HashSet<string> resultSet = new HashSet<string>();
            for(int i  =0; i< s.Length; i++)
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for(int j = i; j< s.Length; j++)
                {
                    if(dict.ContainsKey(s[j]))
                    {
                        dict[s[j]]++;
                    }
                    else{
                        dict[s[j]]=1;
                    }
                    if(hs.Contains(dict.Keys.Count))
                    {
                        resultSet.Add(s.Substring(i,j-i+1));
                    }
                }
            }
            List<string> list = new List<string>(resultSet);
            list.Sort();
            foreach(var str in list)
            {
                System.Console.WriteLine( str);
            }

        }
    }
}
