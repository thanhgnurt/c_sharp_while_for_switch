using System;

namespace BT_031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số Nguyen to hay không");
            Console.WriteLine("Nhap n:");
            string ket_qua = "day la so nguyen to";
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                int i = 2;
                while (i <= n / 2)
                {
                    if (n % i == 0)
                    {
                        ket_qua = "day khong la so nguyen to";
                        break;

                    }
                    i++;
                }

            }
            else ket_qua = "day khong la so nguyen to";

            Console.WriteLine(ket_qua);
          

        }
    }
}
