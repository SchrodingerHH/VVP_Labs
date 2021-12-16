using System;

namespace VVPLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            float input, output;
            Console.WriteLine("Введите значение угла в градусах");
            input = Convert.ToSingle(Console.ReadLine());
            output = (input * MathF.PI) / 180;
            Console.WriteLine($"Значение угла в радианах = {output.ToString()}");
        }
    }
}