using System;

namespace BT_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 14: Tính S(n) = x + x^3 + x^5 + … + x^2n + 1");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x:");
            int x = int.Parse(Console.ReadLine());
            long tich = 1;
            long result = 0;
            int i = 1;
            while (i<=(2*n + 1))
            {
                tich *= x;
                if (i%2!=0)
                {
                    result += tich;
                }
                i++;

            }
            Console.WriteLine("Ket qua la:{0}", result);
        }
    }
}
