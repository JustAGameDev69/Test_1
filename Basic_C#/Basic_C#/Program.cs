namespace Array_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] arr = new int[n];

            for(int i =0; i < n; i++)
            {
                Console.Write("Enter the {0} number: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int elements_total = 0;
            foreach (int item in arr)
            {
                elements_total += item;
            }
            Console.WriteLine("Total elements in this array: " + elements_total);

        }
    }
}
