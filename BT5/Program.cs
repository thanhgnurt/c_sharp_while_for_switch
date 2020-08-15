using System;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 5: Tính S(n) = 1 + 1/3 + 1/5 + … + 1/(2n + 1)");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            int i = 1;
            while (i <= (2*n+1))
            {
                result += 1.0 / i;
                i=i+2;

            }
            Console.WriteLine("Ket qua la: {0}", result);
        }
    }
}
