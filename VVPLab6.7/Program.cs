using System;

namespace VVPLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            float input, a, b;
            Console.WriteLine("Enter a: ");
            input = float.Parse(Console.ReadLine());
            b = input * input;
            a = b * input;
            a = b * a;
            b = a * a;
            a = b * a;
            Console.WriteLine($"a = {input.ToString()}, a^15 = {a.ToString()}");
        }
    }
}