using System;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 4: Tính S(n) = ½ + ¼ + … + 1/2n");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            int i = 2;
            while (i <= 2*n)
            {
                result += 1.0 / i;
                i = i + 2;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
