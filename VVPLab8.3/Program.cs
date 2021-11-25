using System;

namespace VVPLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            float lineA, lineB, output;
            Console.WriteLine("Enter line A length: ");
            lineA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter line B length: ");
            lineB = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Unoccupied length on line A");   
            output = lineA-MathF.Round((lineA / lineB), MidpointRounding.ToZero) * lineB;
            Console.WriteLine(output);
        }
    }
}