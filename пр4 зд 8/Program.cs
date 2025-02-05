using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение шага h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("|     x     |      F(x)      |");
            Console.WriteLine("-----------------------------------");

            for (double x = a; x <= b; x += h)
            {
                double fx = CalculateF(x);
                Console.WriteLine($"| {x,8:F4} | {fx,14:F4} |");
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
        return 2 * Math.Tan(x / 2) + 1 / x;
    }
}