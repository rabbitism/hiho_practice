using System;

namespace _1889
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[,] map = new char[N,N];
            bool[,] visited = new bool[N,N];
            int enemyTotalCount = 0;
            for(int i = 0; i< N; i++)
            {
                string line = Console.ReadLine();
                for(int j = 0; j< N; j++)
                {
                    map[i,j] = line[j];
                    if(line[j]=='E') enemyTotalCount++;
                }
            }
            int max = 0;
            for(int i = 0; i< N; i++)
            {
                for(int j = 0; j<N; j++)
                {
                    if(map[i,j]=='B' && !visited[i,j])
                    {
                        visited[i,j] = true;
                        int death = Ignite(map, visited, i, j, N);
                        max = Math.Max(death, max);
                        //visited[i,j] = false;
                    } 
                    if(max==enemyTotalCount) break;
                }
                if(max==enemyTotalCount) break;
            }
            System.Console.WriteLine(max);
        }

        static int Ignite(char[,] map, bool[,] visited, int x, int y, int N)
        {
            bool[,] back_up = visited.Clone() as bool[,];
            int result = 0;
            for(int i = x; i>=0; i--)
            {
                if(map[i,y]=='E' && !visited[i,y])
                {
                    visited[i,y]=true;
                    result++;
                }
                if(map[i,y]=='B' && !visited[i,y])
                {
                    visited[i,y] = true;
                    result+=Ignite(map, visited, i, y, N);
                    //visited[i,y] = false;
                }
                if(map[i,y]=='#') break;
            }
            for(int i = x; i<N; i++)
            {
                if(map[i,y]=='E' && !visited[i,y])
                {
                    visited[i,y]=true;
                    result++;
                }
                if(map[i,y]=='B' && !visited[i,y])
                {
                    visited[i,y] = true;
                    result+=Ignite(map, visited, i, y, N);
                    //visited[i,y] = false;
                }
                if(map[i,y]=='#') break;
            }
            for(int j = y; j>=0; j--)
            {
                if(map[x,j]=='E' && !visited[x,j])
                {
                    visited[x,j]=true;
                    result++;
                }
                if(map[x,j]=='B' && !visited[x,j])
                {
                    visited[x,j] = true;
                    result+=Ignite(map, visited, x, j, N);
                    //visited[x,j] = false;
                }
                if(map[x,j]=='#') break;
            }
            for(int j = y; j<N; j++)
            {
                if(map[x,j]=='E' && !visited[x,j])
                {
                    visited[x,j]=true;
                    result++;
                }
                if(map[x,j]=='B' && !visited[x,j])
                {
                    visited[x,j] = true;
                    result+=Ignite(map, visited, x,j, N);
                    //visited[x,j] = false;
                }
                if(map[x,j]=='#') break;
            }
            return result;
        }
    }
}
