using System;
using System;
class Program
{
    static void Main()
    {
        int size;
        int evenSum = 0;

        Console.WriteLine("Enter the size of the array:");
        size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the array values:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int value in arr)
        {
            if (value % 2 == 0)
            {
                evenSum += value;
            }
           
        }

        Console.WriteLine("Sum of all even numbers in the array is: " + evenSum);

    }
}