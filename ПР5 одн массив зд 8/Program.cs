using System;

class Program
{
    static void Main()
    {
       
        Random rand = new Random();

        
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());

        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            
            numbers[i] = rand.NextDouble() * 100;
        }

        
        Console.WriteLine("\nИсходный массив:");
        PrintArray(numbers);

       
        double max = numbers[0];
        int indexMax = 0;
        double min = numbers[0];
        int indexMin = 0;

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                indexMax = i;
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
                indexMin = i;
            }
        }

        
        Console.WriteLine($"\nИндекс наибольшего элемента: {indexMax}");
        Console.WriteLine($"Индекс наименьшего элемента: {indexMin}");

        
        if (indexMax != indexMin)
        {
            
            double temp = numbers[indexMax];
            numbers[indexMax] = numbers[indexMin];
            numbers[indexMin] = temp;

            
            Console.WriteLine("\nМассив после замены:");
            PrintArray(numbers);
        }
        else
        {
            Console.WriteLine("\nНаибольший и наименьший элементы совпадают. Замена не требуется.");
        }
    }

    static void PrintArray(double[] array)
    {
        foreach (double num in array)
        {
            Console.Write(num.ToString("F2") + " ");
        }
        Console.WriteLine();
    }
}

