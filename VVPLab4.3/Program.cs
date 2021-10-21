using System;

namespace VVPLab4
{
    class Program
    {
        static float inputA, inputB;

        static void Main(string[] args)
        {
            inputA = float.Parse(Console.ReadLine());
            inputB = float.Parse(Console.ReadLine());

            Console.WriteLine((inputA + inputB) / 2);
        }
    }
}
