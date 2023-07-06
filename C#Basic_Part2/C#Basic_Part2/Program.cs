using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is a simple linear equation solver!");

            Console.Write("Please input a in the equation ( ax + b = 0 ) here: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input b in the equation ( ax + b = 0 ) here: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a==0)
            {
                if(b==0)
                {
                    Console.WriteLine("The solution is all x!");
                }
                else
                {
                    Console.WriteLine("There's no solution!");
                }

            }
            else
            {
                double result = -b / a;
                Console.WriteLine("The solution is: " + result);
            }


        }
    }
}