using System;

namespace BT_010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 10: Tính T(x, n) = x^n");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x:");
            int x = int.Parse(Console.ReadLine());
            long result = 1;
           
            int i = 1;
            while (i <= n)
            {
                result *= x;
                
                i++;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
