using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение xнач: ");
            double xStart = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение xкон: ");
            double xEnd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение шага dx: ");
            double dx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("|     x     |      F(x)      | Члены ряда |");
            Console.WriteLine("-----------------------------------");

            for (double x = xStart; x <= xEnd; x += dx)
            {
                double fx = CalculateF(x);
                int termsCount = CalculateTermsCount(x);
                Console.WriteLine($"| {x,8:F4} | {fx,14:F4} | {termsCount,10} |");
            }

            Console.WriteLine("-----------------------------------");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
        }
    }

    static double CalculateF(double x)
    {
        if (x == 0)
        {
            throw new ArgumentException("Значение x не может быть равно нулю.");
        }

        double sum = 0;
        double term = 1 / x;
        int n = 0;
        double epsilon = 1e-6;

        while (Math.Abs(term) > epsilon)
        {
            sum += term;
            n++;
            term = 2 / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
        }

        return sum;
    }

    static int CalculateTermsCount(double x)
    {
        if (x == 0)
        {
            throw new ArgumentException("Значение x не может быть равно нулю.");
        }

        int count = 0;
        double term = 1 / x;
        double epsilon = 1e-6;

        while (Math.Abs(term) > epsilon)
        {
            count++;
            term = 2 / ((2 * count + 1) * Math.Pow(x, 2 * count + 1));
        }

        return count;
    }
}