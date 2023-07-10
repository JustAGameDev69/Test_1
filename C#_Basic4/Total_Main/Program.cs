using System.Transactions;

namespace Total_Main_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo kích thước ma trận vuông!
            Console.Write("Enter size of square matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n]; //Tạo ma trận vuông cỡ nxn!

            //Nhập từng phần tử vào ma trận
            Console.WriteLine("Enter matrix elements: ");
            for (int i =0; i < n; i++)
            {
                for(int j =0; j < n; j++)
                {
                    Console.Write("arr[{0},{1}]", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Tính tổng các phần tử trên đường chéo chính của ma trận!
            int total_result = 0;
            for (int i = 0; i < n; i++)
            {
                total_result += arr[i, i];
            }
            Console.WriteLine("Sum of elements on the main diagonal of  this square matrix is: "+total_result); //In ra kết quả!

        }
    }
}