using System;
using System.Text;

namespace BT_020_Den_030
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("-------------------");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            ham_nhap myHamNhap = new ham_nhap();
            int chonBaiTap = myHamNhap.hamNhap("Chon bai tap tu 20 den 30:");
            int n;
            switch (chonBaiTap)
            {
                case 20:
                    {
                        Console.WriteLine("Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n");
                        n = myHamNhap.hamNhap("Hay nhap vao n :");
                        BT_020 mybt20 = new BT_020();
                        mybt20.bt20(n);
                        break;
                    }
                case 21:
                    {
                        Console.WriteLine("Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n");
                        n = myHamNhap.hamNhap("Hay nhap vao n:");
                        BT_021 mybt21 = new BT_021();
                        long result = mybt21.bt21(n);
                        Console.WriteLine("ket qua la: {0}", result);
                        break;
                    }
                case 22:
                    {
                        Console.WriteLine("Bài 23: Đếm số lượng “ước số” của số nguyên dương n");
                        n = myHamNhap.hamNhap("Hay nhap vao n:");
                        BT_022 mybt22 = new BT_022();
                        int dem = mybt22.bt22(n);
                        Console.WriteLine("ket qua la: {0}", dem);
                        break;

                    }
                case 24:
                    {
                        Console.WriteLine("Bài 24: Liệt kê tất cả các “ước số lẻ” của số nguyên dương n");
                        n = myHamNhap.hamNhap("Hay nhap vao n:");
                        BT_024 mybt24 = new BT_024();
                        string result = mybt24.bt24(n);
                        Console.WriteLine("ket qua la:{0}",result);
                        break;
                    }
                case 25:
                    {
                        Console.WriteLine("Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n");
                        n = myHamNhap.hamNhap("Hay nhap n");
                        BT_025 mybt25 = new BT_025();
                        int result = mybt25.tong_uoc_chan(n);
                        Console.WriteLine("ket qua la:{0}", result);
                        break;

                    }
                case 26:
                    {
                        Console.WriteLine("Bài 26: Tính tích tất cả các “ước số lẻ” của số nguyên dương n");
                        n = myHamNhap.hamNhap("hay nhap n");
                        BT_026 mybt26 = new BT_026();
                        int result = mybt26.tich_so_le(n);
                        Console.WriteLine("ket qua la:{0}", result);
                        break;




                    }
            }


        }
    }
}
