using System;

namespace BT_042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 42: Cho n là số nguyên dương. Hãy tìm giá trị nguyên dương k lớn nhất sao cho S(k)  < n. Trong đó chuỗi k được định nghĩa như sau: S(k) = 1 + 2 + 3 + … + k");
            Console.WriteLine("Hay nhap n");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int tong=0;
            while (i < n)
            {
                tong += i;
                if (tong >= n)
                {
                    i -= 1;
                    break;
                }
                i++;

                
            }
            Console.WriteLine("so k do la:{0}", i);
        }
    }
}
