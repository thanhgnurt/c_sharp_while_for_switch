using System;

namespace BT_030
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số hoàn thiện hay không");
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            int tong_uoc = 0;
            int i = 1;
            while (i<=n/2)
            {
                if (n % i == 0)
                {
                    tong_uoc += i;
                }
                i++;

            }
            if (tong_uoc == n)
            {
                Console.WriteLine("Day la so hoan thien");

            }
            else Console.WriteLine("Day khong phai so hoan thien");
        }
    }
}
