using System;

namespace BT_016
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bài 16: Tính S(n) = x + x^2/1 + 2 + x^3/1 + 2 + 3 + … + x^n/1 + 2 + 3 + …. + N");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x :");
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            
            long result = 0;


            while (i<=n)
            {
                int j = 1;
                int gia_thua = 0;
                while (j<=i)
                {
                    gia_thua += j;
                    j++;

                }
                int k = 1;
                long tich = 1;
                while (k<=(gia_thua + i -1))
                {
                    tich *= x;
                    k++;

                }
                result += tich;
                i++;

            }
            Console.WriteLine("Ket qua la :{0}", result);


        }
    }
}
