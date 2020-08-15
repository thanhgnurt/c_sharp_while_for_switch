using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Basic_Oop
{
    class input_n
    {
         public int input(string tittle)
        {
            for(; ; )
            {
                try
                {
                    Console.WriteLine(tittle);
                    int n = int.Parse(Console.ReadLine());
                    return n;

                }
                catch
                {
                    Console.WriteLine("Ban nhap sai dinh dang , vui long nhap lai");
                }
            }

            
        }
    }
}
