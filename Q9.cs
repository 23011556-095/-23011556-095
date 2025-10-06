using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        int evenCount = 0, oddCount = 0;

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (arr[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine($"Even numbers: {evenCount}");
        Console.WriteLine($"Odd numbers: {oddCount}");
    }
}
