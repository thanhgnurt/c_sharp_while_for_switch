using System;

namespace BT_102
{
    class Program
    {
        bool kiem_tra_nam_nhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
            {
                return true;
            }
            else return false;

        }
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            Console.WriteLine("Bài 102: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày kế ngày vừa nhập (ngày, tháng, năm)");
            Console.WriteLine("hay nhap ngay:");
            int ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap thang:");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap nam");
            int nam = int.Parse(Console.ReadLine());
            bool kt_nam_nhuan = myprogram.kiem_tra_nam_nhuan(nam);
            switch (ngay)
            {
                case 28:
                    if (thang ==2 && kt_nam_nhuan==false)
                    {
                        ngay = 1;
                        thang = 3;
                        
                    } else
                    {
                        ngay = 29;
                    }
                    break;
                case 29:
                    if (thang == 2)
                    {
                        ngay = 1;
                        thang = 3;
                    } else
                    {
                        ngay = 30;
                    }
                    break;
                case 30:
                    if (thang==1||thang==3||thang==5||thang==7||thang==8||thang==10||thang==12)
                    {
                        ngay = 31;

                    }
                    else
                    {
                        ngay = 1;
                        thang++;
                    }

                    break;
                case 31:
                    ngay = 1;
                    thang = 1;
                    nam++;
                    break;
                default:
                    ngay++;
                    break;
            }

            Console.WriteLine("ngay tiep theo la: {0}/{1}/{2}", ngay, thang, nam);




        }
    }
}
