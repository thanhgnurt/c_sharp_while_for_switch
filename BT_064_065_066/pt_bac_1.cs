using BT_062_063;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_064_065_066
{
    class pt_bac_1:can_bac_n
    {
        public void ptbac1(int a, int b, bool bac4)
        {

            if (a == 0)
            {
                Console.WriteLine("phuong trinh co vo so nghiem");

            } else
            {
                double x = -b / a;
                if (bac4)
                {
                    if (x >= 0)
                    {
                        x = canBacN(2, x);
                        Console.WriteLine("Phuong trinh co hai nghiem la:x1={0} va x2={1}", x, -x);
                    }
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");
                } else
                Console.WriteLine("phuong trinh co nghiem la : x ={0}", x);
            }
        }
    }
}
