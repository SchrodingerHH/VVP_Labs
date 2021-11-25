using System;

namespace VVPLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, output;
            Console.WriteLine("Enter 3-digit num for swapping");
            input = Convert.ToInt32(Console.ReadLine());
            output = (input % 100) * 10 + input / 100;
            Console.WriteLine("Swapped num");
            Console.WriteLine(output);
        }
    }
}