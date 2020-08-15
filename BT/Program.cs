using System;

namespace BT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2");
            Console.WriteLine("Hay nhap vao n:");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int i = 1;
            while (i <= n)
            {
                
                result += i*i;
                i++;
            }

            Console.WriteLine("Ket qua la:{0}", result);
        }
    }
}
