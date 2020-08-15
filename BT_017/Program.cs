using System;

namespace BT_019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 19: Tính S(n) = 1 + x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)!");
            Console.WriteLine("Hay nhap n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x:");
            int x = int.Parse(Console.ReadLine());
            double result = 0;
            long giai_thua = 1;
            long luy_thua = 1;
            int i = 1;
            while (i<=(2*n+1))
            {
                luy_thua *= x;
                giai_thua *= i;
                if (i%2==1)
                {
                result +=(double) luy_thua / giai_thua;
                }
                i++;
            }
            Console.WriteLine("Ket qua la:{0}", result+1);
        }
    }
}
