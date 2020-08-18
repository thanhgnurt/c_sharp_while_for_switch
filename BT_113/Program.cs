using System;
using System.Text;

namespace BT_113
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Bài 113: Lập chương trình tính sin(x) với độ chính xác 0.00001 theo công thức: Sin(x) = x – x^3/3! + x^5/5! + … + (-1)^n . x^2n + 1/(2n + 1)!");
            Console.WriteLine("Hay nhap x:");
            double x = double.Parse(Console.ReadLine());
          
            if (x > 360)
            {
                while (x > 360)
                {
                    x = x - 360;

                }
              
            }
            x = x / 180 * 3.141;
            int n = 0;
            double result = 0;
            while (true)
            {
                int i = 1;
                double giai_thua = 1;
                double luy_thua = 1;
                while (i<=(2*n +1))
                {
                    giai_thua *= i;
                    luy_thua *=x;
                    i++;

                }
                if ((double)luy_thua / giai_thua < 0.00001)
                {
                    break;
                }
                if (n%2 !=0)
                {
                    giai_thua = -giai_thua;

                }
               
                result +=(double) luy_thua / giai_thua;

                n++;
            }
            Console.WriteLine("ket qua la:{0}", result);

        }
    }
}
