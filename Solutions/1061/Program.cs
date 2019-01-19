using System;
using System.Collections.Generic;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTestCases = int.Parse(Console.ReadLine());
            for(int i = 0; i<numOfTestCases; i++)
            {
                int numberOfLeter = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                Stack<char> stack = new Stack<char>();
                int count = 0;
                foreach(char c in input)
                {
                    if(stack.Count==0)
                    {
                        stack.Push(c);
                    }
                    if(c==stack.Peek())
                    {
                        continue;
                    }
                    else if(c-stack.Peek()!=1)
                    {
                        count = 0;
                    }
                    else if(c-stack.Peek()==1)
                    {
                        count++;
                        stack.Push(c);
                    }
                    if(count==2)
                    {
                        System.Console.WriteLine("YES");
                        break;
                    }
                }
                if(count<=1)
                {
                    System.Console.WriteLine("NO");
                }
            }
        }
    }
}
