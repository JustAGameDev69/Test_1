using System;

namespace BMI_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a BMI Calculator!");

            Console.Write("Enter your weight (kg) : ");
            float user_weight = float.Parse(Console.ReadLine());

            Console.Write("Enter your height ( if you height is 170cm, enter 1.70 ) : ");
            float user_height = float.Parse(Console.ReadLine());

            double user_bmi = user_weight / Math.Pow(user_height, 2);

            if (user_bmi < 18.5)
            {
                Console.WriteLine("Your BMI is: " + user_bmi.ToString("0.0") + " and you are underweight!");
            }
            if (user_bmi >= 18.5 && user_bmi < 25.0)
            {
                Console.WriteLine("Your BMI is: " + user_bmi.ToString("0.0") + " and you are totally normal!");
            }
            if (user_bmi >= 25.0 && user_bmi < 30.0)
            {
                Console.WriteLine("Your BMI is: " + user_bmi.ToString("0.0") + " and you are overweight!");
            }
            if (user_bmi >= 30.0)
            {
                Console.WriteLine("Your BMI is: " + user_bmi.ToString("0.0") + " and you are obese! Get to the gym!");
            }

        }
    }
}
