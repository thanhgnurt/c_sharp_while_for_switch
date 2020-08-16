using System;

namespace BT_032
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không");
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            string kiem_tra = "day khong la so chinh phuong";
            int i = 1;
            while (i*i <= n)
            {
                if(i*i == n)
                {
                    kiem_tra = "day la so chinh phuong";
                    break;

                }

                i++;
            }

            Console.WriteLine(kiem_tra);
        }
    }
}
