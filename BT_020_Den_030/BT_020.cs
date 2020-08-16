using System;
using System.Collections.Generic;
using System.Text;

namespace BT_020_Den_030
{
    class BT_020
    {
       public void bt20(int n)
        {
          
           
            Console.WriteLine("---------------------------");
            Console.WriteLine("Cac uoc cua {0} la:", n);
           
            int i = 1;
            while (i <= n/2)
            {
                if (n%i == 0)
                {
                    Console.Write(i + " ");

                }
                i++;
            }
            Console.Write(n);

        }
    }
}
