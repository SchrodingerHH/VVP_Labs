using System;

namespace VVPLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            float output;
            Console.WriteLine("Enter file size in bytes");
            input = Convert.ToInt32(Console.ReadLine());
            output = (float)decimal.Divide(input, 1024);
            Console.WriteLine("File size in KB");
            Console.WriteLine(MathF.Round(output,MidpointRounding.ToPositiveInfinity).ToString());
        }
    }
}