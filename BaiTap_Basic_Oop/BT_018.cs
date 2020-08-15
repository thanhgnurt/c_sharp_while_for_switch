using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Basic_Oop
{
    class BT_018
    {
        //Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!
        public double BT(int n, int x)
        {
            double result = 0.0;
            int luy_thua = 1;
            int giai_thua = 1;
            int i = 1;
            while (i<=2*n)
            {
                luy_thua *= x;
                giai_thua *= i;
                if (i % 2 == 0)
                {
                    result += (double) luy_thua / giai_thua;
                }
                

                i += 1;
            }
            
            return result+1;

        }

    }
}
