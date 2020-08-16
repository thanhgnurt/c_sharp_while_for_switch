using System;
using System.Collections.Generic;
using System.Text;

namespace BT_020_Den_030
{
    class BT_023
    {
        public int bt23(int n)
        {
            int dem = 0;
            int i = 1;
            while (i<=n)
            {
            if (n%i==0)
            {
                    dem++;

            }
            }
            i++;
            return dem;

        }
    }
}
