using System;

namespace _1682
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            char[,] map = new char[N,N];
            for(int i = 0; i< N; i++)
            {
                string line  = Console.ReadLine();
                for(int j = 0; j< N; j++)
                {
                    if(line[j]=='*') map[i,j]='*';
                    else map[i,j]='0';
                }
            }
            for(int i = 0; i< N; i++)
            {
                for(int j = 0; j< N; j++)
                {
                    if(map[i,j]=='*')
                    {
                        for(int m = -1; m<=1; m++)
                        {
                            for(int n = 0-1; n<=1; n++)
                            {
                                if(i+m>=0 && i+m<N && j+n>=0 && j+n<N)
                                {
                                    if(map[i+m, j+n]!='*')
                                    {
                                        map[i+m,j+n] = (char)(map[i+m,j+n]+1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for(int i = 0; i<N; i++)
            {
                for(int j = 0; j< N; j++)
                {
                    System.Console.Write(map[i,j]);
                }
                System.Console.Write("\n");
            }

        }
    }
}
