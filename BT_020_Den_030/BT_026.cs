using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace BT_020_Den_030
{
    class BT_026
    {
        public int tich_so_le(int n)
        {
            int i = 1;
            int result = 1;
            while (i <=n/2)
            {
                if(n%i==0 && i % 2 != 2)
                {
                    result *= i;
                }
                i++;
            }
            if (n % 2 != 0)
            {
                return result * n;

            }
            else return result;
        }
    }
}
