using System;

namespace BT8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            int i = 1;
            while (i <=(2*n+1))
            {
                result +=( 1.0 * i) / (i + 1);
                i= i+2;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
