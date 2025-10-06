using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter a number to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] == search)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine($"{search} is found in the array.");
        else
            Console.WriteLine($"{search} is not found in the array.");
    }
}