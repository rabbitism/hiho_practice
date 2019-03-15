using System;
using System.Collections.Generic;

namespace _1223
{
    class Program
    {
        static string[] signs = new string[]{"<", "<=", "=", ">", ">="};
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            Dictionary<int,int> dictionary = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i< count; i++)
            {
                string inequality = Console.ReadLine();
                if(inequality.Contains("<") || inequality.Contains(">"))
                {
                    stack.Push(inequality);
                }
                else
                {
                    int number = int.Parse(inequality.Split()[2]);
                    if(dictionary.ContainsKey(number)) dictionary[number]++;
                    else dictionary.Add(number, 1);
                }
            }
            List<int> keys = new List<int>(dictionary.Keys);
            while(stack.Count!=0)
            {
                string inequality = stack.Pop();
                string sign = inequality.Split()[1];
                int number = int.Parse(inequality.Split()[2]);
                if(sign == ">")
                {
                    foreach(int key in keys)
                    {
                        if(key>number) dictionary[key]++;
                    }
                }
                if(sign==">=")
                {
                    foreach(int key in keys)
                    {
                        if(key>=number) dictionary[key]++;
                    }
                }
                if(sign=="<=")
                {
                    foreach(int key in keys)
                    {
                        if(key<=number) dictionary[key]++;
                    }
                }
                if(sign=="<")
                {
                    foreach(int key in keys)
                    {
                        if(key<number) dictionary[key]++;
                    }
                }
            }
            int max = 0;
            foreach(int key in dictionary.Keys)
            {
                max = Math.Max(max, dictionary[key]);
            }
            System.Console.WriteLine(max);
        }
    }
}
