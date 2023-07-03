using System;

namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            float width, height, area_result;

            Console.Write("Input rectangle width: ");
            width = float.Parse(Console.ReadLine());

            Console.Write("Input rectangle height: ");
            height = float.Parse(Console.ReadLine());

            area_result = width * height;

            Console.WriteLine("Area of this rectangle is: " + area_result);
        }
    }
}
