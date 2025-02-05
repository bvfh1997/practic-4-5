using System;

class Program
{
    static void Main()
    {
        int n = 5;
        int[,] matrix = new int[n, n];

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j)
                {
                    matrix[i, j] = n - (j - i);
                }
                else
                {
                    matrix[i, j] = n - (i - j);
                }
            }
        }

        // Вывод матрицы
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}