using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BT_064_065_066
{
    class pt_bac_2:pt_bac_1
    {
        public void ptbac2(int a, int b, int c, bool bac4)
        {
            double x;
          
            if (a == 0)
            {
                ptbac1(b, c, bac4);
            } else
            {
                int delta = (b * b) - (4 * a * c);
                if (delta<0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");

                } else
                {
                    if (delta ==0)
                    {
                        x = -b / (2 * a);
                        if (bac4) 
                        {
                            if (x >= 0)
                            {
                                x = canBacN(2, x);
                                Console.WriteLine("Phuong trinh co hai nghiem la : x1 = {0} va x2={1}", x, -x);

                            } else
                            {
                                Console.WriteLine("Phuong trinh vo nghiem");
                            }


                        }else
                        Console.WriteLine("Phuong trinh co nghiem kep x1=x2={0}", x);
                    } else
                    {
                        double can_delta = canBacN(2, delta);
                        double x1 = (-b + can_delta) / (2 * a);
                        double x2 = (-b - can_delta) / (2 * a);
                        if (bac4)
                        {
                            if (x1 >= 0 )
                            {
                                x1 = canBacN(2, x1);
                                Console.WriteLine("Phuong trinh co nghiem la: x ={0}, x={1}", x1,-x1);

                            }
                            if (x2 >= 0)
                            {
                                x2 = canBacN(2, x2);
                                Console.WriteLine("Phuong trinh co nghiem la:x= {0}, x={1}", x2, -x2);
                            }


                        } else
                        {
                        Console.WriteLine("phuong trinh co hai nghiem phan biet la: x1={0}, x2={1}", x1, x2);
                        }
                    }
                }
            }

        }
    }
}
