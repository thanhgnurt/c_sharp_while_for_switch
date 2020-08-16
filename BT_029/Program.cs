using System;

namespace BT_029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            int uocLeMax=0;
            if (n%2!=0)
            {
                uocLeMax=n;
            } else
            {
                int i = n / 2;
                if (i % 2 == 0)
                {
                    i = i - 1;
                }
                while (i>0)
                {
                    if (n%i==0)
                    {
                        uocLeMax = i;
                        break;
                    }
                    i -= 2;
                }
            }

            Console.WriteLine("Ket qua la:{0}", uocLeMax);
        }
    }
}
