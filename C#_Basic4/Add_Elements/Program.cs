using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter position need to add: ");
        int x = int.Parse(Console.ReadLine());


        // Chèn phần tử mới vào mảng
        int[] newArr = new int[n + 1];
        if (x > 0 && x <= arr.Length)
        {
            Console.Write("Enter value need to add: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                if (i < x)
                {
                    newArr[i] = arr[i];
                }
                else if (i == x)
                {
                    newArr[i] = value;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }
            }
            Console.WriteLine("New array after add:");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Cannot add the elements into array!");
        }

    }
}