using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 3: Tính S(n) = 1 + ½ + 1/3 + … + 1/n");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            int i = 1;
            while (i<=n)
            {
                result += 1.0 / i;
                i++;

            }

            Console.WriteLine("Ket qua la : {0}", result);

        }
    }
}
