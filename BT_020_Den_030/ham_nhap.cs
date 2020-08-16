using System;
using System.Collections.Generic;
using System.Text;

namespace BT_020_Den_030
{
    class ham_nhap
    {
        public int hamNhap(string tieu_de)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(tieu_de);
                    int n = int.Parse(Console.ReadLine());
                    return n;
                }
                catch
                {
                    Console.WriteLine("Ban nhap sai dinh dang, xin vui long nhap lai.");
                }

            }
        }
    }
}
