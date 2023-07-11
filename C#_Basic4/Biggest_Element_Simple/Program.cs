using System;

namespace intermiami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());


            int[] arr = new int[n];


            Console.WriteLine("Enter array elements!");
            for(int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }


            int max_element = arr[0];
            for (int i = 0;i < arr.Length;i++)
            {
                if (max_element < arr[i])
                {
                    max_element = arr[i];
                }
            }

            Console.WriteLine("The biggest element in this array is " + max_element);
        }
    }
}