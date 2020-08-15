using System;

namespace BT9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 9: Tính T(n) = 1 x 2 x 3…x N");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            int i = 1;
            while (i <= n)
            {
                result *= i;
                i++;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
