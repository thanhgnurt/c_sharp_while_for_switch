using System;
using System.Collections.Generic;
using System.Text;

namespace BT_062_063
{

    class can_bac_n : luy_thua_n
    {
        public double canBacN(int n, double x)
        {
            int i = 1;
            double temp = 0, temp1 = 0, temp2 = 0;
            while (i <= x)
            {
                temp = luyThuaN(n, i);
                if (temp >= x)
                {
                    if (temp == x)
                    {
                        temp1 = i;
                        break;
                    }
                    break;
                }

                i++;


            }

            if (temp != x)
            {
                temp2 = i;
                double khoang_chan = 1;
                int k = 1;
                while (k <= 15)
                {
                    if (k % 2 != 0)
                    {
                        temp1 = temp2 - khoang_chan;
                        while (temp1 <= temp2)
                        {
                            temp = luyThuaN(n, temp1);
                            if (temp >= x)
                            {

                                break;
                            }
                            temp1 += (double)khoang_chan / 10;

                        }
                        khoang_chan /= (double)10;

                        if (temp1 == x)
                        {
                            break;
                        }

                    }
                    else
                    {
                        temp2 = temp1 - khoang_chan;
                        while (temp2 <= temp1)
                        {
                            temp = luyThuaN(n, temp2);
                            if (temp >= x)
                            {
                                break;
                            }
                            temp2 += (double)khoang_chan / 10;

                        }
                        khoang_chan /= (double)10;
                        if (temp2 == x)
                        {
                            temp1 = temp2;
                            break;
                        }
                    }


                    k++;
                }
            }







            return temp1;
        }


    }
}