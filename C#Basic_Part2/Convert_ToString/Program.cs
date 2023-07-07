using System;

class Program
{
    static void Main(string[] args)
    {
        int choice ;

        while (true)
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the rectangle");
            Console.WriteLine("2. Draw the square triangle");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("This is a retangle!");
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j =1; j<=7; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("This is a square bottom-left triangle!");
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("This is a square bottom-right triangle!");
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            if (j >= 5 - i + 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;

            }
        }
    }
}