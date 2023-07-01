using System;

class Money_Exchange
{
    static void Main(string[] args)
    {
        // KHAI BÁO CÁC BIẾN:
        int input_usd, output_vnd, final_result;
        int exchange_value = 23000;

        //QUY ĐỔI:
        Console.Write(" USD : ");
        string user_input = Console.ReadLine();
        final_result = int.Parse(user_input) * exchange_value;
        Console.WriteLine(" VND : " + final_result + " VND" );

    }
}
