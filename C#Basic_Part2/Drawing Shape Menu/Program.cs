using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Nhap so nguyen khong am co toi da 3 chu so: ");
        num = int.Parse(Console.ReadLine());

        if (num < 0 || num > 999)
        {
            Console.WriteLine("So khong hop le!");
        }
        else if (num == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            string result = "";
            int hundreds = num / 100;
            int tens = (num % 100) / 10;
            int ones = num % 10;

            switch (hundreds)
            {
                case 1:
                    result += "one hundred ";
                    break;
                case 2:
                    result += "two hundred ";
                    break;
                case 3:
                    result += "three hundred ";
                    break;
                case 4:
                    result += "four hundred ";
                    break;
                case 5:
                    result += "five hundred ";
                    break;
                case 6:
                    result += "six hundred ";
                    break;
                case 7:
                    result += "seven hundred ";
                    break;
                case 8:
                    result += "eight hundred ";
                    break;
                case 9:
                    result += "nine hundred ";
                    break;
            }

            if (tens == 1)
            {
                switch (ones)
                {
                    case 0:
                        result += "ten";
                        break;
                    case 1:
                        result += "eleven";
                        break;
                    case 2:
                        result += "twelve";
                        break;
                    case 3:
                        result += "thirteen";
                        break;
                    case 4:
                        result += "fourteen";
                        break;
                    case 5:
                        result += "fifteen";
                        break;
                    case 6:
                        result += "sixteen";
                        break;
                    case 7:
                        result += "seventeen";
                        break;
                    case 8:
                        result += "eighteen";
                        break;
                    case 9:
                        result += "nineteen";
                        break;
                }
            }
            else
            {
                switch (tens)
                {
                    case 2:
                        result += "twenty ";
                        break;
                    case 3:
                        result += "thirty ";
                        break;
                    case 4:
                        result += "forty ";
                        break;
                    case 5:
                        result += "fifty ";
                        break;
                    case 6:
                        result += "sixty ";
                        break;
                    case 7:
                        result += "seventy ";
                        break;
                    case 8:
                        result += "eighty ";
                        break;
                    case 9:
                        result += "ninety ";
                        break;
                }

                switch (ones)
                {
                    case 1:
                        result += "one";
                        break;
                    case 2:
                        result += "two";
                        break;
                    case 3:
                        result += "three";
                        break;
                    case 4:
                        result += "four";
                        break;
                    case 5:
                        result += "five";
                        break;
                    case 6:
                        result += "six";
                        break;
                    case 7:
                        result += "seven";
                        break;
                    case 8:
                        result += "eight";
                        break;
                    case 9:
                        result += "nine";
                        break;
                }
            }

            Console.WriteLine(result);
        }

        Console.ReadLine(); // Dung man hinh de xem ket qua
    }
}