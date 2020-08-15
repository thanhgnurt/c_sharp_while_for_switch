using System;

namespace BT_015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 15: Tính S(n) = 1 + 1/1 + 2 + 1/ 1 + 2 + 3 + ….. + 1/ 1 + 2 + 3 + …. + N");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int result = 0;
            int i = 1;
            while (i <= n)
            {
                sum += i;
                result += sum;
                i++;

            }
            Console.WriteLine("Ket qua la:{0}", result);


        }
    }
}
