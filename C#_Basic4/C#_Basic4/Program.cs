using System.Xml.Schema;

namespace BasicCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter size of array: ");
            n = int.Parse(Console.ReadLine());
            int total_ele = 0;

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the {0} numbers in this array: ", i+1);
                int user_input = int.Parse(Console.ReadLine());
                arr[i] = user_input;
            }

            foreach (int item in arr)
            {
                total_ele += item;
            }
            Console.WriteLine("Total of elements in this array is: " + total_ele);
        }
    }
}