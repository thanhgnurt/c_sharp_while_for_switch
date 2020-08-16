using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BT_033
{
    class tinh_can_bac_hai
    {
       
        public double canBacHai(double n)
        {
            int i = 1;
            double temp1=0;
            while (i <= n)
            {
                temp1 =(double) n / i;
                if (temp1*temp1<=n)
                {
                  
                    break;

                }
                i++;

            }

            int k = 1;
            double khoang_chan = 1;
            double gioi_han;
            while (k<=15)
            {
                if (k%2!=0)
                {
                    gioi_han = temp1 + khoang_chan;
                    while (temp1 <= gioi_han)
                    {
                        if (temp1 * temp1 >= n)
                        {

                            break;

                        }
                        temp1 +=(double) khoang_chan/10;


                    }
                    khoang_chan /=(double) 10;

                }
                else
                {
                    gioi_han = temp1 - khoang_chan;
                    while (temp1 >= khoang_chan)
                    {
                        if (temp1 * temp1 <= n)
                        {
                            break;
                        }
                        temp1 -=(double) khoang_chan/10;

                    }
                    khoang_chan /=(double) 10;

                }
                k++;



            }

            return temp1;


        }
    }
}
