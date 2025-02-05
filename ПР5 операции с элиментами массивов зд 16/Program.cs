using System;

class Program
{
    const int X = 7;
    const int K = 2;

    static void Main()
    {
        int M = 4;
        int N = 5;
        int[,] matrix = new int[M, N];

        Random rand = new Random();

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(1, 21); 
            }
        }
 
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[] rowsWithX = new int[M];
        int count = 0;

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] == X)
                {
                    rowsWithX[count++] = i;
                    break;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine($"\nЭлемент {X} не найден в матрице.");
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[rowsWithX[i], j] *= K;
                }
            }

            Console.WriteLine("\nИзмененная матрица:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}