using System;

namespace _1788
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            while((line=Console.ReadLine())!=null)
            {
                if(line.Length<=1) System.Console.WriteLine("NO");
                else
                {
                    bool flag = false;
                    for(int i = 1; i< line.Length; i++)
                    {
                        if(line[i-1]==line[i])
                        {
                            System.Console.WriteLine("YES");
                            flag = true;
                            break;
                        } 
                    }
                    if(!flag) System.Console.WriteLine("NO");
                }
            }
        }
    }
}
