using System;

namespace BT_012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x:");
            int x = int.Parse(Console.ReadLine());
            long tich = 1;
            long result = 0;

            int i = 1;
            while (i <= n)
            {
                tich *= x;
                result += tich;

                i++;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
