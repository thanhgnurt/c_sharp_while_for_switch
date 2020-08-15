using System;

namespace BT_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int giai_thua = 1;
            int i = 1;
            while (i <= n)
            {
                giai_thua *= i;
                result += giai_thua;
                
                i++;

            }

            Console.WriteLine("Ket qua la : {0}", result);

        }
    }
}
