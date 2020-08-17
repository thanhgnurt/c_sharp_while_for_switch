using System;

namespace BT_043
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n");
            Console.WriteLine("Hay nhap n");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            int tong = 0;
            int tich = 1;
            int sodau = 0;
            int sodaonguoc=0;
            int soLuong = 0;
            int soLonNhat = 0;
            int kiemtradoixung = n;
            if (n == 0)
            {
                dem = 1;
            }
            while (n > 0)
            {
                //tong
                tong += n % 10;
                //tich
                if (n%10!=0)
                {

                tich *= n % 10;
                }
                //tim so dau
                if (n<10)
                {
                    sodau = n;

                }
                //so dao nguoc
                sodaonguoc =(int) sodaonguoc * 10 + n % 10;

                // dem so llluong so lon nhat
                if (soLonNhat == n % 10)
                {
                    soLuong++;
                }
                if (soLonNhat<n%10)
                {
                    soLonNhat = n % 10;
                    soLuong = 1;

                }

         
                






                dem++;
                n /= 10;
            }

            Console.WriteLine("So luong chu so cua so nay la:{0}", dem);
            Console.WriteLine("Tong cac chu so cua so nay la:{0}", tong);
            Console.WriteLine("Bài 45: Hãy tính tích các chữ số của số nguyên dương n:{0}", tich);
            Console.WriteLine("Bài 49: Cho số nguyên dương n. Hãy tìm chữ số đầu tiên của n:{0}", sodau);
            Console.WriteLine("So dao nguoc cua so nguyen duong n:{0}", sodaonguoc);
            Console.WriteLine("dem so luong chu so lon nha cua so nguyen duon n:{0} ", soLuong);
            //kiem tra so doi xung

            if (kiemtradoixung == sodaonguoc)
            {
                Console.WriteLine("day la so doi xung");
            }
            else
            {
                Console.WriteLine("day khong phai so doi xung");
            }

        }
    }
}
