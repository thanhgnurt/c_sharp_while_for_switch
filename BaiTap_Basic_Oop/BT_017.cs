using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Basic_Oop
{
    class BT_017
    {
        public double exercise(int n, int x)
        {
            //Bài 17: Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/N!
            int i = 1;
            double result = 0.0;
            long giai_thua = 1;
            long luy_thua = 1;
            while (i <= n)
            {
                giai_thua *= i;
                luy_thua *= x;
                result += (double)luy_thua / giai_thua;
                i++;

            }

            return result;

        }
    }
}
