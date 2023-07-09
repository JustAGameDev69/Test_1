using System.Runtime.CompilerServices;

namespace student_name_find
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter numbers of student: ");
            n = int.Parse(Console.ReadLine());

            string[] student_name = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the name of sudent number {0} in this array: ", i + 1);
                string name_input = (Console.ReadLine());
                student_name[i] = name_input;
            }


            Console.Write("Find who : ");
            string name_find = Console.ReadLine();
            bool exist=false;

            for (int j = 0; j < n; j++)
            {
                if(name_find == student_name[j])
                {
                    Console.WriteLine("Name exist! That is student number {0} !", j+1);
                    exist = true;
                    break;
                }
            }
            if(!exist)
            {
                Console.WriteLine("Name not found!");
            }
                
        }
    }
}