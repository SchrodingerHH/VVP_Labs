using System;
using System.Linq;

namespace VVPLab8
{
    class Program
    {
        static void Main(string[] args)
        { 
            int input;
            string output;
            Console.WriteLine("Enter 2-digit num for swapping");
            input = Convert.ToInt32(Console.ReadLine());
            output = new string(input.ToString().Reverse().ToArray());
            Console.WriteLine("Swapped num");
            Console.WriteLine(output);
        }
    }
}