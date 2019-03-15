using System;

namespace _1824
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordinates = Console.ReadLine().Split();
            int X1 = int.Parse(coordinates[0]);
            int Y1 = int.Parse(coordinates[1]);
            int X2 = int.Parse(coordinates[2]);
            int Y2 = int.Parse(coordinates[3]);

            int deltaX = X2-X1;
            int deltaY = Y2-Y1;
            int minStep = FindCommon(Math.Abs(deltaX), Math.Abs(deltaY));
            int stepX = deltaX/minStep;
            int stepY = deltaY/minStep;
            if(stepX == 0) stepY=stepY/Math.Abs(stepY);
            if(stepY==0) stepX=stepX/Math.Abs(stepX);
            int X = X2+stepY;
            int Y = Y2-stepX;
            System.Console.WriteLine(X+" "+Y);
        }

        static int FindCommon(int X, int Y)
        {
            int min = Math.Min(X, Y);
            for(int i = min; i>=1; i--)
            {
                if(X%i==0 && Y%i==0)
                return i;
            }
            return 1;
        }
    }
}
