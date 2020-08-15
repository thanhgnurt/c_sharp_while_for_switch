using System;

namespace BaiTap_Basic_Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 17: Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/N!");
            input_n nhap = new input_n();
            int n =nhap.input("hay nhap n");
            int x = nhap.input("hay nhap x");
            BT_017 BT = new BT_017();
            double result = BT.exercise(n, x);
            Console.WriteLine("ket qua :{0}", result);
            BT_018 bt_18 = new BT_018();
            double ketQua = bt_18.BT(n, x);
            Console.WriteLine("ket qua : {0}", ketQua);
            

           
            
        }
    }
}
