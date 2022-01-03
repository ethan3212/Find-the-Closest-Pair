using System;
using static System.Console;

namespace Lab02A
{
    class Program
    {
        const int N = 20;
        static int first;
        static int second;
        static int loopCount = 0;

        static void Main(string[] args)
        {
            int[] X = { 19, 13, 5, 1, 17, 1, 10, 4, 9, 16, 17, 17, 20, 12, 17, 5, 8, 13, 3, 14 };
            int[] Y = { 3, 6, 20, 12, 9, 7, 9, 3, 14, 17, 19, 1, 1, 6, 5, 11, 6, 11, 20, 9 };

            ClosestPair(X, Y, N);
            WriteLine("First= " + first + "Second= " + second);
            WriteLine("Loop count is: " + loopCount);
            ReadLine();
        }
        static void ClosestPair(int [] X, int[] Y, int max)
        {
            double smalDist = max;

            for (int i = 0; i < max; i++)
            {
                for (int j = i + 1; j < max; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(X[i] - X[j], 2) + Math.Pow(Y[i] - Y[j], 2));
                    loopCount++;
                    if (dist < smalDist)
                    {
                        smalDist = dist;
                        first = i;
                        second = j;
                    }

                }
            }


        }
    }
}
