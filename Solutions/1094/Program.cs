using System;
using System.Collections.Generic;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split();
            int N = Convert.ToInt32(sizes[0]);
            int M = Convert.ToInt32(sizes[1]);
            char[,] map = new char[N,M];
            for(int i = 0; i< N; i++)
            {
                string line = Console.ReadLine();
                for(int j = 0; j< M; j++)
                {
                    map[i,j] = line[j];
                }
            }
            char[,] current = new char[3,3];
            for(int i = 0; i< 3; i++)
            {
                string line = Console.ReadLine();
                for(int j = 0; j< 3; j++)
                {
                    current[i,j] = line[j];
                }
            }
            List<char[,]> views = GetAllDirections(current);
            for(int i = 1; i< N-1; i++)
            {
                for(int j = 1; j< M-1; j++)
                {
                    if(map[i,j]==current[1,1])
                    {
                        bool result = IsCurrent(map, i, j, views);
                        if(result) System.Console.WriteLine((i+1)+" "+(j+1));
                    }
                }
            }
        }

        static List<char[,]> GetAllDirections(char[,] current)
        {
            List<char[,]> list = new List<char[,]>();
            list.Add(current);
            for(int i = 0; i< 3; i++)
            {
                char[,] newView = RotateRight(list[i]);
                list.Add(newView);
            }
            return list;

        }

        static char[,] RotateRight(char[,] current)
        {
            int X = current.GetLength(0);
            int Y = current.GetLength(1);
            char[,] result = new char[Y,X];
            for(int i = 0; i< X; i++)
            {
                for(int j = 0; j< Y; j++)
                {
                    result[Y-j-1,i]=current[i,j];
                }
            }
            return result;
        }

        static bool IsCurrent(char[,] map, int x, int y, List<char[,]> views)
        {
            bool result = false;
            foreach(var view in views)
            {
                bool currentResult = true;
                for(int i = 0; i<3; i++)
                {
                    for(int j = 0; j<3; j++)
                    {
                        if(map[x-1+i,y-1+j]!=view[i,j])
                        {
                            currentResult=false;
                            break;
                        }
                    }
                    if(!currentResult) break;
                }
                result |= currentResult;
            }
            return result;
        }
    }
}
