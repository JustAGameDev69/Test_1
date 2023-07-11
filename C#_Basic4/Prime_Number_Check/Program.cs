using System;

namespace Prime_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is_prime = false;
            int n;

            Console.Write("This is prime number checker! Enter a numbers: ");
            n = int.Parse(Console.ReadLine());

            if(n < 2)
            {
                is_prime = false;
            }
            else
            {
                int i = 2;
                is_prime = true;
                while (i<=Math.Sqrt(n))
                {
                    if(i%n ==0)
                    {
                        is_prime = false;
                        break;
                    }
                    i++;
                }

                if(is_prime)
                {
                    Console.WriteLine(n + "is a prime number!");
                }
                else
                {
                    Console.WriteLine(n + "isn't a prime number!");
                }
            }
        }
    }
}