using System;

namespace VVPLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("Enter 2 numbers to be swapped: ");
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            Swap(ref a, ref b);
            
            Console.WriteLine($"First num = {a.ToString()}, second num = {b.ToString()}");
        }

        public static void Swap<T>(ref T swapNum1, ref T swapNum2)
        {
            T buff = swapNum1;
            swapNum1 = swapNum2;
            swapNum2 = buff;
        }
    }
}