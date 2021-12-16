using System;

namespace VVPLab7
{
    class Program
    {
        static void Main(string[] args)
        {            
            float input, output;
            Console.WriteLine("Введите значение угла в радианах");
            input = Convert.ToSingle(Console.ReadLine());
            output = (input * 180) / MathF.PI;
            Console.WriteLine($"Значение угла в градусах = {output.ToString()}");
        }
    }
}