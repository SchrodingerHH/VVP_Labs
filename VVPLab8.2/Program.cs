using System;

namespace VVPLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            float lineA, lineB;
            Console.WriteLine("Enter line A length: ");
            lineA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter line B length: ");
            lineB = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Max B line lengths in line A");
            Console.WriteLine(MathF.Round((lineA/lineB),MidpointRounding.ToZero));
        }
    }
}