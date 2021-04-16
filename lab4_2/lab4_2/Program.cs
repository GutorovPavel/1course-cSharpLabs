using System;
using System.Runtime.InteropServices;

namespace MathFunctions
{
    class Program
    {
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Sum(int firstValue, int secondValue);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Subtract(int firstValue, int secondValue);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Multiply(int firstValue, int secondValue);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Divide(int firstValue, int secondValue);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Mod(int firstValue, int secondValue);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Abs(int value);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Min(int firstValue, int secondValue);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Pow(int firstValue, int secondValue);
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Max(int firstValue, int secondValueb);

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(Subtract(2, 3));
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Divide(2, 3));
            Console.WriteLine(Mod(2, 3));
            Console.WriteLine(Abs(-64));
            Console.WriteLine(Pow(2, 3));
            Console.WriteLine(Min(2, 3));
            Console.WriteLine(Max(2, 3));
        }
    }
}
