using System;
using System.Collections.Generic;
using System.Text;

namespace _1862
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string command = Console.ReadLine();
            /* 
            foreach(char c in command)
            {
                if(stack.Count==0)
                {
                    stack.Push(c);
                }
                else
                {
                    if((c=='L'&& stack.Peek()=='R')  ||(c=='R' && stack.Peek()=='L') ||(c=='F' && stack.Peek()=='B') ||(c=='B' || stack.Peek()=='F')  )
                    {
                        stack.Pop();
                    }
                    else{
                        stack.Push(c);
                    }
                }
            }
            List<char> list = new List<char>();
            while(stack.Count!=0)
            {
                list.Add(stack.Pop());
            }
            list.Reverse();
            string s = new string(list.ToArray());
            
            while(s.Contains("RRRR"))
            {
                s = s.Replace("RRRR", "");
            }
            while(s.Contains("LLLL"))
            {
                s = s.Replace("LLLL", "");
            }
            while(s.Contains("FFFF"))
            {
                s = s.Replace("FFFF", "");
            }
            while(s.Contains("BBBB"))
            {
                s = s.Replace("BBBB", "");
            }*/
            int[] faces = new int[6] { 1, 6, 4, 3, 2, 5 };
            foreach(char c in command)
            {
                if(c=='L') L(faces);
                else if(c=='R') R(faces);
                else if(c=='F') F(faces);
                else if(c=='B') B(faces);
            }
            foreach(var i in faces)
            {
                System.Console.WriteLine(i);
            }

        }

        public static void F(int[] faces)
        {
            int tmp = faces[0];
            faces[0] = faces[5];
            faces[5] = faces[1];
            faces[1] = faces[4];
            faces[4] = tmp;
        }
        public static void B(int[] faces)
        {
            int tmp = faces[0];
            faces[0] = faces[4];
            faces[4] = faces[1];
            faces[1] = faces[5];
            faces[5] = tmp;
        }
        public static void L(int[] faces)
        {
            int tmp = faces[0];
            faces[0] = faces[3];
            faces[3] = faces[1];
            faces[1] = faces[2];
            faces[2] = tmp;
        }
        public static void R(int[] faces)
        {
            int tmp = faces[0];
            faces[0] = faces[2];
            faces[2] = faces[1];
            faces[1] = faces[3];
            faces[3] = tmp;
        }
    }
}
