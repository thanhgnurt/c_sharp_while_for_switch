using System;
using System.Collections.Generic;
using System.Text;

namespace BT_062_063
{
    class luy_thua_n
    {
        public double luyThuaN(int n, double x)
        {
            int i = 1;
            double result = 1;
            while (i <= n)
            {
                result *= (double)x;
                i++;
            }
            return result;
        }
    }
}
