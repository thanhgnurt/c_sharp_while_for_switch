using System;
using System.Collections.Generic;
using System.Text;

namespace BT_020_Den_030
{
    class BT_025
    {
        //Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n
        public int tong_uoc_chan(int n)
        {
            int i = 1;
            int result = 0;
            while (i <= n / 2)
            {
                if (n%1 == 0 && i%2==0)
                {
                    result += i;

                }
                i++;

            }
            if (n%2==0)
            {
                return result + n;
            } else
            return result;
        }
    }
}
