using System;

namespace VVPLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputA, inputB, output;
            Console.WriteLine("Дано выражение вида A*X+B=0");
            Console.WriteLine("Введите A");
            inputA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите B");
            inputB = Convert.ToSingle(Console.ReadLine());
            output = -inputB / inputA;
            Console.WriteLine($"x = {output.ToString()}");
        }
    }
}