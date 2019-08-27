using System;

namespace _1662
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int N = Int32.Parse(dimensions[0]);
            int M = Int32.Parse(dimensions[1]);
            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = Int32.Parse(numbers[j]);
                }
            }
            int sum = 0;
            for (int i = 1; i < N - 1; i++)
            {
                for (int j = 1; j < M - 1; j++)
                {
                    if (Valid(matrix, i, j)) sum++;
                }
            }
            System.Console.WriteLine(sum);
        }

        private static bool Valid(int[,] matrix, int x, int y)
        {
            int sum = matrix[x, y - 1] + matrix[x, y] + matrix[x, y + 1];
            if (sum != matrix[x - 1, y - 1] + matrix[x - 1, y] + matrix[x - 1, y + 1]) return false;
            if (sum != matrix[x + 1, y - 1] + matrix[x + 1, y] + matrix[x + 1, y + 1]) return false;
            if (sum != matrix[x - 1, y - 1] + matrix[x, y - 1] + matrix[x + 1, y - 1]) return false;
            if (sum != matrix[x - 1, y] + matrix[x, y] + matrix[x + 1, y]) return false;
            if (sum != matrix[x - 1, y + 1] + matrix[x, y + 1] + matrix[x + 1, y + 1]) return false;
            if (sum != matrix[x - 1, y - 1] + matrix[x + 1, y + 1] + matrix[x, y]) return false;
            if (sum != matrix[x + 1, y - 1] + matrix[x - 1, y + 1] + matrix[x, y]) return false;
            return true;
        }
    }
}
