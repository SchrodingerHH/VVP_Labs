using System;

namespace VVPLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, d0, d1, d2;
            Console.WriteLine("Введите значение input");
            input = Convert.ToInt32(Console.ReadLine());

            d0 = input / 100;
            d1 = (input-d0*100) / 10;
            d2 = input % 10;

            if (d0<d1 && d1<d2)
            {
                Console.WriteLine($"Последовательность {input.ToString()} возрастает");
            }
            else if (d0>d1 && d1>d2)
            {
                Console.WriteLine($"Последовательность {input.ToString()} убывает");
            }
            else
            {   
                Console.WriteLine($"Последовательность {input.ToString()} не подходит под условия задачи");
            }
        }
    }
}