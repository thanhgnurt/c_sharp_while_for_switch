using System;
using System.Collections.Generic;
using System.Text;

namespace BT_020_Den_030
{
    class BT_024
    {
        public string bt24(int n)
        {
            //Bài 24: Liệt kê tất cả các “ước số lẻ” của số nguyên dương n
            string result = "";
            int i = 1;
            while (i<=n/2)
            {
                if(n%i==0 && i % 2 != 0)
                {
                    result += i + " ";

                }
                i++;

            }
            if (n % 2 != 0)
            {
                return result + n;
            }
            else return result;

        }
    }
}
