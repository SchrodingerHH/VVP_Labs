using System;

namespace VVPLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputA, inputB;
            Console.WriteLine("Введите значение A");
            inputA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите значение B");
            inputB = Convert.ToSingle(Console.ReadLine());

            if (inputA>2 && inputB<=3)
            {
                Console.WriteLine($"Неравенства {inputA.ToString()}>2 и {inputB.ToString()}<=3 справедливы");
            }
            else
            {
                Console.WriteLine($"Неравенства {inputA.ToString()}>2 и {inputB.ToString()}<=3 не справедливы");
            }
        }
    }
}