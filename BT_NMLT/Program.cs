using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 1: Tính S(n) = 1 + 2 + 3 + … + n");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int result = 0;
            while (i<n)
            {
                result += i;
                i++;

            }
            Console.WriteLine("Giai thua n la: {0}", result);

        }
    }
}
