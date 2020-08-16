using System;
using System.ComponentModel.Design;

namespace BT_033
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            tinh_can_bac_hai can_bac_hai = new tinh_can_bac_hai();
            luy_thua_n myLuyThua = new luy_thua_n();
            can_bac_n myCanBacN = new can_bac_n();
            double result=0;
            int i = 1;
            
            while (i <= n)
            {
                result += 2;
                result = can_bac_hai.canBacHai(result);
                i++;
            }
            Console.WriteLine("ket qua la:{0}", result);
            Console.WriteLine("Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn");
            i = 1;
            double kq_bai_34 = 0;

            while (i<=n)
            {
                kq_bai_34 += i;
                kq_bai_34 = can_bac_hai.canBacHai(kq_bai_34);
                i++;

            }
            Console.WriteLine("ket qua la:{0}", kq_bai_34);


            Console.WriteLine("Bài 37: Tính S(n) = CanBac N(N + CanBac N – 1(N – 1 + … + CanBac3(3 + CanBac2(2))) có n – 1 dấu căn");
            double luy_thua_n = myLuyThua.luyThuaN(10, 2);
            Console.WriteLine(luy_thua_n);

            double canN = myCanBacN.canBacN(5, 32);
            Console.WriteLine(canN);








        }
    }
}
