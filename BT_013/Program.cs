using System;

namespace BT_013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n");
            Console.WriteLine("Hay nhap n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x");
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            long tich = 1;
            long result = 0;

            while (i <= 2*n)

            {
                tich *= x;
                if (i%2==0)
                {
                    result += tich;

                }

                i++;
            }

            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
