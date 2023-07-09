using System;

namespace The_Largest_Element
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter numbers of column: ");
            int column = int.Parse(Console.ReadLine());

            Console.Write("Enter numbers of row: ");
            int row = int.Parse(Console.ReadLine());

            int[,] arr = new int[row, column];

            Console.WriteLine("Enter array elements: ");
            for (int i =0; i < row; i++)
            {
                Console.WriteLine("");
                for (int j =0; j < column; j++)
                {
                    Console.Write("arr[{0},{1}] : ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int max_value = arr[0, 0];
            int max_pos_r =0 , max_pos_c=0;
            for (int i =0; i < arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1);j++)
                {
                    if(max_value < arr[i,j])
                    {
                        max_value = arr[i, j];
                        max_pos_r = i;
                        max_pos_c = j;
                    }
                }
            }
            Console.WriteLine("Biggest element in this array is: {0} at [{1},{2}]!", max_value, max_pos_r, max_pos_c);


        }
    }
}