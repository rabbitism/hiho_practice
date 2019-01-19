using System;
using System.Collections.Generic;

namespace _1458
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input.Length<=1) return;
            Stack<int> stack = new Stack<int>();
            SortedDictionary<int,int> dict = new SortedDictionary<int, int>();
            for(int i = 0; i< input.Length; i++)
            {
                if(input[i]=='(')
                {
                    stack.Push(i+1);
                }
                else
                {
                    int start = stack.Pop();
                    dict.Add(start, i+1);
                }
            }
            foreach(int key in dict.Keys)
            {
                System.Console.WriteLine(key+" "+dict[key]);
            }
        }
    }
}
