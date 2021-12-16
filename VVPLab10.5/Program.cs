using System;
using System.Linq;

namespace VVPLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            float input;
            Console.WriteLine("Введите значение input");
            input = Convert.ToSingle(Console.ReadLine());
            
            if (input == Convert.ToSingle(new string(input.ToString().Reverse().ToArray())))
            {
                Console.WriteLine($"{input.ToString()} читается одинаково в обе стороны");
            }
            else
            {
                Console.WriteLine($"{input.ToString()} не читается одинаково в обе стороны");
            }
        }
    }
}