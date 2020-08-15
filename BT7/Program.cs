using System;

namespace BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 7: Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            int i = 1;
            while (i <= n)
            {
                result += 1.0 * i / (i+1);
                i++;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
