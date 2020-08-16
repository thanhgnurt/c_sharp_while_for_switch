using System;
using System.Collections.Generic;
using System.Text;

namespace BT_020_Den_030
{
    class BT_021
    {
       public long bt21(int n)
        {
            
            long result = 1;
            int i = 1;
            while (i<=n/2)
            {
                if (n % i == 0)
                {
                    result *= i;
                }
                i++;

            }

            return result*n;

        }
    }
}
