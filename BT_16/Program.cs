using System;

namespace BT_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 16: Tính S(n) = x + x^2/1 + 2 + x^3/1 + 2 + 3 + … + x^n/1 + 2 + 3 + …. + N");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x:");
            int x = int.Parse(Console.ReadLine());
            long result = 0;
            long tong = -1;
            long luy_thua = 1;
            int i = 1;
            while (i<=n)
            {
                luy_thua *= x;
                tong += i ;
                result += luy_thua + tong;
                i++;

            }

            Console.WriteLine("ket qua la:{0}", result);
        }
    }
}
