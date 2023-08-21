using System;

class Program
{
    static void Main(string[] args)
    {
        // Define an integer array
        int[] numbers = { 2, 4, 6, 8, 10 };

        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        // Specify the multiplication factor
        int factor = 3;

        // Multiply each element by the specified factor using a loop
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] * factor;
        }

        Console.WriteLine("Array after Multiplication:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
