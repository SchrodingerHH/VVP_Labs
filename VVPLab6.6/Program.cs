using System;

namespace VVPLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            float input, a;
            Console.WriteLine("Enter a: ");
            input = float.Parse(Console.ReadLine());
            a = input * input;
            a = a * a;
            a = a * a;
            //Console.WriteLine($"a = {a.ToString()}, {a.ToString()}^2 = {a2.ToString()}, {a.ToString()}^4 = {a4.ToString()}, {a.ToString()}^8 = {a8.ToString()}");
            Console.WriteLine($"{input.ToString()}^8 = {a.ToString()}");
        }
    }
}