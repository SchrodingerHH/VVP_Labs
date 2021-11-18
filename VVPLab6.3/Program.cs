using System;

namespace VVPLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Enter 3 numbers to be swapped: ");
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());
            
            Swap(ref a,ref b,ref c);
            Console.WriteLine("A=>C, C=>B, B=>A");
            Console.WriteLine($"New A value = {a.ToString()}, new B value = {b.ToString()}, new C value = {c.ToString()}");
        }
        
        public static void Swap<T>(ref T swapNum1, ref T swapNum2, ref T swapNum3)
        {
            (swapNum3, swapNum2, swapNum1) = (swapNum1, swapNum3, swapNum2);
        }
    }
}