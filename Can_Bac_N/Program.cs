using System;

namespace Can_Bac_N
{
    class Program
    {
        double luyThuaN(int n, double i)
        {
            int j = 1;
            double result = 1;
            while (j <= n)
            {
                result *= (double)i;
                j++;
            }
            result = Math.Round(result, 15);
            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap x:");
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            double tang_them = 1;
            const int saiSo = 10;
            int j = 1;
            if (x<1)
            {
                while (true)
                {

                    if (p.luyThuaN(n, tang_them) <= x)
                    {
                        result = tang_them;
                        break;
                    }
                    tang_them /= 10;

                }

            } 

            while (j <= saiSo)
            {

                while (true )
                {
                    if (p.luyThuaN(n, result) == x)
                    {
                        Console.WriteLine("kiem tra");
                        j = saiSo +1;
                        break;

                    }
                    if (p.luyThuaN(n, result) >= x)
                    {
                        result -= tang_them;
                        break;
                    }
                    result += tang_them;
                }
                tang_them /= 10;
                j++;

            }

            Console.WriteLine(result);



        }
    }
}
