using System;

namespace VVPLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            float input;
            Console.WriteLine("Введите значение input");
            input = Convert.ToSingle(Console.ReadLine());

            if (input>9&&input<100&&input%2==0)
            {
                Console.WriteLine($"{input.ToString()} является двухзначным чётным числом");
            }
            else
            {
                Console.WriteLine($"{input.ToString()} не подходит под условия задачи");
            }
        }
    }
}