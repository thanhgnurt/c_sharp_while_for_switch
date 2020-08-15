using System;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            int i = 1;
            while (i <= n)
            {
                result += 1.0 / (i*i+i);
                i++;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
