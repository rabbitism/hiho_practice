using System;

namespace _1481
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i< times; i++)
            {
                string s = Console.ReadLine();
                int a = 0;
                foreach(char c in s)
                {
                    if(c=='A') a++;
                }
                if(a>=2||s.Contains("LLL"))
                {
                    System.Console.WriteLine("NO");
                }
                else
                {
                    System.Console.WriteLine("YES");
                }
            }
        }
    }
}
