using System;

namespace VVPLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputA, inputB, inputC;
            Console.WriteLine("Введите значение A");
            inputA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите значение B");
            inputB = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите значение C");
            inputC = Convert.ToSingle(Console.ReadLine());

            if (inputA<inputB && inputB<inputC)
            {
                Console.WriteLine($"Неравенства {inputA.ToString()}<{inputB.ToString()}<{inputC.ToString()} справедливы");
            }
            else
            {
                Console.WriteLine($"Неравенства {inputA.ToString()}<{inputB.ToString()}<{inputC.ToString()} не справедливы");
            }
        }
    }
}