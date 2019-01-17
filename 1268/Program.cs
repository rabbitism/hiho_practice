using System;

namespace _1268
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ParseInput();
            for(int i = 0; i< result.GetLength(0); i++)
            {
                for(int j = 0; j< result.GetLength(1); j++)
                {
                    if(result[i,j]!=0)
                    {
                        result[2-i,2-j] = 10-result[i,j];
                    }
                    else
                    {
                        GetAndSet(result, i,j);
                    }
                }
            }
            for(int i = 0; i< 3; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    if(result[i,j]==0)
                    {
                        System.Console.WriteLine("Too Many");
                        return;
                    }
                }
            }
            for(int i = 0; i< 3; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    System.Console.Write(result[i,j]+" ");
                }
                System.Console.WriteLine();
            }
        }

        private static int[,] ParseInput()
        {
            int[,] result = new int[3,3];
            for(int i = 0; i< 3; i++)
            {
                string[] numberStrings = Console.ReadLine().Split(' ');
                for(int j = 0; j < numberStrings.Length; j++)
                {
                    Int32.TryParse(numberStrings[j], out result[i,j]);
                }
            }
            result[1,1]=5;
            return result;
        }

        private static void GetAndSet(int[,] grid, int x, int y)
        {
            if(grid[2-x,2-y]!=0)
            {
                grid[x,y] = 10-grid[2-x,2-y];
                return;
            }
            int horizontalCount = 0;
            int horizontalSum = 0;
            for(int i = 0; i< 3; i++)
            {
                if(i==x) continue;
                if(grid[i,y]!=0)
                {
                    horizontalCount++;
                    horizontalSum+=grid[i,y];
                }
            }
            if(horizontalCount==2)
            {
                grid[x,y]=15-horizontalSum;
                return;
            }

            int verticalCount= 0;
            int verticalSum = 0;
            for(int j = 0; j< 3; j++)
            {
                if(j==y) continue;
                if(grid[x,j]!=0)
                {
                    verticalCount++;
                    verticalSum+=grid[x,j];
                }
            }
            if(verticalCount==2)
            {
                grid[x,y]=15-verticalSum;
                return;
            }
        }
    }
}
