using System;
using System.Text;

namespace BT_110
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Bài 110: Cần có tổng 200000 đồng từ 3 loại giấy bạc 1000 đồng, 2000 đồng, 5000 đồng. Lập chương trình để tìm ra tất cả các phương án có thể");
            int z = 1;
            int dem = 0;
            while (z<=39)
            {
                int y = 1;
                while (y<(float)(200-5*z)/2)
                {
                    if (200-5*z-2*y > 0) {
                        dem++;
                        Console.WriteLine("phuong an {0} : {1} to nam ngan {2} to hai ngan {3} to mot ngan ", dem, z, y, 200 - 5 * z - 2 * y);
                    }
                    
                    y++;

                }
                z++;

            }
            Console.WriteLine("so truong hop la:{0}", dem);


        }
    }
}
